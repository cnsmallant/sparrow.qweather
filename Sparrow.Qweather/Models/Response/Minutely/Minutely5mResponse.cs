using Sparrow.Qweather.Models.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sparrow.Qweather.Models.Response.Minutely
{
    /// <summary>
    /// 分钟级降水
    /// </summary>
    public class Minutely5mResponse : CommonInfoResponse
    {
        /// <summary>
        /// 当前 API 的最近更新时间
        /// </summary>
        /// <example>2021-12-16T18:55+08:00</example>
        [JsonPropertyName("updateTime")]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 当前数据的响应式页面链接，便于嵌入网站或应用
        /// </summary>
        /// <example>https://www.qweather.com</example>
        [JsonPropertyName("fxLink")]
        public string FxLink { get; set; }

        /// <summary>
        /// 分钟降水描述文本（例如“95分钟后雨就停了”）
        /// </summary>
        /// <example>95分钟后雨就停了</example>
        [JsonPropertyName("summary")]
        public string Summary { get; set; }

        /// <summary>
        /// 分钟降水数据列表，通常每5分钟一条记录
        /// </summary>
        [JsonPropertyName("minutely")]
        public List<Minutely5mItem> Minutely { get; set; }
    }

    /// <summary>
    /// 表示单条分钟级降水数据（每5分钟的累计降水量）。
    /// </summary>
    public class Minutely5mItem
    {
        /// <summary>
        /// 预报时间（北京时间，含时区偏移）
        /// </summary>
        /// <example>2021-12-16T18:55+08:00</example>
        [JsonPropertyName("fxTime")]
        public string FxTime { get; set; }

        /// <summary>
        /// 5分钟累计降水量（单位：毫米）
        /// </summary>
        /// <example>0.15</example>
        [JsonPropertyName("precip")]
        public string Precip { get; set; }

        /// <summary>
        /// 降水类型
        /// <list type="bullet">
        /// <item>
        /// <description>rain - 雨</description>
        /// </item>
        /// <item>
        /// <description>snow - 雪</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <example>rain</example>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}