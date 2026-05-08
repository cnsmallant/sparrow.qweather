using System;
using System.Text.Json;
using System.Threading.Tasks;
using Flurl.Http;
using Microsoft.Extensions.Caching.Memory;
using Sparrow.Qweather.Interface.Common;
using Sparrow.Qweather.Models.Options;

namespace Sparrow.Qweather.Tools
{
    /// <summary>
    /// 请求响应工具类
    /// </summary>
    public static class ResponseTool
    {
        private static readonly IMemoryCache _cache = new MemoryCache(new MemoryCacheOptions());

        /// <summary>
        /// 获取并处理相应数据GET
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="this"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static async Task<T> GetApiResponseAsync<T>(
            this ICommonInfoRequest @this,
            WebApiOptions options,
            string path
        )
        {
            var cacheKey = $"{options.Kid}";
            var token = GetCache(cacheKey);
            if (string.IsNullOrEmpty(token))
            {
                token = SignatureTool.GenerateJwtToken(options.Kid, options.Sub, options.CertPath);
                SetCache(cacheKey, token);
            }
            var url = @this.GeneralServiceUrl(options, path);
            var json = await url.WithOAuthBearerToken(token).GetStringAsync();
            json = json.Replace("[]", "null").Replace("{}", "null");
            return JsonSerializer.Deserialize<T>(json);
        }

        /// <summary>
        /// 写入缓存
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void SetCache(string key, string value, double expiration = 86000)
        {
            _cache.Set(key, value, TimeSpan.FromSeconds(expiration));
        }

        /// <summary>
        /// 获取缓存
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetCache(string key)
        {
            _cache.TryGetValue(key, out string value);
            return value;
        }
    }
}