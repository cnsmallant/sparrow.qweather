using System.Collections.Generic;
using System.Text.Json.Serialization;
using Sparrow.Qweather.Models.Common;

namespace Sparrow.Qweather.Models.Response.Astronomy
{
    /// <summary>
    /// 月相
    /// </summary>
    public class MoonResponse : CommonInfoResponse
    {
        /// <summary>
        /// 当前 API 的最近更新时间。
        /// </summary>
        /// <example>2021-11-15T17:00+08:00</example>
        [JsonPropertyName("updateTime")]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 当前数据的响应式页面链接，便于嵌入网站或应用。
        /// </summary>
        /// <example>http://hfx.link/2ax1</example>
        [JsonPropertyName("fxLink")]
        public string FxLink { get; set; }

        /// <summary>
        /// 当天月升时间（可能为空）。
        /// </summary>
        /// <example>2021-11-20T17:25+08:00</example>
        [JsonPropertyName("moonrise")]
        public string Moonrise { get; set; }

        /// <summary>
        /// 当天月落时间（可能为空）。
        /// </summary>
        /// <example>2021-11-21T07:42+08:00</example>
        [JsonPropertyName("moonset")]
        public string Moonset { get; set; }

        /// <summary>
        /// 逐小时月相预报列表。
        /// </summary>
        [JsonPropertyName("moonPhase")]
        public List<MoonPhaseItem> MoonPhase { get; set; }
    }

    /// <summary>
    /// 表示单个月相预报点的详细信息。
    /// </summary>
    public class MoonPhaseItem
    {
        /// <summary>
        /// 月相逐小时预报时间（北京时间，含时区偏移）。
        /// </summary>
        /// <example>2021-11-20T00:00+08:00</example>
        [JsonPropertyName("fxTime")]
        public string FxTime { get; set; }

        /// <summary>
        /// 月相数值。
        /// </summary>
        /// <example>0.51</example>
        [JsonPropertyName("value")]
        public string Value { get; set; }

        /// <summary>
        /// 月相名称（如“亏凸月”）。
        /// </summary>
        /// <example>亏凸月</example>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 月亮照明度（百分比数值）。
        /// </summary>
        /// <example>100</example>
        [JsonPropertyName("illumination")]
        public string Illumination { get; set; }

        /// <summary>
        /// 月相图标代码，参考天气图标项目。
        /// </summary>
        /// <example>805</example>
        [JsonPropertyName("icon")]
        public string Icon { get; set; }
    }
}