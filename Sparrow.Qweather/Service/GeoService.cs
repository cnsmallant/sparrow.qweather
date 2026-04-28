using System;
using System.IO;
using System.Threading.Tasks;
using Sparrow.Qweather.Const;
using Sparrow.Qweather.Interface.Service;
using Sparrow.Qweather.Models.Options;
using Sparrow.Qweather.Models.Request.Geo;
using Sparrow.Qweather.Models.Response.Geo;
using Sparrow.Qweather.Tools;

namespace Sparrow.Qweather.Service
{
    /// <summary>
    /// 地理服务 https://dev.qweather.com/docs/api/geoapi/
    /// </summary>
    internal class GeoService : IGeoService
    {
        /// <summary>
        /// 城市查询 https://dev.qweather.com/docs/api/geoapi/city-lookup/
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public Task<CityLookUpResponse> CityLookUpAsync(
            WebApiOptions options,
            CityLookUpRequest args
        )
        {
            return args.GetApiResponseAsync<CityLookUpResponse>(
                options,
                WebApiConst.GeoCityLookUpPath
            );
        }

        /// <summary>
        /// 热门城市 https://dev.qweather.com/docs/api/geoapi/top-city/
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>

        public Task<CityTopResponse> CityTopAsync(
            WebApiOptions options,
            CityTopRequest args
        )
        {
            return args.GetApiResponseAsync<CityTopResponse>(
                options,
                WebApiConst.GeoCityTopPath
            );
        }

        /// <summary>
        /// POI搜索 https://dev.qweather.com/docs/api/geoapi/poi-lookup/
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public Task<PoiLookUpResponse> PoiLookUpAsync(
            WebApiOptions options,
            PoiLookUpRequest args
        )
        {
            return args.GetApiResponseAsync<PoiLookUpResponse>(
                options,
                WebApiConst.GeoPoiLookUpPath
            );
        }

        /// <summary>
        /// POI范围搜索 https://dev.qweather.com/docs/api/geoapi/poi-range/
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public Task<PoiRangeReponse> PoiRangeAsync(
            WebApiOptions options,
            PoiRangeRequest args
        )
        {
            return args.GetApiResponseAsync<PoiRangeReponse>(
                options,
                WebApiConst.GeoPoiRangePath
            );
        }
    }
}