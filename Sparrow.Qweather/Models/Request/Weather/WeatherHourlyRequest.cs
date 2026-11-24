using Sparrow.Qweather.Models.Common;

namespace Sparrow.Qweather.Models.Request.Weather
{
    /// <summary>
    /// 查询天气预报小时数据
    /// </summary>
    public class WeatherHourlyRequest
    {
        /// <summary>
        /// 路径参数
        /// </summary>
        public WeatherHourlyPathParameters Path { get; set; }

        /// <summary>
        /// 查询参数
        /// </summary>
        public WeatherHourlyQueryParameters Query { get; set; } = new WeatherHourlyQueryParameters();
    }

    /// <summary>
    /// 路径参数
    /// </summary>

    public class WeatherHourlyPathParameters
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
    /// 查询天气预报小时数据
    /// </summary>
    public class WeatherHourlyQueryParameters : CommonInfoRequest
    {
        /// <summary>
        /// 预报小时数，支持 1-240 小时，默认返回 24 小时
        /// </summary>
        public string Hours { get; set; } = "24";

        /// <summary>
        /// 本地时间，格式为：2020-05-05T09:00:00
        /// </summary>
        public string LocalTime { get; set; } = "true";
    }
}