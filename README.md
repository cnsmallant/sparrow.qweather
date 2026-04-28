# 和风天气 Sparrow.Qweather .NET SDK 使用说明

---

## 初始化

```csharp
public static WebApiClient WebApiClient()
{
    string folderPath = @"cert";
    string relativeFilePath = @"您的私钥证书";

    string certPath = Path.GetFullPath(Path.Combine(folderPath, relativeFilePath)); // 证书路径
    var options = new WebApiOptions()
    {
        Host     = "您的API Host",
        Kid      = "您的项目ID",
        Sub      = "您的凭据ID",
        CertPath = certPath           // 证书路径
    };

    var client = WebApiClientBuilder.Create(options).Build();
    return client;
}
```

---

## 使用示例

```csharp
using Sparrow.Qweather.Client;
using Sparrow.Qweather.Example;
using Sparrow.Qweather.Tools;

var request =
    new Sparrow.Qweather.Models.Request.Weather.WeatherNowRequest
    {
        Location = "101010100",
    }; // 实时天气查询

var response = await WebApiClientSetting.WebApiClient().WeatherNowAsync(request);
var json = JsonTool.SerializeWithNullFilter(response);
Console.WriteLine(json);
```

---

## SDK 方法与和风天气 API 对应列表

### 地理位置 GeoAPI

