using Sparrow.Qweather.Models.Common;
using System.Text.Json.Serialization;

namespace Sparrow.Qweather.Models.Response.Weather
{
    /// <summary>
    /// 实时天气
    /// </summary>
    public class WeatherNowResponse : CommonInfoResponse
    {
        /// <summary>
        /// 当前 API 的最近更新时间
        /// </summary>
        /// <example>2020-06-30T22:00+08:00</example>
        [JsonPropertyName("updateTime")]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 当前数据的响应式页面链接，便于嵌入网站或应用
        /// </summary>
        /// <example>http://hfx.link/2ax1</example>
        [JsonPropertyName("fxLink")]
        public string FxLink { get; set; }

        /// <summary>
        /// 实况天气数据
        /// </summary>
        [JsonPropertyName("now")]
        public WeatherNowItem Now { get; set; }
    }

    /// <summary>
    /// 表示实况天气的具体数据
    /// </summary>
    public class WeatherNowItem
    {
        /// <summary>
        /// 数据观测时间
        /// </summary>
        /// <example>2020-06-30T21:40+08:00</example>
        [JsonPropertyName("obsTime")]
        public string ObsTime { get; set; }

        /// <summary>
        /// 温度，默认单位：摄氏度
        /// </summary>
        /// <example>24</example>
        [JsonPropertyName("temp")]
        public string Temp { get; set; }

        /// <summary>
        /// 体感温度，默认单位：摄氏度
        /// </summary>
        /// <example>26</example>
        [JsonPropertyName("feelsLike")]
        public string FeelsLike { get; set; }

        /// <summary>
        /// 天气状况的图标代码，参考天气图标项目
        /// </summary>
        /// <example>101</example>
        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 天气状况的文字描述，包括阴晴雨雪等
        /// </summary>
        /// <example>多云</example>
        [JsonPropertyName("text")]
        public string Text { get; set; }

        /// <summary>
        /// 风向360角度
        /// </summary>
        /// <example>123</example>
        [JsonPropertyName("wind360")]
        public string Wind360 { get; set; }

        /// <summary>
        /// 风向
        /// </summary>
        /// <example>东南风</example>
        [JsonPropertyName("windDir")]
        public string WindDir { get; set; }

        /// <summary>
        /// 风力等级
        /// </summary>
        /// <example>1</example>
        [JsonPropertyName("windScale")]
        public string WindScale { get; set; }

        /// <summary>
        /// 风速，单位：公里/小时
        /// </summary>
        /// <example>3</example>
        [JsonPropertyName("windSpeed")]
        public string WindSpeed { get; set; }

        /// <summary>
        /// 相对湿度，百分比数值
        /// </summary>
        /// <example>72</example>
        [JsonPropertyName("humidity")]
        public string Humidity { get; set; }

        /// <summary>
        /// 过去1小时降水量，默认单位：毫米
        /// </summary>
        /// <example>0.0</example>
        [JsonPropertyName("precip")]
        public string Precip { get; set; }

        /// <summary>
        /// 大气压强，默认单位：百帕
        /// </summary>
        /// <example>1003</example>
        [JsonPropertyName("pressure")]
        public string Pressure { get; set; }

        /// <summary>
        /// 能见度，默认单位：公里
        /// </summary>
        /// <example>16</example>
        [JsonPropertyName("vis")]
        public string Vis { get; set; }

        /// <summary>
        /// 云量，百分比数值。可能为空
        /// </summary>
        /// <example>10</example>
        [JsonPropertyName("cloud")]
        public string Cloud { get; set; }

        /// <summary>
        /// 露点温度。可能为空
        /// </summary>
        /// <example>21</example>
        [JsonPropertyName("dew")]
        public string Dew { get; set; }
    }
}