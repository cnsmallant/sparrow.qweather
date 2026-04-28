using Sparrow.Qweather.Interface.Common;

namespace Sparrow.Qweather.Models.Common
{
    /// <summary>
    /// 公共请求参数
    /// </summary>
    public class CommonInfoRequest : ICommonInfoRequest
    {
        /// <summary>
        /// 语言
        /// </summary>
        public string Lang { get; set; }
    }
}