| SDK 方法 | Request 类 | Response 类 | 和风天气文档 |
|---------|-----------|------------|------------|
| `CityLookUpAsync` | `CityLookUpRequest` | `CityLookUpResponse` | [城市查询](https://dev.qweather.com/docs/api/geoapi/city-lookup/) |
| `CityTopAsync` | `CityTopRequest` | `CityTopResponse` | [热门城市](https://dev.qweather.com/docs/api/geoapi/top-city/) |
| `PoiLookUpAsync` | `PoiLookUpRequest` | `PoiLookUpResponse` | [POI 搜索](https://dev.qweather.com/docs/api/geoapi/poi-lookup/) |
| `PoiRangeAsync` | `PoiRangeRequest` | `PoiRangeReponse` | [POI 范围搜索](https://dev.qweather.com/docs/api/geoapi/poi-range/) |

---

### 天气预报

| SDK 方法 | Request 类 | Response 类 | 和风天气文档 |
|---------|-----------|------------|------------|
| `WeatherNowAsync` | `WeatherNowRequest` | `WeatherNowResponse` | [实时天气](https://dev.qweather.com/docs/api/weather/weather-now/) |
| `WeatherDaysAsync` | `WeatherDaysRequest` | `WeatherDaysResponse` | [每日天气预报](https://dev.qweather.com/docs/api/weather/weather-daily-forecast/)（3d/7d/10d/15d/30d） |
| `WeatherHoursAsync` | `WeatherHoursRequest` | `WeatherHoursResponse` | [逐小时天气预报](https://dev.qweather.com/docs/api/weather/weather-hourly-forecast/)（3h/6h/12h/24h） |
| `GridWeatherNowAsync` | `GridWeatherNowRequest` | `GridWeatherNowResponse` | [格点实时天气](https://dev.qweather.com/docs/api/weather/grid-weather-now/) |
| `GridWeatherDaysAsync` | `GridWeatherDaysRequest` | `GridWeatherDaysResponse` | [格点每日天气预报](https://dev.qweather.com/docs/api/weather/grid-weather-daily-forecast/)（3d/7d） |
| `GridWeatherHoursAsync` | `GridWeatherHoursRequest` | `GridWeatherHoursResponse` | [格点逐小时天气预报](https://dev.qweather.com/docs/api/weather/grid-weather-hourly-forecast/)（24h/72h） |

---

### 分钟级预报

| SDK 方法 | Request 类 | Response 类 | 和风天气文档 |
|---------|-----------|------------|------------|
| `Minutely5mAsync` | `Minutely5mRequset` | `Minutely5mResponse` | [分钟级降水](https://dev.qweather.com/docs/api/minutely/minutely-5m/) |

---

### 天气预警

| SDK 方法 | Request 类 | Response 类 | 和风天气文档 |
|---------|-----------|------------|------------|
| `WeatheralertCurrentAsync` | `WeatheralertCurrentRequest` | `WeatheralertCurrentResponse` | [实时天气预警](https://dev.qweather.com/docs/api/warning/weather-alert/) |

---

### 天气指数

| SDK 方法 | Request 类 | Response 类 | 和风天气文档 |
|---------|-----------|------------|------------|
| `IndicesForecastAsync` | `IndicesForecastRequest` | `IndicesForecastResponse` | [天气指数预报](https://dev.qweather.com/docs/api/indices/indices-forecast/) |

---

### 空气质量

| SDK 方法 | Request 类 | Response 类 | 和风天气文档 |
|---------|-----------|------------|------------|
| `AirCurrentAsync` | `AirCurrentRequest` | `AirCurrentResponse` | [实时空气质量](https://dev.qweather.com/docs/api/air-quality/air-current/) |
| `AirHourlyForecastAsync` | `AirHourlyForecastRequest` | `AirHourlyForecastResponse` | [空气质量小时预报](https://dev.qweather.com/docs/api/air-quality/air-hourly-forecast/) |

---

### 时光机（历史数据）

| SDK 方法 | Request 类 | Response 类 | 和风天气文档 |
|---------|-----------|------------|------------|
| `HistoricalWeatherAsync` | `HistoricalWeatherRequest` | `HistoricalWeatherResponse` | [天气时光机](https://dev.qweather.com/docs/api/time-machine/time-machine-weather/) |
| `HistoricalAirAsync` | `HistoricalAirRequest` | `HistoricalAirResponse` | [空气质量时光机](https://dev.qweather.com/docs/api/time-machine/time-machine-air/) |

---

### 热带气旋（台风）

| SDK 方法 | Request 类 | Response 类 | 和风天气文档 |
|---------|-----------|------------|------------|
| `StormForecastAsync` | `StormForecastRequest` | `StormForecastResponse` | [台风预报](https://dev.qweather.com/docs/api/tropical-cyclone/storm-forecast/) |
| `StormTrackAsync` | `StormTrackRequest` | `StormTrackResponse` | [台风实况和路径](https://dev.qweather.com/docs/api/tropical-cyclone/storm-track/) |
| `StormListAsync` | `StormListRequest` | `StormListResponse` | [台风列表](https://dev.qweather.com/docs/api/tropical-cyclone/storm-list/) |

---

### 海洋数据

| SDK 方法 | Request 类 | Response 类 | 和风天气文档 |
|---------|-----------|------------|------------|
| `TideAsync` | `TideRequest` | `TideResponse` | [潮汐](https://dev.qweather.com/docs/api/ocean/tide/) |

---

### 太阳辐射

| SDK 方法 | Request 类 | Response 类 | 和风天气文档 |
|---------|-----------|------------|------------|
| `SolarRadiationForecastAsync` | `SolarRadiationForecastRequest` | `SolarRadiationForecastResponse` | [太阳辐射预报](https://dev.qweather.com/docs/api/solar-radiation/solar-radiation-forecast/) |

---

### 天文

| SDK 方法 | Request 类 | Response 类 | 和风天气文档 |
|---------|-----------|------------|------------|
| `SunAsync` | `SunRequest` | `SunResponse` | [日出日落](https://dev.qweather.com/docs/api/astronomy/sunrise-sunset/) |
| `MoonAsync` | `MoonRequest` | `MoonResponse` | [月升月落和月相](https://dev.qweather.com/docs/api/astronomy/moon-and-moon-phase/) |
| `SolarElevationAngleAsync` | `SolarElevationAngleRequest` | `SolarElevationAngleResponse` | [太阳高度角](https://dev.qweather.com/docs/api/astronomy/solar-elevation-angle/) |

---

### 控制台

| SDK 方法 | Request 类 | Response 类 | 和风天气文档 |
|---------|-----------|------------|------------|
| `FinanceSummaryAsync` | `FinanceSummaryRequest` | `FinanceSummaryResponse` | [财务汇总](https://dev.qweather.com/docs/api/console/finance/) |
| `MetricsStatsAsync` | `MetricsStatsRequest` | `MetricsStatsResponse` | [请求量统计](https://dev.qweather.com/docs/api/console/stats/) |
