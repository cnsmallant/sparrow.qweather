using Sparrow.Qweather.Models.Common;

namespace Sparrow.Qweather.Models.Request.Geo
{
    /// <summary>
    /// 城市查询
    /// </summary>
    public class CityLookUpRequest : CommonInfoRequest
    {
        /// <summary>
        /// 需要查询的地区名称（必选）。 支持以下四种格式：
        /// <list type="bullet">
        /// <item>
        /// <description>文字地名：如“北京”，支持模糊搜索（至少一个汉字或2个字符）</description>
        /// </item>
        /// <item>
        /// <description>经纬度坐标：十进制，小数点后最多两位，英文逗号分隔，如“116.41,39.92”</description>
        /// </item>
        /// <item>
        /// <description>LocationID：地点唯一标识符</description>
        /// </item>
        /// <item>
        /// <description>Adcode：中国城市行政区划代码</description>
        /// </item>
        /// </list>
        /// 模糊搜索时系统会根据相关性和 Rank 值排序返回多个结果；若存在重名，需配合 <see cref="Adm"/> 参数进一步筛选。
        /// </summary>
        /// <example>北京</example>
        /// <example>116.41,39.92</example>
        public string Location { get; set; }

        /// <summary>
        /// 上级行政区划（可选）。用于限定搜索范围，排除重名城市。 例如(location=西安 )。
        /// </summary>
        public string Adm { get; set; }

        /// <summary>
        /// 搜索范围（可选）。指定仅在某个国家或地区内搜索，使用 ISO 3166 国家代码（如 cn、us、jp）。 若不设置，则搜索所有城市。
        /// </summary>
        /// <example>cn</example>
        public string Range { get; set; }

        /// <summary>
        /// 返回结果的数量（可选）。取值范围 1-20，默认值为 10。
        /// </summary>
        /// <example>5</example>
        public string Number { get; set; } = "10"; // 默认 10
    }
}