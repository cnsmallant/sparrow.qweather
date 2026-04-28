using Sparrow.Qweather.Models.Common;

namespace Sparrow.Qweather.Models.Request.Weather
{
    /// <summary>
    /// 每日天气预报
    /// </summary>
    public class WeatherDaysRequest
    {
        /// <summary>
        ///路径参数
        /// </summary>
        public WeatherDaysPathParameters Path { get; set; }

        /// <summary>
        /// 查询参数
        /// </summary>
        public WeatherDaysQueryParameters Query { get; set; }
    }

    /// <summary>
    /// 路径参数
    /// </summary>
    public class WeatherDaysPathParameters
    {
        /// <summary>
        /// days(必选)预报天数，支持最多30天预报，可选值：3d 3天预报。7d 7天预报。10d 10天预报。15d 15天预报。30d 30天预报。
        /// </summary>
        public string Days { get; set; }
    }

    /// <summary>
    /// 查询参数
    /// </summary>
    public class WeatherDaysQueryParameters : CommonInfoRequest
    {
        /// <summary>
        /// 获取或设置需要查询的地区标识。 支持以下格式：
        /// <list type="bullet">
        /// <item>
        /// <description>LocationID（通过 GeoAPI 获取，如 "101010100" 表示北京）</description>
        /// </item>
        /// <item>
        /// <description>经度,纬度（十进制，最多支持小数点后两位，如 "116.41,39.92"）</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <example>101010100</example>
        /// <example>116.41,39.92</example>
        /// <remarks>此参数为必选参数。</remarks>
        public string Location { get; set; }

        /// <summary>
        /// 获取或设置数据单位。
        /// <list type="bullet">
        /// <item>
        /// <description>m - 公制单位（默认）</description>
        /// </item>
        /// <item>
        /// <description>i - 英制单位</description>
        /// </item>
        /// </list>
        /// 更多选项和说明参考度量衡单位文档。
        /// </summary>
        /// <value>m 或 i</value>
        /// <example>m</example>
        /// <remarks>此参数为可选参数，默认值为 "m"。</remarks>
        public string Unit { get; set; } = "m";
    }
}