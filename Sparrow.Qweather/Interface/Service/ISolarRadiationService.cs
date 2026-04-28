using Sparrow.Qweather.Models.Options;
using Sparrow.Qweather.Models.Request.SolarRadiation;
using Sparrow.Qweather.Models.Response.SolarRadiation;
using System.Threading.Tasks;

namespace Sparrow.Qweather.Interface.Service
{
    /// <summary>
    /// 太阳辐射
    /// </summary>
    public interface ISolarRadiationService
    {
        /// <summary>
        /// 太阳辐射预报
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        Task<SolarRadiationForecastResponse> SolarRadiationForecastAsync(
            WebApiOptions options,
            SolarRadiationForecastRequest args
        );
    }
}