using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Sparrow.Qweather.Models.Options;
using Sparrow.Qweather.Models.Request.Indices;
using Sparrow.Qweather.Models.Response.Indices;

namespace Sparrow.Qweather.Interface.Service
{
    /// <summary>
    /// 指数预报
    /// </summary>
    public interface IIndicesService
    {
        /// <summary>
        /// 天气指数预报
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        Task<IndicesForecastResponse> IndicesForecastAsync(
            WebApiOptions options,
            IndicesForecastRequest args
        );
    }
}