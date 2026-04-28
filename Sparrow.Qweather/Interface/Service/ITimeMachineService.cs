using Sparrow.Qweather.Models.Options;
using Sparrow.Qweather.Models.Request.TimeMachine;
using Sparrow.Qweather.Models.Response.TimeMachine;
using System.Threading.Tasks;

namespace Sparrow.Qweather.Interface.Service
{
    /// <summary>
    /// 时光机
    /// </summary>
    public interface ITimeMachineService
    {
        /// <summary>
        /// 天气时光机
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        Task<HistoricalWeatherResponse> HistoricalWeatherAsync(WebApiOptions options, HistoricalWeatherRequest args);

        /// <summary>
        /// 空气质量时光机
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        Task<HistoricalAirResponse> HistoricalAirAsync(WebApiOptions options, HistoricalAirRequest args);
    }
}