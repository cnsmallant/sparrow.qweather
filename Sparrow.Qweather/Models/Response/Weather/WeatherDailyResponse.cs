using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using Sparrow.Qweather.Models.Common;
using Sparrow.Qweather.Tools;

namespace Sparrow.Qweather.Models.Response.Weather
{
    /// <summary>
    /// 天气预报天
    /// </summary>
    public class WeatherDailyResponse
    {
        /// <summary>
        /// 元数据信息
        /// </summary>
        [JsonPropertyName("metadata")]
        public CommonMetaDataResponse Metadata { get; set; }

        /// <summary>
        /// 每日天气预报列表
        /// </summary>
        [JsonPropertyName("days")]
        public List<WeatherDailyDayForecast> Days { get; set; }
    }

    // ============================== 每日预报 ==============================

    /// <summary>
    /// 单日天气预报
    /// </summary>
    public class WeatherDailyDayForecast
    {
        /// <summary>
        /// 预报数据的开始时间（UTC）
        /// </summary>
        [JsonPropertyName("forecastStartTime")]
        public DateTime? ForecastStartTime { get; set; }

        /// <summary>
        /// 预报数据的结束时间（不含，UTC）
        /// </summary>
        [JsonPropertyName("forecastEndTime")]
        public DateTime? ForecastEndTime { get; set; }

        /// <summary>
        /// 太阳和月亮天文事件
        /// </summary>
        [JsonPropertyName("astro")]
        public WeatherDailyAstro Astro { get; set; }

        /// <summary>
        /// 预报时段的最高温度
        /// </summary>
        [JsonPropertyName("temperatureMax")]
        public WeatherDailyTemperature TemperatureMax { get; set; }

        /// <summary>
        /// 预报时段的最低温度
        /// </summary>
        [JsonPropertyName("temperatureMin")]
        public WeatherDailyTemperature TemperatureMin { get; set; }

        /// <summary>
        /// 当日平均温度
        /// </summary>
        [JsonPropertyName("temperatureAvg")]
        public WeatherDailyTemperature TemperatureAvg { get; set; }

        /// <summary>
        /// 当日最大紫外线指数，取值范围 [0, 15]
        /// </summary>
        [JsonPropertyName("uvIndexMax")]
        public int? UvIndexMax { get; set; }

        /// <summary>
        /// 白天预报（当地时间 [07:00, 19:00)）
        /// </summary>
        [JsonPropertyName("daytime")]
        public WeatherDailyDaytimeForecast Daytime { get; set; }

        /// <summary>
        /// 夜间预报（当地时间 [19:00, 次日07:00)）
        /// </summary>
        [JsonPropertyName("nighttime")]
        public NighttimeForecast Nighttime { get; set; }
    }

    // ============================== 天文事件 ==============================

    /// <summary>
    /// 太阳和月亮天文事件
    /// </summary>
    public class WeatherDailyAstro
    {
        /// <summary>
        /// 日出时间（UTC）
        /// </summary>
        [JsonPropertyName("sunrise")]
        public DateTime? Sunrise { get; set; }

        /// <summary>
        /// 日落时间（UTC）
        /// </summary>
        [JsonPropertyName("sunset")]
        public DateTime? Sunset { get; set; }

        /// <summary>
        /// 天文晨光的开始时间（UTC）
        /// </summary>
        [JsonPropertyName("astronomicalDawn")]
        public DateTime? AstronomicalDawn { get; set; }

        /// <summary>
        /// 航海晨光的开始时间（UTC）
        /// </summary>
        [JsonPropertyName("nauticalDawn")]
        public DateTime? NauticalDawn { get; set; }

        /// <summary>
        /// 民用晨光的开始时间（UTC）
        /// </summary>
        [JsonPropertyName("civilDawn")]
        public DateTime? CivilDawn { get; set; }

        /// <summary>
        /// 天文暮光的结束时间（UTC）
        /// </summary>
        [JsonPropertyName("astronomicalDusk")]
        public DateTime? AstronomicalDusk { get; set; }

        /// <summary>
        /// 航海暮光的结束时间（UTC）
        /// </summary>
        [JsonPropertyName("nauticalDusk")]
        public DateTime? NauticalDusk { get; set; }

        /// <summary>
        /// 民用暮光的结束时间（UTC）
        /// </summary>
        [JsonPropertyName("civilDusk")]
        public DateTime? CivilDusk { get; set; }

        /// <summary>
        /// 太阳正午时间（UTC）
        /// </summary>
        [JsonPropertyName("solarNoon")]
        public DateTime? SolarNoon { get; set; }

        /// <summary>
        /// 太阳子夜时间（UTC）
        /// </summary>
        [JsonPropertyName("solarMidnight")]
        public DateTime? SolarMidnight { get; set; }

        /// <summary>
        /// 月出时间（UTC）
        /// </summary>
        [JsonPropertyName("moonrise")]
        public DateTime? Moonrise { get; set; }

        /// <summary>
        /// 月落时间（UTC）
        /// </summary>
        [JsonPropertyName("moonset")]
        public DateTime? Moonset { get; set; }

        /// <summary>
        /// 月亮上中天时间（UTC）
        /// </summary>
        [JsonPropertyName("moonTransit")]
        public DateTime? MoonTransit { get; set; }

        /// <summary>
        /// 月亮下中天时间（UTC）
        /// </summary>
        [JsonPropertyName("moonUnderfoot")]
        public DateTime? MoonUnderfoot { get; set; }

        /// <summary>
        /// 当天主导月相
        /// </summary>
        [JsonPropertyName("moonPhase")]
        public string MoonPhase { get; set; }

        /// <summary>
        /// 月相描述
        /// </summary>

