using System.Threading.Tasks;
using Sparrow.Qweather.Const;
using Sparrow.Qweather.Interface.Service;
using Sparrow.Qweather.Models.Options;
using Sparrow.Qweather.Models.Request.TropicalCyclone;
using Sparrow.Qweather.Models.Response.TropicalCyclone;
using Sparrow.Qweather.Tools;

namespace Sparrow.Qweather.Service
{
    /// <summary>
    /// 热带气旋服务
    /// </summary>
    public class TropicalCycloneService : ITropicalCycloneService
    {
        /// <summary>
        /// 台风预报 https://dev.qweather.com/docs/api/tropical-cyclone/storm-forecast/
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public async Task<StormForecastResponse> StormForecastAsync(
            WebApiOptions options,
            StormForecastRequest args
        )
        {
            return await args.GetApiResponseAsync<StormForecastResponse>(
                options,
                WebApiConst.StormForecastPath
            );
        }

        /// <summary>
        /// 台风实况和路径 https://dev.qweather.com/docs/api/tropical-cyclone/storm-track/
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public Task<StormTrackResponse> StormTrackAsync(
            WebApiOptions options,
            StormTrackRequest args
        )
        {
            return args.GetApiResponseAsync<StormTrackResponse>(
                options,
                WebApiConst.StormTrackPath
            );
        }

        /// <summary>
        /// 台风列表 https://dev.qweather.com/docs/api/tropical-cyclone/storm-list/
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public Task<StormListResponse> StormListAsync(WebApiOptions options, StormListRequest args)
        {
            return args.GetApiResponseAsync<StormListResponse>(options, WebApiConst.StormListPath);
        }
    }
}