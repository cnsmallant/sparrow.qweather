using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sparrow.Qweather.Models.Response.AirQuality
{
    /// <summary>
    /// 监测站数据
    /// </summary>
    public class AirStationResponse
    {
        /// <summary>
        /// 响应元数据，包含数据标签和来源声明。
        /// </summary>
        [JsonPropertyName("metadata")]
        public AirStationMetadata Metadata { get; set; }

        /// <summary>
        /// 污染物信息列表。
        /// </summary>
        [JsonPropertyName("pollutants")]
        public List<AirStationPollutant> Pollutants { get; set; }
    }

    /// <summary>
    /// 表示响应元数据。
    /// </summary>
    public class AirStationMetadata
    {
        /// <summary>
        /// 数据标签，用于追踪或验证响应数据的完整性。
        /// </summary>
        /// <example>d75a323239766b831889e8020cba5aca9b90fca5080a1175c3487fd8acb06e84</example>
        [JsonPropertyName("tag")]
        public string Tag { get; set; }

        /// <summary>
        /// 数据来源或声明列表。开发者必须将此内容与当前数据一起展示（例如在页面的免责声明中）。
        /// </summary>
        /// <example>["QWeather", "https://developer.qweather.com/attribution.html"]</example>
        [JsonPropertyName("sources")]
        public List<string> Sources { get; set; }
    }

    /// <summary>
    /// 表示一种污染物的详细信息。
    /// </summary>
    public class AirStationPollutant
    {
        /// <summary>
        /// 污染物代码（如 "pm2p5", "pm10", "no2", "o3", "so2"）。
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 污染物名称（简短）。
        /// </summary>
        /// <example>PM 2.5</example>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 污染物全称。
        /// </summary>
        /// <example>Fine particulate matter (&lt;2.5µm)</example>
        [JsonPropertyName("fullName")]
        public string FullName { get; set; }

        /// <summary>
        /// 污染物浓度信息。
        /// </summary>
        [JsonPropertyName("concentration")]
        public AirStationConcentration Concentration { get; set; }
    }

    /// <summary>
    /// 表示污染物浓度值及单位。
    /// </summary>
    public class AirStationConcentration
    {
        /// <summary>
        /// 浓度数值。
        /// </summary>
        /// <example>11.0</example>
        [JsonPropertyName("value")]
        public double Value { get; set; }

        /// <summary>
        /// 浓度单位（如 "μg/m3"）。
        /// </summary>
        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }
}