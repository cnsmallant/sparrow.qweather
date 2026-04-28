using System.Collections.Generic;
using System.Text.Json.Serialization;
using Sparrow.Qweather.Models.Common;

namespace Sparrow.Qweather.Models.Response.TimeMachine
{
    /// <summary>
    /// 空气质量时光机
    /// </summary>
    public class HistoricalAirResponse : CommonInfoResponse
    {
        /// <summary>
        /// 当前数据的响应式页面链接，便于嵌入网站或应用。
        /// </summary>
        /// <example>http://hfx.link/2ax6</example>
        [JsonPropertyName("fxLink")]
        public string FxLink { get; set; }

        /// <summary>
        /// 逐小时空气质量数据列表。
        /// </summary>
        [JsonPropertyName("airHourly")]
        public List<HistoricalAirHourlyItem> AirHourly { get; set; }
    }

    /// <summary>
    /// 空气质量时光机
    /// </summary>
    public class HistoricalAirHourlyItem
    {
        /// <summary>
        /// 空气质量数据发布时间。
        /// </summary>
        /// <example>2020-07-25 00:00</example>
        [JsonPropertyName("pubTime")]
        public string PubTime { get; set; }

        /// <summary>
        /// 空气质量指数（AQI）。
        /// </summary>
        /// <example>52</example>
        [JsonPropertyName("aqi")]
        public string Aqi { get; set; }

        /// <summary>
        /// 空气质量指数等级。
        /// </summary>
        /// <example>2</example>
        [JsonPropertyName("level")]
        public string Level { get; set; }

        /// <summary>
        /// 空气质量指数级别（如“良”、“优”）。
        /// </summary>
        /// <example>良</example>
        [JsonPropertyName("category")]
        public string Category { get; set; }

        /// <summary>
        /// 空气质量的主要污染物。 当空气质量为优时，返回值为 "NA"。
        /// </summary>
        /// <example>PM10</example>
        [JsonPropertyName("primary")]
        public string Primary { get; set; }

        /// <summary>
        /// PM10 浓度（μg/m³）。
        /// </summary>
        /// <example>54</example>
        [JsonPropertyName("pm10")]
        public string Pm10 { get; set; }

        /// <summary>
        /// PM2.5 浓度（μg/m³）。
        /// </summary>
        /// <example>22</example>
        [JsonPropertyName("pm2p5")]
        public string Pm2p5 { get; set; }

        /// <summary>
        /// 二氧化氮（NO₂）浓度（μg/m³）。
        /// </summary>
        /// <example>31</example>
        [JsonPropertyName("no2")]
        public string No2 { get; set; }

        /// <summary>
        /// 二氧化硫（SO₂）浓度（μg/m³）。
        /// </summary>
        /// <example>2</example>
        [JsonPropertyName("so2")]
        public string So2 { get; set; }

        /// <summary>
        /// 一氧化碳（CO）浓度（mg/m³）。
        /// </summary>
        /// <example>0.5</example>
        [JsonPropertyName("co")]
        public string Co { get; set; }

        /// <summary>
        /// 臭氧（O₃）浓度（μg/m³）。
        /// </summary>
        /// <example>85</example>
        [JsonPropertyName("o3")]
        public string O3 { get; set; }
    }
}