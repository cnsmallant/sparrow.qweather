using Sparrow.Qweather.Models.Common;

namespace Sparrow.Qweather.Models.Request.Geo
{
    /// <summary>
    /// POI搜索
    /// </summary>
    public class PoiLookUpRequest : CommonInfoRequest
    {
        /// <summary>
        /// 获取或设置需要查询的地区名称或坐标。 支持以下格式：
        /// <list type="bullet">
        /// <item>
        /// <description>文字地名（如 "北京"）</description>
        /// </item>
        /// <item>
        /// <description>经度,纬度（十进制，最多支持小数点后两位，如 "116.41,39.92"）</description>
        /// </item>
        /// <item>
        /// <description>LocationID（和风天气的地区ID）</description>
        /// </item>
        /// <item>
        /// <description>Adcode（仅限中国城市）</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <example>北京</example>
        /// <example>116.41,39.92</example>
        /// <remarks>此参数为必选参数。</remarks>
        public string Location { get; set; }

        /// <summary>
        /// 获取或设置要搜索的 POI 类型。 支持的类型包括：
        /// <list type="bullet">
        /// <item>
        /// <description>scenic - 景点</description>
        /// </item>
        /// <item>
        /// <description>TSTA - 潮汐站点</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <example>scenic</example>
        /// <remarks>此参数为必选参数。</remarks>
        public string Type { get; set; }

        /// <summary>
        /// 获取或设置搜索的城市范围。 可指定只在特定城市内搜索 POI。城市名称可以是文字或城市的 LocationID。 注意：城市名称为精准匹配，建议使用 LocationID
        /// 以避免匹配失败。 若不设置此参数，则不限制城市范围。
        /// </summary>
        /// <example>北京</example>
        /// <example>101010100</example>
        /// <remarks>此参数为可选参数。</remarks>
        public string City { get; set; }

        /// <summary>
        /// 获取或设置返回结果的数量。 取值范围：1 到 20。默认值为 10。
        /// </summary>
        /// <value>1 到 20 之间的整数。</value>
        /// <remarks>此参数为可选参数。</remarks>
        public string Number { get; set; } = "10";
    }
}