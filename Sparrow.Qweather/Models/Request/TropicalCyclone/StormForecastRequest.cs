using System;
using System.Collections.Generic;
using System.Text;
using Sparrow.Qweather.Models.Common;

namespace Sparrow.Qweather.Models.Request.TropicalCyclone
{
    /// <summary>
    /// 台风预报
    /// </summary>
    public class StormForecastRequest : CommonInfoRequest
    {
        /// <summary>
        /// (必选)需要查询的台风ID，StormID可通过台风查询API获取。例如 stormid=NP2018
        /// </summary>
        public string Stormid { get; set; }
    }
}