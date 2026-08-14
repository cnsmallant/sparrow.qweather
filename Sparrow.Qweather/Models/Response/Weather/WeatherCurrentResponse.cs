using System.Text.Json.Serialization;
using Sparrow.Qweather.Models.Common;
using Sparrow.Qweather.Tools;

namespace Sparrow.Qweather.Models.Response.Weather
{
    /// <summary>
    /// 天气实况接口返回结果
    /// </summary>
    public class WeatherCurrentResponse
    {
        /// <summary>
        /// 元数据
        /// </summary>
        [JsonPropertyName("metadata")]
        public CommonMetaDataResponse MetaData { get; set; }

        /// <summary>
        /// 天气现象数据
        /// </summary>
        [JsonPropertyName("condition")]
        public Condition Condition { get; set; }

        /// <summary>
        /// 温度数据
        /// </summary>
        [JsonPropertyName("temperature")]
        public Temperature Temperature { get; set; }

        /// <summary>
        /// 体感温度数据
        /// </summary>
        [JsonPropertyName("feelsLike")]
        public FeelsLike FeelsLike { get; set; }

        /// <summary>
        /// 相对湿度，取值范围 [0, 1]
        /// </summary>
        [JsonPropertyName("humidity")]
        public double? Humidity { get; set; }

        /// <summary>
        /// 风的数据
        /// </summary>
        [JsonPropertyName("wind")]
        public Wind Wind { get; set; }

        /// <summary>
        /// 阵风风速数据
        /// </summary>
        [JsonPropertyName("windGust")]
        public WindGust WindGust { get; set; }

        /// <summary>
        /// 降水数据
        /// </summary>
        [JsonPropertyName("precipitation")]
        public Precipitation Precipitation { get; set; }

        /// <summary>
        /// 海平面气压数据
        /// </summary>
        [JsonPropertyName("pressure")]
        public Pressure Pressure { get; set; }

        /// <summary>
        /// 能见度数据
        /// </summary>
        [JsonPropertyName("visibility")]
        public Visibility Visibility { get; set; }

        /// <summary>
        /// 露点温度数据
        /// </summary>
        [JsonPropertyName("dewPoint")]
        public DewPoint DewPoint { get; set; }

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

    /// <summary>
    /// 天气现象
    /// </summary>
    public class Condition
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
    public class Temperature
    {
        /// <summary>
        /// 温度数值
        /// </summary>
        [JsonPropertyName("value")]
        public double? Value { get; set; }

        /// <summary>
        /// 温度单位
        /// </summary>
        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    /// <summary>
    /// 体感温度数据（含数值和单位）
    /// </summary>
    public class FeelsLike
    {
        /// <summary>
        /// 体感温度数值
        /// </summary>
        [JsonPropertyName("value")]
        public double? Value { get; set; }

        /// <summary>
        /// 体感温度单位
        /// </summary>
        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    /// <summary>
    /// 风的数据
    /// </summary>
    public class Wind
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
    public class WindDirection
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
    public class WindSpeed
    {
        /// <summary>
        /// 风速数值
        /// </summary>
        [JsonPropertyName("value")]
        public double? Value { get; set; }

        /// <summary>
        /// 风速单位
        /// </summary>
        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    /// <summary>
    /// 阵风风速数据（含数值和单位）
    /// </summary>
    public class WindGust
    {
        /// <summary>
        /// 阵风风速数值
        /// </summary>
        [JsonPropertyName("value")]
        public double? Value { get; set; }

        /// <summary>
        /// 阵风风速单位
        /// </summary>
        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    /// <summary>
    /// 降水数据
    /// </summary>
    public class Precipitation
    {
        /// <summary>
        /// 累计一小时降水量数据
        /// </summary>
        [JsonPropertyName("amount")]
        public PrecipitationAmount Amount { get; set; }

        /// <summary>
        /// 降水强度数据
        /// </summary>
        [JsonPropertyName("intensity")]
        public PrecipitationIntensity Intensity { get; set; }

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
    /// 累计一小时降水量数据（含数值和单位）
    /// </summary>
    public class PrecipitationAmount
    {
        /// <summary>
        /// 降水量数值
        /// </summary>
        [JsonPropertyName("value")]
        public double? Value { get; set; }

        /// <summary>
        /// 降水量单位
        /// </summary>
        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    /// <summary>
    /// 降水强度数据（含数值和单位）
    /// </summary>
    public class PrecipitationIntensity
    {
        /// <summary>
        /// 降水强度数值
        /// </summary>
        [JsonPropertyName("value")]
        public double? Value { get; set; }

        /// <summary>
        /// 降水强度单位
        /// </summary>
        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    /// <summary>
    /// 海平面气压数据（含数值和单位）
    /// </summary>
    public class Pressure
    {
        /// <summary>
        /// 气压数值
        /// </summary>
        [JsonPropertyName("value")]
        public double? Value { get; set; }

        /// <summary>
        /// 气压单位
        /// </summary>
        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    /// <summary>
    /// 能见度数据（含数值和单位）
    /// </summary>
    public class Visibility
    {
        /// <summary>
        /// 能见度数值
        /// </summary>
        [JsonPropertyName("value")]
        public double? Value { get; set; }

        /// <summary>
        /// 能见度单位
        /// </summary>
        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    /// <summary>
    /// 露点温度数据（含数值和单位）
    /// </summary>
    public class DewPoint
    {
        /// <summary>
        /// 露点温度数值
        /// </summary>
        [JsonPropertyName("value")]
        public double? Value { get; set; }

        /// <summary>
        /// 露点温度单位
        /// </summary>
        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }
}