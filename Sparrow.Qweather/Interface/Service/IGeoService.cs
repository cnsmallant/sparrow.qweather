using Sparrow.Qweather.Models.Options;
using Sparrow.Qweather.Models.Request.Geo;
using Sparrow.Qweather.Models.Response.Geo;
using System.Threading.Tasks;

namespace Sparrow.Qweather.Interface.Service
{
    /// <summary>
    /// 地理信息
    /// </summary>
    public interface IGeoService
    {
        /// <summary>
        /// 城市查询
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        Task<CityLookUpResponse> CityLookUpAsync(WebApiOptions options, CityLookUpRequest args);

        /// <summary>
        /// 热门城市
        /// </summary>
        /// <param name="options"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        Task<CityTopResponse> CityTopAsync(WebApiOptions options, CityTopRequest args);

        /// <summary>
        /// POI搜索
        /// </summary>
        Task<PoiLookUpResponse> PoiLookUpAsync(WebApiOptions options, PoiLookUpRequest args);

        /// <summary>
        /// POI范围搜索
        /// </summary>
        Task<PoiRangeReponse> PoiRangeAsync(WebApiOptions options, PoiRangeRequest args);
    }
}