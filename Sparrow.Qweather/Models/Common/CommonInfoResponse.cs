using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace Sparrow.Qweather.Models.Common
{
    /// <summary>
    /// 通用返回结果
    /// </summary>
    public class CommonInfoResponse
    {
        /// <summary>
        /// 返回状态
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 返回数据来源及版权信息
        /// </summary>
        [JsonPropertyName("refer")]
        public CommonInfoRefer Refer { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        /// <returns></returns>
        public bool IsSuccessful()
        {
            if (Code == "200")
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 错误信息
        /// </summary>
        /// <returns></returns>
        public string Error()
        {
            if (Code != "200")
            {
                return Code;
            }
            return string.Empty;
        }
    }

    public class CommonInfoRefer
    {
        /// <summary>
        /// 原始数据来源或数据源说明（可能为空）
        /// </summary>
        /// <example>["QWeather"]</example>
        [JsonPropertyName("sources")]
        public List<string> Sources { get; set; }

        /// <summary>
        /// 数据许可或版权声明（可能为空）
        /// </summary>
        /// <example>["QWeather Developers License"]</example>
        [JsonPropertyName("license")]
        public List<string> License { get; set; }
    }
}