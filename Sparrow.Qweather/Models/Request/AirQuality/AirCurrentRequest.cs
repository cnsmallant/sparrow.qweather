using Sparrow.Qweather.Models.Common;

namespace Sparrow.Qweather.Models.Request.AirQuality
{
    /// <summary>
    /// 实时空气质量
    /// </summary>
    public class AirCurrentRequest
    {
        /// <summary>
        /// 路径参数
        /// </summary>
        public AirCurrentPathParameters Path { get; set; }

        /// <summary>
        /// 查询参数
        /// </summary>
        public AirCurrentQueryParameters Query { get; set; }
    }

    /// <summary>
    /// 路径参数
    /// </summary>
    public class AirCurrentPathParameters
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

    /// <summary>
    /// 查询参数
    /// </summary>
    public class AirCurrentQueryParameters : CommonInfoRequest
    {
    }
}