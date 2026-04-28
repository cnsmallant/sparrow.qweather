using System.Collections.Generic;
using System.Text.Json.Serialization;
using Sparrow.Qweather.Models.Common;

namespace Sparrow.Qweather.Models.Response.Geo
{
    /// <summary>
    /// 城市查询响应
    /// </summary>
    public class CityLookUpResponse : CommonInfoResponse
    {
        /// <summary>
        /// 地点列表
        /// </summary>
        [JsonPropertyName("location")]
        public List<CityLookUpLocationItem> Location { get; set; }
    }

    /// <summary>
    /// 单个地点/城市的天气信息实体（对应 location 数组中的每一项）
    /// </summary>
    public class CityLookUpLocationItem
    {
        /// <summary>
        /// 地区/城市名称
        /// </summary>
        /// <example>北京</example>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 地区/城市 ID（和风天气专属 ID）
        /// </summary>
        /// <example>101010100</example>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 地区/城市纬度（十进制，字符串形式）
        /// </summary>
        /// <example>39.90499</example>
        [JsonPropertyName("lat")]
        public string Lat { get; set; }

        /// <summary>
        /// 地区/城市经度（十进制，字符串形式）
        /// </summary>
        /// <example>116.40529</example>
        [JsonPropertyName("lon")]
        public string Lon { get; set; }

        /// <summary>
        /// 地区/城市的上级行政区划名称（例如区/县所属的地级市名称）
        /// </summary>
        /// <example>北京</example>
        [JsonPropertyName("adm2")]
        public string Adm2 { get; set; }

        /// <summary>
        /// 地区/城市所属的一级行政区域（例如省、自治区、直辖市）
        /// </summary>
        /// <example>北京市</example>
        [JsonPropertyName("adm1")]
        public string Adm1 { get; set; }

        /// <summary>
        /// 地区/城市所属的国家名称
        /// </summary>
        /// <example>中国</example>
        [JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// 地区/城市所在时区（IANA 时区数据库格式）
        /// </summary>
        /// <example>Asia/Shanghai</example>
        [JsonPropertyName("tz")]
        public string Tz { get; set; }

        /// <summary>
        /// 地区/城市当前与 UTC 时间偏移的小时数（格式如 +08:00, -05:00）
        /// </summary>
        /// <example>+08:00</example>
        [JsonPropertyName("utcOffset")]
        public string UtcOffset { get; set; }

        /// <summary>
        /// 地区/城市是否当前处于夏令时：1 表示是，0 表示否
        /// </summary>
        /// <example>0</example>
        [JsonPropertyName("isDst")]
        public string IsDst { get; set; }

        /// <summary>
        /// 地区/城市的属性（如 city, district, village 等）
        /// </summary>
        /// <example>city</example>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 地区评分（用于相关性排序，数值越小代表匹配度越高或重要性越高）
        /// </summary>
        /// <example>10</example>
        [JsonPropertyName("rank")]
        public string Rank { get; set; }

        /// <summary>
        /// 该地区的天气预报网页链接，可嵌入网站或应用
        /// </summary>
        /// <example>https://www.qweather.com/weather/beijing-101010100.html</example>
        [JsonPropertyName("fxLink")]
        public string FxLink { get; set; }
    }
}