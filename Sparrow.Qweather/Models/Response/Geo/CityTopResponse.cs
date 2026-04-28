using Sparrow.Qweather.Models.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sparrow.Qweather.Models.Response.Geo
{
    /// <summary>
    /// 获取热门城市列表的响应
    /// </summary>
    public class CityTopResponse : CommonInfoResponse
    {
        /// <summary>
        /// 热门城市/地区数组
        /// </summary>
        [JsonPropertyName("topCityList")]
        public List<TopCityItem> TopCityList { get; set; }
    }

    /// <summary>
    /// 表示热门城市列表中的单个城市/地区信息
    /// </summary>
    public class TopCityItem
    {
        /// <summary>
        /// 地区/城市名称
        /// </summary>
        /// <example>北京</example>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 地区/城市 ID（和风天气唯一标识）
        /// </summary>
        /// <example>101010100</example>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 地区/城市纬度，采用 WGS84 坐标系统
        /// </summary>
        /// <example>39.90499</example>
        [JsonPropertyName("lat")]
        public string Lat { get; set; }

        /// <summary>
        /// 地区/城市经度，采用 WGS84 坐标系统
        /// </summary>
        /// <example>116.40529</example>
        [JsonPropertyName("lon")]
        public string Lon { get; set; }

        /// <summary>
        /// 地区/城市的上级行政区划名称（例如地级市、州、盟等）
        /// </summary>
        /// <example>北京</example>
        [JsonPropertyName("adm2")]
        public string Adm2 { get; set; }

        /// <summary>
        /// 地区/城市所属一级行政区域（省、直辖市、自治区等）
        /// </summary>
        /// <example>北京市</example>
        [JsonPropertyName("adm1")]
        public string Adm1 { get; set; }

        /// <summary>
        /// 地区/城市所属国家名称
        /// </summary>
        /// <example>中国</example>
        [JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// 地区/城市所在时区（IANA 时区名称）
        /// </summary>
        /// <example>Asia/Shanghai</example>
        [JsonPropertyName("tz")]
        public string Tz { get; set; }

        /// <summary>
        /// 地区/城市目前与 UTC 时间偏移的小时数
        /// </summary>
        /// <example>+08:00</example>
        [JsonPropertyName("utcOffset")]
        public string UtcOffset { get; set; }

        /// <summary>
        /// 地区/城市是否当前处于夏令时
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
        public string IsDst { get; set; }  // 使用 string 类型以匹配 JSON 中的 "0"/"1"

        // 若需要布尔值，可声明为 bool 并自定义转换器，但为简洁此处保留原字符串

        /// <summary>
        /// 地区/城市的属性类型，标识该地点是城市、区县、乡镇还是风景区等
        /// </summary>
        /// <example>city</example>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 地区评分，用于表示该地区的热门程度或重要性（数值越小可能越热门，具体参考和风天气文档）
        /// </summary>
        /// <example>10</example>
        [JsonPropertyName("rank")]
        public string Rank { get; set; }   // JSON 中 rank 为字符串型数字

        /// <summary>
        /// 该地区的天气预报网页链接，可直接嵌入网站或应用
        /// </summary>
        /// <example>https://www.qweather.com/weather/beijing-101010100.html</example>
        [JsonPropertyName("fxLink")]
        public string FxLink { get; set; }
    }
}