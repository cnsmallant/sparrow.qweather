using System.Collections.Generic;
using System.Text.Json.Serialization;
using Sparrow.Qweather.Models.Common;

namespace Sparrow.Qweather.Models.Response.Weatheralert
{
    /// <summary>
    /// 实时天气预警
    /// </summary>
    public class WeatheralertCurrentResponse
    {
        /// <summary>
        /// 数据的元信息，包含数据标签和归属说明。
        /// </summary>
        [JsonPropertyName("metadata")]
        public Metadata Metadata { get; set; }

        /// <summary>
        /// 预警信息列表（一个地点可能有多个同时生效的预警）。
        /// </summary>
        [JsonPropertyName("alerts")]
        public List<Alert> Alerts { get; set; }
    }

    /// <summary>
    /// 表示响应数据的元信息。
    /// </summary>
    public class Metadata
    {
        /// <summary>
        /// 数据标签，用于追踪或验证响应数据的完整性。
        /// </summary>
        /// <example>ec71f87d59c5db45281fecc9f25d136f638ba414ff0a4c4e97258e6d30218aac</example>
        [JsonPropertyName("tag")]
        public string Tag { get; set; }

        /// <summary>
        /// 表示请求是否成功但无数据返回。
        /// <list type="bullet">
        /// <item>
        /// <description>true - 请求成功，但无数据返回（例如查询地点无预警）</description>
        /// </item>
        /// <item>
        /// <description>false - 有数据返回</description>
        /// </item>
        /// </list>
        /// </summary>
        [JsonPropertyName("zeroResult")]
        public bool ZeroResult { get; set; }

        /// <summary>
        /// 数据来源或声明列表。开发者必须将此内容与当前数据一起展示（例如在页面的免责声明中）。
        /// </summary>
        /// <example>
        /// ["https://developer.qweather.com/attribution.html", "当前预警数据可能存在延迟或信息过时，以官方数据发布为准。"]
        /// </example>
        [JsonPropertyName("attributions")]
        public List<string> Attributions { get; set; }
    }

    /// <summary>
    /// 表示单条预警信息的详细内容。
    /// </summary>
    public class Alert
    {
        /// <summary>
        /// 本条预警信息的唯一标识 ID。
        /// </summary>
        /// <example>202510241119105837988676</example>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 预警发布机构的名称（可能为空）。
        /// </summary>
        /// <example>临桂区气象台</example>
        [JsonPropertyName("senderName")]
        public string SenderName { get; set; }

        /// <summary>
        /// 原始预警信息生成的时间（实际发布或接收时间会略有延迟）。
        /// </summary>
        /// <example>2025-10-24T11:19+08:00</example>
        [JsonPropertyName("issuedTime")]
        public string IssuedTime { get; set; }

        /// <summary>
        /// 预警信息的消息类型（如 update、cancel、alert 等）。
        /// </summary>
        [JsonPropertyName("messageType")]
        public MessageType MessageType { get; set; }

        /// <summary>
        /// 预警事件类型（如大风、暴雨等）。
        /// </summary>
        [JsonPropertyName("eventType")]
        public EventType EventType { get; set; }

        /// <summary>
        /// 预警信息的紧迫程度（可能为空，例如 "immediate", "expected", "future"）。
        /// </summary>
        [JsonPropertyName("urgency")]
        public string Urgency { get; set; }

        /// <summary>
        /// 预警信息的严重程度（例如 "minor", "moderate", "severe", "extreme"）。
        /// </summary>
        /// <example>minor</example>
        [JsonPropertyName("severity")]
        public string Severity { get; set; }

        /// <summary>
        /// 预警信息的确定性或可信度（可能为空，例如 "observed", "likely", "possible"）。
        /// </summary>
        [JsonPropertyName("certainty")]
        public string Certainty { get; set; }

        /// <summary>
        /// 预警对应的图标代码，可参考和风天气图标项目。
        /// </summary>
        /// <example>1006</example>
        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 预警颜色的 RGBA 信息（用于 UI 显示）。
        /// </summary>
        [JsonPropertyName("color")]
        public Color Color { get; set; }

