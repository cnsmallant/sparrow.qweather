using Sparrow.Qweather.Models.Common;

namespace Sparrow.Qweather.Models.Request.Indices
{
    public class IndicesForecastRequest : CommonInfoRequest
    {
        /// <summary>
        /// 天气预报指数查询接口路径
        /// </summary>
        public IndicesForecastPathParameters Path { get; set; }

        /// <summary>
        /// 天气预报指数查询接口参数
        /// </summary>
        public IndicesForecastQueryParameters Query { get; set; }
    }

    /// <summary>
    /// 天气预报指数查询路径
    /// </summary>
    public class IndicesForecastPathParameters
    {
        /// <summary>
        /// 获取或设置预报天数（路径参数）。 支持以下选项：
        /// <list type="bullet">
        /// <item>
        /// <description>1d - 1天预报</description>
        /// </item>
        /// <item>
        /// <description>3d - 3天预报</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <example>1d</example>
        /// <remarks>此参数为必选参数。</remarks>
        public string Days { get; set; }
    }

    /// <summary>
    /// 天气预报指数查询接口
    /// </summary>
    public class IndicesForecastQueryParameters : CommonInfoRequest
    {
        /// <summary>
        /// 获取或设置需要查询的地区标识（查询参数）。 支持以下格式：
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
        /// 获取或设置生活指数的类型 ID（查询参数）。 可以是一次性获取多个类型，多个 ID 用英文逗号分隔（例如 "3,5"）。 具体生活指数的 ID 和等级参考天气指数文档。
        /// 注意：各项生活指数并非适用于所有城市。
        /// </summary>
        /// <example>3,5</example>
        /// <remarks>此参数为必选参数。</remarks>
        public string Type { get; set; }
    }
}