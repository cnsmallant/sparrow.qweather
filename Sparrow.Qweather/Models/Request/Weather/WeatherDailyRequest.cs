using System;
using System.Collections.Generic;
using System.Text;
using Sparrow.Qweather.Models.Common;

namespace Sparrow.Qweather.Models.Request.Weather
{
    /// <summary>
    /// 每日天气预报
    /// </summary>
    public class WeatherDailyRequest
    {
        /// <summary>
        /// 路径参数
        /// </summary>
        public WeatherDailyPathParameters Path { get; set; }

        /// <summary>
        /// 查询参数
        /// </summary>
        public WeatherDailyQueryParameters Query { get; set; } = new WeatherDailyQueryParameters();
    }

    public class WeatherDailyPathParameters
    {
        /// <summary>
        /// 纬度
        /// </summary>
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        public string Longitude { get; set; }
    }

    /// <summary>
    /// 天气预报请求参数
    /// </summary>
    public class WeatherDailyQueryParameters : CommonInfoRequest
    {
        /// <summary>
        /// 预报天数，支持 1-10 天，默认返回 7 天
        /// </summary>
        public string Days { get; set; } = "7";

        public string LocalTime { get; set; }
    }
}