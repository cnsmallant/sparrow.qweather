using Sparrow.Qweather.Models.Common;
using System.Text.Json.Serialization;

namespace Sparrow.Qweather.Models.Request.Weatheralert
{
    /// <summary>
    /// 实时天气预警
    /// </summary>
    public class WeatheralertCurrentRequest
    {
        /// <summary>
        /// 查询参数
        /// </summary>
        public WeatheralertCurrentTimeQueryParameters Query { get; set; }

        /// <summary>
        /// 路径参数
        /// </summary>
        public WeatheralertCurrentGeoPathParameters Path { get; set; }
    }

    /// <summary>
    /// 表示时间相关的查询参数。 可用于控制 API 返回的时间格式（本地时间或 UTC 时间）。
    /// </summary>
    public class WeatheralertCurrentTimeQueryParameters : CommonInfoRequest
    {
        /// <summary>
        /// 获取或设置是否返回查询地点的本地时间。
        /// <list type="bullet">
        /// <item>
        /// <description>true - 返回本地时间（根据查询地点的时区）</description>
        /// </item>
        /// <item>
        /// <description>false - 返回 UTC 时间（协调世界时，默认值）</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <example>true</example>
        /// <remarks>此参数为可选参数，默认值为 false。</remarks>
        public bool LocalTime { get; set; } = false;
    }

    /// <summary>
    /// 表示地理坐标的路径参数（经度/纬度）。 通常用于 URL 路径中的占位符，例如 "/api/weather/{latitude}/{longitude}"。
    /// </summary>
    public class WeatheralertCurrentGeoPathParameters
    {
        /// <summary>
        /// 获取或设置纬度。 格式要求：十进制数值，最多支持小数点后两位。
        /// </summary>
        /// <example>39.92</example>
        /// <remarks>此参数为必选参数，取值范围：-90.00 到 90.00。</remarks>
        public string Latitude { get; set; }

        /// <summary>
        /// 获取或设置经度。 格式要求：十进制数值，最多支持小数点后两位。
        /// </summary>
        /// <example>116.41</example>
        /// <remarks>此参数为必选参数，取值范围：-180.00 到 180.00。</remarks>
        public string Longitude { get; set; }
    }
}