using System;
using System.Collections.Generic;
using System.Text;
using Sparrow.Qweather.Models.Common;

namespace Sparrow.Qweather.Models.Request.AirQuality
{
    /// <summary>
    /// 空气质量每日预报
    /// </summary>
    public class AirDailyForecastRequest
    {
        /// <summary>
        /// 查询参数
        /// </summary>
        public AirDailyForecastQueryParameters Query { get; set; }

        /// <summary>
        /// 路径参数
        /// </summary>
        public AirDailyForecastPathParameters Path { get; set; }
    }

    /// <summary>
    /// 空气质量每日预报查询参数
    /// </summary>
    public class AirDailyForecastQueryParameters : CommonInfoRequest
    {
        /// <summary>
        /// 是否返回查询地点的本地时间。true 返回本地时间，false 返回UTC时间（默认）。
        /// </summary>
        public bool LocalTime { get; set; } = false;
    }

    /// <summary>
    /// 空气质量每日预报路径参数
    /// </summary>
    public class AirDailyForecastPathParameters
    {
        /// <summary>
        /// 所需位置的纬度。十进制，最多支持小数点后两位。例如 39.92
        /// </summary>
        public string Latitude { get; set; }

        /// <summary>
        /// 所需位置的经度。十进制，最多支持小数点后两位。例如 116.41
        /// </summary>
        public string Longitude { get; set; }
    }
}