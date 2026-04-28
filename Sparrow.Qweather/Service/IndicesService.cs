using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Sparrow.Qweather.Const;
using Sparrow.Qweather.Interface.Service;
using Sparrow.Qweather.Models.Options;
using Sparrow.Qweather.Models.Request.Indices;
using Sparrow.Qweather.Models.Response.Indices;
using Sparrow.Qweather.Tools;

namespace Sparrow.Qweather.Service
{
    /// <summary>
    /// 指数服务
    /// </summary>
    public class IndicesService : IIndicesService
    {
        /// <summary>
        /// 天气指数预报 https://dev.qweather.com/docs/api/indices/indices-forecast/
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public async Task<IndicesForecastResponse> IndicesForecastAsync(
            WebApiOptions options,
            IndicesForecastRequest args
        )
        {
            string path = string.Format(WebApiConst.IndicesForecastPath, args.Path.Days);
            return await args.Query.GetApiResponseAsync<IndicesForecastResponse>(options, path);
        }
    }
}