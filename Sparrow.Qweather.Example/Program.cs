using Sparrow.Qweather.Client;
using Sparrow.Qweather.Example;
using Sparrow.Qweather.Tools;

#region 实时天气

var weatherNowResponse = await WebApiClientSetting
    .WebApiClient()
    .WeatherCurrentAsync(
        new Sparrow.Qweather.Models.Request.Weather.WeatherCurrentRequest
        {
            Path = new Sparrow.Qweather.Models.Request.Weather.WeatherCurrentPathParameters
            {
                Latitude = "39.92",
                Longitude = "116.41",
            }
        }
    );
var weatherNowJson = JsonTool.SerializeWithNullFilter(weatherNowResponse);

#endregion 实时天气

Console.WriteLine($"实时天气返回数据：{weatherNowJson}");