using Sparrow.Qweather.Const;
using Sparrow.Qweather.Interface.Service;
using Sparrow.Qweather.Models.Options;
using Sparrow.Qweather.Models.Request.Ocean;
using Sparrow.Qweather.Models.Response.Ocean;
using Sparrow.Qweather.Tools;
using System.Threading.Tasks;

namespace Sparrow.Qweather.Service
{
    /// <summary>
    /// 海洋数据
    /// </summary>
    public class OceanService : IOceanService
    {
        /// <summary>
        /// 潮汐 https://dev.qweather.com/docs/api/ocean/tide/
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public Task<TideResponse> TideAsync(WebApiOptions options, TideRequest args)
        {
            return args.GetApiResponseAsync<TideResponse>(options, WebApiConst.OceanTidePath);
        }
    }
}