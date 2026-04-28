using Sparrow.Qweather.Models.Common;
using System.Text.Json.Serialization;

namespace Sparrow.Qweather.Models.Response.Astronomy
{
    /// <summary>
    /// 太阳高度角
    /// </summary>
    public class SolarElevationAngleResponse : CommonInfoResponse
    {
        /// <summary>
        /// 太阳高度角（单位：度）
        /// <para>表示太阳光线与地平线之间的夹角，取值范围 -90° ～ 90°。</para>
        /// <para>对应 JSON 字段： <c>solarElevationAngle</c></para>
        /// <para>示例值： <c>42.88</c></para>
        /// </summary>
        [JsonPropertyName("solarElevationAngle")]
        public double SolarElevationAngle { get; set; }

        /// <summary>
        /// 太阳方位角（单位：度）
        /// <para>以正北方向为起点顺时针旋转的角度，取值范围 0° ～ 360°。</para>
        /// <para>对应 JSON 字段： <c>solarAzimuthAngle</c></para>
        /// <para>示例值： <c>185.92</c></para>
        /// </summary>
        [JsonPropertyName("solarAzimuthAngle")]
        public double SolarAzimuthAngle { get; set; }

        /// <summary>
        /// 太阳时（真太阳时）
        /// <para>格式： <c>HHmm</c>（24小时制），表示当地的真太阳时间。</para>
        /// <para>对应 JSON 字段： <c>solarHour</c></para>
        /// <para>示例值： <c>"1217"</c> 表示 12:17</para>
        /// </summary>
        [JsonPropertyName("solarHour")]
        public string SolarHour { get; set; }

        /// <summary>
        /// 时角（单位：度）
        /// <para>表示当地经度与太阳所在经度之间的角度差，每 15° 对应 1 小时。</para>
        /// <para>对应 JSON 字段： <c>hourAngle</c></para>
        /// <para>示例值： <c>-4.41</c></para>
        /// </summary>
        [JsonPropertyName("hourAngle")]
        public double HourAngle { get; set; }
    }
}