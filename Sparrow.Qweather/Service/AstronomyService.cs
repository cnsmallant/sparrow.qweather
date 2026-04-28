using Sparrow.Qweather.Const;
using Sparrow.Qweather.Interface.Service;
using Sparrow.Qweather.Models.Options;
using Sparrow.Qweather.Models.Request.Astronomy;
using Sparrow.Qweather.Models.Response.Astronomy;
using Sparrow.Qweather.Tools;
using System.Threading.Tasks;

namespace Sparrow.Qweather.Service
{
    /// <summary>
    /// 天文
    /// </summary>
    public class AstronomyService : IAstronomyService
    {
        /// <summary>
        /// 日出日落 https://dev.qweather.com/docs/api/astronomy/sunrise-sunset/
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public Task<SunResponse> SunAsync(WebApiOptions options, SunRequest args)
        {
            return args.GetApiResponseAsync<SunResponse>(
                options,
                WebApiConst.SunPath
            );
        }

        /// <summary>
        /// 月升月落和月相 https://dev.qweather.com/docs/api/astronomy/moon-and-moon-phase/
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public Task<MoonResponse> MoonAsync(WebApiOptions options, MoonRequest args)
        {
            return args.GetApiResponseAsync<MoonResponse>(
                options,
                WebApiConst.MoonPath
            );
        }

        /// <summary>
        /// 太阳高度角 https://dev.qweather.com/docs/api/astronomy/solar-elevation-angle/
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public Task<SolarElevationAngleResponse> SolarElevationAngleAsync(WebApiOptions options, SolarElevationAngleRequest args)
        {
            return args.GetApiResponseAsync<SolarElevationAngleResponse>(
                options,
                WebApiConst.SolarElevationAnglePath
            );
        }
    }
}