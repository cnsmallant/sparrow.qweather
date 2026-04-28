using Sparrow.Qweather.Models.Common;

namespace Sparrow.Qweather.Models.Request.Minutely
{
    /// <summary>
    /// 分钟级降水
    /// </summary>
    public class Minutely5mRequset : CommonInfoRequest
    {
        /// <summary>
        /// 地理位置
        /// </summary>
        public string Location { get; set; }
    }
}