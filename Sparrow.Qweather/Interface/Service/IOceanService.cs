using Sparrow.Qweather.Models.Options;
using Sparrow.Qweather.Models.Request.Ocean;
using Sparrow.Qweather.Models.Response.Ocean;
using System.Threading.Tasks;

namespace Sparrow.Qweather.Interface.Service
{
    /// <summary>
    /// 海洋数据
    /// </summary>
    public interface IOceanService
    {
        /// <summary>
        /// 潮汐
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        Task<TideResponse> TideAsync(WebApiOptions options, TideRequest args);
    }
}