using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Sparrow.Qweather.Const;
using Sparrow.Qweather.Interface.Service;
using Sparrow.Qweather.Models.Options;
using Sparrow.Qweather.Models.Request.Weatheralert;
using Sparrow.Qweather.Models.Response.Weatheralert;
using Sparrow.Qweather.Tools;

namespace Sparrow.Qweather.Service
{
    /// <summary>
    /// 天气预警
    /// </summary>
    public class WeatheralertService : IWeatheralertService
    {
        /// <summary>
        /// 实时天气预警 https://dev.qweather.com/docs/api/warning/weather-alert/
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public Task<WeatheralertCurrentResponse> WeatheralertCurrentAsync(
            WebApiOptions options,
            WeatheralertCurrentRequest args
        )
        {
            string path = string.Format(
                WebApiConst.WeatheralertCurrentPath,
                args.Path.Latitude,
                args.Path.Longitude
            );
            return args.Query.GetApiResponseAsync<WeatheralertCurrentResponse>(
                options,
                path
            );
        }
    }
}