using Sparrow.Qweather.Const;
using Sparrow.Qweather.Interface.Service;
using Sparrow.Qweather.Models.Options;
using Sparrow.Qweather.Models.Request.Minutely;
using Sparrow.Qweather.Models.Response.Minutely;
using Sparrow.Qweather.Tools;
using System.Threading.Tasks;

namespace Sparrow.Qweather.Service
{
    public class MinutelyService : IMinutelyService
    {
        /// <summary>
        /// 分钟级降水 https://dev.qweather.com/docs/api/minutely/minutely-precipitation/
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>

        public Task<Minutely5mResponse> Minutely5mAsync(
            WebApiOptions options,
            Minutely5mRequset args
        )
        {
            return args.GetApiResponseAsync<Minutely5mResponse>(
                options,
                WebApiConst.Minutely5mPath
            );
        }
    }
}