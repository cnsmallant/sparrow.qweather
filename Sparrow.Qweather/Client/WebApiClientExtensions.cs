using Sparrow.Qweather.Interface.Service;
using Sparrow.Qweather.Models.Request.AirQuality;
using Sparrow.Qweather.Models.Request.Astronomy;
using Sparrow.Qweather.Models.Request.Console;
using Sparrow.Qweather.Models.Request.Geo;
using Sparrow.Qweather.Models.Request.Indices;
using Sparrow.Qweather.Models.Request.Minutely;
using Sparrow.Qweather.Models.Request.Ocean;
using Sparrow.Qweather.Models.Request.SolarRadiation;
using Sparrow.Qweather.Models.Request.TimeMachine;
using Sparrow.Qweather.Models.Request.TropicalCyclone;
using Sparrow.Qweather.Models.Request.Weather;
using Sparrow.Qweather.Models.Request.Weatheralert;
using Sparrow.Qweather.Models.Response.AirQuality;
using Sparrow.Qweather.Models.Response.Astronomy;
using Sparrow.Qweather.Models.Response.Console;
using Sparrow.Qweather.Models.Response.Geo;
using Sparrow.Qweather.Models.Response.Indices;
using Sparrow.Qweather.Models.Response.Minutely;
using Sparrow.Qweather.Models.Response.Ocean;
using Sparrow.Qweather.Models.Response.SolarRadiation;
using Sparrow.Qweather.Models.Response.TimeMachine;
using Sparrow.Qweather.Models.Response.TropicalCyclone;
using Sparrow.Qweather.Models.Response.Weather;
using Sparrow.Qweather.Models.Response.Weatheralert;
using Sparrow.Qweather.Tools;
using System.Threading.Tasks;

namespace Sparrow.Qweather.Client
{
    /// <summary>
    /// WebApiClient 扩展方法
    /// </summary>
    public static class WebApiClientExtensions
    {
        #region GeoApi

        /// <summary>
        /// 城市查询 https://dev.qweather.com/docs/api/geoapi/city-lookup/
        /// </summary>
        /// <param name="client"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static async Task<CityLookUpResponse> CityLookUpAsync(
            this WebApiClient client,
            CityLookUpRequest args
        )
        {
            return await ServiceFactoryTool
                .GetService<IGeoService>()
                .CityLookUpAsync(client.Options, args);
        }

