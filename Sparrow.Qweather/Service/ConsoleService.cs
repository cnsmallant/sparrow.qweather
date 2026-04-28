using System.Threading.Tasks;
using Sparrow.Qweather.Const;
using Sparrow.Qweather.Interface.Service;
using Sparrow.Qweather.Models.Options;
using Sparrow.Qweather.Models.Request.Console;
using Sparrow.Qweather.Models.Response.Console;
using Sparrow.Qweather.Tools;

namespace Sparrow.Qweather.Service
{
    /// <summary>
    /// 控制台
    /// </summary>
    public class ConsoleService : IConsoleService
    {
        /// <summary>
        /// 财务汇总 https://dev.qweather.com/docs/api/console/finance/
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public Task<FinanceSummaryResponse> FinanceSummaryAsync(
            WebApiOptions options,
            FinanceSummaryRequest args
        )
        {
            return args.GetApiResponseAsync<FinanceSummaryResponse>(
                options,
                WebApiConst.FinanceSummaryPath
            );
        }

        /// <summary>
        /// 请求量统计 https://dev.qweather.com/docs/api/console/stats/
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public Task<MetricsStatsResponse> MetricsStatsAsync(WebApiOptions options, MetricsStatsRequest args)
        {
            return args.GetApiResponseAsync<MetricsStatsResponse>(
                options,
                WebApiConst.MetricsStatsPath
            );
        }
    }
}