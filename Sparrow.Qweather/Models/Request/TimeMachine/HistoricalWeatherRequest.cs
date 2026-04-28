using Sparrow.Qweather.Models.Common;

namespace Sparrow.Qweather.Models.Request.TimeMachine
{
    /// <summary>
    /// 天气时光机
    /// </summary>
    public class HistoricalWeatherRequest : CommonInfoRequest
    {
        /// <summary>
        /// 获取或设置需要查询的地区 ID（查询参数）。 仅支持 LocationID，可通过 GeoAPI 获取。
        /// </summary>
        /// <example>101010100</example>
        /// <remarks>此参数为必选参数。</remarks>
        public string Location { get; set; }

        /// <summary>
        /// 获取或设置查询日期（查询参数）。 最多可选择最近 10 天（不包含今天）的数据。 格式：yyyyMMdd（例如 20200531）。
        /// </summary>
        /// <example>20200531</example>
        /// <remarks>此参数为必选参数。</remarks>
        public string Date { get; set; }

        /// <summary>
        /// 获取或设置数据单位（查询参数）。
        /// <list type="bullet">
        /// <item>
        /// <description>m - 公制单位（默认）</description>
        /// </item>
        /// <item>
        /// <description>i - 英制单位</description>
        /// </item>
        /// </list>
        /// 更多选项和说明参考度量衡单位文档。
        /// </summary>
        /// <value>m 或 i</value>
        /// <example>m</example>
        /// <remarks>此参数为可选参数，默认值为 "m"。</remarks>
        public string Unit { get; set; } = "m";
    }
}