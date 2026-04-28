using Sparrow.Qweather.Client;
using Sparrow.Qweather.Example;
using Sparrow.Qweather.Tools;

var request =
    new Sparrow.Qweather.Models.Request.Weather.WeatherNowRequest
    {
        Location = "101010100",
    };//实时天气查询

var response = await WebApiClientSetting.WebApiClient().WeatherNowAsync(request);
var json = JsonTool.SerializeWithNullFilter(response);
Console.WriteLine(json);