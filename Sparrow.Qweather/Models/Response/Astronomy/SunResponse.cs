using Sparrow.Qweather.Models.Common;
using System.Text.Json.Serialization;

namespace Sparrow.Qweather.Models.Response.Astronomy
{
    /// <summary>
    /// 日出日落
    /// </summary>
    public class SunResponse : CommonInfoResponse
    {
        /// <summary>
        /// 当前 API 的最近更新时间。
        /// </summary>
        /// <example>2021-02-17T11:00+08:00</example>
        [JsonPropertyName("updateTime")]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 当前数据的响应式页面链接，便于嵌入网站或应用。
        /// </summary>
        /// <example>http://hfx.link/2ax1</example>
        [JsonPropertyName("fxLink")]
        public string FxLink { get; set; }

        /// <summary>
        /// 日出时间（在高纬度地区可能为空）。
        /// </summary>
        /// <example>2021-02-20T06:58+08:00</example>
        [JsonPropertyName("sunrise")]
        public string Sunrise { get; set; }

        /// <summary>
        /// 日落时间（在高纬度地区可能为空）。
        /// </summary>
        /// <example>2021-02-20T17:57+08:00</example>
        [JsonPropertyName("sunset")]
        public string Sunset { get; set; }
    }
}