using Sparrow.Qweather.Models.Common;

namespace Sparrow.Qweather.Models.Request.Geo
{
    /// <summary>
    /// POI范围搜索
    /// </summary>
    public class PoiRangeRequest : CommonInfoRequest
    {
        /// <summary>
        /// 获取或设置查询的中心点坐标。 格式：经度,纬度（十进制，最多支持小数点后两位）。
        /// </summary>
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
        /// 获取或设置搜索半径，单位为公里。 取值范围：1 到 50。默认值为 5。
        /// </summary>
        /// <value>1 到 50 之间的整数。</value>
        /// <example>10</example>
        /// <remarks>此参数为可选参数。</remarks>
        public string Radius { get; set; } = "5";

        /// <summary>
        /// 获取或设置返回结果的数量。 取值范围：1 到 20。默认值为 10。
        /// </summary>
        /// <value>1 到 20 之间的整数。</value>
        /// <example>15</example>
        /// <remarks>此参数为可选参数。</remarks>
        public string Number { get; set; } = "10";
    }
}