        /// <summary>
        /// 热门城市 https://dev.qweather.com/docs/api/geoapi/top-city/
        /// </summary>
        /// <param name="client"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static async Task<CityTopResponse> CityTopAsync(
            this WebApiClient client,
            CityTopRequest args
        )
        {
            return await ServiceFactoryTool
                .GetService<IGeoService>()
                .CityTopAsync(client.Options, args);
        }

        /// <summary>
        /// POI搜索 https://dev.qweather.com/docs/api/geoapi/poi-lookup/
        /// </summary>
        /// <param name="client"></param>
        /// <param name="args"></param>
        /// <returns></returns>

        public static async Task<PoiLookUpResponse> PoiLookUpAsync(
            this WebApiClient client,
            PoiLookUpRequest args
        )
        {
            return await ServiceFactoryTool
                .GetService<IGeoService>()
                .PoiLookUpAsync(client.Options, args);
        }

        /// <summary>
        /// POI范围搜索 https://dev.qweather.com/docs/api/geoapi/poi-range/
        /// </summary>
        /// <param name="client"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static async Task<PoiRangeReponse> PoiRangeAsync(
            this WebApiClient client,
            PoiRangeRequest args
        )
        {
            return await ServiceFactoryTool
                .GetService<IGeoService>()
                .PoiRangeAsync(client.Options, args);
        }

        #endregion GeoApi

        #region 天气预报

        /// <summary>
        /// 实时天气 https://dev.qweather.com/docs/api/weather/weather-now/
        /// </summary>
        /// <param name="client"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static async Task<WeatherNowResponse> WeatherNowAsync(
            this WebApiClient client,
            WeatherNowRequest args
        )
        {
            return await ServiceFactoryTool
                .GetService<IWeatherService>()
                .WeatherNowAsync(client.Options, args);
        }

        /// <summary>
        /// 每日天气预报 https://dev.qweather.com/docs/api/weather/weather-daily-forecast/
        /// </summary>
        /// <param name="args"></param>
        /// <param name="days">
        /// days(必选)预报天数，支持最多30天预报，可选值：3d 3天预报。7d 7天预报。10d 10天预报。15d 15天预报。30d 30天预报。
        /// </param>
        /// <returns></returns>
        public static async Task<WeatherDaysResponse> WeatherDaysAsync(
            this WebApiClient client,
            WeatherDaysRequest args
        )
        {
            return await ServiceFactoryTool
                .GetService<IWeatherService>()
                .WeatherDaysAsync(client.Options, args);
        }

        /// <summary>
        /// 逐小时天气预报 https://dev.qweather.com/docs/api/weather/weather-hourly-forecast/
        /// </summary>
        /// <param name="args"></param>
        /// <param name="hours">
        /// hours(必选)预报小时数，支持最多72小时预报，可选值：3h 3小时预报。6h 6小时预报。12h 12小时预报。24h 24小时预报。
        /// </param>
        /// <returns></returns>
        public static async Task<WeatherHoursResponse> WeatherHoursAsync(
            this WebApiClient client,
            WeatherHoursRequest args
        )
        {
            return await ServiceFactoryTool
                .GetService<IWeatherService>()
                .WeatherHoursAsync(client.Options, args);
        }

        /// <summary>
        /// 格点实时天气 https://dev.qweather.com/docs/api/weather/grid-weather-now/
        /// </summary>
        /// <param name="client"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static async Task<GridWeatherNowResponse> GridWeatherNowAsync(
            this WebApiClient client,
            GridWeatherNowRequest args
        )
        {
            return await ServiceFactoryTool
                .GetService<IWeatherService>()
                .GridWeatherNowAsync(client.Options, args);
        }

        /// <summary>
        /// 格点每日天气预报 https://dev.qweather.com/docs/api/weather/grid-weather-daily-forecast/
        /// </summary>
        /// <param name="client"></param>
        /// <param name="args"></param>
        /// <param name="days">days(必选)预报天数，支持最多7天预报，可选值：3d 3天预报。7d 7天预报。</param>
        /// <returns></returns>
        public static async Task<GridWeatherDaysResponse> GridWeatherDaysAsync(
            this WebApiClient client,
            GridWeatherDaysRequest args
        )
        {
            return await ServiceFactoryTool
                .GetService<IWeatherService>()
                .GridWeatherDaysAsync(client.Options, args);
        }

        /// <summary>
        /// 格点逐小时天气预报 https://dev.qweather.com/docs/api/weather/grid-weather-hourly-forecast/
        /// </summary>
        /// <param name="client"></param>
        /// <param name="args"></param>
        /// <param name="hours">hours(必选)预报小时数，支持最多72小时预报，可选值：24h 24小时预报。72h 72小时预报。</param>
        /// <returns></returns>

        public static async Task<GridWeatherHoursResponse> GridWeatherHoursAsync(
            this WebApiClient client,
            GridWeatherHoursRequest args
        )
        {
            return await ServiceFactoryTool
                .GetService<IWeatherService>()
                .GridWeatherHoursAsync(client.Options, args);
        }

        #endregion 天气预报

        #region 分钟级预报

        /// <summary>
        /// 分钟级降水 https://dev.qweather.com/docs/api/minutely/minutely-5m/
        /// 分钟级降水API（临近预报）支持中国1公里精度的未来2小时每5分钟降雨预报数据。
        /// </summary>
        /// <param name="client"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static async Task<Minutely5mResponse> Minutely5mAsync(
            this WebApiClient client,
            Minutely5mRequset args
        )
        {
            return await ServiceFactoryTool
                .GetService<IMinutelyService>()
                .Minutely5mAsync(client.Options, args);
        }

        #endregion 分钟级预报

        #region 天气预警

        /// <summary>
        /// 实时天气预警 https://dev.qweather.com/docs/api/warning/weather-alert/
        /// </summary>
        /// <param name="client"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static async Task<WeatheralertCurrentResponse> WeatheralertCurrentAsync(
            this WebApiClient client,
            WeatheralertCurrentRequest args
        )
        {
            return await ServiceFactoryTool
                .GetService<IWeatheralertService>()
                .WeatheralertCurrentAsync(client.Options, args);
        }

        #endregion 天气预警

        #region 天气指数

        /// <summary>
        /// 天气指数 https://dev.qweather.com/docs/api/indices/indices-forecast/
        /// </summary>
        /// <param name="client"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static async Task<IndicesForecastResponse> IndicesForecastAsync(
            this WebApiClient client,
            IndicesForecastRequest args
        )
        {
            return await ServiceFactoryTool
                .GetService<IIndicesService>()
                .IndicesForecastAsync(client.Options, args);
        }

        #endregion 天气指数

        #region 空气质量

        /// <summary>
        /// 实时空气质量 https://dev.qweather.com/docs/api/air-quality/air-current/
        /// </summary>
        /// <param name="client"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static async Task<AirCurrentResponse> AirCurrentAsync(
            this WebApiClient client,
            AirCurrentRequest args
        )
        {
            return await ServiceFactoryTool
                .GetService<IAirQualityService>()
                .AirCurrentAsync(client.Options, args);
        }

        /// <summary>
        /// 空气质量小时预报 https://dev.qweather.com/docs/api/air-quality/air-hourly-forecast/
        /// </summary>
        /// <param name="client"></param>
        /// <param name="args"></param>
        /// <returns></returns>

        public static async Task<AirHourlyForecastResponse> AirHourlyForecastAsync(
            this WebApiClient client,
            AirHourlyForecastRequest args
        )
        {
            return await ServiceFactoryTool
                .GetService<IAirQualityService>()
                .AirHourlyForecastAsync(client.Options, args);
        }

        #endregion 空气质量

        #region 时光机

        /// <summary>
        /// 天气时光机 https://dev.qweather.com/docs/api/time-machine/time-machine-weather/
        /// </summary>
        /// <param name="client"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static async Task<HistoricalWeatherResponse> HistoricalWeatherAsync(
            this WebApiClient client,
            HistoricalWeatherRequest args
        )
        {
            return await ServiceFactoryTool
                .GetService<ITimeMachineService>()
                .HistoricalWeatherAsync(client.Options, args);
        }

        /// <summary>
        /// 空气质量时光机 https://dev.qweather.com/docs/api/time-machine/time-machine-air/
        /// </summary>
        /// <param name="client"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static async Task<HistoricalAirResponse> HistoricalAirAsync(
            this WebApiClient client,
            HistoricalAirRequest args
        )
        {
            return await ServiceFactoryTool
                .GetService<ITimeMachineService>()
                .HistoricalAirAsync(client.Options, args);
        }

        #endregion 时光机

        #region 热带气旋（台风）

        /// <summary>
        /// 台风预报 https://dev.qweather.com/docs/api/tropical-cyclone/storm-forecast/
        /// </summary>
        /// <param name="client"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static async Task<StormForecastResponse> StormForecastAsync(
            this WebApiClient client,
            StormForecastRequest args
        )
        {
            return await ServiceFactoryTool
                .GetService<ITropicalCycloneService>()
                .StormForecastAsync(client.Options, args);
        }

        /// <summary>
        /// 台风实况和路径 https://dev.qweather.com/docs/api/tropical-cyclone/storm-track/
        /// </summary>
        /// <param name="client"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static async Task<StormTrackResponse> StormTrackAsync(
            this WebApiClient client,
            StormTrackRequest args
        )
        {
            return await ServiceFactoryTool
                .GetService<ITropicalCycloneService>()
                .StormTrackAsync(client.Options, args);
        }

        /// <summary>
        /// 台风列表 https://dev.qweather.com/docs/api/tropical-cyclone/storm-list/
        /// </summary>
        /// <param name="client"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static async Task<StormListResponse> StormListAsync(
            this WebApiClient client,
            StormListRequest args
        )
        {
            return await ServiceFactoryTool
                .GetService<ITropicalCycloneService>()
                .StormListAsync(client.Options, args);
        }

        #endregion 热带气旋（台风）

        #region 海洋数据

        /// <summary>
        /// 潮汐 https://dev.qweather.com/docs/api/ocean/tide/
        /// </summary>
        /// <param name="client"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static async Task<TideResponse> TideAsync(this WebApiClient client, TideRequest args)
        {
            return await ServiceFactoryTool
                .GetService<IOceanService>()
                .TideAsync(client.Options, args);
        }

        #endregion 海洋数据

        #region 太阳辐射

        /// <summary>
        /// 太阳辐射预报 https://dev.qweather.com/docs/api/solar-radiation/solar-radiation-forecast/
        /// </summary>
        /// <param name="client"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static async Task<SolarRadiationForecastResponse> SolarRadiationForecastAsync(
            this WebApiClient client,
            SolarRadiationForecastRequest args
        )
        {
            return await ServiceFactoryTool
                .GetService<ISolarRadiationService>()
                .SolarRadiationForecastAsync(client.Options, args);
        }

        #endregion 太阳辐射

        #region 天文

        /// <summary>
        /// 日出日落 https://dev.qweather.com/docs/api/astronomy/sunrise-sunset/
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>

        public static async Task<SunResponse> SunAsync(this WebApiClient client, SunRequest args)
        {
            return await ServiceFactoryTool
                .GetService<IAstronomyService>()
                .SunAsync(client.Options, args);
        }

        /// <summary>
        /// 月升月落和月相 https://dev.qweather.com/docs/api/astronomy/moon-and-moon-phase/
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static async Task<MoonResponse> MoonAsync(this WebApiClient client, MoonRequest args)
        {
            return await ServiceFactoryTool
                .GetService<IAstronomyService>()
                .MoonAsync(client.Options, args);
        }

        /// <summary>
        /// 太阳高度角 https://dev.qweather.com/docs/api/astronomy/solar-elevation-angle/
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static async Task<SolarElevationAngleResponse> SolarElevationAngleAsync(
            this WebApiClient client,
            SolarElevationAngleRequest args
        )
        {
            return await ServiceFactoryTool
                .GetService<IAstronomyService>()
                .SolarElevationAngleAsync(client.Options, args);
        }

        #endregion 天文

        #region 控制台

        /// <summary>
        /// 财务汇总 https://dev.qweather.com/docs/api/console/finance/
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static async Task<FinanceSummaryResponse> FinanceSummaryAsync(
            this WebApiClient client,
            FinanceSummaryRequest args
        )
        {
            return await ServiceFactoryTool
                .GetService<IConsoleService>()
                .FinanceSummaryAsync(client.Options, args);
        }

        /// <summary>
        /// 请求量统计 https://dev.qweather.com/docs/api/console/stats/
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static async Task<MetricsStatsResponse> MetricsStatsAsync(
            this WebApiClient client,
            MetricsStatsRequest args
        )
        {
            return await ServiceFactoryTool
                .GetService<IConsoleService>()
                .MetricsStatsAsync(client.Options, args);
        }

        #endregion 控制台
    }
}