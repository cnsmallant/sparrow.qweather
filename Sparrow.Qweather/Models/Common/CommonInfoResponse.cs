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

    public class CommonMetaDataResponse
    {
        /// <summary>
        /// 数据唯一标识
        /// </summary>
        [JsonPropertyName("tag")]
        public string Tag { get; set; }

        /// <summary>
        /// 数据归因信息或声明，必须与当前数据共同显示
        /// </summary>
        [JsonPropertyName("attributions")]
        public List<string> Attributions { get; set; }

        /// <summary>
        /// 当前是否有返回的数据。当 "zeroResult": true 时，表示请求是成功的，但没有任何需要返回的数据。例如查询一个坐标的天气预警信息，此时该地点没有任何预警信息。
        /// </summary>
        [JsonPropertyName("zeroResult")]
        public bool ZeroResult { get; set; }
    }
}