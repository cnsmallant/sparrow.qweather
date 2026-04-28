using Sparrow.Qweather.Models.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sparrow.Qweather.Models.Response.Weather
{
    /// <summary>
    /// 逐小时天气预报
    /// </summary>
    public class WeatherHoursResponse : CommonInfoResponse
    {
        /// <summary>
        /// 当前 API 的最近更新时间
        /// </summary>
        /// <example>2021-02-16T13:35+08:00</example>
        [JsonPropertyName("updateTime")]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 当前数据的响应式页面链接，便于嵌入网站或应用
        /// </summary>
        /// <example>http://hfx.link/2ax1</example>
        [JsonPropertyName("fxLink")]
        public string FxLink { get; set; }

        /// <summary>
        /// 逐小时天气预报数组，通常包含未来24-72小时的预报数据
        /// </summary>
        [JsonPropertyName("hourly")]
        public List<WeatherHourlyItem> Hourly { get; set; }
    }

    /// <summary>
    /// 表示单小时天气预报的详细信息。
    /// </summary>
    public class WeatherHourlyItem
    {
        /// <summary>
        /// 预报时间（北京时间，含时区偏移）
        /// </summary>
        /// <example>2021-02-16T15:00+08:00</example>
        [JsonPropertyName("fxTime")]
        public string FxTime { get; set; }

        /// <summary>
        /// 温度（默认单位：摄氏度）
        /// </summary>
        /// <example>2</example>
        [JsonPropertyName("temp")]
        public string Temp { get; set; }

        /// <summary>
        /// 天气状况的图标代码，参考天气图标项目
        /// </summary>
        /// <example>100</example>
        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 天气状况的文字描述（如晴、多云、雨等）
        /// </summary>
        /// <example>晴</example>
        [JsonPropertyName("text")]
        public string Text { get; set; }

        /// <summary>
        /// 风向360角度
        /// </summary>
        /// <example>335</example>
        [JsonPropertyName("wind360")]
        public string Wind360 { get; set; }

        /// <summary>
        /// 风向（如西北风）
        /// </summary>
        /// <example>西北风</example>
        [JsonPropertyName("windDir")]
        public string WindDir { get; set; }

        /// <summary>
        /// 风力等级（如 3-4）
        /// </summary>
        /// <example>3-4</example>
        [JsonPropertyName("windScale")]
        public string WindScale { get; set; }

        /// <summary>
        /// 风速（公里/小时）
        /// </summary>
        /// <example>20</example>
        [JsonPropertyName("windSpeed")]
        public string WindSpeed { get; set; }

        /// <summary>
        /// 相对湿度（百分比数值）
        /// </summary>
        /// <example>11</example>
        [JsonPropertyName("humidity")]
        public string Humidity { get; set; }

        /// <summary>
        /// 当前小时累计降水量（默认单位：毫米）
        /// </summary>
        /// <example>0.0</example>
        [JsonPropertyName("precip")]
        public string Precip { get; set; }

        /// <summary>
        /// 逐小时预报降水概率（百分比数值，可能为空）
        /// </summary>
        /// <example>0</example>
        [JsonPropertyName("pop")]
        public string Pop { get; set; }

        /// <summary>
        /// 大气压强（默认单位：百帕）
        /// </summary>
        /// <example>1025</example>
        [JsonPropertyName("pressure")]
        public string Pressure { get; set; }

        /// <summary>
        /// 云量（百分比数值，可能为空）
        /// </summary>
        /// <example>0</example>
        [JsonPropertyName("cloud")]
        public string Cloud { get; set; }

        /// <summary>
        /// 露点温度（可能为空）
        /// </summary>
        /// <example>-25</example>
        [JsonPropertyName("dew")]
        public string Dew { get; set; }
    }
}