# 和风天气 .NET SDK Sparrow.Qweather 

[![GitHub stars](https://img.shields.io/github/stars/cnsmallant/sparrow.qweather?style=flat&logo=github)](https://github.com/cnsmallant/sparrow.qweather/stargazers)  [![star](https://gitee.com/dikeko/sparrow.qweather/badge/star.svg?theme=gray)](https://gitee.com/dikeko/sparrow.qweather/stargazers)  [![NuGet Version](https://img.shields.io/nuget/vpre/sparrow.qweather?style=flatt&logo=nuget)](https://www.nuget.org/packages/Sparrow.Qweather)  ![GitHub License](https://img.shields.io/github/license/cnsmallant/sparrow.qweather?logo=github)  ![NuGet Downloads](https://img.shields.io/nuget/dt/sparrow.qweather?logo=nuget)


---
## 简介
Sparrow.Qweather 是基于和风天气开放平台官方 API 封装的 .NET SDK，提供简洁、类型安全的异步调用接口，让开发者无需关心 JWT 签名与 HTTP 细节，即可在 .NET 项目中快速接入全球气象数据服务。

### 项目地址
- GitHub：https://github.com/cnsmallant/sparrow.qweather
- Gitee：https://gitee.com/dikeko/sparrow.qweather

### 特性
- 全覆盖：封装和风天气包括天气预报、空气质量、台风、海洋、天文、历史数据等

- 开箱即用：统一的 WebApiClient 扩展方法，一行代码发起请求
- 安全鉴权：内置 Ed25519 私钥 + JWT 签名，无需手动处理认证逻辑
- 异步优先：全部接口采用 async/await 模式，天然适配现代 .NET 应用
- 类型安全：每个接口均有对应的强类型 Request / Response 类，IDE 自动补全友好


# 和风天气 Sparrow.Qweather .NET SDK 使用说明

## 安装方式
```bash
> dotnet add package Sparrow.Qweather
```
```powershell
PM> NuGet\Install-Package Sparrow.Qweather
```

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

## 使用示例

```csharp
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

```

## SDK 方法与和风天气 API 对应列表

### 一、地理信息（GeoApi）

| 方法                                 | 说明                               | 文档链接                                                     |
| :----------------------------------- | :--------------------------------- | :----------------------------------------------------------- |
| `CityLookUpAsync(CityLookUpRequest)` | 城市查询（支持模糊搜索、定位等）   | [城市查询](https://dev.qweather.com/docs/api/geoapi/city-lookup/) |
| `CityTopAsync(CityTopRequest)`       | 热门城市查询（全球及国内热门城市） | [热门城市](https://dev.qweather.com/docs/api/geoapi/top-city/) |
| `PoiLookUpAsync(PoiLookUpRequest)`   | POI（兴趣点）搜索                  | [POI搜索](https://dev.qweather.com/docs/api/geoapi/poi-lookup/) |
| `PoiRangeAsync(PoiRangeRequest)`     | POI 范围搜索（指定坐标及半径内）   | [POI范围搜索](https://dev.qweather.com/docs/api/geoapi/poi-range/) |

------

### 二、天气预报（新版）

| 方法                                         | 说明                             | 文档链接                                                     |
| :------------------------------------------- | :------------------------------- | :----------------------------------------------------------- |
| `WeatherCurrentAsync(WeatherCurrentRequest)` | 实时天气（当前天气状况）         | [实时天气](https://dev.qweather.com/docs/api/weather/weather-current/) |
| `WeatherDailyAsync(WeatherDailyRequest)`     | 每日天气预报（支持指定天数）     | [每日天气预报](https://dev.qweather.com/docs/api/weather/weather-daily-forecast/) |
| `WeatherHourlyAsync(WeatherHourlyRequest)`   | 逐小时天气预报（支持指定小时数） | [小时天气预报](https://dev.qweather.com/docs/api/weather/weather-hourly-forecast/) |

------

### 三、旧版天气预报（已废弃，标记 `[Obsolete]`）

> ⚠️ 这些方法已被标记为 `[Obsolete]`，建议迁移至新版天气预报方法。

| 方法                                             | 说明                                 | 文档链接                                                     |
| :----------------------------------------------- | :----------------------------------- | :----------------------------------------------------------- |
| `WeatherNowAsync(WeatherNowRequest)`             | 实时天气（旧版）                     | [天气实况](https://dev.qweather.com/docs/api/weather/weather-now/) |
| `WeatherDaysAsync(WeatherDaysRequest)`           | 每日天气预报（旧版，参数 `days`）    | [每日预报](https://dev.qweather.com/docs/api/weather/weather-daily-forecast/) |
| `WeatherHoursAsync(WeatherHoursRequest)`         | 逐小时天气预报（旧版，参数 `hours`） | [逐小时预报](https://dev.qweather.com/docs/api/weather/weather-hourly-forecast/) |
| `GridWeatherNowAsync(GridWeatherNowRequest)`     | 格点实时天气                         | [格点实况](https://dev.qweather.com/docs/api/weather/grid-weather-now/) |
| `GridWeatherDaysAsync(GridWeatherDaysRequest)`   | 格点每日预报                         | [格点每日预报](https://dev.qweather.com/docs/api/weather/grid-weather-daily-forecast/) |
| `GridWeatherHoursAsync(GridWeatherHoursRequest)` | 格点逐小时预报                       | [格点逐小时预报](https://dev.qweather.com/docs/api/weather/grid-weather-hourly-forecast/) |

------

### 四、分钟级降水预报

| 方法                                 | 说明                               | 文档链接                                                     |
| :----------------------------------- | :--------------------------------- | :----------------------------------------------------------- |
| `Minutely5mAsync(Minutely5mRequset)` | 分钟级降水（未来2小时，5分钟间隔） | [分钟级降水](https://dev.qweather.com/docs/api/minutely/minutely-5m/) |

------

### 五、天气预警

| 方法                                                   | 说明                             | 文档链接                                                     |
| :----------------------------------------------------- | :------------------------------- | :----------------------------------------------------------- |
| `WeatheralertCurrentAsync(WeatheralertCurrentRequest)` | 实时天气预警（当前生效中的预警） | [实时天气预警](https://dev.qweather.com/docs/api/warning/weather-alert/) |

------

### 六、天气指数

| 方法                                           | 说明                                 | 文档链接                                                     |
| :--------------------------------------------- | :----------------------------------- | :----------------------------------------------------------- |
| `IndicesForecastAsync(IndicesForecastRequest)` | 天气指数预报（如穿衣、防晒、洗车等） | [天气指数](https://dev.qweather.com/docs/api/indices/indices-forecast/) |

------

### 七、空气质量

| 方法                                               | 说明             | 文档链接                                                     |
| :------------------------------------------------- | :--------------- | :----------------------------------------------------------- |
| `AirCurrentAsync(AirCurrentRequest)`               | 实时空气质量     | [实时空气质量](https://dev.qweather.com/docs/api/air-quality/air-current/) |
| `AirHourlyForecastAsync(AirHourlyForecastRequest)` | 空气质量小时预报 | [空气质量小时预报](https://dev.qweather.com/docs/api/air-quality/air-hourly-forecast/) |

------

### 八、时光机（历史数据）

| 方法                                               | 说明                           | 文档链接                                                     |
| :------------------------------------------------- | :----------------------------- | :----------------------------------------------------------- |
| `HistoricalWeatherAsync(HistoricalWeatherRequest)` | 天气时光机（历史天气数据）     | [天气时光机](https://dev.qweather.com/docs/api/time-machine/time-machine-weather/) |
| `HistoricalAirAsync(HistoricalAirRequest)`         | 空气质量时光机（历史空气质量） | [空气质量时光机](https://dev.qweather.com/docs/api/time-machine/time-machine-air/) |

------

### 九、热带气旋（台风）

| 方法                                       | 说明           | 文档链接                                                     |
| :----------------------------------------- | :------------- | :----------------------------------------------------------- |
| `StormForecastAsync(StormForecastRequest)` | 台风预报       | [台风预报](https://dev.qweather.com/docs/api/tropical-cyclone/storm-forecast/) |
| `StormTrackAsync(StormTrackRequest)`       | 台风实况和路径 | [台风实况和路径](https://dev.qweather.com/docs/api/tropical-cyclone/storm-track/) |
| `StormListAsync(StormListRequest)`         | 台风列表       | [台风列表](https://dev.qweather.com/docs/api/tropical-cyclone/storm-list/) |

------

### 十、海洋数据

| 方法                     | 说明     | 文档链接                                              |
| :----------------------- | :------- | :---------------------------------------------------- |
| `TideAsync(TideRequest)` | 潮汐数据 | [潮汐](https://dev.qweather.com/docs/api/ocean/tide/) |

------

### 十一、太阳辐射

| 方法                                                         | 说明         | 文档链接                                                     |
| :----------------------------------------------------------- | :----------- | :----------------------------------------------------------- |
| `SolarRadiationForecastAsync(SolarRadiationForecastRequest)` | 太阳辐射预报 | [太阳辐射预报](https://dev.qweather.com/docs/api/solar-radiation/solar-radiation-forecast/) |

------

### 十二、天文

| 方法                                                   | 说明           | 文档链接                                                     |
| :----------------------------------------------------- | :------------- | :----------------------------------------------------------- |
| `SunAsync(SunRequest)`                                 | 日出日落时间   | [日出日落](https://dev.qweather.com/docs/api/astronomy/sunrise-sunset/) |
| `MoonAsync(MoonRequest)`                               | 月升月落和月相 | [月升月落和月相](https://dev.qweather.com/docs/api/astronomy/moon-and-moon-phase/) |
| `SolarElevationAngleAsync(SolarElevationAngleRequest)` | 太阳高度角     | [太阳高度角](https://dev.qweather.com/docs/api/astronomy/solar-elevation-angle/) |

------

### 十三、控制台（统计与财务）

| 方法                                         | 说明                         | 文档链接                                                     |
| :------------------------------------------- | :--------------------------- | :----------------------------------------------------------- |
| `FinanceSummaryAsync(FinanceSummaryRequest)` | 财务汇总（开发者控制台账单） | [财务汇总](https://dev.qweather.com/docs/api/console/finance/) |
| `MetricsStatsAsync(MetricsStatsRequest)`     | 请求量统计（API 调用次数等） | [请求量统计](https://dev.qweather.com/docs/api/console/stats/) |