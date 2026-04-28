using Sparrow.Qweather.Const;
using Sparrow.Qweather.Interface.Service;
using Sparrow.Qweather.Models.Options;
using Sparrow.Qweather.Models.Request.TimeMachine;
using Sparrow.Qweather.Models.Response.TimeMachine;
using Sparrow.Qweather.Tools;
using System.Threading.Tasks;

namespace Sparrow.Qweather.Service
{
    /// <summary>
    /// 时光机
    /// </summary>
    public class TimeMachineService : ITimeMachineService
    {
        /// <summary>
        /// 天气时光机 https://dev.qweather.com/docs/api/time-machine/time-machine-weather/
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public Task<HistoricalWeatherResponse> HistoricalWeatherAsync(
            WebApiOptions options,
            HistoricalWeatherRequest args
        )
        {
            return args.GetApiResponseAsync<HistoricalWeatherResponse>(
                options,
                WebApiConst.HistoricalWeatherPath
            );
        }

        /// <summary>
        /// 空气质量时光机 https://dev.qweather.com/docs/api/time-machine/time-machine-air/
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public Task<HistoricalAirResponse> HistoricalAirAsync(WebApiOptions options, HistoricalAirRequest args)
        {
            return args.GetApiResponseAsync<HistoricalAirResponse>(
                options,
                WebApiConst.HistoricalAirPath
            );
        }
    }
}