using Sparrow.Qweather.Models.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Sparrow.Qweather.Models.Response.TropicalCyclone
{
    /// <summary>
    /// 台风预报
    /// </summary>
    public class StormForecastResponse : CommonInfoResponse
    {
        /// <summary>
        /// 当前 API 的最近更新时间。
        /// </summary>
        /// <example>2021-07-27T03:00+00:00</example>
        [JsonPropertyName("updateTime")]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 当前数据的响应式页面链接，便于嵌入网站或应用。
        /// </summary>
        /// <example>https://www.qweather.com</example>
        [JsonPropertyName("fxLink")]
        public string FxLink { get; set; }

        /// <summary>
        /// 台风预报位置列表（按时间顺序）。
        /// </summary>
        [JsonPropertyName("forecast")]
        public List<StormForecastTyphoonForecastItem> Forecast { get; set; }
    }

    /// <summary>
    /// 表示单个台风预报点的详细信息（时间、位置、强度等）。
    /// </summary>
    public class StormForecastTyphoonForecastItem
    {
        /// <summary>
        /// 台风预报时间（北京时间，含时区偏移）。
        /// </summary>
        /// <example>2021-07-27T20:00+08:00</example>
        [JsonPropertyName("fxTime")]
        public string FxTime { get; set; }

        /// <summary>
        /// 台风所处纬度。
        /// </summary>
        /// <example>31.7</example>
        [JsonPropertyName("lat")]
        public string Lat { get; set; }

        /// <summary>
        /// 台风所处经度。
        /// </summary>
        /// <example>118.4</example>
        [JsonPropertyName("lon")]
        public string Lon { get; set; }

        /// <summary>
        /// 台风类型（如 TS - 热带风暴, TD - 热带低压）。
        /// </summary>
        /// <example>TS</example>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 台风中心气压（单位：百帕）。
        /// </summary>
        /// <example>990</example>
        [JsonPropertyName("pressure")]
        public string Pressure { get; set; }

        /// <summary>
        /// 台风附近最大风速（单位：米/秒）。
        /// </summary>
        /// <example>18</example>
        [JsonPropertyName("windSpeed")]
        public string WindSpeed { get; set; }

        /// <summary>
        /// 台风移动速度（可能为空）。
        /// </summary>
        /// <example></example>
        [JsonPropertyName("moveSpeed")]
        public string MoveSpeed { get; set; }

        /// <summary>
        /// 台风移动方位（如“西北”），可能为空。
        /// </summary>
        [JsonPropertyName("moveDir")]
        public string MoveDir { get; set; }

        /// <summary>
        /// 台风移动方位360度方向（0-360度），可能为空。
        /// </summary>
        [JsonPropertyName("move360")]
        public string Move360 { get; set; }
    }
}