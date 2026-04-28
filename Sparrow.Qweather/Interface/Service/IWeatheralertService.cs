using Sparrow.Qweather.Models.Options;
using Sparrow.Qweather.Models.Request.Weatheralert;
using Sparrow.Qweather.Models.Response.Weatheralert;
using System.Threading.Tasks;

namespace Sparrow.Qweather.Interface.Service
{
    /// <summary>
    /// 实时天气预警
    /// </summary>
    public interface IWeatheralertService
    {
        /// <summary>
        /// 实时天气预警
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        Task<WeatheralertCurrentResponse> WeatheralertCurrentAsync(WebApiOptions options, WeatheralertCurrentRequest args);
    }
}