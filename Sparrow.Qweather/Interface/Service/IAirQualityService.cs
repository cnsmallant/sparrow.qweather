using Sparrow.Qweather.Models.Options;
using Sparrow.Qweather.Models.Request.AirQuality;
using Sparrow.Qweather.Models.Response.AirQuality;
using System.Threading.Tasks;

namespace Sparrow.Qweather.Interface.Service
{
    /// <summary>
    /// 空气质量
    /// </summary>
    public interface IAirQualityService
    {
        /// <summary>
        /// 实时空气质量
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        Task<AirCurrentResponse> AirCurrentAsync(WebApiOptions options, AirCurrentRequest args);

        /// <summary>
        /// 空气质量小时预报
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        Task<AirHourlyForecastResponse> AirHourlyForecastAsync(WebApiOptions options, AirHourlyForecastRequest args);

        /// <summary>
        /// 空气质量每日预报
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        Task<AirDailyForecastResponse> AirDailyForecastAsync(WebApiOptions options, AirDailyForecastRequest args);

        /// <summary>
        /// 监测站数据
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        Task<AirStationResponse> AirStationAsync(WebApiOptions options, AirStationRequest args);
    }
}