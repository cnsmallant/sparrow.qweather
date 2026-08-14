using System.Collections.Generic;

namespace Sparrow.Qweather.Tools
{
    /// <summary>
    /// 月相数据工具类
    /// </summary>
    public static class MoonPhaseDataTool
    {
        /// <summary>
        /// 月相字典，键为代码（小写），值为中文描述
        /// </summary>
        public static readonly Dictionary<string, string> MoonPhases = new Dictionary<string, string>
    {
        { "new-moon", "新月" },
        { "waxing-crescent", "蛾眉月" },
        { "first-quarter", "上弦月" },
        { "waxing-gibbous", "盈凸月" },
        { "full-moon", "满月" },
        { "waning-gibbous", "亏凸月" },
        { "last-quarter", "下弦月" },
        { "waning-crescent", "残月" }
    };
    }
}