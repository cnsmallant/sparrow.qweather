using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sparrow.Qweather.Models.Response.AirQuality
{
    /// <summary>
    /// 空气质量小时预报
    /// </summary>
    public class AirHourlyForecastResponse
    {
        /// <summary>
        /// 响应元数据，包含数据标签。
        /// </summary>
        [JsonPropertyName("metadata")]
        public AirHourlyMetadata Metadata { get; set; }

        /// <summary>
        /// 逐小时空气质量预报列表。
        /// </summary>
        [JsonPropertyName("hours")]
        public List<AirHourlyHourlyAirQuality> Hours { get; set; }
    }

    /// <summary>
    /// 表示响应元数据。
    /// </summary>
    public class AirHourlyMetadata
    {
        /// <summary>
        /// 数据标签，用于追踪或验证响应数据的完整性。
        /// </summary>
        /// <example>b1d735802464094bf274fd2165309ddfdab22cec2fa0e644edfcd7f803c2aaad</example>
        [JsonPropertyName("tag")]
        public string Tag { get; set; }
    }

    /// <summary>
    /// 表示单小时的空气质量信息。
    /// </summary>
    public class AirHourlyHourlyAirQuality
    {
        /// <summary>
        /// 预报时间（ISO8601 格式，UTC 时间）。
        /// </summary>
        /// <example>2023-05-17T03:00Z</example>
        [JsonPropertyName("forecastTime")]
        public string ForecastTime { get; set; }

        /// <summary>
        /// 该小时内的空气质量指数列表（不同标准，如 QAQI、GB-DEFRA 等）。
        /// </summary>
        [JsonPropertyName("indexes")]
        public List<AirHourlyAirQualityIndex> Indexes { get; set; }

        /// <summary>
        /// 该小时内的各类污染物详细信息列表。
        /// </summary>
        [JsonPropertyName("pollutants")]
        public List<AirHourlyPollutant> Pollutants { get; set; }
    }

    /// <summary>
    /// 表示一种空气质量指数（如 QAQI、GB-DEFRA）。
    /// </summary>
    public class AirHourlyAirQualityIndex
    {
        /// <summary>
        /// 空气质量指数代码（如 "qaqi", "gb-defra"）。
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
        /// <example>1.4</example>
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
        /// 空气质量指数类别（如 "Excellent", "Low"）。
        /// </summary>
        [JsonPropertyName("category")]
        public string Category { get; set; }

        /// <summary>
        /// 指数对应的显示颜色（RGBA 分量）。
        /// </summary>
        [JsonPropertyName("color")]
        public AirHourlyColor Color { get; set; }

        /// <summary>
        /// 首要污染物信息（可能为空）。
        /// </summary>
        [JsonPropertyName("primaryPollutant")]
        public AirHourlyPrimaryPollutant PrimaryPollutant { get; set; }

        /// <summary>
        /// 健康影响及建议。
        /// </summary>
        [JsonPropertyName("health")]
        public AirHourlyHealth Health { get; set; }
    }

    /// <summary>
    /// 表示 RGBA 颜色分量。
    /// </summary>
    public class AirHourlyColor
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
    public class AirHourlyPrimaryPollutant
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
    public class AirHourlyHealth
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
        public AirHourlyAdvice Advice { get; set; }
    }

    /// <summary>
    /// 表示健康指导意见。
    /// </summary>
    public class AirHourlyAdvice
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
    public class AirHourlyPollutant
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
        public AirHourlyConcentration Concentration { get; set; }

        /// <summary>
        /// 该污染物在不同空气质量指数标准下的分指数列表（可能为空）。
        /// </summary>
        [JsonPropertyName("subIndexes")]
        public List<AirHourlySubIndex> SubIndexes { get; set; }
    }

    /// <summary>
    /// 表示污染物浓度值及单位。
    /// </summary>
    public class AirHourlyConcentration
    {
        /// <summary>
        /// 浓度数值。
        /// </summary>
        /// <example>17.01</example>
        [JsonPropertyName("value")]
        public double Value { get; set; }

        /// <summary>
        /// 浓度单位（如 "μg/m3", "ppb", "ppm"）。
        /// </summary>
        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    /// <summary>
    /// 表示一种空气质量指数标准下某污染物的分指数。
    /// </summary>
    public class AirHourlySubIndex
    {
        /// <summary>
        /// 分指数对应的空气质量指数代码（如 "qaqi"）。
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