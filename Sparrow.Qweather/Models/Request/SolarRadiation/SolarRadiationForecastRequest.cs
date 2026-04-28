using Sparrow.Qweather.Models.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Sparrow.Qweather.Models.Request.SolarRadiation
{
    /// <summary>
    /// 太阳辐射
    /// </summary>
    public class SolarRadiationForecastRequest
    {
        /// <summary>
        /// 太阳辐射路径参数
        /// </summary>
        public SolarRadiationForecastPathParameters Path { get; set; }

        /// <summary>
        /// 太阳辐射查询参数
        /// </summary>
        public SolarRadiationForecastQueryParameters Query { get; set; }
    }

    /// <summary>
    /// 太阳辐射路径参数
    /// </summary>

    public class SolarRadiationForecastPathParameters
    {
        /// <summary>
        /// 纬度 (必选)所需位置的纬度。十进制，最多支持小数点后两位。例如 39.92
        /// </summary>
        public string Latitude { get; set; }

        /// <summary>
        /// 经度 (必选)所需位置的经度。十进制，最多支持小数点后两位。例如 116.41
        /// </summary>
        public string Longitude { get; set; }
    }

    /// <summary>
    /// 太阳辐射查询参数
    /// </summary>

    public class SolarRadiationForecastQueryParameters : CommonInfoRequest
    {
        /// <summary>
        /// 获取或设置预报小时数（查询参数）。 可选范围：1 到 60。默认值为 24。
        /// </summary>
        /// <value>1-60 之间的整数</value>
        /// <example>12</example>
        /// <remarks>此参数为可选参数，默认值为 24。</remarks>
        public string Hours { get; set; } = "24";

        /// <summary>
        /// 获取或设置预报数据的时间间隔（分钟）（查询参数）。 可选值：15、30、60。默认值为 60。
        /// </summary>
        /// <value>15, 30 或 60</value>
        /// <example>15</example>
        /// <remarks>此参数为可选参数，默认值为 60。</remarks>
        public string Interval { get; set; } = "60";

        /// <summary>
        /// 获取或设置光伏系统的倾斜角度（度数）（查询参数）。 可选范围：0 到 90（整数）。当 extra 参数包含 "poa" 时，此参数为必传。
        /// </summary>
        /// <value>0-90 之间的整数</value>
        /// <example>30</example>
        /// <remarks>此参数为可选参数，但在请求 extra 包含 "poa" 时必填。</remarks>
        public string Tilt { get; set; }

        /// <summary>
        /// 获取或设置光伏系统的方位角（度数）（查询参数）。 可选范围：0 到 359（整数），其中 0 表示正北方向。 当 extra 参数包含 "poa" 时，此参数为必传。
        /// </summary>
        /// <value>0-359 之间的整数</value>
        /// <example>180</example>
        /// <remarks>此参数为可选参数，但在请求 extra 包含 "poa" 时必填。</remarks>
        public string Azimuth { get; set; }

        /// <summary>
        /// 获取或设置额外信息选项（查询参数）。 可选值包括：
        /// <list type="bullet">
        /// <item>
        /// <description>weather - 基本天气数据</description>
        /// </item>
        /// <item>
        /// <description>poa - 阵列平面辐照度（需同时传递 tilt 和 azimuth）</description>
        /// </item>
        /// </list>
        /// 多个选项使用英文逗号分隔，例如 "weather,poa"。
        /// </summary>
        /// <example>weather</example>
        /// <remarks>此参数为可选参数。</remarks>
        public string Extra { get; set; }
    }
}