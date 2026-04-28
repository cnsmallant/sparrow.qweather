using Sparrow.Qweather.Models.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sparrow.Qweather.Models.Response.TropicalCyclone
{
    /// <summary>
    /// 台风实况和路径
    /// </summary>
    public class StormTrackResponse : CommonInfoResponse
    {
        /// <summary>
        /// 当前 API 的最近更新时间。
        /// </summary>
        /// <example>2025-06-01T10:52+00:00</example>
        [JsonPropertyName("updateTime")]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 当前数据的响应式页面链接，便于嵌入网站或应用。
        /// </summary>
        /// <example>https://www.qweather.com</example>
        [JsonPropertyName("fxLink")]
        public string FxLink { get; set; }

        /// <summary>
        /// 是否为活跃台风。1 - 活跃台风，0 - 停编。
        /// </summary>
        /// <example>0</example>
        [JsonPropertyName("isActive")]
        public string IsActive { get; set; }

        /// <summary>
        /// 当前台风的最新位置及强度信息。
        /// </summary>
        [JsonPropertyName("now")]
        public StormTrackNowInfo Now { get; set; }

        /// <summary>
        /// 台风历史轨迹点列表（从生成到停编的路径点）。
        /// </summary>
        [JsonPropertyName("track")]
        public List<StormTrackPoint> Track { get; set; }
    }

    /// <summary>
    /// 表示当前台风的最新信息。
    /// </summary>
    public class StormTrackNowInfo
    {
        /// <summary>
        /// 台风信息发布时间。
        /// </summary>
        /// <example>2024-05-26T14:00+08:00</example>
        [JsonPropertyName("pubTime")]
        public string PubTime { get; set; }

        /// <summary>
        /// 台风所处纬度。
        /// </summary>
        /// <example>14.2</example>
        [JsonPropertyName("lat")]
        public string Lat { get; set; }

        /// <summary>
        /// 台风所处经度。
        /// </summary>
        /// <example>121.5</example>
        [JsonPropertyName("lon")]
        public string Lon { get; set; }

        /// <summary>
        /// 台风类型（如 TD - 热带低压, TS - 热带风暴, STS - 强热带风暴, TY - 台风）。
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
        /// <example>23</example>
        [JsonPropertyName("windSpeed")]
        public string WindSpeed { get; set; }

        /// <summary>
        /// 台风移动速度（单位：公里/小时）。
        /// </summary>
        /// <example>9</example>
        [JsonPropertyName("moveSpeed")]
        public string MoveSpeed { get; set; }

        /// <summary>
        /// 台风移动方位（如 NE）。
        /// </summary>
        /// <example>NE</example>
        [JsonPropertyName("moveDir")]
        public string MoveDir { get; set; }

        /// <summary>
        /// 台风移动方位360度方向（0-360度，可能为空）。
        /// </summary>
        [JsonPropertyName("move360")]
        public string Move360 { get; set; }

        /// <summary>
        /// 台风7级风圈半径（30节/55公里/小时）。
        /// </summary>
        [JsonPropertyName("windRadius30")]
        public StormTrackWindRadius WindRadius30 { get; set; }

        /// <summary>
        /// 台风10级风圈半径（50节/93公里/小时）。
        /// </summary>
        [JsonPropertyName("windRadius50")]
        public StormTrackWindRadius WindRadius50 { get; set; }

        /// <summary>
        /// 台风12级风圈半径（64节/118公里/小时）。
        /// </summary>
        [JsonPropertyName("windRadius64")]
        public StormTrackWindRadius WindRadius64 { get; set; }
    }

    /// <summary>
    /// 表示台风历史轨迹上的一个路径点。
    /// </summary>
    public class StormTrackPoint
    {
        /// <summary>
        /// 当前轨迹点的时间（台风信息发布时间）。
        /// </summary>
        /// <example>2024-05-26T14:00+08:00</example>
        [JsonPropertyName("time")]
        public string Time { get; set; }

        /// <summary>
        /// 台风所处纬度。
        /// </summary>
        [JsonPropertyName("lat")]
        public string Lat { get; set; }

        /// <summary>
        /// 台风所处经度。
        /// </summary>
        [JsonPropertyName("lon")]
        public string Lon { get; set; }

        /// <summary>
        /// 台风类型（如 TD, TS, STS, TY）。
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 台风中心气压（单位：百帕）。
        /// </summary>
        [JsonPropertyName("pressure")]
        public string Pressure { get; set; }

        /// <summary>
        /// 台风附近最大风速（单位：米/秒）。
        /// </summary>
        [JsonPropertyName("windSpeed")]
        public string WindSpeed { get; set; }

        /// <summary>
        /// 台风移动速度（单位：公里/小时）。
        /// </summary>
        [JsonPropertyName("moveSpeed")]
        public string MoveSpeed { get; set; }

        /// <summary>
        /// 台风移动方位（如 NW, NNE）。
        /// </summary>
        [JsonPropertyName("moveDir")]
        public string MoveDir { get; set; }

        /// <summary>
        /// 台风移动方位360度方向（可能为空）。
        /// </summary>
        [JsonPropertyName("move360")]
        public string Move360 { get; set; }

        /// <summary>
        /// 台风7级风圈半径（可能为空）。
        /// </summary>
        [JsonPropertyName("windRadius30")]
        public StormTrackWindRadius WindRadius30 { get; set; }

        /// <summary>
        /// 台风10级风圈半径（可能为空）。
        /// </summary>
        [JsonPropertyName("windRadius50")]
        public StormTrackWindRadius WindRadius50 { get; set; }

        /// <summary>
        /// 台风12级风圈半径（可能为空）。
        /// </summary>
        [JsonPropertyName("windRadius64")]
        public StormTrackWindRadius WindRadius64 { get; set; }
    }

    /// <summary>
    /// 表示台风的风圈半径（东北、东南、西南、西北四个方向）。
    /// </summary>
    public class StormTrackWindRadius
    {
        /// <summary>
        /// 东北方向风圈半径（单位：公里）。
        /// </summary>
        /// <example>120</example>
        [JsonPropertyName("neRadius")]
        public string NeRadius { get; set; }

        /// <summary>
        /// 东南方向风圈半径（单位：公里）。
        /// </summary>
        /// <example>150</example>
        [JsonPropertyName("seRadius")]
        public string SeRadius { get; set; }

        /// <summary>
        /// 西南方向风圈半径（单位：公里）。
        /// </summary>
        /// <example>100</example>
        [JsonPropertyName("swRadius")]
        public string SwRadius { get; set; }

        /// <summary>
        /// 西北方向风圈半径（单位：公里）。
        /// </summary>
        /// <example>80</example>
        [JsonPropertyName("nwRadius")]
        public string NwRadius { get; set; }
    }
}