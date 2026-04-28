using Sparrow.Qweather.Models.Options;
using Sparrow.Qweather.Models.Request.Console;
using Sparrow.Qweather.Models.Response.Console;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sparrow.Qweather.Interface.Service
{
    /// <summary>
    /// 控制台
    /// </summary>
    public interface IConsoleService
    {
        /// <summary>
        /// 财务汇总
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        Task<FinanceSummaryResponse> FinanceSummaryAsync(WebApiOptions options, FinanceSummaryRequest args);

        /// <summary>
        /// 请求量统计
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        Task<MetricsStatsResponse> MetricsStatsAsync(WebApiOptions options, MetricsStatsRequest args);
    }
}