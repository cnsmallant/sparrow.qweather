using Sparrow.Qweather.Models.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Sparrow.Qweather.Models.Request.Astronomy
{
    /// <summary>
    /// 日出日落请求
    /// </summary>
    public class SunRequest : CommonInfoRequest
    {
        /// <summary>
        /// 获取或设置需要查询的地区（查询参数）。 支持以下格式：
        /// <list type="bullet">
        /// <item>
        /// <description>LocationID（通过 GeoAPI 获取，如 "101010100" 表示北京）</description>
        /// </item>
        /// <item>
        /// <description>经度,纬度（十进制，最多支持小数点后两位，如 "116.41,39.92"）</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <example>101010100</example>
        /// <example>116.41,39.92</example>
        /// <remarks>此参数为必选参数。</remarks>
        public string Location { get; set; }

        /// <summary>
        /// 获取或设置查询日期（查询参数）。 最多可选择未来 60 天（包含今天）的数据。 格式：yyyyMMdd（例如 20200531 表示 2020年5月31日）。
        /// </summary>
        /// <example>20200531</example>
        /// <remarks>此参数为必选参数。</remarks>
        public string Date { get; set; }
    }
}