using Sparrow.Qweather.Models.Options;
using Sparrow.Qweather.Models.Request.Astronomy;
using Sparrow.Qweather.Models.Response.Astronomy;
using System.Threading.Tasks;

namespace Sparrow.Qweather.Interface.Service
{
    /// <summary>
    /// 天文
    /// </summary>
    public interface IAstronomyService
    {
        /// <summary>
        /// 日出日落
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        Task<SunResponse> SunAsync(WebApiOptions options, SunRequest args);

        /// <summary>
        /// 月升月落和月相
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        Task<MoonResponse> MoonAsync(WebApiOptions options, MoonRequest args);

        /// <summary>
        /// 太阳高度角
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        Task<SolarElevationAngleResponse> SolarElevationAngleAsync(WebApiOptions options, SolarElevationAngleRequest args);
    }
}