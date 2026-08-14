using System;
using System.Threading.Tasks;
using Sparrow.Qweather.Models.Options;
using Sparrow.Qweather.Models.Request.Weather;
using Sparrow.Qweather.Models.Response.Weather;

namespace Sparrow.Qweather.Interface.Service
{
    /// <summary>
    /// 天气服务
    /// </summary>
    public interface IWeatherService
    {
        #region 天气预报

        /// <summary>
        /// 天气实况
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        Task<WeatherCurrentResponse> WeatherCurrentAsync(WebApiOptions options, WeatherCurrentRequest args);

        /// <summary>
        /// 每日天气预报
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        Task<WeatherDailyResponse> WeatherDailyAsync(WebApiOptions options, WeatherDailyRequest args);

        #endregion 天气预报

        #region 旧版天气预报 2026年8月14日14:59:41

        /// <summary>
        /// 实时天气
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        [Obsolete]
        Task<WeatherNowResponse> WeatherNowAsync(WebApiOptions options, WeatherNowRequest args);

        /// <summary>
        /// 每日天气预报
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        [Obsolete]
        Task<WeatherDaysResponse> WeatherDaysAsync(WebApiOptions options, WeatherDaysRequest args);

        /// <summary>
        /// 逐小时天气预报
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        [Obsolete]
        Task<WeatherHoursResponse> WeatherHoursAsync(
            WebApiOptions options,
            WeatherHoursRequest args
        );

        /// <summary>
        /// 格点实时天气
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        [Obsolete]
        Task<GridWeatherNowResponse> GridWeatherNowAsync(
            WebApiOptions options,
            GridWeatherNowRequest args
        );

        /// <summary>
        /// 格点每日天气预报
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <param name="days"></param>
        /// <returns></returns>
        [Obsolete]
        Task<GridWeatherDaysResponse> GridWeatherDaysAsync(
            WebApiOptions options,
            GridWeatherDaysRequest args
        );

        /// <summary>
        /// 格点逐小时天气预报
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <param name="hours"></param>
        /// <returns></returns>
        [Obsolete]
        Task<GridWeatherHoursResponse> GridWeatherHoursAsync(
            WebApiOptions options,
            GridWeatherHoursRequest args
        );

        #endregion 旧版天气预报 2026年8月14日14:59:41
    }
}