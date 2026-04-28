using System.Text.Json.Serialization;
using Sparrow.Qweather.Models.Common;

namespace Sparrow.Qweather.Models.Response.Weather
{
    /// <summary>
    /// 实时天气
    /// </summary>
    public class GridWeatherNowResponse : CommonInfoResponse
    {
        /// <summary>
        /// 当前 API 的最近更新时间
        /// </summary>
        /// <example>2021-12-16T18:25+08:00</example>
        [JsonPropertyName("updateTime")]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 当前数据的响应式页面链接，便于嵌入网站或应用
        /// </summary>
        /// <example>https://www.qweather.com</example>
        [JsonPropertyName("fxLink")]
        public string FxLink { get; set; }

        /// <summary>
        /// 实况天气数据
        /// </summary>
        [JsonPropertyName("now")]
        public GridWeatherNowItem Now { get; set; }
    }

    /// <summary>
    /// 表示当前实时天气的详细信息。
    /// </summary>
    public class GridWeatherNowItem
    {
        /// <summary>
        /// 数据观测时间
        /// </summary>
        /// <example>2021-12-16T10:00+00:00</example>
        [JsonPropertyName("obsTime")]
        public string ObsTime { get; set; }

        /// <summary>
        /// 温度（默认单位：摄氏度）
        /// </summary>
        /// <example>-1</example>
        [JsonPropertyName("temp")]
        public string Temp { get; set; }

        /// <summary>
        /// 天气状况的图标代码，参考天气图标项目
        /// </summary>
        /// <example>150</example>
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
        /// <example>287</example>
        [JsonPropertyName("wind360")]
        public string Wind360 { get; set; }

        /// <summary>
        /// 风向（如西北风）
        /// </summary>
        /// <example>西北风</example>
        [JsonPropertyName("windDir")]
        public string WindDir { get; set; }

        /// <summary>
        /// 风力等级
        /// </summary>
        /// <example>2</example>
        [JsonPropertyName("windScale")]
        public string WindScale { get; set; }

        /// <summary>
        /// 风速（公里/小时）
        /// </summary>
        /// <example>10</example>
        [JsonPropertyName("windSpeed")]
        public string WindSpeed { get; set; }

        /// <summary>
        /// 相对湿度（百分比数值）
        /// </summary>
        /// <example>27</example>
        [JsonPropertyName("humidity")]
        public string Humidity { get; set; }

        /// <summary>
        /// 过去1小时降水量（默认单位：毫米）
        /// </summary>
        /// <example>0.0</example>
        [JsonPropertyName("precip")]
        public string Precip { get; set; }

        /// <summary>
        /// 大气压强（默认单位：百帕）
        /// </summary>
        /// <example>1021</example>
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
        /// <example>-17</example>
        [JsonPropertyName("dew")]
        public string Dew { get; set; }
    }
}