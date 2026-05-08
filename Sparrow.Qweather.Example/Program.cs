using Sparrow.Qweather.Client;
using Sparrow.Qweather.Example;
using Sparrow.Qweather.Tools;

#region 实时天气

var weatherNowRequest = new Sparrow.Qweather.Models.Request.Weather.WeatherNowRequest
{
    Location = "101010100",
}; //实时天气查询

var weatherNowResponse = await WebApiClientSetting
    .WebApiClient()
    .WeatherNowAsync(weatherNowRequest);
var weatherNowJson = JsonTool.SerializeWithNullFilter(weatherNowResponse);

#endregion 实时天气

#region 逐小时天气

var weatherHoursRequest = new Sparrow.Qweather.Models.Request.Weather.WeatherHoursRequest
{
    Path = new Sparrow.Qweather.Models.Request.Weather.WeatherHoursPathParameters { Hours = "24h" },
    Query = new Sparrow.Qweather.Models.Request.Weather.WeatherHoursQueryParameters
    {
        Location = "101010100",
    }
};
var weatherHoursResponse = await WebApiClientSetting
    .WebApiClient()
    .WeatherHoursAsync(weatherHoursRequest);
var weatherHoursJson = JsonTool.SerializeWithNullFilter(weatherHoursResponse);

#endregion 逐小时天气

Console.WriteLine($"实时天气返回数据：{weatherNowJson}\n逐小时天气返回数据：{weatherHoursJson}");