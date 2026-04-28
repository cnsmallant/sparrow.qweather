using System.Text.Json.Serialization;

namespace Sparrow.Qweather.Models.Common
{
    /// <summary>
    /// 错误信息
    /// </summary>
    public class CommonErrorResponse
    {
        /// <summary>
        /// 返回结果码 0：表示成功，非0表示失败
        /// </summary>
        [JsonPropertyName("errcode")]
        public int ErrCode { get; set; }

        /// <summary>
        /// 具体错误原因 详细说明错误原因，当errcode不为0时返回
        /// </summary>
        [JsonPropertyName("errdetail")]
        public string ErrDetail { get; set; }

        /// <summary>
        /// 返回状态说明 OK：表示成功，其他值表示错误
        /// </summary>
        [JsonPropertyName("errmsg")]
        public string ErrMsg { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        /// <returns></returns>
        public bool IsSuccessful()
        {
            if (ErrCode == 0 && ErrMsg.ToUpper() == "OK")
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
            if (ErrCode != 0 && ErrMsg.ToUpper() != "OK")
            {
                return ErrDetail;
            }
            return string.Empty;
        }
    }
}