using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sparrow.Qweather.Models.Response.SolarRadiation
{
    /// <summary>
    /// 太阳辐射预报接口返回结果
    /// </summary>
    public class SolarRadiationForecastResponse
    {
        /// <summary>
        /// 响应元数据，包含数据标签。
        /// </summary>
        [JsonPropertyName("metadata")]
        public SolarRadiationForecastMetadata Metadata { get; set; }

        /// <summary>
        /// 太阳辐照逐时预报列表。
        /// </summary>
        [JsonPropertyName("forecasts")]
        public List<SolarRadiationForecastItem> Forecasts { get; set; }
    }

    /// <summary>
    /// 表示响应元数据。
    /// </summary>
    public class SolarRadiationForecastMetadata
    {
        /// <summary>
        /// 数据标签，用于追踪或验证响应数据的完整性。
        /// </summary>
        /// <example>c4ca4238a0b923820dcc509a6f75849b</example>
        [JsonPropertyName("tag")]
        public string Tag { get; set; }
    }

    /// <summary>
    /// 表示单个预报时间点的太阳辐照及相关数据。
    /// </summary>
    public class SolarRadiationForecastItem
    {
        /// <summary>
        /// 预报时间（ISO8601 格式，UTC 时间）。
        /// </summary>
        /// <example>2023-10-15T11:30Z</example>
        [JsonPropertyName("forecastTime")]
        public string ForecastTime { get; set; }

        /// <summary>
        /// 太阳角度信息（方位角、高度角）。
        /// </summary>
        [JsonPropertyName("solarAngle")]
        public SolarRadiationForecastSolarAngle SolarAngle { get; set; }

        /// <summary>
        /// 法向直接辐照（DNI）。
        /// </summary>
        [JsonPropertyName("dni")]
        public SolarRadiationForecastIrradianceValue Dni { get; set; }

        /// <summary>
        /// 散射水平面辐照（DHI）。
        /// </summary>
        [JsonPropertyName("dhi")]
        public SolarRadiationForecastIrradianceValue Dhi { get; set; }

        /// <summary>
        /// 总水平面辐照（GHI）。
        /// </summary>
        [JsonPropertyName("ghi")]
        public SolarRadiationForecastIrradianceValue Ghi { get; set; }

        /// <summary>
        /// 天气信息（温度、风速、湿度）。仅在请求 extra=weather 时返回。
        /// </summary>
        [JsonPropertyName("weather")]
        public SolarRadiationForecastWeather Weather { get; set; }

        /// <summary>
        /// 组件平面辐照信息（POA）。仅在请求 extra=poa 时返回。
        /// </summary>
        [JsonPropertyName("poa")]
        public SolarRadiationForecastPoa Poa { get; set; }
    }

    /// <summary>
    /// 表示太阳角度（方位角和高度角）。
    /// </summary>
    public class SolarRadiationForecastSolarAngle
    {
        /// <summary>
        /// 太阳方位角（正北为 0 度，顺时针增加）。
        /// </summary>
        /// <example>184</example>
        [JsonPropertyName("azimuth")]
        public int Azimuth { get; set; }

        /// <summary>
        /// 太阳高度角。
        /// </summary>
        /// <example>40</example>
        [JsonPropertyName("elevation")]
        public int Elevation { get; set; }
    }

    /// <summary>
    /// 表示带有单位和数值的辐照值（适用于 DNI、DHI、GHI 及 POA 各分量）。
    /// </summary>
    public class SolarRadiationForecastIrradianceValue
    {
        /// <summary>
        /// 辐照数值（单位：瓦特每平方米）。
        /// </summary>
        /// <example>25.16</example>
        [JsonPropertyName("value")]
        public double Value { get; set; }

        /// <summary>
        /// 数值单位（通常为 "W/m²"）。
        /// </summary>
        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    /// <summary>
    /// 表示天气信息（温度、风速、湿度）。
    /// </summary>
    public class SolarRadiationForecastWeather
    {
        /// <summary>
        /// 温度信息。
        /// </summary>
        [JsonPropertyName("temperature")]
        public SolarRadiationForecastTemperature Temperature { get; set; }

        /// <summary>
        /// 风速信息。
        /// </summary>
        [JsonPropertyName("windSpeed")]
        public SolarRadiationForecastWindSpeed WindSpeed { get; set; }

        /// <summary>
        /// 相对湿度（百分比数值）。
        /// </summary>
        /// <example>76</example>
        [JsonPropertyName("humidity")]
        public int Humidity { get; set; }
    }

    /// <summary>
    /// 表示温度值及单位。
    /// </summary>
    public class SolarRadiationForecastTemperature
    {
        /// <summary>
        /// 温度数值（单位：摄氏度）。
        /// </summary>
        /// <example>18.6</example>
        [JsonPropertyName("value")]
        public double Value { get; set; }

        /// <summary>
        /// 温度单位（通常为 "°C"）。
        /// </summary>
        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    /// <summary>
    /// 表示风速值及单位。
    /// </summary>
    public class SolarRadiationForecastWindSpeed
    {
        /// <summary>
        /// 风速数值（单位：米/秒）。
        /// </summary>
        /// <example>2.78</example>
        [JsonPropertyName("value")]
        public double Value { get; set; }

        /// <summary>
        /// 风速单位（通常为 "m/s"）。
        /// </summary>
        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    /// <summary>
    /// 表示组件平面（POA）辐照信息（包含全局、直接、散射、反射分量）。
    /// </summary>
    public class SolarRadiationForecastPoa
    {
        /// <summary>
        /// 组件平面总辐照（全局）。
        /// </summary>
        [JsonPropertyName("global")]
        public SolarRadiationForecastIrradianceValue Global { get; set; }

        /// <summary>
        /// 组件平面直接辐照。
        /// </summary>
        [JsonPropertyName("direct")]
        public SolarRadiationForecastIrradianceValue Direct { get; set; }

        /// <summary>
        /// 组件平面散射辐照。
        /// </summary>
        [JsonPropertyName("diffuse")]
        public SolarRadiationForecastIrradianceValue Diffuse { get; set; }

        /// <summary>
        /// 组件平面地面反射辐照。
        /// </summary>
        [JsonPropertyName("reflected")]
        public SolarRadiationForecastIrradianceValue Reflected { get; set; }
    }
}