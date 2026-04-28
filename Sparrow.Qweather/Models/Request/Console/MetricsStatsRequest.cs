using Sparrow.Qweather.Models.Common;
using System.Text.Json.Serialization;

namespace Sparrow.Qweather.Models.Request.Console
{
    /// <summary>
    /// 请求量统计
    /// </summary>
    public class MetricsStatsRequest : CommonInfoRequest
    {
        /// <summary>
        /// 项目ID，指定该项目以查看请求量统计。
        /// <para>注意： <c>project</c> 与 <c>credential</c> 互斥，仅能提供其中一个。</para>
        /// </summary>
        [JsonPropertyName("project")]
        public string Project { get; set; }

        /// <summary>
        /// 凭据ID，指定该凭据以查看请求量统计。
        /// <para>注意： <c>credential</c> 与 <c>project</c> 互斥，仅能提供其中一个。</para>
        /// </summary>
        [JsonPropertyName("credential")]
        public string Credential { get; set; }
    }
}