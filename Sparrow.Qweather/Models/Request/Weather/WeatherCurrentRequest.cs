using System;
using System.Collections.Generic;
using System.Text;
using Sparrow.Qweather.Models.Common;

namespace Sparrow.Qweather.Models.Request.Weather
{
    /// <summary>
    /// 天气实况
    /// </summary>
    public class WeatherCurrentRequest
    {
        /// <summary>
        /// 天气实况路径参数
        /// </summary>
        public WeatherCurrentPathParameters Path { get; set; }

        /// <summary>
        /// 天气实况查询参数
        /// </summary>
        public WeatherCurrentQueryParameters Query { get; set; } = new WeatherCurrentQueryParameters();
    }

    /// <summary>
    /// 天气实况路径参数
    /// </summary>
    public class WeatherCurrentPathParameters
    {
        /// <summary>
        /// 纬度 所需位置的纬度。十进制，最多支持小数点后两位。例如 39.92
        /// </summary>
        public string Latitude { get; set; }

        /// <summary>
        /// 经度 所需位置的经度。十进制，最多支持小数点后两位。例如 116.41
        /// </summary>
        public string Longitude { get; set; }
    }

    /// <summary>
    /// 天气实况查询参数
    /// </summary>
    public class WeatherCurrentQueryParameters : CommonInfoRequest
    {
        /// <summary>
        /// 是否返回查询地点的本地时间 可选值： false UTC时间（默认），true 本地时间
        /// </summary>
        public string LocalTime { get; set; } = "true";
    }
}