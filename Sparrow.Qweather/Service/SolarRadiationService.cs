using System.Threading.Tasks;
using Sparrow.Qweather.Const;
using Sparrow.Qweather.Interface.Service;
using Sparrow.Qweather.Models.Options;
using Sparrow.Qweather.Models.Request.SolarRadiation;
using Sparrow.Qweather.Models.Response.SolarRadiation;
using Sparrow.Qweather.Tools;

namespace Sparrow.Qweather.Service
{
    /// <summary>
    /// 太阳辐射服务
    /// </summary>
    public class SolarRadiationService : ISolarRadiationService
    {
        /// <summary>
        /// 太阳辐射预报 https://dev.qweather.com/docs/api/solar-radiation/solar-radiation-forecast/
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public Task<SolarRadiationForecastResponse> SolarRadiationForecastAsync(
            WebApiOptions options,
            SolarRadiationForecastRequest args
        )
        {
            string path = string.Format(
                WebApiConst.SolarRadiationForecastPath,
                args.Path.Latitude,
                args.Path.Longitude
            );
            return args.Query.GetApiResponseAsync<SolarRadiationForecastResponse>(options, path);
        }
    }
}