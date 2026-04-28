using Sparrow.Qweather.Models.Common;

namespace Sparrow.Qweather.Models.Request.Geo
{
    /// <summary>
    /// 热门城市查询
    /// </summary>
    public class CityTopRequest : CommonInfoRequest
    {
        /// <summary>
        /// 获取或设置搜索范围（国家或地区代码）。 需使用 ISO 3166 定义的国家/地区代码（如 "cn" 表示中国）。 若不设置，则搜索范围覆盖所有城市。
        /// </summary>
        /// <example>cn, us, jp</example>
        /// <remarks>该参数对应查询字符串中的 "range"。</remarks>
        public string Range { get; set; }

        /// <summary>
        /// 获取或设置返回结果的数量。 取值范围：1 到 20。默认值为 10。
        /// </summary>
        /// <value>1 到 20 之间的整数。</value>
        /// <remarks>该参数对应查询字符串中的 "number"。</remarks>
        public string Number { get; set; } = "10"; // 提供默认值 10
    }
}