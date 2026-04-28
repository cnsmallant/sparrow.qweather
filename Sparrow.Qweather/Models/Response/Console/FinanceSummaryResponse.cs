using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sparrow.Qweather.Models.Response.Console
{
    public class FinanceSummaryResponse
    {
        /// <summary>
        /// 元数据信息（包含请求标识等）
        /// </summary>
        [JsonPropertyName("metadata")]
        public FinanceSummaryMetadata Metadata { get; set; }

        /// <summary>
        /// 当前数据的截止日期（UTC 时间）
        /// <para>格式：ISO 8601，示例： <c>2024-04-03T17:13Z</c></para>
        /// </summary>
        [JsonPropertyName("asOf")]
        public DateTimeOffset AsOf { get; set; }

        /// <summary>
        /// 货币代码，支持 CNY 和 USD
        /// <para>示例： <c>"CNY"</c> 或 <c>"USD"</c></para>
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 可用额度（正数代表盈余，负数代表欠费）
        /// <para>示例： <c>-17.54</c></para>
        /// </summary>
        [JsonPropertyName("balance")]
        public decimal Balance { get; set; }

        /// <summary>
        /// 应计费用明细
        /// </summary>
        [JsonPropertyName("accruedCharges")]
        public FinanceSummaryAccruedCharges AccruedCharges { get; set; }

        /// <summary>
        /// 待支付账单列表
        /// </summary>
        [JsonPropertyName("pendingBills")]
        public List<FinanceSummaryPendingBill> PendingBills { get; set; }

        /// <summary>
        /// 生效中或待生效的节省计划列表
        /// </summary>
        [JsonPropertyName("availableSavingsPlans")]
        public List<FinanceSummaryAvailableSavingsPlan> AvailableSavingsPlans { get; set; }

        /// <summary>
        /// 生效中或待生效的资源包列表
        /// </summary>
        [JsonPropertyName("availableResourcePlans")]
        public List<FinanceSummaryAvailableResourcePlan> AvailableResourcePlans { get; set; }
    }

    /// <summary>
    /// 元数据实体
    /// </summary>
    public class FinanceSummaryMetadata
    {
        /// <summary>
        /// 请求追踪标识（唯一标记）
        /// <para>示例： <c>"2a9873efd0a6c75665dc4f6116b19bdf"</c></para>
        /// </summary>
        [JsonPropertyName("tag")]
        public string Tag { get; set; }
    }

    /// <summary>
    /// 应计费用明细实体
    /// </summary>
    public class FinanceSummaryAccruedCharges
    {
        /// <summary>
        /// 前一天应计费用总额
        /// </summary>
        [JsonPropertyName("previousDay")]
        public decimal PreviousDay { get; set; }

        /// <summary>
        /// 本月应计费用总额
        /// </summary>
        [JsonPropertyName("thisMonth")]
        public decimal ThisMonth { get; set; }

        /// <summary>
        /// 从上次出账以来的应计费用总额
        /// </summary>
        [JsonPropertyName("sinceLastBill")]
        public decimal SinceLastBill { get; set; }
    }

    /// <summary>
    /// 待支付账单实体
    /// </summary>
    public class FinanceSummaryPendingBill
    {
        /// <summary>
        /// 待支付账单号
        /// <para>示例： <c>"20681CYX"</c></para>
        /// </summary>
        [JsonPropertyName("number")]
        public string Number { get; set; }

        /// <summary>
        /// 账单日期（UTC 时间）
        /// </summary>
        [JsonPropertyName("date")]
        public DateTimeOffset Date { get; set; }

        /// <summary>
        /// 账单类型（例如 PayAsYouGo、SavingsPlans 等）
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 账单状态（例如 unpaid、paid）
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 账单的总金额
        /// </summary>
        [JsonPropertyName("amount")]
        public decimal Amount { get; set; }

        /// <summary>
        /// 账单剩余应付金额
        /// </summary>
        [JsonPropertyName("amountDue")]
        public decimal AmountDue { get; set; }

        /// <summary>
        /// 应付日期（UTC 截止时间）
        /// </summary>
        [JsonPropertyName("dueDate")]
        public DateTimeOffset DueDate { get; set; }
    }

    /// <summary>
    /// 生效中或待生效的节省计划实体
    /// </summary>
    public class FinanceSummaryAvailableSavingsPlan
    {
        /// <summary>
        /// 节省计划关联的账单号
        /// </summary>
        [JsonPropertyName("billNumber")]
        public string BillNumber { get; set; }

        /// <summary>
        /// 节省计划状态（pending 或 active）
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 承诺期限（例如 "1" 表示 1 年）
        /// </summary>
        [JsonPropertyName("term")]
        public string Term { get; set; }

        /// <summary>
        /// 承诺金额
        /// </summary>
        [JsonPropertyName("commitments")]
        public decimal Commitments { get; set; }

        /// <summary>
        /// 已用承诺金额
        /// </summary>
        [JsonPropertyName("utilized")]
        public decimal Utilized { get; set; }

        /// <summary>
        /// 生效时间（UTC）
        /// </summary>
        [JsonPropertyName("effectiveTime")]
        public DateTimeOffset EffectiveTime { get; set; }
    }

    /// <summary>
    /// 生效中或待生效的资源包实体
    /// </summary>
    public class FinanceSummaryAvailableResourcePlan
    {
        /// <summary>
        /// 资源包关联的账单号
        /// </summary>
        [JsonPropertyName("billNumber")]
        public string BillNumber { get; set; }

        /// <summary>
        /// 资源包状态（pending 或 active）
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 总请求量（整数或小数均可）
        /// </summary>
        [JsonPropertyName("requests")]
        public decimal Requests { get; set; }

        /// <summary>
        /// 已用请求量
        /// </summary>
        [JsonPropertyName("utilized")]
        public decimal Utilized { get; set; }

        /// <summary>
        /// 生效时间（UTC）
        /// </summary>
        [JsonPropertyName("effectiveTime")]
        public DateTimeOffset EffectiveTime { get; set; }
    }
}