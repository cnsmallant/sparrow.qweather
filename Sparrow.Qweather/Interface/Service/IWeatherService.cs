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
        /// <summary>
        /// 实时天气
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        Task<WeatherNowResponse> WeatherNowAsync(WebApiOptions options, WeatherNowRequest args);

        /// <summary>
        /// 每日天气预报
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        Task<WeatherDaysResponse> WeatherDaysAsync(WebApiOptions options, WeatherDaysRequest args);

        /// <summary>
        /// 逐小时天气预报
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
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
        Task<GridWeatherHoursResponse> GridWeatherHoursAsync(
            WebApiOptions options,
            GridWeatherHoursRequest args
        );
    }
}