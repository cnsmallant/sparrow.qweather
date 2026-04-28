using Sparrow.Qweather.Models.Common;

namespace Sparrow.Qweather.Models.Request.AirQuality
{
    public class AirStationRequest
    {
        /// <summary>
        /// 查询参数
        /// </summary>
        public AirStationQueryParameters Query { get; set; }

        /// <summary>
        /// 路径参数
        /// </summary>
        public AirStationPathParameters Path { get; set; }
    }

    /// <summary>
    /// 监测站数据路径参数
    /// </summary>
    public class AirStationPathParameters
    {
        /// <summary>
        /// 空气质量监测站的LocationID，LocationID可通过GeoAPI获取。例如 P58911
        /// </summary>
        public string LocationID { get; set; }
    }

    /// <summary>
    /// 监测站数据查询参数
    /// </summary>
    public class AirStationQueryParameters : CommonInfoRequest
    {
    }
}