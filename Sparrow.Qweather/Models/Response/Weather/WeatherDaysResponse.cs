using System.Collections.Generic;
using System.Text.Json.Serialization;
using Sparrow.Qweather.Models.Common;

namespace Sparrow.Qweather.Models.Response.Weather
{
    /// <summary>
    /// 每日天气预报 https://dev.qweather.com/docs/api/weather/weather-daily-forecast/
    /// </summary>
    public class WeatherDaysResponse : CommonInfoResponse
    {
        /// <summary>
        /// 当前 API 的最近更新时间
        /// </summary>
        /// <example>2021-11-15T16:35+08:00</example>
        [JsonPropertyName("updateTime")]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 当前数据的响应式页面链接，便于嵌入网站或应用
        /// </summary>
        /// <example>http://hfx.link/2ax1</example>
        [JsonPropertyName("fxLink")]
        public string FxLink { get; set; }

        /// <summary>
        /// 每日天气预报数组，通常包含未来3-7天的预报数据
        /// </summary>
        [JsonPropertyName("daily")]
        public List<WeatheDailyItem> Daily { get; set; }
    }

    /// <summary>
    /// 表示单日天气预报的详细信息。
    /// </summary>
    public class WeatheDailyItem
    {
        /// <summary>
        /// 预报日期
        /// </summary>
        /// <example>2021-11-15</example>
        [JsonPropertyName("fxDate")]
        public string FxDate { get; set; }

        /// <summary>
        /// 日出时间（在高纬度地区可能为空）
        /// </summary>
        /// <example>06:58</example>
        [JsonPropertyName("sunrise")]
        public string Sunrise { get; set; }

        /// <summary>
        /// 日落时间（在高纬度地区可能为空）
        /// </summary>
        /// <example>16:59</example>
        [JsonPropertyName("sunset")]
        public string Sunset { get; set; }

        /// <summary>
        /// 当天月升时间（可能为空）
        /// </summary>
        /// <example>15:16</example>
        [JsonPropertyName("moonrise")]
        public string Moonrise { get; set; }

        /// <summary>
        /// 当天月落时间（可能为空）
        /// </summary>
        /// <example>03:40</example>
        [JsonPropertyName("moonset")]
        public string Moonset { get; set; }

        /// <summary>
        /// 月相名称
        /// </summary>
        /// <example>盈凸月</example>
        [JsonPropertyName("moonPhase")]
        public string MoonPhase { get; set; }

        /// <summary>
        /// 月相图标代码，参考天气图标项目
        /// </summary>
        /// <example>803</example>
        [JsonPropertyName("moonPhaseIcon")]
        public string MoonPhaseIcon { get; set; }

        /// <summary>
        /// 预报当天最高温度（默认单位：摄氏度）
        /// </summary>
        /// <example>12</example>
        [JsonPropertyName("tempMax")]
        public string TempMax { get; set; }

        /// <summary>
        /// 预报当天最低温度（默认单位：摄氏度）
        /// </summary>
        /// <example>-1</example>
        [JsonPropertyName("tempMin")]
        public string TempMin { get; set; }

        /// <summary>
        /// 预报白天天气状况的图标代码，参考天气图标项目
        /// </summary>
        /// <example>101</example>
        [JsonPropertyName("iconDay")]
        public string IconDay { get; set; }

        /// <summary>
        /// 预报白天天气状况文字描述（如晴、多云、雨等）
        /// </summary>
        /// <example>多云</example>
        [JsonPropertyName("textDay")]
        public string TextDay { get; set; }

        /// <summary>
        /// 预报夜间天气状况的图标代码，参考天气图标项目
        /// </summary>
        /// <example>150</example>
        [JsonPropertyName("iconNight")]
        public string IconNight { get; set; }

        /// <summary>
        /// 预报夜间天气状况文字描述
        /// </summary>
        /// <example>晴</example>
        [JsonPropertyName("textNight")]
        public string TextNight { get; set; }

        /// <summary>
        /// 预报白天风向360角度
        /// </summary>
        /// <example>45</example>
        [JsonPropertyName("wind360Day")]
        public string Wind360Day { get; set; }

        /// <summary>
        /// 预报白天风向
        /// </summary>
        /// <example>东北风</example>
        [JsonPropertyName("windDirDay")]
        public string WindDirDay { get; set; }

        /// <summary>
        /// 预报白天风力等级
        /// </summary>
        /// <example>1-2</example>
        [JsonPropertyName("windScaleDay")]
        public string WindScaleDay { get; set; }

        /// <summary>
        /// 预报白天风速（公里/小时）
        /// </summary>
        /// <example>3</example>
        [JsonPropertyName("windSpeedDay")]
        public string WindSpeedDay { get; set; }

        /// <summary>
        /// 预报夜间风向360角度
        /// </summary>
        /// <example>0</example>
        [JsonPropertyName("wind360Night")]
        public string Wind360Night { get; set; }

        /// <summary>
        /// 预报夜间风向
        /// </summary>
        /// <example>北风</example>
        [JsonPropertyName("windDirNight")]
        public string WindDirNight { get; set; }

        /// <summary>
        /// 预报夜间风力等级
        /// </summary>
        /// <example>1-2</example>
        [JsonPropertyName("windScaleNight")]
        public string WindScaleNight { get; set; }

        /// <summary>
        /// 预报夜间风速（公里/小时）
        /// </summary>
        /// <example>3</example>
        [JsonPropertyName("windSpeedNight")]
        public string WindSpeedNight { get; set; }

        /// <summary>
        /// 预报当天总降水量（默认单位：毫米）
        /// </summary>
        /// <example>0.0</example>
        [JsonPropertyName("precip")]
        public string Precip { get; set; }

        /// <summary>
        /// 紫外线强度指数
        /// </summary>
        /// <example>3</example>
        [JsonPropertyName("uvIndex")]
        public string UvIndex { get; set; }

        /// <summary>
        /// 相对湿度（百分比数值）
        /// </summary>
        /// <example>65</example>
        [JsonPropertyName("humidity")]
        public string Humidity { get; set; }

        /// <summary>
        /// 大气压强（默认单位：百帕）
        /// </summary>
        /// <example>1020</example>
        [JsonPropertyName("pressure")]
        public string Pressure { get; set; }

        /// <summary>
        /// 能见度（默认单位：公里）
        /// </summary>
        /// <example>25</example>
        [JsonPropertyName("vis")]
        public string Vis { get; set; }

        /// <summary>
        /// 云量（百分比数值，可能为空）
        /// </summary>
        /// <example>4</example>
        [JsonPropertyName("cloud")]
        public string Cloud { get; set; }
    }
}