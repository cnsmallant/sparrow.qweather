using System.Text.Json;
using System.Threading.Tasks;
using Flurl.Http;
using Sparrow.Qweather.Interface.Common;
using Sparrow.Qweather.Models.Options;

namespace Sparrow.Qweather.Tools
{
    /// <summary>
    /// 请求响应工具类
    /// </summary>
    public static class ResponseTool
    {
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
            var token = SignatureTool.GenerateJwtToken(options.Kid, options.Sub, options.CertPath);
            var url = @this.GeneralServiceUrl(options, path);
            var json = await url.WithOAuthBearerToken(token).GetStringAsync();
            json = json.Replace("[]", "null").Replace("{}", "null");
            return JsonSerializer.Deserialize<T>(json);
        }
    }
}