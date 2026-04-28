using System.Threading.Tasks;
using Sparrow.Qweather.Models.Options;
using Sparrow.Qweather.Models.Request.TropicalCyclone;
using Sparrow.Qweather.Models.Response.TropicalCyclone;

namespace Sparrow.Qweather.Interface.Service
{
    /// <summary>
    /// 热带气旋（台风）
    /// </summary>
    public interface ITropicalCycloneService
    {
        /// <summary>
        /// 台风预报
        /// </summary>
        Task<StormForecastResponse> StormForecastAsync(
            WebApiOptions options,
            StormForecastRequest args
        );

        /// <summary>
        /// 台风实况和路径
        /// </summary>
        Task<StormTrackResponse> StormTrackAsync(WebApiOptions options, StormTrackRequest args);

        /// <summary>
        /// 台风列表
        /// </summary>
        Task<StormListResponse> StormListAsync(WebApiOptions options, StormListRequest args);
    }
}