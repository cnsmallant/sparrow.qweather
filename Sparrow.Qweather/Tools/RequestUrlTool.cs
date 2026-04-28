using NSec.Cryptography;
using Sparrow.Qweather.Interface;
using Sparrow.Qweather.Models.Options;
using System.Net.Http;

namespace Sparrow.Qweather.Tools
{
    /// <summary>
    /// 请求URL
    /// </summary>
    public static class RequestUrlTool
    {
        /// <summary>
        /// 通用的 API URL 生成方法 https://dev.qweather.com/docs/configuration/api-config/
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="this"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static string GeneralServiceUrl<T>(this T @this, WebApiOptions options, string path) where T : class
        {
            // 通常来讲，一个完整的API请求URL由scheme，host，path，path parameters和query parameters组成：
            //https://abcxyz.qweatherapi.com/airquality/v1/station/{LocationID}?lang=en
            //\___ /   \____________________ /\____________________ /\___________ /\______ /
            //scheme           host                       path             pathparams  queryparams
            //scheme: 仅支持HTTPS协议。
            //host: 开发者的API Host，请在控制台 - 设置中查看。
            //path: API的请求路径（或称之为API端点、Endpoint）。
            //path params: 路径参数均为必选参数。
            //query params: 查询参数，包括必选和可选参数，多个查询参数使用 & 分割。

            var lang = @this.GetType().GetProperty("Lang")?.GetValue(@this)?.ToString();
            if (string.IsNullOrEmpty(lang))
            {
                @this.GetType().GetProperty("Lang")?.SetValue(@this, options.Lang);
            }

            var queryString = @this.ToQueryString();
            var baseUrl = $"{options.Scheme}{options.Host}{path}?{queryString}";

            return baseUrl;
        }
    }
}