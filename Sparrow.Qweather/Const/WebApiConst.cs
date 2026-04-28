namespace Sparrow.Qweather.Const
{
    /// <summary>
    /// WebApi常量
    /// </summary>
    public class WebApiConst
    {
        /// <summary>
        /// 城市查询
        /// </summary>
        public const string GeoCityLookUpPath = "/geo/v2/city/lookup";

        /// <summary>
        /// 热门城市
        /// </summary>
        public const string GeoCityTopPath = "/geo/v2/city/top";

        /// <summary>
        /// POI搜索
        /// </summary>
        public const string GeoPoiLookUpPath = "/geo/v2/poi/lookup";

        /// <summary>
        /// POI范围搜索
        /// </summary>
        public const string GeoPoiRangePath = "/geo/v2/poi/range";

        /// <summary>
        /// 实时天气
        /// </summary>
        public const string WeatherNowPath = "/v7/weather/now";

        /// <summary>
        /// 每日天气预报
        /// </summary>
        public const string WeatherDaysPath = "/v7/weather/{0}";

        /// <summary>
        /// 逐小时天气预报
        /// </summary>
        public const string WeatherHoursPath = "/v7/weather/{0}";

        /// <summary>
        /// 格点实时天气
        /// </summary>
        public const string GridWeatherNowPath = "/v7/grid-weather/now";

        /// <summary>
        /// 格点每日天气预报
        /// </summary>
        public const string GridWeatherDaysPath = "/v7/grid-weather/{0}";

        /// <summary>
        /// 格点逐小时天气预报
        /// </summary>
        public const string GridWeatherHoursPath = "/v7/grid-weather/{0}";

        /// <summary>
        /// 分钟级降水
        /// </summary>
        public const string Minutely5mPath = "/v7/minutely/5m";

        /// <summary>
        /// 实时天气预警
        /// </summary>
        public const string WeatheralertCurrentPath = "/weatheralert/v1/current/{0}/{1}";

        /// <summary>
        /// 天气指数预报
        /// </summary>
        public const string IndicesForecastPath = "/v7/indices/{0}";

        /// <summary>
        /// 实时空气质量
        /// </summary>

        public const string AirQualityCurrentPath = "/airquality/v1/current/{0}/{1}";

        /// <summary>
        /// 空气质量小时预报
        /// </summary>

        public const string AirQualityHourlyForecastPath = "/airquality/v1/hourly/{0}/{1}";

        /// <summary>
        /// 空气质量每日预报
        /// </summary>
        public const string AirQualityDailyForecastPath = "/airquality/v1/daily/{0}/{1}";

        /// <summary>
        /// 监测站数据
        /// </summary>
        public const string AirQualityStationPath = "/airquality/v1/station/{0}";

        /// <summary>
        /// 天气时光机
        /// </summary>
        public const string HistoricalWeatherPath = "/v7/historical/weather";

        /// <summary>
        /// 空气质量时光机
        /// </summary>
        public const string HistoricalAirPath = "/v7/historical/air";

        /// <summary>
        /// 台风预报
        /// </summary>
        public const string StormForecastPath = "/v7/tropical/storm-forecast";

        /// <summary>
        /// 台风实况和路径
        /// </summary>
        public const string StormTrackPath = "/v7/tropical/storm-track";

        /// <summary>
        /// 台风列表
        /// </summary>
        public const string StormListPath = "/v7/tropical/storm-list";

        ///<summary>
        /// 潮汐
        /// </summary>
        public const string OceanTidePath = "/v7/ocean/tide";

        ///<summary>
        /// 太阳辐射预报
        /// </summary>
        public const string SolarRadiationForecastPath = "/solarradiation/v1/forecast/{0}/{1}";

        ///<summary>
        /// 日出日落
        /// </summary>
        public const string SunPath = "/v7/astronomy/sun";

        ///<summary>
        /// 月升月落和月相
        /// </summary>
        public const string MoonPath = "/v7/astronomy/moon";

        ///<summary>
        /// 太阳高度角
        /// </summary>

        public const string SolarElevationAnglePath = "/v7/astronomy/solar-elevation-angle";

        ///<summary>
        /// 财务汇总
        /// </summary>
        public const string FinanceSummaryPath = "/finance/v1/summary";

        /// <summary>
        /// 请求量统计
        /// </summary>
        public const string MetricsStatsPath = "/metrics/v1/stats";
    }
}