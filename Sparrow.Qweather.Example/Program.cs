using Sparrow.Qweather.Client;
using Sparrow.Qweather.Example;
using Sparrow.Qweather.Tools;

#region 实时天气

var weatherNowResponse = await WebApiClientSetting
    .WebApiClient()
    .WeatherDailyAsync(new Sparrow.Qweather.Models.Request.Weather.WeatherDailyRequest
    {
        Path = new Sparrow.Qweather.Models.Request.Weather.WeatherDailyPathParameters
        {
            Latitude = "39.92",
            Longitude = "116.41",
        }
    });
var weatherNowJson = JsonTool.SerializeWithNullFilter(weatherNowResponse);

#endregion 实时天气

//#region 逐小时天气

//var weatherHoursRequest = new Sparrow.Qweather.Models.Request.Weather.WeatherHoursRequest
//{
//    Path = new Sparrow.Qweather.Models.Request.Weather.WeatherHoursPathParameters { Hours = "24h" },
//    Query = new Sparrow.Qweather.Models.Request.Weather.WeatherHoursQueryParameters
//    {
//        Location = "101010100",
//    }
//};
//var weatherHoursResponse = await WebApiClientSetting
//    .WebApiClient()
//    .WeatherHoursAsync(weatherHoursRequest);
//var weatherHoursJson = JsonTool.SerializeWithNullFilter(weatherHoursResponse);

//#endregion 逐小时天气

Console.WriteLine($"实时天气返回数据：{weatherNowJson}");