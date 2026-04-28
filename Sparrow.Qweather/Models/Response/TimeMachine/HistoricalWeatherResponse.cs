using Sparrow.Qweather.Models.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sparrow.Qweather.Models.Response.TimeMachine
{
    /// <summary>
    /// 天气时光机
    /// </summary>
    public class HistoricalWeatherResponse : CommonInfoResponse
    {
        /// <summary>
        /// 当前数据的响应式页面链接，便于嵌入网站或应用。
        /// </summary>
        /// <example>http://hfx.link/2ax6</example>
        [JsonPropertyName("fxLink")]
        public string FxLink { get; set; }

        /// <summary>
        /// 每日天气信息（当天）。
        /// </summary>
        [JsonPropertyName("weatherDaily")]
        public HistoricalWeatherDaily WeatherDaily { get; set; }

        /// <summary>
        /// 逐小时天气信息列表（当天 24 小时）。
        /// </summary>
        [JsonPropertyName("weatherHourly")]
        public List<HistoricalWeatherHourlyItem> WeatherHourly { get; set; }
    }

    /// <summary>
    /// 表示每日天气的详细信息。
    /// </summary>
    public class HistoricalWeatherDaily
    {
        /// <summary>
        /// 当天日期。
        /// </summary>
        /// <example>2020-07-25</example>
        [JsonPropertyName("date")]
        public string Date { get; set; }

        /// <summary>
        /// 日出时间（在高纬度地区可能为空）。
        /// </summary>
        /// <example>05:08</example>
        [JsonPropertyName("sunrise")]
        public string Sunrise { get; set; }

        /// <summary>
        /// 日落时间（在高纬度地区可能为空）。
        /// </summary>
        /// <example>19:33</example>
        [JsonPropertyName("sunset")]
        public string Sunset { get; set; }

        /// <summary>
        /// 当天月升时间（可能为空）。
        /// </summary>
        /// <example>09:54</example>
        [JsonPropertyName("moonrise")]
        public string Moonrise { get; set; }

        /// <summary>
        /// 当天月落时间（可能为空）。
        /// </summary>
        /// <example>22:40</example>
        [JsonPropertyName("moonset")]
        public string Moonset { get; set; }

        /// <summary>
        /// 当天月相名称。
        /// </summary>
        /// <example>峨眉月</example>
        [JsonPropertyName("moonPhase")]
        public string MoonPhase { get; set; }

        /// <summary>
        /// 当天最高温度（默认单位：摄氏度）。
        /// </summary>
        /// <example>33</example>
        [JsonPropertyName("tempMax")]
        public string TempMax { get; set; }

        /// <summary>
        /// 当天最低温度（默认单位：摄氏度）。
        /// </summary>
        /// <example>23</example>
        [JsonPropertyName("tempMin")]
        public string TempMin { get; set; }

        /// <summary>
        /// 当天相对湿度（百分比数值）。
        /// </summary>
        /// <example>52</example>
        [JsonPropertyName("humidity")]
        public string Humidity { get; set; }

        /// <summary>
        /// 当天总降水量（默认单位：毫米）。
        /// </summary>
        /// <example>0.0</example>
        [JsonPropertyName("precip")]
        public string Precip { get; set; }

        /// <summary>
        /// 大气压强（默认单位：百帕）。
        /// </summary>
        /// <example>1000</example>
        [JsonPropertyName("pressure")]
        public string Pressure { get; set; }
    }

    /// <summary>
    /// 表示单小时天气的详细信息。
    /// </summary>
    public class HistoricalWeatherHourlyItem
    {
        /// <summary>
        /// 当天时间（格式：yyyy-MM-dd HH:mm）。
        /// </summary>
        /// <example>2020-07-25 00:00</example>
        [JsonPropertyName("time")]
        public string Time { get; set; }

        /// <summary>
        /// 当天每小时温度（默认单位：摄氏度）。
        /// </summary>
        /// <example>28</example>
        [JsonPropertyName("temp")]
        public string Temp { get; set; }

        /// <summary>
        /// 当天每小时天气状况的图标代码，参考天气图标项目。
        /// </summary>
        /// <example>100</example>
        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 当天每小时天气状况的文字描述（如晴、多云等）。
        /// </summary>
        /// <example>晴</example>
        [JsonPropertyName("text")]
        public string Text { get; set; }

        /// <summary>
        /// 当天每小时累计降水量（默认单位：毫米）。
        /// </summary>
        /// <example>0.0</example>
        [JsonPropertyName("precip")]
        public string Precip { get; set; }

        /// <summary>
        /// 当天每小时风向360角度。
        /// </summary>
        /// <example>246</example>
        [JsonPropertyName("wind360")]
        public string Wind360 { get; set; }

        /// <summary>
        /// 当天每小时风向（如西南风）。
        /// </summary>
        /// <example>西南风</example>
        [JsonPropertyName("windDir")]
        public string WindDir { get; set; }

        /// <summary>
        /// 当天每小时风力等级。
        /// </summary>
        /// <example>2</example>
        [JsonPropertyName("windScale")]
        public string WindScale { get; set; }

        /// <summary>
        /// 当天每小时风速（公里/小时）。
        /// </summary>
        /// <example>8</example>
        [JsonPropertyName("windSpeed")]
        public string WindSpeed { get; set; }

        /// <summary>
        /// 当天每小时相对湿度（百分比数值）。
        /// </summary>
        /// <example>49</example>
        [JsonPropertyName("humidity")]
        public string Humidity { get; set; }

        /// <summary>
        /// 大气压强（默认单位：百帕）。
        /// </summary>
        /// <example>1001</example>
        [JsonPropertyName("pressure")]
        public string Pressure { get; set; }
    }
}