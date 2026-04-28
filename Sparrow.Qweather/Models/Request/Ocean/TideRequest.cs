using Sparrow.Qweather.Models.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Sparrow.Qweather.Models.Request.Ocean
{
    /// <summary>
    /// 潮汐请求参数
    /// </summary>
    public class TideRequest : CommonInfoRequest
    {
        /// <summary>
        /// 获取或设置需要查询的潮汐站点 ID（查询参数）。 请填写潮汐站点的 LocationID，可通过 POI 搜索服务获取。
        /// </summary>
        /// <example>P2951</example>
        /// <remarks>此参数为必选参数。</remarks>
        public string Location { get; set; }

        /// <summary>
        /// 获取或设置查询日期（查询参数）。 最多可选择未来 10 天（包含今天）的数据。 格式：yyyyMMdd（例如 20200531）。
        /// </summary>
        /// <example>20200531</example>
        /// <remarks>此参数为必选参数。</remarks>
        public string Date { get; set; }
    }
}