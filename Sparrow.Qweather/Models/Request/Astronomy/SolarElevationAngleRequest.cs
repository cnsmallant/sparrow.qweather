using Sparrow.Qweather.Models.Common;

namespace Sparrow.Qweather.Models.Request.Astronomy
{
    /// <summary>
    /// 太阳高度角
    /// </summary>
    public class SolarElevationAngleRequest : CommonInfoRequest
    {
        /// <summary>
        /// 获取或设置查询位置的经纬度坐标。
        /// <para>格式：经度,纬度（十进制，最多支持小数点后两位），以英文逗号分隔。</para>
        /// <para>示例： <c>116.41,39.92</c></para>
        /// <para>此参数为必选。</para>
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// 获取或设置查询日期。
        /// <para>格式： <c>yyyyMMdd</c>（例如： <c>20170809</c> 表示 2017年8月9日）。</para>
        /// <para>此参数为必选。</para>
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// 获取或设置查询时间（24小时制）。
        /// <para>格式： <c>HHmm</c>（例如： <c>1230</c> 表示 12:30）。</para>
        /// <para>此参数为必选。</para>
        /// </summary>
        public string Time { get; set; }

        /// <summary>
        /// 获取或设置查询地区所在的时区。
        /// <para>格式： <c>±HHmm</c>，其中正数表示东时区，负数表示西时区。</para>
        /// <para>示例： <c>0800</c>（东八区）， <c>-0530</c>（西五区30分）。</para>
        /// <para>此参数为必选。</para>
        /// </summary>
        public string Tz { get; set; }

        /// <summary>
        /// 获取或设置海拔高度（单位：米）。
        /// <para>示例： <c>43</c> 表示海拔43米。</para>
        /// <para>此参数为必选。</para>
        /// </summary>
        public int Alt { get; set; }
    }
}