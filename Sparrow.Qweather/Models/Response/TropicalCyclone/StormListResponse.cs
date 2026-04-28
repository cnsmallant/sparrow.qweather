using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using Sparrow.Qweather.Models.Common;

namespace Sparrow.Qweather.Models.Response.TropicalCyclone
{
    /// <summary>
    /// 台风列表
    /// </summary>
    public class StormListResponse : CommonInfoResponse
    {
        /// <summary>
        /// 当前 API 的最近更新时间。
        /// </summary>
        /// <example>2020-12-31T16:00+00:00</example>
        [JsonPropertyName("updateTime")]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 当前数据的响应式页面链接，便于嵌入网站或应用。
        /// </summary>
        /// <example>https://www.qweather.com</example>
        [JsonPropertyName("fxLink")]
        public string FxLink { get; set; }

        /// <summary>
        /// 台风信息列表。
        /// </summary>
        [JsonPropertyName("storm")]
        public List<StormListItem> Storm { get; set; }
    }

    /// <summary>
    /// 表示单个台风的基本信息。
    /// </summary>
    public class StormListItem
    {
        /// <summary>
        /// 台风 ID。
        /// </summary>
        /// <example>NP_2022</example>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 台风名称。
        /// </summary>
        /// <example>环高</example>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 台风所处流域（如 NP 表示西北太平洋）。
        /// </summary>
        /// <example>NP</example>
        [JsonPropertyName("basin")]
        public string Basin { get; set; }

        /// <summary>
        /// 台风所处年份（四位数字）。
        /// </summary>
        /// <example>2020</example>
        [JsonPropertyName("year")]
        public string Year { get; set; }

        /// <summary>
        /// 是否为活跃台风。
        /// <list type="bullet">
        /// <item>
        /// <description>1 - 活跃台风</description>
        /// </item>
        /// <item>
        /// <description>0 - 停编</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <example>0</example>
        [JsonPropertyName("isActive")]
        public string IsActive { get; set; }
    }
}