        [JsonPropertyName("text")]
        public string Text
        {
            get
            {
                if (string.IsNullOrEmpty(MoonPhase))
                {
                    return string.Empty;
                }
                if (MoonPhaseDataTool.MoonPhases.TryGetValue(MoonPhase, out string description))
                {
                    return description; // 输出：月相：满月
                }
                else
                {
                    return string.Empty;
                }
            }
        }
    }

    // ============================== 白天 / 夜间预报 ==============================

    /// <summary>
    /// 白天预报（当地时间 [07:00, 19:00)）
    /// </summary>
    public class WeatherDailyDaytimeForecast
    {
        /// <summary>
        /// 预报数据的开始时间（UTC）
        /// </summary>
        [JsonPropertyName("forecastStartTime")]
        public DateTime? ForecastStartTime { get; set; }

        /// <summary>
        /// 预报数据的结束时间（不含，UTC）
        /// </summary>
        [JsonPropertyName("forecastEndTime")]
        public DateTime? ForecastEndTime { get; set; }

        /// <summary>
        /// 天气现象
        /// </summary>
        [JsonPropertyName("condition")]
        public Condition Condition { get; set; }

        /// <summary>
        /// 预报时段的最高温度
        /// </summary>
        [JsonPropertyName("temperatureMax")]
        public WeatherDailyTemperature TemperatureMax { get; set; }

        /// <summary>
        /// 预报时段的最低温度
        /// </summary>
        [JsonPropertyName("temperatureMin")]
        public WeatherDailyTemperature TemperatureMin { get; set; }

        /// <summary>
        /// 预报时段的平均相对湿度，取值范围 [0, 1]
        /// </summary>
        [JsonPropertyName("humidity")]
        public double? Humidity { get; set; }

        /// <summary>
        /// 风的数据
        /// </summary>
        [JsonPropertyName("wind")]
        public Wind Wind { get; set; }

        /// <summary>
        /// 预报时段的最大阵风风速
        /// </summary>
        [JsonPropertyName("windGustMax")]
        public WindGustMax WindGustMax { get; set; }

        /// <summary>
        /// 降水数据
        /// </summary>
        [JsonPropertyName("precipitation")]
        public PrecipitationForecast Precipitation { get; set; }

        /// <summary>
        /// 预报时段的平均总云量，取值范围 [0, 1]
        /// </summary>
        [JsonPropertyName("cloudCover")]
        public double? CloudCover { get; set; }
    }

    /// <summary>
    /// 夜间预报（当地时间 [19:00, 次日07:00)），结构与 DaytimeForecast 相同
    /// </summary>
    public class NighttimeForecast : WeatherDailyDaytimeForecast
    {
        // 完全继承 DaytimeForecast 的所有属性 若需要独立注释可在此添加，但此处直接复用即可
    }

    // ============================== 预报降水数据 ==============================

    /// <summary>
    /// 预报时段内的降水数据
    /// </summary>
    public class PrecipitationForecast
    {
        /// <summary>
        /// 当前数据时段内的累计降水量
        /// </summary>
        [JsonPropertyName("amount")]
        public PrecipitationAmount Amount { get; set; }

        /// <summary>
        /// 降水概率，取值范围 [0, 1]
        /// </summary>
        [JsonPropertyName("probability")]
        public double? Probability { get; set; }

        /// <summary>
        /// 降水类型代码
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 降水描述
        /// </summary>
        [JsonPropertyName("text")]
        public string Text
        {
            get
            {
                if (!string.IsNullOrEmpty(Type))
                {
                    if (
                        PrecipitationDataTool.PrecipitationTypes.TryGetValue(
                            Type,
                            out string description
                        )
                    )
                    {
                        return description;
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
                return string.Empty;
            }
        }
    }

    // ============================== 复用类（已在前面定义，此处列出供参考） ==============================

    /// <summary>
    /// 温度数据（含数值和单位）
    /// </summary>
    public class WeatherDailyTemperature
    {
        [JsonPropertyName("value")]
        public double? Value { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    /// <summary>
    /// 天气现象
    /// </summary>
    public class WeatherDailyCondition
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }
    }

    /// <summary>
    /// 风的数据
    /// </summary>
    public class WeatherDailyWind
    {
        [JsonPropertyName("direction")]
        public WindDirection Direction { get; set; }

        [JsonPropertyName("speed")]
        public WindSpeed Speed { get; set; }

        [JsonPropertyName("scale")]
        public int? Scale { get; set; }
    }

    /// <summary>
    /// 风向数据
    /// </summary>
    public class WeatherDailyWindDirection
    {
        [JsonPropertyName("degree")]
        public int? Degree { get; set; }

        [JsonPropertyName("compass")]
        public string Compass { get; set; }

        /// <summary>
        /// 风向描述
        /// </summary>
        [JsonPropertyName("text")]
        public WindDirectionInfo Text
        {
            get
            {
                if (!string.IsNullOrEmpty(Compass))
                {
                    var result = WindDataTool.WindDirections[Compass];
                    return result;
                }

                return new WindDirectionInfo();
            }
        }
    }

    /// <summary>
    /// 风速数据（含数值和单位）
    /// </summary>
    public class WeatherDailyWindSpeed
    {
        [JsonPropertyName("value")]
        public double? Value { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    /// <summary>
    /// 最大阵风风速（含数值和单位）
    /// </summary>
    public class WindGustMax
    {
        [JsonPropertyName("value")]
        public double? Value { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    /// <summary>
    /// 降水量数据（含数值和单位）
    /// </summary>
    public class WeatherDailyPrecipitationAmount
    {
        [JsonPropertyName("value")]
        public double? Value { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }
}