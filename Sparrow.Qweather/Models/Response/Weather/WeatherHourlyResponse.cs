using Sparrow.Qweather.Models.Common;
using Sparrow.Qweather.Tools;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sparrow.Qweather.Models.Response.Weather
{
    /// <summary>
    /// 小时天气预报 https://dev.qweather.com/docs/api/weather/weather-hourly-forecast/
    /// </summary>
    public class WeatherHourlyResponse
    {
        /// <summary>
        /// 元数据信息
        /// </summary>
        [JsonPropertyName("metadata")]
        public CommonMetaDataResponse Metadata { get; set; }

        /// <summary>
        /// 逐小时天气预报列表
        /// </summary>
        [JsonPropertyName("hours")]
        public List<HourlyForecast> Hours { get; set; }
    }

    // ============================== 逐小时预报 ==============================

    /// <summary>
    /// 单小时天气预报
    /// </summary>
    public class HourlyForecast
    {
        /// <summary>
        /// 预报时间（UTC）
        /// </summary>
        [JsonPropertyName("forecastTime")]
        public DateTime? ForecastTime { get; set; }

        /// <summary>
        /// 天气现象
        /// </summary>
        [JsonPropertyName("condition")]
        public WeatherHourlyCondition Condition { get; set; }

        /// <summary>
        /// 温度数据
        /// </summary>
        [JsonPropertyName("temperature")]
        public WeatherHourlyTemperature Temperature { get; set; }

        /// <summary>
        /// 体感温度数据
        /// </summary>
        [JsonPropertyName("feelsLike")]
        public WeatherHourlyFeelsLike FeelsLike { get; set; }

        /// <summary>
        /// 相对湿度，取值范围 [0, 1]
        /// </summary>
        [JsonPropertyName("humidity")]
        public double? Humidity { get; set; }

        /// <summary>
        /// 风的数据
        /// </summary>
        [JsonPropertyName("wind")]
        public WeatherHourlyWind Wind { get; set; }

        /// <summary>
        /// 阵风风速数据
        /// </summary>
        [JsonPropertyName("windGust")]
        public WeatherHourlyWindGust WindGust { get; set; }

        /// <summary>
        /// 降水数据
        /// </summary>
        [JsonPropertyName("precipitation")]
        public HourlyPrecipitation Precipitation { get; set; }

        /// <summary>
        /// 海平面气压数据
        /// </summary>
        [JsonPropertyName("pressure")]
        public WeatherHourlyPressure Pressure { get; set; }

        /// <summary>
        /// 能见度数据
        /// </summary>
        [JsonPropertyName("visibility")]
        public WeatherHourlyVisibility Visibility { get; set; }

        /// <summary>
        /// 露点温度数据
        /// </summary>
        [JsonPropertyName("dewPoint")]
        public WeatherHourlyDewPoint DewPoint { get; set; }

        /// <summary>
        /// 云量，取值范围 [0, 1]
        /// </summary>
        [JsonPropertyName("cloudCover")]
        public double? CloudCover { get; set; }

        /// <summary>
        /// 紫外线指数，取值范围 [0, 15]
        /// </summary>
        [JsonPropertyName("uvIndex")]
        public int? UvIndex { get; set; }
    }

    // ============================== 公共数据结构 ==============================

    /// <summary>
    /// 天气现象
    /// </summary>
    public class WeatherHourlyCondition
    {
        /// <summary>
        /// 天气现象的本地化描述
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }

        /// <summary>
        /// 天气现象代码
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }
    }

    /// <summary>
    /// 温度数据（含数值和单位）
    /// </summary>
    public class WeatherHourlyTemperature
    {
        /// <summary>
        /// 数值
        /// </summary>
        [JsonPropertyName("value")]
        public double? Value { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    /// <summary>
    /// 体感温度数据（含数值和单位），结构同 Temperature
    /// </summary>
    public class WeatherHourlyFeelsLike
    {
        [JsonPropertyName("value")]
        public double? Value { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    /// <summary>
    /// 风的数据
    /// </summary>
    public class WeatherHourlyWind
    {
        /// <summary>
        /// 风向数据
        /// </summary>
        [JsonPropertyName("direction")]
        public WindDirection Direction { get; set; }

        /// <summary>
        /// 风速数据
        /// </summary>
        [JsonPropertyName("speed")]
        public WindSpeed Speed { get; set; }

        /// <summary>
        /// 蒲福风级
        /// </summary>
        [JsonPropertyName("scale")]
        public int? Scale { get; set; }
    }

    /// <summary>
    /// 风向数据
    /// </summary>
    public class WeatherHourlyWindDirection
    {
        /// <summary>
        /// 风向角度，取值范围 [0, 359]
        /// </summary>
        [JsonPropertyName("degree")]
        public int? Degree { get; set; }

        /// <summary>
        /// 风向的方位代码
        /// </summary>
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
    public class WeatherHourlyWindSpeed
    {
        [JsonPropertyName("value")]
        public double? Value { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    /// <summary>
    /// 阵风风速数据（含数值和单位）
    /// </summary>
    public class WeatherHourlyWindGust
    {
        [JsonPropertyName("value")]
        public double? Value { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    /// <summary>
    /// 逐小时降水数据（含累计量、强度、概率和类型）
    /// </summary>
    public class HourlyPrecipitation
    {
        /// <summary>
        /// 当前数据时段内的累计降水量
        /// </summary>
        [JsonPropertyName("amount")]
        public PrecipitationAmount Amount { get; set; }

        /// <summary>
        /// 降水强度
        /// </summary>
        [JsonPropertyName("intensity")]
        public PrecipitationIntensity Intensity { get; set; }

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

    /// <summary>
    /// 降水量数据（含数值和单位）
    /// </summary>
    public class WeatherHourlyPrecipitationAmount
    {
        [JsonPropertyName("value")]
        public double? Value { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    /// <summary>
    /// 降水强度数据（含数值和单位）
    /// </summary>
    public class WeatherHourlyPrecipitationIntensity
    {
        [JsonPropertyName("value")]
        public double? Value { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    /// <summary>
    /// 海平面气压数据（含数值和单位）
    /// </summary>
    public class WeatherHourlyPressure
    {
        [JsonPropertyName("value")]
        public double? Value { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    /// <summary>
    /// 能见度数据（含数值和单位）
    /// </summary>
    public class WeatherHourlyVisibility
    {
        [JsonPropertyName("value")]
        public double? Value { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    /// <summary>
    /// 露点温度数据（含数值和单位）
    /// </summary>
    public class WeatherHourlyDewPoint
    {
        [JsonPropertyName("value")]
        public double? Value { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }
}