using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using Sparrow.Qweather.Models.Common;

namespace Sparrow.Qweather.Models.Request.TropicalCyclone
{
    /// <summary>
    /// 台风列表
    /// </summary>
    public class StormListRequest : CommonInfoRequest
    {
        /// <summary>
        /// 获取或设置需要查询的台风流域（查询参数）。 当前仅支持 NP（西北太平洋）。 basin(必选)需要查询的台风所在的流域 AL North Atlantic 北大西洋 EP
        /// Eastern Pacific 东太平洋 NP NorthWest Pacific 西北太平洋 SP SouthWestern Pacific 西南太平洋 NI North
        /// Indian 北印度洋 SI South Indian 南印度洋
        /// </summary>
        /// <example>NP</example>
        /// <remarks>此参数为必选参数。</remarks>
        public string Basin { get; set; }

        /// <summary>
        /// 获取或设置需要查询的年份（查询参数）。 支持查询本年度和上一年度的台风。格式为四位数字。
        /// </summary>
        /// <example>2020</example>
        /// <remarks>此参数为必选参数。</remarks>
        public string Year { get; set; }
    }
}