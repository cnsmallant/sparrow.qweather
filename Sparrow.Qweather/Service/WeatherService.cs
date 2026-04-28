using System.Threading.Tasks;
using Sparrow.Qweather.Const;
using Sparrow.Qweather.Interface.Service;
using Sparrow.Qweather.Models.Options;
using Sparrow.Qweather.Models.Request.Weather;
using Sparrow.Qweather.Models.Response.Weather;
using Sparrow.Qweather.Tools;

namespace Sparrow.Qweather.Service
{
    /// <summary>
    /// 天气预报 https://dev.qweather.com/docs/api/weather/
    /// </summary>
    public class WeatherService : IWeatherService
    {
        /// <summary>
        /// 实时天气 https://dev.qweather.com/docs/api/weather/weather-now/
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public Task<WeatherNowResponse> WeatherNowAsync(
            WebApiOptions options,
            WeatherNowRequest args
        )
        {
            return args.GetApiResponseAsync<WeatherNowResponse>(
                options,
                WebApiConst.WeatherNowPath
            );
        }

        /// <summary>
        /// 每日天气预报 https://dev.qweather.com/docs/api/weather/weather-daily-forecast/
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public Task<WeatherDaysResponse> WeatherDaysAsync(
            WebApiOptions options,
            WeatherDaysRequest args
        )
        {
            string path = string.Format(WebApiConst.WeatherDaysPath, args.Path.Days);
            return args.Query.GetApiResponseAsync<WeatherDaysResponse>(options, path);
        }

        /// <summary>
        /// 逐小时天气预报 https://dev.qweather.com/docs/api/weather/weather-hourly-forecast/
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public Task<WeatherHoursResponse> WeatherHoursAsync(
            WebApiOptions options,
            WeatherHoursRequest args
        )
        {
            string path = string.Format(WebApiConst.WeatherDaysPath, args.Path.Hours);
            return args.Query.GetApiResponseAsync<WeatherHoursResponse>(options, path);
        }

        /// <summary>
        /// 格点实时天气 https://dev.qweather.com/docs/api/weather/grid-weather-now/
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public Task<GridWeatherNowResponse> GridWeatherNowAsync(
            WebApiOptions options,
            GridWeatherNowRequest args
        )
        {
            return args.GetApiResponseAsync<GridWeatherNowResponse>(
                options,
                WebApiConst.GridWeatherNowPath
            );
        }

        /// <summary>
        /// 格点每日天气预报 https://dev.qweather.com/docs/api/weather/grid-weather-daily-forecast/
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public Task<GridWeatherDaysResponse> GridWeatherDaysAsync(
            WebApiOptions options,
            GridWeatherDaysRequest args
        )
        {
            string path = string.Format(WebApiConst.GridWeatherDaysPath, args.Path.Days);
            return args.Query.GetApiResponseAsync<GridWeatherDaysResponse>(options, path);
        }

        /// <summary>
        /// 格点逐小时天气预报 https://dev.qweather.com/docs/api/weather/grid-weather-hourly-forecast/
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public Task<GridWeatherHoursResponse> GridWeatherHoursAsync(
            WebApiOptions options,
            GridWeatherHoursRequest args
        )
        {
            string path = string.Format(WebApiConst.GridWeatherHoursPath, args.Path.Hours);
            return args.Query.GetApiResponseAsync<GridWeatherHoursResponse>(options, path);
        }
    }
}