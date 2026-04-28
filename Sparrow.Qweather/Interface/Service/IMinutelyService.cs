using Sparrow.Qweather.Models.Options;
using Sparrow.Qweather.Models.Request.Minutely;
using Sparrow.Qweather.Models.Response.Minutely;
using System.Threading.Tasks;

namespace Sparrow.Qweather.Interface.Service
{
    public interface IMinutelyService
    {
        /// <summary>
        /// 分钟级降水
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        Task<Minutely5mResponse> Minutely5mAsync(WebApiOptions options, Minutely5mRequset args);
    }
}