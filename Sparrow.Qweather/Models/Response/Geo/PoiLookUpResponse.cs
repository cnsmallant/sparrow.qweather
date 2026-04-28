using Sparrow.Qweather.Models.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sparrow.Qweather.Models.Response.Geo
{
    /// <summary>
    /// POI搜索
    /// </summary>
    public class PoiLookUpResponse : CommonInfoResponse
    {
        /// <summary>
        /// POI
        /// </summary>
        [JsonPropertyName("poi")]
        public List<PoiLookUpPoiItem> Poi { get; set; }
    }

    /// <summary>
    /// 表示单个 POI（兴趣点）的信息
    /// </summary>
    public class PoiLookUpPoiItem
    {
        /// <summary>
        /// POI 名称
        /// </summary>
        /// <example>景山公园</example>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// POI 的唯一标识 ID
        /// </summary>
        /// <example>10101010012A</example>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// POI 纬度，采用 WGS84 坐标系统
        /// </summary>
        /// <example>39.91999</example>
        [JsonPropertyName("lat")]
        public string Lat { get; set; }

        /// <summary>
        /// POI 经度，采用 WGS84 坐标系统
        /// </summary>
        /// <example>116.38999</example>
        [JsonPropertyName("lon")]
        public string Lon { get; set; }

        /// <summary>
        /// POI 的上级行政区划名称（例如地级市、州、盟等）
        /// </summary>
        /// <example>北京</example>
        [JsonPropertyName("adm2")]
        public string Adm2 { get; set; }

        /// <summary>
        /// POI 所属一级行政区域（省、直辖市、自治区等）
        /// </summary>
        /// <example>北京</example>
        [JsonPropertyName("adm1")]
        public string Adm1 { get; set; }

        /// <summary>
        /// POI 所属国家名称
        /// </summary>
        /// <example>中国</example>
        [JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// POI 所在时区（IANA 时区名称）
        /// </summary>
        /// <example>Asia/Shanghai</example>
        [JsonPropertyName("tz")]
        public string Tz { get; set; }

        /// <summary>
        /// POI 目前与 UTC 时间偏移的小时数
        /// </summary>
        /// <example>+08:00</example>
        [JsonPropertyName("utcOffset")]
        public string UtcOffset { get; set; }

        /// <summary>
        /// POI 是否当前处于夏令时
        /// <list type="bullet">
        /// <item>
        /// <description>1 - 当前处于夏令时</description>
        /// </item>
        /// <item>
        /// <description>0 - 当前不是夏令时</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <example>0</example>
        [JsonPropertyName("isDst")]
        public string IsDst { get; set; }

        /// <summary>
        /// POI 的类型，例如 scenic（景点）、TSTA（潮汐站点）等
        /// </summary>
        /// <example>scenic</example>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// POI 评分（数值越高或越低取决于具体业务，参考和风天气文档）
        /// </summary>
        /// <example>67</example>
        [JsonPropertyName("rank")]
        public string Rank { get; set; }

        /// <summary>
        /// 该 POI 的天气预报网页链接，便于嵌入网站或应用
        /// </summary>
        /// <example>https://www.qweather.com</example>
        [JsonPropertyName("fxLink")]
        public string FxLink { get; set; }
    }
}