        /// <summary>
        /// 预警信息的生效时间（可能为空）。
        /// </summary>
        /// <example>2025-10-24T11:19+08:00</example>
        [JsonPropertyName("effectiveTime")]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// 预警事件预计开始的时间（可能为空）。
        /// </summary>
        /// <example>2025-10-24T11:19+08:00</example>
        [JsonPropertyName("onsetTime")]
        public string OnsetTime { get; set; }

        /// <summary>
        /// 预警信息的失效时间（过期时间）。
        /// </summary>
        /// <example>2025-10-25T11:19+08:00</example>
        [JsonPropertyName("expireTime")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 预警信息的简要描述或标题。
        /// </summary>
        /// <example>临桂区气象台更新大风蓝色预警信号</example>
        [JsonPropertyName("headline")]
        public string Headline { get; set; }

        /// <summary>
        /// 预警信息的详细描述。
        /// </summary>
        /// <example>临桂区气象台24日11时19分继续发布大风蓝色预警信号：预计未来24小时内临桂将出现6级（或阵风7级）以上大风，请做好防范。</example>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 当前预警信息的触发标准或条件（仅供参考，可能滞后于官方标准，可能为空）。
        /// </summary>
        /// <example>24小时内可能受大风影响，平均风力可达6级以上，或者阵风7级以上；或者已经受大风影响，平均风力为6～7级，或者阵风7～8级并可能持续。</example>
        [JsonPropertyName("criteria")]
        public string Criteria { get; set; }

        /// <summary>
        /// 对当前预警的应对方式的类型代码列表（可能为空）。
        /// </summary>
        /// <example>[]</example>
        [JsonPropertyName("responseTypes")]
        public List<string> ResponseTypes { get; set; }

        /// <summary>
        /// 对当前预警的防御指南或行动指导（可能为空）。
        /// </summary>
        /// <example>1. 政府及有关部门按照职责做好防大风工作。...</example>
        [JsonPropertyName("instruction")]
        public string Instruction { get; set; }
    }

    /// <summary>
    /// 表示预警信息的消息类型（例如新发布、更新、取消等）。
    /// </summary>
    public class MessageType
    {
        /// <summary>
        /// 预警信息性质的代码（例如 "alert", "update", "cancel"）。
        /// </summary>
        /// <example>update</example>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 当前预警取代或取消后续预警 ID 的列表。 仅当 messageType.code 为 "update" 或 "cancel" 时返回。
        /// </summary>
        /// <example>["202510181140100706230391"]</example>
        [JsonPropertyName("supersedes")]
        public List<string> Supersedes { get; set; }
    }

    /// <summary>
    /// 表示预警事件类型（如大风、暴雨、高温等）。
    /// </summary>
    public class EventType
    {
        /// <summary>
        /// 预警事件类型的名称（中文或英文）。
        /// </summary>
        /// <example>大风</example>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 预警事件类型的代码（和风天气定义的数字代码）。
        /// </summary>
        /// <example>1006</example>
        [JsonPropertyName("code")]
        public string Code { get; set; }
    }

    /// <summary>
    /// 表示预警信息颜色的 RGBA 分量值。
    /// </summary>
    public class Color
    {
        /// <summary>
        /// 预警信息的颜色代码，例如 "blue", "yellow", "orange", "red"。
        /// </summary>
        /// <example>blue</example>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 预警颜色红色分量值（0–255）。
        /// </summary>
        /// <example>30</example>
        [JsonPropertyName("red")]
        public int Red { get; set; }

        /// <summary>
        /// 预警颜色绿色分量值（0–255）。
        /// </summary>
        /// <example>50</example>
        [JsonPropertyName("green")]
        public int Green { get; set; }

        /// <summary>
        /// 预警颜色蓝色分量值（0–255）。
        /// </summary>
        /// <example>205</example>
        [JsonPropertyName("blue")]
        public int Blue { get; set; }

        /// <summary>
        /// 预警颜色的透明度分量值（0–1），1 表示完全不透明。
        /// </summary>
        /// <example>1</example>
        [JsonPropertyName("alpha")]
        public double Alpha { get; set; }
    }
}