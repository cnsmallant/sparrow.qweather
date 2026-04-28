using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sparrow.Qweather.Models.Response.Console
{
    /// <summary>
    /// 请求量统计
    /// </summary>
    public class MetricsStatsResponse
    {
        /// <summary>
        /// 元数据信息（包含请求追踪标识）
        /// </summary>
        [JsonPropertyName("metadata")]
        public MetricsStatsMetadata Metadata { get; set; }

        /// <summary>
        /// 当前数据的截止日期（UTC 时间）
        /// <para>格式：ISO 8601，示例： <c>2025-05-12T02:59Z</c></para>
        /// <para>
        /// 表示统计数据的最后时间点， <see cref="Success"/> 和 <see cref="Errors"/> 中的小时数组均以该时间为结束时间，共 24 个小时数据。
        /// </para>
        /// </summary>
        [JsonPropertyName("asOf")]
        public DateTimeOffset AsOf { get; set; }

        /// <summary>
        /// 成功请求的统计列表
        /// <para>每个元素包含 API 名称及其最近 24 小时每小时的请求量。</para>
        /// </summary>
        [JsonPropertyName("success")]
        public List<MetricsStatsApiHourlyStats> Success { get; set; }

        /// <summary>
        /// 错误请求的统计列表
        /// <para>每个元素包含 API 名称及其最近 24 小时每小时的错误请求量。</para>
        /// </summary>
        [JsonPropertyName("errors")]
        public List<MetricsStatsApiHourlyStats> Errors { get; set; }
    }

    /// <summary>
    /// 元数据实体
    /// </summary>
    public class MetricsStatsMetadata
    {
        /// <summary>
        /// 请求追踪标识（唯一标记）
        /// <para>示例： <c>"dcd6183920ebf9f5aa3fd066ed68e61b"</c></para>
        /// </summary>
        [JsonPropertyName("tag")]
        public string Tag { get; set; }
    }

    /// <summary>
    /// API 每小时请求量统计实体
    /// <para>用于成功请求或错误请求的统计结果。</para>
    /// </summary>
    public class MetricsStatsApiHourlyStats
    {
        /// <summary>
        /// API 名称
        /// <para>示例： <c>"Weather"</c>、 <c>"Geo"</c>、 <c>"WeatherAlert"</c> 等。</para>
        /// </summary>
        [JsonPropertyName("api")]
        public string Api { get; set; }

        /// <summary>
        /// 最近 24 小时每小时的请求量（整数数组）
        /// <para>
        /// 数组长度固定为 24，下标 0 对应最早的 1 小时，下标 23 对应距离 <see cref="ApiRequestStatistics.AsOf"/> 最近的 1 小时。
        /// </para>
        /// <para>
        /// 示例：若 <c>asOf = 2025-03-20T09:59Z</c>，则 <c>hours[23]</c> 表示 09:00～09:59（UTC）的请求量。
        /// </para>
        /// </summary>
        [JsonPropertyName("hours")]
        public List<int> Hours { get; set; }
    }
}