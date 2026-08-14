using System;
using System.Collections.Generic;
using System.Text;

namespace Sparrow.Qweather.Tools
{
    /// <summary>
    /// 降水数据
    /// </summary>
    public static class PrecipitationDataTool
    {
        /// <summary>
        /// 降水类型
        /// </summary>
        public static readonly Dictionary<string, string> PrecipitationTypes = new Dictionary<
            string,
            string
        >
        {
            { "rain", "雨" },
            { "snow", "雪" },
            { "ice", "冰粒或冻雨" },
            { "mixed", "混合降水" },
            { "none", "无降水" },
            { "unknown", "未知" }
        };
    }
}