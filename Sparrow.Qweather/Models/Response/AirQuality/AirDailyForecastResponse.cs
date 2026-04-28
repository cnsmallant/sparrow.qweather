using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sparrow.Qweather.Models.Response.AirQuality
{
    /// <summary>
    /// 空气质量每日预报
    /// </summary>
    public class AirDailyForecastResponse
    {
        /// <summary>
        /// 响应元数据，包含数据标签。
        /// </summary>
        [JsonPropertyName("metadata")]
        public AirDailyForecastMetadata Metadata { get; set; }

        /// <summary>
        /// 逐日空气质量预报列表。
        /// </summary>
        [JsonPropertyName("days")]
        public List<AirDailyForecastDailyAirQuality> Days { get; set; }
    }

    /// <summary>
    /// 表示响应元数据。
    /// </summary>
    public class AirDailyForecastMetadata
    {
        /// <summary>
        /// 数据标签，用于追踪或验证响应数据的完整性。
        /// </summary>
        /// <example>4b78230843e636a6f910631d94878da73aa980a66abfcf53d35f9c06493a292d</example>
        [JsonPropertyName("tag")]
        public string Tag { get; set; }
    }

    /// <summary>
    /// 表示单日的空气质量信息。
    /// </summary>
    public class AirDailyForecastDailyAirQuality
    {
        /// <summary>
        /// 预报数据的开始时间（ISO8601 格式，UTC 时间）。
        /// </summary>
        /// <example>2023-02-14T23:00Z</example>
        [JsonPropertyName("forecastStartTime")]
        public string ForecastStartTime { get; set; }

        /// <summary>
        /// 预报数据的结束时间（ISO8601 格式，UTC 时间）。
        /// </summary>
        /// <example>2023-02-15T23:00Z</example>
        [JsonPropertyName("forecastEndTime")]
        public string ForecastEndTime { get; set; }

        /// <summary>
        /// 该日内的空气质量指数列表（不同标准，如 QAQI、EU-EEA 等）。
        /// </summary>
        [JsonPropertyName("indexes")]
        public List<AirDailyForecastAirQualityIndex> Indexes { get; set; }

        /// <summary>
        /// 该日内的各类污染物详细信息列表。
        /// </summary>
        [JsonPropertyName("pollutants")]
        public List<AirDailyForecastPollutant> Pollutants { get; set; }
    }

    /// <summary>
    /// 表示一种空气质量指数（如 QAQI、EU-EEA）。
    /// </summary>
    public class AirDailyForecastAirQualityIndex
    {
        /// <summary>
        /// 空气质量指数代码（如 "qaqi", "eu-eea"）。
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 空气质量指数的名称。
        /// </summary>
        /// <example>QAQI</example>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 空气质量指数的数值（可为整数或小数）。
        /// </summary>
        /// <example>1.0</example>
        [JsonPropertyName("aqi")]
        public double Aqi { get; set; }

        /// <summary>
        /// 空气质量指数的文本显示（通常与 Aqi 相同，但保留为字符串）。
        /// </summary>
        [JsonPropertyName("aqiDisplay")]
        public string AqiDisplay { get; set; }

        /// <summary>
        /// 空气质量指数等级（可能为空）。
        /// </summary>
        /// <example>1</example>
        [JsonPropertyName("level")]
        public string Level { get; set; }

        /// <summary>
        /// 空气质量指数类别（如 "Excellent", "Fair"）。
        /// </summary>
        [JsonPropertyName("category")]
        public string Category { get; set; }

        /// <summary>
        /// 指数对应的显示颜色（RGBA 分量）。
        /// </summary>
        [JsonPropertyName("color")]
        public AirDailyForecastColor Color { get; set; }

        /// <summary>
        /// 首要污染物信息（可能为空）。
        /// </summary>
        [JsonPropertyName("primaryPollutant")]
        public AirDailyForecastPrimaryPollutant PrimaryPollutant { get; set; }

        /// <summary>
        /// 健康影响及建议。
        /// </summary>
        [JsonPropertyName("health")]
        public AirDailyForecastHealth Health { get; set; }
    }

    /// <summary>
    /// 表示 RGBA 颜色分量。
    /// </summary>
    public class AirDailyForecastColor
    {
        /// <summary>
        /// 红色分量（0–255）。
        /// </summary>
        [JsonPropertyName("red")]
        public int Red { get; set; }

        /// <summary>
        /// 绿色分量（0–255）。
        /// </summary>
        [JsonPropertyName("green")]
        public int Green { get; set; }

        /// <summary>
        /// 蓝色分量（0–255）。
        /// </summary>
        [JsonPropertyName("blue")]
        public int Blue { get; set; }

        /// <summary>
        /// 透明度分量（0–1，1 表示完全不透明）。
        /// </summary>
        [JsonPropertyName("alpha")]
        public double Alpha { get; set; }
    }

    /// <summary>
    /// 表示首要污染物信息。
    /// </summary>
    public class AirDailyForecastPrimaryPollutant
    {
        /// <summary>
        /// 污染物代码（如 "pm2p5", "o3"）。
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
    }

    /// <summary>
    /// 表示空气质量对健康的影响及建议。
    /// </summary>
    public class AirDailyForecastHealth
    {
        /// <summary>
        /// 健康影响描述（可能为空）。
        /// </summary>
        /// <example>No health implications.</example>
        [JsonPropertyName("effect")]
        public string Effect { get; set; }

        /// <summary>
        /// 健康指导意见（包含一般人群和敏感人群）。
        /// </summary>
        [JsonPropertyName("advice")]
        public AirDailyForecastAdvice Advice { get; set; }
    }

    /// <summary>
    /// 表示健康指导意见。
    /// </summary>
    public class AirDailyForecastAdvice
    {
        /// <summary>
        /// 对一般人群的健康指导意见（可能为空）。
        /// </summary>
        [JsonPropertyName("generalPopulation")]
        public string GeneralPopulation { get; set; }

        /// <summary>
        /// 对敏感人群的健康指导意见（可能为空）。
        /// </summary>
        [JsonPropertyName("sensitivePopulation")]
        public string SensitivePopulation { get; set; }
    }

    /// <summary>
    /// 表示一种污染物的详细信息。
    /// </summary>
    public class AirDailyForecastPollutant
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
        [JsonPropertyName("fullName")]
        public string FullName { get; set; }

        /// <summary>
        /// 污染物浓度信息。
        /// </summary>
        [JsonPropertyName("concentration")]
        public AirDailyForecastConcentration Concentration { get; set; }

        /// <summary>
        /// 该污染物在不同空气质量指数标准下的分指数列表（可能为空）。
        /// </summary>
        [JsonPropertyName("subIndexes")]
        public List<AirDailyForecastSubIndex> SubIndexes { get; set; }
    }

    /// <summary>
    /// 表示污染物浓度值及单位。
    /// </summary>
    public class AirDailyForecastConcentration
    {
        /// <summary>
        /// 浓度数值。
        /// </summary>
        /// <example>11.88</example>
        [JsonPropertyName("value")]
        public double Value { get; set; }

        /// <summary>
        /// 浓度单位（如 "μg/m3"）。
        /// </summary>
        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    /// <summary>
    /// 表示一种空气质量指数标准下某污染物的分指数。
    /// </summary>
    public class AirDailyForecastSubIndex
    {
        /// <summary>
        /// 分指数对应的空气质量指数代码（如 "qaqi", "eu-eea"）。
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 分指数数值（可能为空）。
        /// </summary>
        [JsonPropertyName("aqi")]
        public double? Aqi { get; set; }

        /// <summary>
        /// 分指数的文本显示。
        /// </summary>
        [JsonPropertyName("aqiDisplay")]
        public string AqiDisplay { get; set; }
    }
}