using System.Threading.Tasks;
using Sparrow.Qweather.Const;
using Sparrow.Qweather.Interface.Service;
using Sparrow.Qweather.Models.Options;
using Sparrow.Qweather.Models.Request.AirQuality;
using Sparrow.Qweather.Models.Response.AirQuality;
using Sparrow.Qweather.Tools;

namespace Sparrow.Qweather.Service
{
    /// <summary>
    /// 空气质量服务
    /// </summary>
    public class AirQualityService : IAirQualityService
    {
        /// <summary>
        /// 实时空气质量 https://dev.qweather.com/docs/api/air-quality/air-current/
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public Task<AirCurrentResponse> AirCurrentAsync(
            WebApiOptions options,
            AirCurrentRequest args
        )
        {
            string path = string.Format(
                WebApiConst.AirQualityCurrentPath,
                args.Path.Latitude,
                args.Path.Longitude
            );
            return args.Query.GetApiResponseAsync<AirCurrentResponse>(options, path);
        }

        /// <summary>
        /// 空气质量小时预报 https://dev.qweather.com/docs/api/air-quality/air-hourly-forecast/
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public Task<AirHourlyForecastResponse> AirHourlyForecastAsync(
            WebApiOptions options,
            AirHourlyForecastRequest args
        )
        {
            string path = string.Format(
                WebApiConst.AirQualityHourlyForecastPath,
                args.Path.Latitude,
                args.Path.Longitude
            );
            return args.Query.GetApiResponseAsync<AirHourlyForecastResponse>(options, path);
        }

        /// <summary>
        /// 空气质量每日预报 https://dev.qweather.com/docs/api/air-quality/air-daily-forecast/
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public Task<AirDailyForecastResponse> AirDailyForecastAsync(
            WebApiOptions options,
            AirDailyForecastRequest args
        )
        {
            string path = string.Format(
                WebApiConst.AirQualityDailyForecastPath,
                args.Path.Latitude,
                args.Path.Longitude
            );
            return args.Query.GetApiResponseAsync<AirDailyForecastResponse>(options, path);
        }

        /// <summary>
        /// 监测站数据 https://dev.qweather.com/docs/api/air-quality/air-station/
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public Task<AirStationResponse> AirStationAsync(
            WebApiOptions options,
            AirStationRequest args
        )
        {
            string path = string.Format(WebApiConst.AirQualityStationPath, args.Path.LocationID);
            return args.Query.GetApiResponseAsync<AirStationResponse>(options, path);
        }
    }
}