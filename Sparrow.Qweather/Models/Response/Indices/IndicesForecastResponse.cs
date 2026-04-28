using Sparrow.Qweather.Models.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sparrow.Qweather.Models.Response.Indices
{
    public class IndicesForecastResponse : CommonInfoResponse
    {
        /// <summary>
        /// 当前 API 的最近更新时间
        /// </summary>
        /// <example>2021-12-16T18:35+08:00</example>
        [JsonPropertyName("updateTime")]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 当前数据的响应式页面链接，便于嵌入网站或应用
        /// </summary>
        /// <example>http://hfx.link/2ax2</example>
        [JsonPropertyName("fxLink")]
        public string FxLink { get; set; }

        /// <summary>
        /// 生活指数预报列表，每个元素表示某一天的一种生活指数
        /// </summary>
        [JsonPropertyName("daily")]
        public List<IndicesDailyItem> Daily { get; set; }
    }

    /// <summary>
    /// 表示单条生活指数预报的详细信息。
    /// </summary>
    public class IndicesDailyItem
    {
        /// <summary>
        /// 预报日期
        /// </summary>
        /// <example>2021-12-16</example>
        [JsonPropertyName("date")]
        public string Date { get; set; }

        /// <summary>
        /// 生活指数类型 ID（例如 1-运动指数，2-洗车指数等）
        /// </summary>
        /// <example>1</example>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 生活指数类型的名称
        /// </summary>
        /// <example>运动指数</example>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 生活指数预报等级（通常为数字等级）
        /// </summary>
        /// <example>3</example>
        [JsonPropertyName("level")]
        public string Level { get; set; }

        /// <summary>
        /// 生活指数预报级别名称（如“较不宜”）
        /// </summary>
        /// <example>较不宜</example>
        [JsonPropertyName("category")]
        public string Category { get; set; }

        /// <summary>
        /// 生活指数预报的详细描述（可能为空）
        /// </summary>
        /// <example>天气较好，但考虑天气寒冷，风力较强，推荐您进行室内运动，若户外运动请注意保暖并做好准备活动。</example>
        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}