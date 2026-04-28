using Sparrow.Qweather.Models.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sparrow.Qweather.Models.Response.Ocean
{
    /// <summary>
    /// 潮汐数据
    /// </summary>
    public class TideResponse : CommonInfoResponse
    {
        /// <summary>
        /// 当前 API 的最近更新时间。
        /// </summary>
        /// <example>2021-02-04T05:02+08:00</example>
        [JsonPropertyName("updateTime")]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 当前数据的响应式页面链接，便于嵌入网站或应用。
        /// </summary>
        /// <example>https://www.qweather.com</example>
        [JsonPropertyName("fxLink")]
        public string FxLink { get; set; }

        /// <summary>
        /// 潮汐表（满潮/干潮点列表）。
        /// </summary>
        [JsonPropertyName("tideTable")]
        public List<TideTableItem> TideTable { get; set; }

        /// <summary>
        /// 逐小时潮高预报数据列表。
        /// </summary>
        [JsonPropertyName("tideHourly")]
        public List<TideHourlyItem> TideHourly { get; set; }
    }

    /// <summary>
    /// 表示潮汐表中的单个满潮（H）或干潮（L）点。
    /// </summary>
    public class TideTableItem
    {
        /// <summary>
        /// 满潮或干潮时间（北京时间，含时区偏移）。
        /// </summary>
        /// <example>2021-02-06T03:48+08:00</example>
        [JsonPropertyName("fxTime")]
        public string FxTime { get; set; }

        /// <summary>
        /// 海水高度（单位：米）。
        /// </summary>
        /// <example>2.17</example>
        [JsonPropertyName("height")]
        public string Height { get; set; }

        /// <summary>
        /// 潮汐类型：H - 满潮（高潮），L - 干潮（低潮）。
        /// </summary>
        /// <example>H</example>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }

    /// <summary>
    /// 表示逐小时潮高预报的数据点。
    /// </summary>
    public class TideHourlyItem
    {
        /// <summary>
        /// 逐小时预报时间（北京时间，含时区偏移）。
        /// </summary>
        /// <example>2021-02-06T00:00+08:00</example>
        [JsonPropertyName("fxTime")]
        public string FxTime { get; set; }

        /// <summary>
        /// 海水高度（单位：米）。对于某些地点，此数据可能为空。
        /// </summary>
        /// <example>1.02</example>
        [JsonPropertyName("height")]
        public string Height { get; set; }
    }
}