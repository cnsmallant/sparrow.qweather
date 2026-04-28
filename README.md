# Sparrow.Qweather .NET SDK

---
## Git库
GitHub:  https://github.com/cnsmallant/sparrow.qweather
Gitee： https://gitee.com/dikeko/sparrow.qweather

## 语言 / Languages

- [简体中文](#简体中文)
- [English](#english)
- [Français](#français)
- [Español](#español)
- [Русский](#русский)
- [العربية](#العربية)
- [日本語](#日本語)
- [한국어](#한국어)

---

---

# 简体中文

# 和风天气 Sparrow.Qweather .NET SDK 使用说明

## 安装方式
```cmd
dotnet add package Sparrow.Qweather
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

var request =
    new Sparrow.Qweather.Models.Request.Weather.WeatherNowRequest
    {
        Location = "101010100",
    }; // 实时天气查询

var response = await WebApiClientSetting.WebApiClient().WeatherNowAsync(request);
var json = JsonTool.SerializeWithNullFilter(response);
Console.WriteLine(json);
```

## SDK 方法与和风天气 API 对应列表

### 地理位置 GeoAPI

| SDK 方法 | Request 类 | Response 类 | 和风天气文档 |
|---------|-----------|------------|------------|
| `CityLookUpAsync` | `CityLookUpRequest` | `CityLookUpResponse` | [城市查询](https://dev.qweather.com/docs/api/geoapi/city-lookup/) |
| `CityTopAsync` | `CityTopRequest` | `CityTopResponse` | [热门城市](https://dev.qweather.com/docs/api/geoapi/top-city/) |
| `PoiLookUpAsync` | `PoiLookUpRequest` | `PoiLookUpResponse` | [POI 搜索](https://dev.qweather.com/docs/api/geoapi/poi-lookup/) |
| `PoiRangeAsync` | `PoiRangeRequest` | `PoiRangeReponse` | [POI 范围搜索](https://dev.qweather.com/docs/api/geoapi/poi-range/) |

### 天气预报

| SDK 方法 | Request 类 | Response 类 | 和风天气文档 |
|---------|-----------|------------|------------|
| `WeatherNowAsync` | `WeatherNowRequest` | `WeatherNowResponse` | [实时天气](https://dev.qweather.com/docs/api/weather/weather-now/) |
| `WeatherDaysAsync` | `WeatherDaysRequest` | `WeatherDaysResponse` | [每日天气预报](https://dev.qweather.com/docs/api/weather/weather-daily-forecast/)（3d/7d/10d/15d/30d） |
| `WeatherHoursAsync` | `WeatherHoursRequest` | `WeatherHoursResponse` | [逐小时天气预报](https://dev.qweather.com/docs/api/weather/weather-hourly-forecast/)（3h/6h/12h/24h） |
| `GridWeatherNowAsync` | `GridWeatherNowRequest` | `GridWeatherNowResponse` | [格点实时天气](https://dev.qweather.com/docs/api/weather/grid-weather-now/) |
| `GridWeatherDaysAsync` | `GridWeatherDaysRequest` | `GridWeatherDaysResponse` | [格点每日天气预报](https://dev.qweather.com/docs/api/weather/grid-weather-daily-forecast/)（3d/7d） |
| `GridWeatherHoursAsync` | `GridWeatherHoursRequest` | `GridWeatherHoursResponse` | [格点逐小时天气预报](https://dev.qweather.com/docs/api/weather/grid-weather-hourly-forecast/)（24h/72h） |

### 分钟级预报

| SDK 方法 | Request 类 | Response 类 | 和风天气文档 |
|---------|-----------|------------|------------|
| `Minutely5mAsync` | `Minutely5mRequset` | `Minutely5mResponse` | [分钟级降水](https://dev.qweather.com/docs/api/minutely/minutely-5m/) |

### 天气预警

| SDK 方法 | Request 类 | Response 类 | 和风天气文档 |
|---------|-----------|------------|------------|
| `WeatheralertCurrentAsync` | `WeatheralertCurrentRequest` | `WeatheralertCurrentResponse` | [实时天气预警](https://dev.qweather.com/docs/api/warning/weather-alert/) |

### 天气指数

| SDK 方法 | Request 类 | Response 类 | 和风天气文档 |
|---------|-----------|------------|------------|
| `IndicesForecastAsync` | `IndicesForecastRequest` | `IndicesForecastResponse` | [天气指数预报](https://dev.qweather.com/docs/api/indices/indices-forecast/) |

### 空气质量

| SDK 方法 | Request 类 | Response 类 | 和风天气文档 |
|---------|-----------|------------|------------|
| `AirCurrentAsync` | `AirCurrentRequest` | `AirCurrentResponse` | [实时空气质量](https://dev.qweather.com/docs/api/air-quality/air-current/) |
| `AirHourlyForecastAsync` | `AirHourlyForecastRequest` | `AirHourlyForecastResponse` | [空气质量小时预报](https://dev.qweather.com/docs/api/air-quality/air-hourly-forecast/) |

### 时光机（历史数据）

| SDK 方法 | Request 类 | Response 类 | 和风天气文档 |
|---------|-----------|------------|------------|
| `HistoricalWeatherAsync` | `HistoricalWeatherRequest` | `HistoricalWeatherResponse` | [天气时光机](https://dev.qweather.com/docs/api/time-machine/time-machine-weather/) |
| `HistoricalAirAsync` | `HistoricalAirRequest` | `HistoricalAirResponse` | [空气质量时光机](https://dev.qweather.com/docs/api/time-machine/time-machine-air/) |

### 热带气旋（台风）

| SDK 方法 | Request 类 | Response 类 | 和风天气文档 |
|---------|-----------|------------|------------|
| `StormForecastAsync` | `StormForecastRequest` | `StormForecastResponse` | [台风预报](https://dev.qweather.com/docs/api/tropical-cyclone/storm-forecast/) |
| `StormTrackAsync` | `StormTrackRequest` | `StormTrackResponse` | [台风实况和路径](https://dev.qweather.com/docs/api/tropical-cyclone/storm-track/) |
| `StormListAsync` | `StormListRequest` | `StormListResponse` | [台风列表](https://dev.qweather.com/docs/api/tropical-cyclone/storm-list/) |

### 海洋数据

| SDK 方法 | Request 类 | Response 类 | 和风天气文档 |
|---------|-----------|------------|------------|
| `TideAsync` | `TideRequest` | `TideResponse` | [潮汐](https://dev.qweather.com/docs/api/ocean/tide/) |

### 太阳辐射

| SDK 方法 | Request 类 | Response 类 | 和风天气文档 |
|---------|-----------|------------|------------|
| `SolarRadiationForecastAsync` | `SolarRadiationForecastRequest` | `SolarRadiationForecastResponse` | [太阳辐射预报](https://dev.qweather.com/docs/api/solar-radiation/solar-radiation-forecast/) |

### 天文

| SDK 方法 | Request 类 | Response 类 | 和风天气文档 |
|---------|-----------|------------|------------|
| `SunAsync` | `SunRequest` | `SunResponse` | [日出日落](https://dev.qweather.com/docs/api/astronomy/sunrise-sunset/) |
| `MoonAsync` | `MoonRequest` | `MoonResponse` | [月升月落和月相](https://dev.qweather.com/docs/api/astronomy/moon-and-moon-phase/) |
| `SolarElevationAngleAsync` | `SolarElevationAngleRequest` | `SolarElevationAngleResponse` | [太阳高度角](https://dev.qweather.com/docs/api/astronomy/solar-elevation-angle/) |

### 控制台

| SDK 方法 | Request 类 | Response 类 | 和风天气文档 |
|---------|-----------|------------|------------|
| `FinanceSummaryAsync` | `FinanceSummaryRequest` | `FinanceSummaryResponse` | [财务汇总](https://dev.qweather.com/docs/api/console/finance/) |
| `MetricsStatsAsync` | `MetricsStatsRequest` | `MetricsStatsResponse` | [请求量统计](https://dev.qweather.com/docs/api/console/stats/) |

---

---

# English

# QWeather Sparrow.Qweather .NET SDK Documentation

## Installation
```cmd
dotnet add package Sparrow.Qweather
```

## Initialization

```csharp
public static WebApiClient WebApiClient()
{
    string folderPath = @"cert";
    string relativeFilePath = @"your_private_key_certificate";

    string certPath = Path.GetFullPath(Path.Combine(folderPath, relativeFilePath)); // certificate path
    var options = new WebApiOptions()
    {
        Host     = "your_API_Host",
        Kid      = "your_project_ID",
        Sub      = "your_credential_ID",
        CertPath = certPath           // certificate path
    };

    var client = WebApiClientBuilder.Create(options).Build();
    return client;
}
```

## Usage Example

```csharp
using Sparrow.Qweather.Client;
using Sparrow.Qweather.Example;
using Sparrow.Qweather.Tools;

var request =
    new Sparrow.Qweather.Models.Request.Weather.WeatherNowRequest
    {
        Location = "101010100",
    }; // Real-time weather query

var response = await WebApiClientSetting.WebApiClient().WeatherNowAsync(request);
var json = JsonTool.SerializeWithNullFilter(response);
Console.WriteLine(json);
```

## SDK Method to QWeather API Mapping

### Geo API

| SDK Method | Request Class | Response Class | QWeather Docs |
|-----------|--------------|---------------|---------------|
| `CityLookUpAsync` | `CityLookUpRequest` | `CityLookUpResponse` | [City Lookup](https://dev.qweather.com/docs/api/geoapi/city-lookup/) |
| `CityTopAsync` | `CityTopRequest` | `CityTopResponse` | [Top City](https://dev.qweather.com/docs/api/geoapi/top-city/) |
| `PoiLookUpAsync` | `PoiLookUpRequest` | `PoiLookUpResponse` | [POI Lookup](https://dev.qweather.com/docs/api/geoapi/poi-lookup/) |
| `PoiRangeAsync` | `PoiRangeRequest` | `PoiRangeReponse` | [POI Range](https://dev.qweather.com/docs/api/geoapi/poi-range/) |

### Weather Forecast

| SDK Method | Request Class | Response Class | QWeather Docs |
|-----------|--------------|---------------|---------------|
| `WeatherNowAsync` | `WeatherNowRequest` | `WeatherNowResponse` | [Weather Now](https://dev.qweather.com/docs/api/weather/weather-now/) |
| `WeatherDaysAsync` | `WeatherDaysRequest` | `WeatherDaysResponse` | [Daily Forecast](https://dev.qweather.com/docs/api/weather/weather-daily-forecast/) (3d/7d/10d/15d/30d) |
| `WeatherHoursAsync` | `WeatherHoursRequest` | `WeatherHoursResponse` | [Hourly Forecast](https://dev.qweather.com/docs/api/weather/weather-hourly-forecast/) (3h/6h/12h/24h) |
| `GridWeatherNowAsync` | `GridWeatherNowRequest` | `GridWeatherNowResponse` | [Grid Weather Now](https://dev.qweather.com/docs/api/weather/grid-weather-now/) |
| `GridWeatherDaysAsync` | `GridWeatherDaysRequest` | `GridWeatherDaysResponse` | [Grid Daily Forecast](https://dev.qweather.com/docs/api/weather/grid-weather-daily-forecast/) (3d/7d) |
| `GridWeatherHoursAsync` | `GridWeatherHoursRequest` | `GridWeatherHoursResponse` | [Grid Hourly Forecast](https://dev.qweather.com/docs/api/weather/grid-weather-hourly-forecast/) (24h/72h) |

### Minutely Forecast

| SDK Method | Request Class | Response Class | QWeather Docs |
|-----------|--------------|---------------|---------------|
| `Minutely5mAsync` | `Minutely5mRequset` | `Minutely5mResponse` | [Minutely Precipitation](https://dev.qweather.com/docs/api/minutely/minutely-5m/) |

### Weather Warning

| SDK Method | Request Class | Response Class | QWeather Docs |
|-----------|--------------|---------------|---------------|
| `WeatheralertCurrentAsync` | `WeatheralertCurrentRequest` | `WeatheralertCurrentResponse` | [Weather Alert](https://dev.qweather.com/docs/api/warning/weather-alert/) |

### Weather Indices

| SDK Method | Request Class | Response Class | QWeather Docs |
|-----------|--------------|---------------|---------------|
| `IndicesForecastAsync` | `IndicesForecastRequest` | `IndicesForecastResponse` | [Indices Forecast](https://dev.qweather.com/docs/api/indices/indices-forecast/) |

### Air Quality

| SDK Method | Request Class | Response Class | QWeather Docs |
|-----------|--------------|---------------|---------------|
| `AirCurrentAsync` | `AirCurrentRequest` | `AirCurrentResponse` | [Air Current](https://dev.qweather.com/docs/api/air-quality/air-current/) |
| `AirHourlyForecastAsync` | `AirHourlyForecastRequest` | `AirHourlyForecastResponse` | [Air Hourly Forecast](https://dev.qweather.com/docs/api/air-quality/air-hourly-forecast/) |

### Time Machine (Historical Data)

| SDK Method | Request Class | Response Class | QWeather Docs |
|-----------|--------------|---------------|---------------|
| `HistoricalWeatherAsync` | `HistoricalWeatherRequest` | `HistoricalWeatherResponse` | [Historical Weather](https://dev.qweather.com/docs/api/time-machine/time-machine-weather/) |
| `HistoricalAirAsync` | `HistoricalAirRequest` | `HistoricalAirResponse` | [Historical Air](https://dev.qweather.com/docs/api/time-machine/time-machine-air/) |

### Tropical Cyclone (Typhoon)

| SDK Method | Request Class | Response Class | QWeather Docs |
|-----------|--------------|---------------|---------------|
| `StormForecastAsync` | `StormForecastRequest` | `StormForecastResponse` | [Storm Forecast](https://dev.qweather.com/docs/api/tropical-cyclone/storm-forecast/) |
| `StormTrackAsync` | `StormTrackRequest` | `StormTrackResponse` | [Storm Track](https://dev.qweather.com/docs/api/tropical-cyclone/storm-track/) |
| `StormListAsync` | `StormListRequest` | `StormListResponse` | [Storm List](https://dev.qweather.com/docs/api/tropical-cyclone/storm-list/) |

### Ocean Data

| SDK Method | Request Class | Response Class | QWeather Docs |
|-----------|--------------|---------------|---------------|
| `TideAsync` | `TideRequest` | `TideResponse` | [Tide](https://dev.qweather.com/docs/api/ocean/tide/) |

### Solar Radiation

| SDK Method | Request Class | Response Class | QWeather Docs |
|-----------|--------------|---------------|---------------|
| `SolarRadiationForecastAsync` | `SolarRadiationForecastRequest` | `SolarRadiationForecastResponse` | [Solar Radiation Forecast](https://dev.qweather.com/docs/api/solar-radiation/solar-radiation-forecast/) |

### Astronomy

| SDK Method | Request Class | Response Class | QWeather Docs |
|-----------|--------------|---------------|---------------|
| `SunAsync` | `SunRequest` | `SunResponse` | [Sunrise & Sunset](https://dev.qweather.com/docs/api/astronomy/sunrise-sunset/) |
| `MoonAsync` | `MoonRequest` | `MoonResponse` | [Moon & Moon Phase](https://dev.qweather.com/docs/api/astronomy/moon-and-moon-phase/) |
| `SolarElevationAngleAsync` | `SolarElevationAngleRequest` | `SolarElevationAngleResponse` | [Solar Elevation Angle](https://dev.qweather.com/docs/api/astronomy/solar-elevation-angle/) |

### Console

| SDK Method | Request Class | Response Class | QWeather Docs |
|-----------|--------------|---------------|---------------|
| `FinanceSummaryAsync` | `FinanceSummaryRequest` | `FinanceSummaryResponse` | [Finance Summary](https://dev.qweather.com/docs/api/console/finance/) |
| `MetricsStatsAsync` | `MetricsStatsRequest` | `MetricsStatsResponse` | [Metrics Stats](https://dev.qweather.com/docs/api/console/stats/) |

---

---

# Français

# Documentation du SDK .NET QWeather Sparrow.Qweather

## Installation
```cmd
dotnet add package Sparrow.Qweather
```

## Initialisation

```csharp
public static WebApiClient WebApiClient()
{
    string folderPath = @"cert";
    string relativeFilePath = @"votre_certificat_clé_privée";

    string certPath = Path.GetFullPath(Path.Combine(folderPath, relativeFilePath)); // chemin du certificat
    var options = new WebApiOptions()
    {
        Host     = "votre_hôte_API",
        Kid      = "votre_ID_projet",
        Sub      = "votre_ID_credential",
        CertPath = certPath           // chemin du certificat
    };

    var client = WebApiClientBuilder.Create(options).Build();
    return client;
}
```

## Exemple d'utilisation

```csharp
using Sparrow.Qweather.Client;
using Sparrow.Qweather.Example;
using Sparrow.Qweather.Tools;

var request =
    new Sparrow.Qweather.Models.Request.Weather.WeatherNowRequest
    {
        Location = "101010100",
    }; // Requête météo en temps réel

var response = await WebApiClientSetting.WebApiClient().WeatherNowAsync(request);
var json = JsonTool.SerializeWithNullFilter(response);
Console.WriteLine(json);
```

## Correspondance méthodes SDK / API QWeather

### API Géographique (GeoAPI)

| Méthode SDK | Classe Request | Classe Response | Documentation QWeather |
|------------|---------------|----------------|------------------------|
| `CityLookUpAsync` | `CityLookUpRequest` | `CityLookUpResponse` | [Recherche de ville](https://dev.qweather.com/docs/api/geoapi/city-lookup/) |
| `CityTopAsync` | `CityTopRequest` | `CityTopResponse` | [Villes populaires](https://dev.qweather.com/docs/api/geoapi/top-city/) |
| `PoiLookUpAsync` | `PoiLookUpRequest` | `PoiLookUpResponse` | [Recherche POI](https://dev.qweather.com/docs/api/geoapi/poi-lookup/) |
| `PoiRangeAsync` | `PoiRangeRequest` | `PoiRangeReponse` | [POI dans un rayon](https://dev.qweather.com/docs/api/geoapi/poi-range/) |

### Prévisions météo

| Méthode SDK | Classe Request | Classe Response | Documentation QWeather |
|------------|---------------|----------------|------------------------|
| `WeatherNowAsync` | `WeatherNowRequest` | `WeatherNowResponse` | [Météo en temps réel](https://dev.qweather.com/docs/api/weather/weather-now/) |
| `WeatherDaysAsync` | `WeatherDaysRequest` | `WeatherDaysResponse` | [Prévisions journalières](https://dev.qweather.com/docs/api/weather/weather-daily-forecast/) (3d/7d/10d/15d/30d) |
| `WeatherHoursAsync` | `WeatherHoursRequest` | `WeatherHoursResponse` | [Prévisions horaires](https://dev.qweather.com/docs/api/weather/weather-hourly-forecast/) (3h/6h/12h/24h) |
| `GridWeatherNowAsync` | `GridWeatherNowRequest` | `GridWeatherNowResponse` | [Météo grille temps réel](https://dev.qweather.com/docs/api/weather/grid-weather-now/) |
| `GridWeatherDaysAsync` | `GridWeatherDaysRequest` | `GridWeatherDaysResponse` | [Prévisions grille journalières](https://dev.qweather.com/docs/api/weather/grid-weather-daily-forecast/) (3d/7d) |
| `GridWeatherHoursAsync` | `GridWeatherHoursRequest` | `GridWeatherHoursResponse` | [Prévisions grille horaires](https://dev.qweather.com/docs/api/weather/grid-weather-hourly-forecast/) (24h/72h) |

### Prévisions à la minute

| Méthode SDK | Classe Request | Classe Response | Documentation QWeather |
|------------|---------------|----------------|------------------------|
| `Minutely5mAsync` | `Minutely5mRequset` | `Minutely5mResponse` | [Précipitations par minute](https://dev.qweather.com/docs/api/minutely/minutely-5m/) |

### Alertes météo

| Méthode SDK | Classe Request | Classe Response | Documentation QWeather |
|------------|---------------|----------------|------------------------|
| `WeatheralertCurrentAsync` | `WeatheralertCurrentRequest` | `WeatheralertCurrentResponse` | [Alerte météo](https://dev.qweather.com/docs/api/warning/weather-alert/) |

### Indices météo

| Méthode SDK | Classe Request | Classe Response | Documentation QWeather |
|------------|---------------|----------------|------------------------|
| `IndicesForecastAsync` | `IndicesForecastRequest` | `IndicesForecastResponse` | [Prévisions d'indices](https://dev.qweather.com/docs/api/indices/indices-forecast/) |

### Qualité de l'air

| Méthode SDK | Classe Request | Classe Response | Documentation QWeather |
|------------|---------------|----------------|------------------------|
| `AirCurrentAsync` | `AirCurrentRequest` | `AirCurrentResponse` | [Qualité de l'air actuelle](https://dev.qweather.com/docs/api/air-quality/air-current/) |
| `AirHourlyForecastAsync` | `AirHourlyForecastRequest` | `AirHourlyForecastResponse` | [Prévisions horaires qualité air](https://dev.qweather.com/docs/api/air-quality/air-hourly-forecast/) |

### Machine à remonter le temps (données historiques)

| Méthode SDK | Classe Request | Classe Response | Documentation QWeather |
|------------|---------------|----------------|------------------------|
| `HistoricalWeatherAsync` | `HistoricalWeatherRequest` | `HistoricalWeatherResponse` | [Météo historique](https://dev.qweather.com/docs/api/time-machine/time-machine-weather/) |
| `HistoricalAirAsync` | `HistoricalAirRequest` | `HistoricalAirResponse` | [Qualité de l'air historique](https://dev.qweather.com/docs/api/time-machine/time-machine-air/) |

### Cyclone tropical (Typhon)

| Méthode SDK | Classe Request | Classe Response | Documentation QWeather |
|------------|---------------|----------------|------------------------|
| `StormForecastAsync` | `StormForecastRequest` | `StormForecastResponse` | [Prévision typhon](https://dev.qweather.com/docs/api/tropical-cyclone/storm-forecast/) |
| `StormTrackAsync` | `StormTrackRequest` | `StormTrackResponse` | [Trajectoire typhon](https://dev.qweather.com/docs/api/tropical-cyclone/storm-track/) |
| `StormListAsync` | `StormListRequest` | `StormListResponse` | [Liste des typhons](https://dev.qweather.com/docs/api/tropical-cyclone/storm-list/) |

### Données océaniques

| Méthode SDK | Classe Request | Classe Response | Documentation QWeather |
|------------|---------------|----------------|------------------------|
| `TideAsync` | `TideRequest` | `TideResponse` | [Marée](https://dev.qweather.com/docs/api/ocean/tide/) |

### Rayonnement solaire

| Méthode SDK | Classe Request | Classe Response | Documentation QWeather |
|------------|---------------|----------------|------------------------|
| `SolarRadiationForecastAsync` | `SolarRadiationForecastRequest` | `SolarRadiationForecastResponse` | [Prévisions rayonnement solaire](https://dev.qweather.com/docs/api/solar-radiation/solar-radiation-forecast/) |

### Astronomie

| Méthode SDK | Classe Request | Classe Response | Documentation QWeather |
|------------|---------------|----------------|------------------------|
| `SunAsync` | `SunRequest` | `SunResponse` | [Lever/Coucher du soleil](https://dev.qweather.com/docs/api/astronomy/sunrise-sunset/) |
| `MoonAsync` | `MoonRequest` | `MoonResponse` | [Lune et phase lunaire](https://dev.qweather.com/docs/api/astronomy/moon-and-moon-phase/) |
| `SolarElevationAngleAsync` | `SolarElevationAngleRequest` | `SolarElevationAngleResponse` | [Angle d'élévation solaire](https://dev.qweather.com/docs/api/astronomy/solar-elevation-angle/) |

### Console

| Méthode SDK | Classe Request | Classe Response | Documentation QWeather |
|------------|---------------|----------------|------------------------|
| `FinanceSummaryAsync` | `FinanceSummaryRequest` | `FinanceSummaryResponse` | [Résumé financier](https://dev.qweather.com/docs/api/console/finance/) |
| `MetricsStatsAsync` | `MetricsStatsRequest` | `MetricsStatsResponse` | [Statistiques de requêtes](https://dev.qweather.com/docs/api/console/stats/) |

---

---

# Español

# Documentación del SDK .NET QWeather Sparrow.Qweather

## Instalación
```cmd
dotnet add package Sparrow.Qweather
```

## Inicialización

```csharp
public static WebApiClient WebApiClient()
{
    string folderPath = @"cert";
    string relativeFilePath = @"su_certificado_clave_privada";

    string certPath = Path.GetFullPath(Path.Combine(folderPath, relativeFilePath)); // ruta del certificado
    var options = new WebApiOptions()
    {
        Host     = "su_Host_API",
        Kid      = "su_ID_proyecto",
        Sub      = "su_ID_credencial",
        CertPath = certPath           // ruta del certificado
    };

    var client = WebApiClientBuilder.Create(options).Build();
    return client;
}
```

## Ejemplo de uso

```csharp
using Sparrow.Qweather.Client;
using Sparrow.Qweather.Example;
using Sparrow.Qweather.Tools;

var request =
    new Sparrow.Qweather.Models.Request.Weather.WeatherNowRequest
    {
        Location = "101010100",
    }; // Consulta del tiempo en tiempo real

var response = await WebApiClientSetting.WebApiClient().WeatherNowAsync(request);
var json = JsonTool.SerializeWithNullFilter(response);
Console.WriteLine(json);
```

## Correspondencia entre métodos SDK y API QWeather

### API Geográfica (GeoAPI)

| Método SDK | Clase Request | Clase Response | Documentación QWeather |
|-----------|--------------|---------------|------------------------|
| `CityLookUpAsync` | `CityLookUpRequest` | `CityLookUpResponse` | [Búsqueda de ciudad](https://dev.qweather.com/docs/api/geoapi/city-lookup/) |
| `CityTopAsync` | `CityTopRequest` | `CityTopResponse` | [Ciudades populares](https://dev.qweather.com/docs/api/geoapi/top-city/) |
| `PoiLookUpAsync` | `PoiLookUpRequest` | `PoiLookUpResponse` | [Búsqueda POI](https://dev.qweather.com/docs/api/geoapi/poi-lookup/) |
| `PoiRangeAsync` | `PoiRangeRequest` | `PoiRangeReponse` | [POI en radio](https://dev.qweather.com/docs/api/geoapi/poi-range/) |

### Pronóstico del tiempo

| Método SDK | Clase Request | Clase Response | Documentación QWeather |
|-----------|--------------|---------------|------------------------|
| `WeatherNowAsync` | `WeatherNowRequest` | `WeatherNowResponse` | [Tiempo actual](https://dev.qweather.com/docs/api/weather/weather-now/) |
| `WeatherDaysAsync` | `WeatherDaysRequest` | `WeatherDaysResponse` | [Pronóstico diario](https://dev.qweather.com/docs/api/weather/weather-daily-forecast/) (3d/7d/10d/15d/30d) |
| `WeatherHoursAsync` | `WeatherHoursRequest` | `WeatherHoursResponse` | [Pronóstico por horas](https://dev.qweather.com/docs/api/weather/weather-hourly-forecast/) (3h/6h/12h/24h) |
| `GridWeatherNowAsync` | `GridWeatherNowRequest` | `GridWeatherNowResponse` | [Tiempo de cuadrícula actual](https://dev.qweather.com/docs/api/weather/grid-weather-now/) |
| `GridWeatherDaysAsync` | `GridWeatherDaysRequest` | `GridWeatherDaysResponse` | [Pronóstico cuadrícula diario](https://dev.qweather.com/docs/api/weather/grid-weather-daily-forecast/) (3d/7d) |
| `GridWeatherHoursAsync` | `GridWeatherHoursRequest` | `GridWeatherHoursResponse` | [Pronóstico cuadrícula por horas](https://dev.qweather.com/docs/api/weather/grid-weather-hourly-forecast/) (24h/72h) |

### Pronóstico por minutos

| Método SDK | Clase Request | Clase Response | Documentación QWeather |
|-----------|--------------|---------------|------------------------|
| `Minutely5mAsync` | `Minutely5mRequset` | `Minutely5mResponse` | [Precipitación por minutos](https://dev.qweather.com/docs/api/minutely/minutely-5m/) |

### Alertas meteorológicas

| Método SDK | Clase Request | Clase Response | Documentación QWeather |
|-----------|--------------|---------------|------------------------|
| `WeatheralertCurrentAsync` | `WeatheralertCurrentRequest` | `WeatheralertCurrentResponse` | [Alerta meteorológica](https://dev.qweather.com/docs/api/warning/weather-alert/) |

### Índices meteorológicos

| Método SDK | Clase Request | Clase Response | Documentación QWeather |
|-----------|--------------|---------------|------------------------|
| `IndicesForecastAsync` | `IndicesForecastRequest` | `IndicesForecastResponse` | [Pronóstico de índices](https://dev.qweather.com/docs/api/indices/indices-forecast/) |

### Calidad del aire

| Método SDK | Clase Request | Clase Response | Documentación QWeather |
|-----------|--------------|---------------|------------------------|
| `AirCurrentAsync` | `AirCurrentRequest` | `AirCurrentResponse` | [Calidad del aire actual](https://dev.qweather.com/docs/api/air-quality/air-current/) |
| `AirHourlyForecastAsync` | `AirHourlyForecastRequest` | `AirHourlyForecastResponse` | [Pronóstico horario calidad aire](https://dev.qweather.com/docs/api/air-quality/air-hourly-forecast/) |

### Máquina del tiempo (datos históricos)

| Método SDK | Clase Request | Clase Response | Documentación QWeather |
|-----------|--------------|---------------|------------------------|
| `HistoricalWeatherAsync` | `HistoricalWeatherRequest` | `HistoricalWeatherResponse` | [Tiempo histórico](https://dev.qweather.com/docs/api/time-machine/time-machine-weather/) |
| `HistoricalAirAsync` | `HistoricalAirRequest` | `HistoricalAirResponse` | [Calidad del aire histórica](https://dev.qweather.com/docs/api/time-machine/time-machine-air/) |

### Ciclón tropical (Tifón)

| Método SDK | Clase Request | Clase Response | Documentación QWeather |
|-----------|--------------|---------------|------------------------|
| `StormForecastAsync` | `StormForecastRequest` | `StormForecastResponse` | [Pronóstico de tifón](https://dev.qweather.com/docs/api/tropical-cyclone/storm-forecast/) |
| `StormTrackAsync` | `StormTrackRequest` | `StormTrackResponse` | [Trayectoria del tifón](https://dev.qweather.com/docs/api/tropical-cyclone/storm-track/) |
| `StormListAsync` | `StormListRequest` | `StormListResponse` | [Lista de tifones](https://dev.qweather.com/docs/api/tropical-cyclone/storm-list/) |

### Datos oceánicos

| Método SDK | Clase Request | Clase Response | Documentación QWeather |
|-----------|--------------|---------------|------------------------|
| `TideAsync` | `TideRequest` | `TideResponse` | [Marea](https://dev.qweather.com/docs/api/ocean/tide/) |

### Radiación solar

| Método SDK | Clase Request | Clase Response | Documentación QWeather |
|-----------|--------------|---------------|------------------------|
| `SolarRadiationForecastAsync` | `SolarRadiationForecastRequest` | `SolarRadiationForecastResponse` | [Pronóstico radiación solar](https://dev.qweather.com/docs/api/solar-radiation/solar-radiation-forecast/) |

### Astronomía

| Método SDK | Clase Request | Clase Response | Documentación QWeather |
|-----------|--------------|---------------|------------------------|
| `SunAsync` | `SunRequest` | `SunResponse` | [Amanecer y atardecer](https://dev.qweather.com/docs/api/astronomy/sunrise-sunset/) |
| `MoonAsync` | `MoonRequest` | `MoonResponse` | [Luna y fase lunar](https://dev.qweather.com/docs/api/astronomy/moon-and-moon-phase/) |
| `SolarElevationAngleAsync` | `SolarElevationAngleRequest` | `SolarElevationAngleResponse` | [Ángulo de elevación solar](https://dev.qweather.com/docs/api/astronomy/solar-elevation-angle/) |

### Consola

| Método SDK | Clase Request | Clase Response | Documentación QWeather |
|-----------|--------------|---------------|------------------------|
| `FinanceSummaryAsync` | `FinanceSummaryRequest` | `FinanceSummaryResponse` | [Resumen financiero](https://dev.qweather.com/docs/api/console/finance/) |
| `MetricsStatsAsync` | `MetricsStatsRequest` | `MetricsStatsResponse` | [Estadísticas de solicitudes](https://dev.qweather.com/docs/api/console/stats/) |

---

---

# Русский

# Документация SDK .NET QWeather Sparrow.Qweather

## Установка
```cmd
dotnet add package Sparrow.Qweather
```

## Инициализация

```csharp
public static WebApiClient WebApiClient()
{
    string folderPath = @"cert";
    string relativeFilePath = @"ваш_сертификат_закрытого_ключа";

    string certPath = Path.GetFullPath(Path.Combine(folderPath, relativeFilePath)); // путь к сертификату
    var options = new WebApiOptions()
    {
        Host     = "ваш_API_хост",
        Kid      = "ваш_ID_проекта",
        Sub      = "ваш_ID_учётных_данных",
        CertPath = certPath           // путь к сертификату
    };

    var client = WebApiClientBuilder.Create(options).Build();
    return client;
}
```

## Пример использования

```csharp
using Sparrow.Qweather.Client;
using Sparrow.Qweather.Example;
using Sparrow.Qweather.Tools;

var request =
    new Sparrow.Qweather.Models.Request.Weather.WeatherNowRequest
    {
        Location = "101010100",
    }; // Запрос погоды в реальном времени

var response = await WebApiClientSetting.WebApiClient().WeatherNowAsync(request);
var json = JsonTool.SerializeWithNullFilter(response);
Console.WriteLine(json);
```

## Таблица соответствия методов SDK и API QWeather

### Геолокационный API (GeoAPI)

| Метод SDK | Класс Request | Класс Response | Документация QWeather |
|----------|--------------|---------------|----------------------|
| `CityLookUpAsync` | `CityLookUpRequest` | `CityLookUpResponse` | [Поиск города](https://dev.qweather.com/docs/api/geoapi/city-lookup/) |
| `CityTopAsync` | `CityTopRequest` | `CityTopResponse` | [Популярные города](https://dev.qweather.com/docs/api/geoapi/top-city/) |
| `PoiLookUpAsync` | `PoiLookUpRequest` | `PoiLookUpResponse` | [Поиск POI](https://dev.qweather.com/docs/api/geoapi/poi-lookup/) |
| `PoiRangeAsync` | `PoiRangeRequest` | `PoiRangeReponse` | [POI в радиусе](https://dev.qweather.com/docs/api/geoapi/poi-range/) |

### Прогноз погоды

| Метод SDK | Класс Request | Класс Response | Документация QWeather |
|----------|--------------|---------------|----------------------|
| `WeatherNowAsync` | `WeatherNowRequest` | `WeatherNowResponse` | [Текущая погода](https://dev.qweather.com/docs/api/weather/weather-now/) |
| `WeatherDaysAsync` | `WeatherDaysRequest` | `WeatherDaysResponse` | [Ежедневный прогноз](https://dev.qweather.com/docs/api/weather/weather-daily-forecast/) (3d/7d/10d/15d/30d) |
| `WeatherHoursAsync` | `WeatherHoursRequest` | `WeatherHoursResponse` | [Почасовой прогноз](https://dev.qweather.com/docs/api/weather/weather-hourly-forecast/) (3h/6h/12h/24h) |
| `GridWeatherNowAsync` | `GridWeatherNowRequest` | `GridWeatherNowResponse` | [Текущая погода сетки](https://dev.qweather.com/docs/api/weather/grid-weather-now/) |
| `GridWeatherDaysAsync` | `GridWeatherDaysRequest` | `GridWeatherDaysResponse` | [Ежедневный прогноз сетки](https://dev.qweather.com/docs/api/weather/grid-weather-daily-forecast/) (3d/7d) |
| `GridWeatherHoursAsync` | `GridWeatherHoursRequest` | `GridWeatherHoursResponse` | [Почасовой прогноз сетки](https://dev.qweather.com/docs/api/weather/grid-weather-hourly-forecast/) (24h/72h) |

### Поминутный прогноз

| Метод SDK | Класс Request | Класс Response | Документация QWeather |
|----------|--------------|---------------|----------------------|
| `Minutely5mAsync` | `Minutely5mRequset` | `Minutely5mResponse` | [Поминутные осадки](https://dev.qweather.com/docs/api/minutely/minutely-5m/) |

### Погодные предупреждения

| Метод SDK | Класс Request | Класс Response | Документация QWeather |
|----------|--------------|---------------|----------------------|
| `WeatheralertCurrentAsync` | `WeatheralertCurrentRequest` | `WeatheralertCurrentResponse` | [Погодное предупреждение](https://dev.qweather.com/docs/api/warning/weather-alert/) |

### Погодные индексы

| Метод SDK | Класс Request | Класс Response | Документация QWeather |
|----------|--------------|---------------|----------------------|
| `IndicesForecastAsync` | `IndicesForecastRequest` | `IndicesForecastResponse` | [Прогноз индексов](https://dev.qweather.com/docs/api/indices/indices-forecast/) |

### Качество воздуха

| Метод SDK | Класс Request | Класс Response | Документация QWeather |
|----------|--------------|---------------|----------------------|
| `AirCurrentAsync` | `AirCurrentRequest` | `AirCurrentResponse` | [Текущее качество воздуха](https://dev.qweather.com/docs/api/air-quality/air-current/) |
| `AirHourlyForecastAsync` | `AirHourlyForecastRequest` | `AirHourlyForecastResponse` | [Почасовой прогноз качества воздуха](https://dev.qweather.com/docs/api/air-quality/air-hourly-forecast/) |

### Машина времени (исторические данные)

| Метод SDK | Класс Request | Класс Response | Документация QWeather |
|----------|--------------|---------------|----------------------|
| `HistoricalWeatherAsync` | `HistoricalWeatherRequest` | `HistoricalWeatherResponse` | [Историческая погода](https://dev.qweather.com/docs/api/time-machine/time-machine-weather/) |
| `HistoricalAirAsync` | `HistoricalAirRequest` | `HistoricalAirResponse` | [Историческое качество воздуха](https://dev.qweather.com/docs/api/time-machine/time-machine-air/) |

### Тропический циклон (Тайфун)

| Метод SDK | Класс Request | Класс Response | Документация QWeather |
|----------|--------------|---------------|----------------------|
| `StormForecastAsync` | `StormForecastRequest` | `StormForecastResponse` | [Прогноз тайфуна](https://dev.qweather.com/docs/api/tropical-cyclone/storm-forecast/) |
| `StormTrackAsync` | `StormTrackRequest` | `StormTrackResponse` | [Траектория тайфуна](https://dev.qweather.com/docs/api/tropical-cyclone/storm-track/) |
| `StormListAsync` | `StormListRequest` | `StormListResponse` | [Список тайфунов](https://dev.qweather.com/docs/api/tropical-cyclone/storm-list/) |

### Океанические данные

| Метод SDK | Класс Request | Класс Response | Документация QWeather |
|----------|--------------|---------------|----------------------|
| `TideAsync` | `TideRequest` | `TideResponse` | [Приливы](https://dev.qweather.com/docs/api/ocean/tide/) |

### Солнечная радиация

| Метод SDK | Класс Request | Класс Response | Документация QWeather |
|----------|--------------|---------------|----------------------|
| `SolarRadiationForecastAsync` | `SolarRadiationForecastRequest` | `SolarRadiationForecastResponse` | [Прогноз солнечной радиации](https://dev.qweather.com/docs/api/solar-radiation/solar-radiation-forecast/) |

### Астрономия

| Метод SDK | Класс Request | Класс Response | Документация QWeather |
|----------|--------------|---------------|----------------------|
| `SunAsync` | `SunRequest` | `SunResponse` | [Восход и закат](https://dev.qweather.com/docs/api/astronomy/sunrise-sunset/) |
| `MoonAsync` | `MoonRequest` | `MoonResponse` | [Луна и фазы луны](https://dev.qweather.com/docs/api/astronomy/moon-and-moon-phase/) |
| `SolarElevationAngleAsync` | `SolarElevationAngleRequest` | `SolarElevationAngleResponse` | [Угол высоты солнца](https://dev.qweather.com/docs/api/astronomy/solar-elevation-angle/) |

### Консоль

| Метод SDK | Класс Request | Класс Response | Документация QWeather |
|----------|--------------|---------------|----------------------|
| `FinanceSummaryAsync` | `FinanceSummaryRequest` | `FinanceSummaryResponse` | [Финансовая сводка](https://dev.qweather.com/docs/api/console/finance/) |
| `MetricsStatsAsync` | `MetricsStatsRequest` | `MetricsStatsResponse` | [Статистика запросов](https://dev.qweather.com/docs/api/console/stats/) |

---

---

# العربية

# توثيق SDK ‏.NET الخاص بـ QWeather Sparrow.Qweather

## التثبيت
```cmd
dotnet add package Sparrow.Qweather
```

## التهيئة

```csharp
public static WebApiClient WebApiClient()
{
    string folderPath = @"cert";
    string relativeFilePath = @"شهادة_مفتاحك_الخاص";

    string certPath = Path.GetFullPath(Path.Combine(folderPath, relativeFilePath)); // مسار الشهادة
    var options = new WebApiOptions()
    {
        Host     = "مضيف_API_الخاص_بك",
        Kid      = "معرّف_مشروعك",
        Sub      = "معرّف_بيانات_اعتمادك",
        CertPath = certPath           // مسار الشهادة
    };

    var client = WebApiClientBuilder.Create(options).Build();
    return client;
}
```

## مثال على الاستخدام

```csharp
using Sparrow.Qweather.Client;
using Sparrow.Qweather.Example;
using Sparrow.Qweather.Tools;

var request =
    new Sparrow.Qweather.Models.Request.Weather.WeatherNowRequest
    {
        Location = "101010100",
    }; // استعلام الطقس الفوري

var response = await WebApiClientSetting.WebApiClient().WeatherNowAsync(request);
var json = JsonTool.SerializeWithNullFilter(response);
Console.WriteLine(json);
```

## جدول تطابق أساليب SDK مع واجهات برمجة تطبيقات QWeather

### واجهة الموقع الجغرافي (GeoAPI)

| أسلوب SDK | فئة Request | فئة Response | توثيق QWeather |
|----------|------------|-------------|----------------|
| `CityLookUpAsync` | `CityLookUpRequest` | `CityLookUpResponse` | [البحث عن مدينة](https://dev.qweather.com/docs/api/geoapi/city-lookup/) |
| `CityTopAsync` | `CityTopRequest` | `CityTopResponse` | [المدن الأكثر شعبية](https://dev.qweather.com/docs/api/geoapi/top-city/) |
| `PoiLookUpAsync` | `PoiLookUpRequest` | `PoiLookUpResponse` | [البحث عن نقطة اهتمام](https://dev.qweather.com/docs/api/geoapi/poi-lookup/) |
| `PoiRangeAsync` | `PoiRangeRequest` | `PoiRangeReponse` | [نقاط الاهتمام في نطاق](https://dev.qweather.com/docs/api/geoapi/poi-range/) |

### توقعات الطقس

| أسلوب SDK | فئة Request | فئة Response | توثيق QWeather |
|----------|------------|-------------|----------------|
| `WeatherNowAsync` | `WeatherNowRequest` | `WeatherNowResponse` | [الطقس الآن](https://dev.qweather.com/docs/api/weather/weather-now/) |
| `WeatherDaysAsync` | `WeatherDaysRequest` | `WeatherDaysResponse` | [التوقعات اليومية](https://dev.qweather.com/docs/api/weather/weather-daily-forecast/) (3d/7d/10d/15d/30d) |
| `WeatherHoursAsync` | `WeatherHoursRequest` | `WeatherHoursResponse` | [التوقعات بالساعة](https://dev.qweather.com/docs/api/weather/weather-hourly-forecast/) (3h/6h/12h/24h) |
| `GridWeatherNowAsync` | `GridWeatherNowRequest` | `GridWeatherNowResponse` | [طقس الشبكة الآن](https://dev.qweather.com/docs/api/weather/grid-weather-now/) |
| `GridWeatherDaysAsync` | `GridWeatherDaysRequest` | `GridWeatherDaysResponse` | [التوقعات اليومية للشبكة](https://dev.qweather.com/docs/api/weather/grid-weather-daily-forecast/) (3d/7d) |
| `GridWeatherHoursAsync` | `GridWeatherHoursRequest` | `GridWeatherHoursResponse` | [التوقعات بالساعة للشبكة](https://dev.qweather.com/docs/api/weather/grid-weather-hourly-forecast/) (24h/72h) |

### توقعات دقيقة بدقيقة

| أسلوب SDK | فئة Request | فئة Response | توثيق QWeather |
|----------|------------|-------------|----------------|
| `Minutely5mAsync` | `Minutely5mRequset` | `Minutely5mResponse` | [هطول الأمطار بالدقيقة](https://dev.qweather.com/docs/api/minutely/minutely-5m/) |

### تحذيرات الطقس

| أسلوب SDK | فئة Request | فئة Response | توثيق QWeather |
|----------|------------|-------------|----------------|
| `WeatheralertCurrentAsync` | `WeatheralertCurrentRequest` | `WeatheralertCurrentResponse` | [تنبيه الطقس](https://dev.qweather.com/docs/api/warning/weather-alert/) |

### مؤشرات الطقس

| أسلوب SDK | فئة Request | فئة Response | توثيق QWeather |
|----------|------------|-------------|----------------|
| `IndicesForecastAsync` | `IndicesForecastRequest` | `IndicesForecastResponse` | [توقعات المؤشرات](https://dev.qweather.com/docs/api/indices/indices-forecast/) |

### جودة الهواء

| أسلوب SDK | فئة Request | فئة Response | توثيق QWeather |
|----------|------------|-------------|----------------|
| `AirCurrentAsync` | `AirCurrentRequest` | `AirCurrentResponse` | [جودة الهواء الحالية](https://dev.qweather.com/docs/api/air-quality/air-current/) |
| `AirHourlyForecastAsync` | `AirHourlyForecastRequest` | `AirHourlyForecastResponse` | [توقعات جودة الهواء بالساعة](https://dev.qweather.com/docs/api/air-quality/air-hourly-forecast/) |

### آلة الزمن (البيانات التاريخية)

| أسلوب SDK | فئة Request | فئة Response | توثيق QWeather |
|----------|------------|-------------|----------------|
| `HistoricalWeatherAsync` | `HistoricalWeatherRequest` | `HistoricalWeatherResponse` | [الطقس التاريخي](https://dev.qweather.com/docs/api/time-machine/time-machine-weather/) |
| `HistoricalAirAsync` | `HistoricalAirRequest` | `HistoricalAirResponse` | [جودة الهواء التاريخية](https://dev.qweather.com/docs/api/time-machine/time-machine-air/) |

### الإعصار المداري (التايفون)

| أسلوب SDK | فئة Request | فئة Response | توثيق QWeather |
|----------|------------|-------------|----------------|
| `StormForecastAsync` | `StormForecastRequest` | `StormForecastResponse` | [توقع الإعصار](https://dev.qweather.com/docs/api/tropical-cyclone/storm-forecast/) |
| `StormTrackAsync` | `StormTrackRequest` | `StormTrackResponse` | [مسار الإعصار](https://dev.qweather.com/docs/api/tropical-cyclone/storm-track/) |
| `StormListAsync` | `StormListRequest` | `StormListResponse` | [قائمة الأعاصير](https://dev.qweather.com/docs/api/tropical-cyclone/storm-list/) |

### بيانات المحيط

| أسلوب SDK | فئة Request | فئة Response | توثيق QWeather |
|----------|------------|-------------|----------------|
| `TideAsync` | `TideRequest` | `TideResponse` | [المد والجزر](https://dev.qweather.com/docs/api/ocean/tide/) |

### الإشعاع الشمسي

| أسلوب SDK | فئة Request | فئة Response | توثيق QWeather |
|----------|------------|-------------|----------------|
| `SolarRadiationForecastAsync` | `SolarRadiationForecastRequest` | `SolarRadiationForecastResponse` | [توقعات الإشعاع الشمسي](https://dev.qweather.com/docs/api/solar-radiation/solar-radiation-forecast/) |

### علم الفلك

| أسلوب SDK | فئة Request | فئة Response | توثيق QWeather |
|----------|------------|-------------|----------------|
| `SunAsync` | `SunRequest` | `SunResponse` | [شروق وغروب الشمس](https://dev.qweather.com/docs/api/astronomy/sunrise-sunset/) |
| `MoonAsync` | `MoonRequest` | `MoonResponse` | [القمر وأطواره](https://dev.qweather.com/docs/api/astronomy/moon-and-moon-phase/) |
| `SolarElevationAngleAsync` | `SolarElevationAngleRequest` | `SolarElevationAngleResponse` | [زاوية ارتفاع الشمس](https://dev.qweather.com/docs/api/astronomy/solar-elevation-angle/) |

### لوحة التحكم

| أسلوب SDK | فئة Request | فئة Response | توثيق QWeather |
|----------|------------|-------------|----------------|
| `FinanceSummaryAsync` | `FinanceSummaryRequest` | `FinanceSummaryResponse` | [الملخص المالي](https://dev.qweather.com/docs/api/console/finance/) |
| `MetricsStatsAsync` | `MetricsStatsRequest` | `MetricsStatsResponse` | [إحصاءات الطلبات](https://dev.qweather.com/docs/api/console/stats/) |

---

---

# 日本語

# QWeather Sparrow.Qweather .NET SDK ドキュメント

## インストール
```cmd
dotnet add package Sparrow.Qweather
```

## 初期化

```csharp
public static WebApiClient WebApiClient()
{
    string folderPath = @"cert";
    string relativeFilePath = @"あなたの秘密鍵証明書";

    string certPath = Path.GetFullPath(Path.Combine(folderPath, relativeFilePath)); // 証明書パス
    var options = new WebApiOptions()
    {
        Host     = "あなたのAPI Host",
        Kid      = "あなたのプロジェクトID",
        Sub      = "あなたのクレデンシャルID",
        CertPath = certPath           // 証明書パス
    };

    var client = WebApiClientBuilder.Create(options).Build();
    return client;
}
```

## 使用例

```csharp
using Sparrow.Qweather.Client;
using Sparrow.Qweather.Example;
using Sparrow.Qweather.Tools;

var request =
    new Sparrow.Qweather.Models.Request.Weather.WeatherNowRequest
    {
        Location = "101010100",
    }; // リアルタイム天気クエリ

var response = await WebApiClientSetting.WebApiClient().WeatherNowAsync(request);
var json = JsonTool.SerializeWithNullFilter(response);
Console.WriteLine(json);
```

## SDK メソッドと QWeather API の対応表

### 地理位置情報 GeoAPI

| SDK メソッド | Request クラス | Response クラス | QWeather ドキュメント |
|------------|--------------|----------------|----------------------|
| `CityLookUpAsync` | `CityLookUpRequest` | `CityLookUpResponse` | [都市検索](https://dev.qweather.com/docs/api/geoapi/city-lookup/) |
| `CityTopAsync` | `CityTopRequest` | `CityTopResponse` | [人気都市](https://dev.qweather.com/docs/api/geoapi/top-city/) |
| `PoiLookUpAsync` | `PoiLookUpRequest` | `PoiLookUpResponse` | [POI 検索](https://dev.qweather.com/docs/api/geoapi/poi-lookup/) |
| `PoiRangeAsync` | `PoiRangeRequest` | `PoiRangeReponse` | [POI 範囲検索](https://dev.qweather.com/docs/api/geoapi/poi-range/) |

### 天気予報

| SDK メソッド | Request クラス | Response クラス | QWeather ドキュメント |
|------------|--------------|----------------|----------------------|
| `WeatherNowAsync` | `WeatherNowRequest` | `WeatherNowResponse` | [現在の天気](https://dev.qweather.com/docs/api/weather/weather-now/) |
| `WeatherDaysAsync` | `WeatherDaysRequest` | `WeatherDaysResponse` | [日別予報](https://dev.qweather.com/docs/api/weather/weather-daily-forecast/)（3d/7d/10d/15d/30d） |
| `WeatherHoursAsync` | `WeatherHoursRequest` | `WeatherHoursResponse` | [時間別予報](https://dev.qweather.com/docs/api/weather/weather-hourly-forecast/)（3h/6h/12h/24h） |
| `GridWeatherNowAsync` | `GridWeatherNowRequest` | `GridWeatherNowResponse` | [グリッド現在天気](https://dev.qweather.com/docs/api/weather/grid-weather-now/) |
| `GridWeatherDaysAsync` | `GridWeatherDaysRequest` | `GridWeatherDaysResponse` | [グリッド日別予報](https://dev.qweather.com/docs/api/weather/grid-weather-daily-forecast/)（3d/7d） |
| `GridWeatherHoursAsync` | `GridWeatherHoursRequest` | `GridWeatherHoursResponse` | [グリッド時間別予報](https://dev.qweather.com/docs/api/weather/grid-weather-hourly-forecast/)（24h/72h） |

### 分単位予報

| SDK メソッド | Request クラス | Response クラス | QWeather ドキュメント |
|------------|--------------|----------------|----------------------|
| `Minutely5mAsync` | `Minutely5mRequset` | `Minutely5mResponse` | [分単位降水](https://dev.qweather.com/docs/api/minutely/minutely-5m/) |

### 気象警報

| SDK メソッド | Request クラス | Response クラス | QWeather ドキュメント |
|------------|--------------|----------------|----------------------|
| `WeatheralertCurrentAsync` | `WeatheralertCurrentRequest` | `WeatheralertCurrentResponse` | [気象警報](https://dev.qweather.com/docs/api/warning/weather-alert/) |

### 気象指数

| SDK メソッド | Request クラス | Response クラス | QWeather ドキュメント |
|------------|--------------|----------------|----------------------|
| `IndicesForecastAsync` | `IndicesForecastRequest` | `IndicesForecastResponse` | [指数予報](https://dev.qweather.com/docs/api/indices/indices-forecast/) |

### 大気質

| SDK メソッド | Request クラス | Response クラス | QWeather ドキュメント |
|------------|--------------|----------------|----------------------|
| `AirCurrentAsync` | `AirCurrentRequest` | `AirCurrentResponse` | [現在の大気質](https://dev.qweather.com/docs/api/air-quality/air-current/) |
| `AirHourlyForecastAsync` | `AirHourlyForecastRequest` | `AirHourlyForecastResponse` | [時間別大気質予報](https://dev.qweather.com/docs/api/air-quality/air-hourly-forecast/) |

### タイムマシン（履歴データ）

| SDK メソッド | Request クラス | Response クラス | QWeather ドキュメント |
|------------|--------------|----------------|----------------------|
| `HistoricalWeatherAsync` | `HistoricalWeatherRequest` | `HistoricalWeatherResponse` | [過去の天気](https://dev.qweather.com/docs/api/time-machine/time-machine-weather/) |
| `HistoricalAirAsync` | `HistoricalAirRequest` | `HistoricalAirResponse` | [過去の大気質](https://dev.qweather.com/docs/api/time-machine/time-machine-air/) |

### 熱帯低気圧（台風）

| SDK メソッド | Request クラス | Response クラス | QWeather ドキュメント |
|------------|--------------|----------------|----------------------|
| `StormForecastAsync` | `StormForecastRequest` | `StormForecastResponse` | [台風予報](https://dev.qweather.com/docs/api/tropical-cyclone/storm-forecast/) |
| `StormTrackAsync` | `StormTrackRequest` | `StormTrackResponse` | [台風経路](https://dev.qweather.com/docs/api/tropical-cyclone/storm-track/) |
| `StormListAsync` | `StormListRequest` | `StormListResponse` | [台風リスト](https://dev.qweather.com/docs/api/tropical-cyclone/storm-list/) |

### 海洋データ

| SDK メソッド | Request クラス | Response クラス | QWeather ドキュメント |
|------------|--------------|----------------|----------------------|
| `TideAsync` | `TideRequest` | `TideResponse` | [潮汐](https://dev.qweather.com/docs/api/ocean/tide/) |

### 太陽放射

| SDK メソッド | Request クラス | Response クラス | QWeather ドキュメント |
|------------|--------------|----------------|----------------------|
| `SolarRadiationForecastAsync` | `SolarRadiationForecastRequest` | `SolarRadiationForecastResponse` | [太陽放射予報](https://dev.qweather.com/docs/api/solar-radiation/solar-radiation-forecast/) |

### 天文

| SDK メソッド | Request クラス | Response クラス | QWeather ドキュメント |
|------------|--------------|----------------|----------------------|
| `SunAsync` | `SunRequest` | `SunResponse` | [日の出・日の入り](https://dev.qweather.com/docs/api/astronomy/sunrise-sunset/) |
| `MoonAsync` | `MoonRequest` | `MoonResponse` | [月の出・月の入り・月相](https://dev.qweather.com/docs/api/astronomy/moon-and-moon-phase/) |
| `SolarElevationAngleAsync` | `SolarElevationAngleRequest` | `SolarElevationAngleResponse` | [太陽高度角](https://dev.qweather.com/docs/api/astronomy/solar-elevation-angle/) |

### コンソール

| SDK メソッド | Request クラス | Response クラス | QWeather ドキュメント |
|------------|--------------|----------------|----------------------|
| `FinanceSummaryAsync` | `FinanceSummaryRequest` | `FinanceSummaryResponse` | [財務概要](https://dev.qweather.com/docs/api/console/finance/) |
| `MetricsStatsAsync` | `MetricsStatsRequest` | `MetricsStatsResponse` | [リクエスト統計](https://dev.qweather.com/docs/api/console/stats/) |

---

---

# 한국어

# QWeather Sparrow.Qweather .NET SDK 문서

## 설치
```cmd
dotnet add package Sparrow.Qweather
```

## 초기화

```csharp
public static WebApiClient WebApiClient()
{
    string folderPath = @"cert";
    string relativeFilePath = @"개인키_인증서";

    string certPath = Path.GetFullPath(Path.Combine(folderPath, relativeFilePath)); // 인증서 경로
    var options = new WebApiOptions()
    {
        Host     = "API Host",
        Kid      = "프로젝트 ID",
        Sub      = "자격증명 ID",
        CertPath = certPath           // 인증서 경로
    };

    var client = WebApiClientBuilder.Create(options).Build();
    return client;
}
```

## 사용 예제

```csharp
using Sparrow.Qweather.Client;
using Sparrow.Qweather.Example;
using Sparrow.Qweather.Tools;

var request =
    new Sparrow.Qweather.Models.Request.Weather.WeatherNowRequest
    {
        Location = "101010100",
    }; // 실시간 날씨 조회

var response = await WebApiClientSetting.WebApiClient().WeatherNowAsync(request);
var json = JsonTool.SerializeWithNullFilter(response);
Console.WriteLine(json);
```

## SDK 메서드와 QWeather API 대응 목록

### 지리 위치 GeoAPI

| SDK 메서드 | Request 클래스 | Response 클래스 | QWeather 문서 |
|----------|--------------|----------------|--------------|
| `CityLookUpAsync` | `CityLookUpRequest` | `CityLookUpResponse` | [도시 검색](https://dev.qweather.com/docs/api/geoapi/city-lookup/) |
| `CityTopAsync` | `CityTopRequest` | `CityTopResponse` | [인기 도시](https://dev.qweather.com/docs/api/geoapi/top-city/) |
| `PoiLookUpAsync` | `PoiLookUpRequest` | `PoiLookUpResponse` | [POI 검색](https://dev.qweather.com/docs/api/geoapi/poi-lookup/) |
| `PoiRangeAsync` | `PoiRangeRequest` | `PoiRangeReponse` | [POI 범위 검색](https://dev.qweather.com/docs/api/geoapi/poi-range/) |

### 날씨 예보

| SDK 메서드 | Request 클래스 | Response 클래스 | QWeather 문서 |
|----------|--------------|----------------|--------------|
| `WeatherNowAsync` | `WeatherNowRequest` | `WeatherNowResponse` | [현재 날씨](https://dev.qweather.com/docs/api/weather/weather-now/) |
| `WeatherDaysAsync` | `WeatherDaysRequest` | `WeatherDaysResponse` | [일별 예보](https://dev.qweather.com/docs/api/weather/weather-daily-forecast/)（3d/7d/10d/15d/30d） |
| `WeatherHoursAsync` | `WeatherHoursRequest` | `WeatherHoursResponse` | [시간별 예보](https://dev.qweather.com/docs/api/weather/weather-hourly-forecast/)（3h/6h/12h/24h） |
| `GridWeatherNowAsync` | `GridWeatherNowRequest` | `GridWeatherNowResponse` | [격자 현재 날씨](https://dev.qweather.com/docs/api/weather/grid-weather-now/) |
| `GridWeatherDaysAsync` | `GridWeatherDaysRequest` | `GridWeatherDaysResponse` | [격자 일별 예보](https://dev.qweather.com/docs/api/weather/grid-weather-daily-forecast/)（3d/7d） |
| `GridWeatherHoursAsync` | `GridWeatherHoursRequest` | `GridWeatherHoursResponse` | [격자 시간별 예보](https://dev.qweather.com/docs/api/weather/grid-weather-hourly-forecast/)（24h/72h） |

### 분 단위 예보

| SDK 메서드 | Request 클래스 | Response 클래스 | QWeather 문서 |
|----------|--------------|----------------|--------------|
| `Minutely5mAsync` | `Minutely5mRequset` | `Minutely5mResponse` | [분 단위 강수](https://dev.qweather.com/docs/api/minutely/minutely-5m/) |

### 기상 경보

| SDK 메서드 | Request 클래스 | Response 클래스 | QWeather 문서 |
|----------|--------------|----------------|--------------|
| `WeatheralertCurrentAsync` | `WeatheralertCurrentRequest` | `WeatheralertCurrentResponse` | [기상 경보](https://dev.qweather.com/docs/api/warning/weather-alert/) |

### 날씨 지수

| SDK 메서드 | Request 클래스 | Response 클래스 | QWeather 문서 |
|----------|--------------|----------------|--------------|
| `IndicesForecastAsync` | `IndicesForecastRequest` | `IndicesForecastResponse` | [지수 예보](https://dev.qweather.com/docs/api/indices/indices-forecast/) |

### 대기질

| SDK 메서드 | Request 클래스 | Response 클래스 | QWeather 문서 |
|----------|--------------|----------------|--------------|
| `AirCurrentAsync` | `AirCurrentRequest` | `AirCurrentResponse` | [현재 대기질](https://dev.qweather.com/docs/api/air-quality/air-current/) |
| `AirHourlyForecastAsync` | `AirHourlyForecastRequest` | `AirHourlyForecastResponse` | [시간별 대기질 예보](https://dev.qweather.com/docs/api/air-quality/air-hourly-forecast/) |

### 타임머신 (역사 데이터)

| SDK 메서드 | Request 클래스 | Response 클래스 | QWeather 문서 |
|----------|--------------|----------------|--------------|
| `HistoricalWeatherAsync` | `HistoricalWeatherRequest` | `HistoricalWeatherResponse` | [과거 날씨](https://dev.qweather.com/docs/api/time-machine/time-machine-weather/) |
| `HistoricalAirAsync` | `HistoricalAirRequest` | `HistoricalAirResponse` | [과거 대기질](https://dev.qweather.com/docs/api/time-machine/time-machine-air/) |

### 열대성 저기압 (태풍)

| SDK 메서드 | Request 클래스 | Response 클래스 | QWeather 문서 |
|----------|--------------|----------------|--------------|
| `StormForecastAsync` | `StormForecastRequest` | `StormForecastResponse` | [태풍 예보](https://dev.qweather.com/docs/api/tropical-cyclone/storm-forecast/) |
| `StormTrackAsync` | `StormTrackRequest` | `StormTrackResponse` | [태풍 경로](https://dev.qweather.com/docs/api/tropical-cyclone/storm-track/) |
| `StormListAsync` | `StormListRequest` | `StormListResponse` | [태풍 목록](https://dev.qweather.com/docs/api/tropical-cyclone/storm-list/) |

### 해양 데이터

| SDK 메서드 | Request 클래스 | Response 클래스 | QWeather 문서 |
|----------|--------------|----------------|--------------|
| `TideAsync` | `TideRequest` | `TideResponse` | [조석](https://dev.qweather.com/docs/api/ocean/tide/) |

### 태양 복사

| SDK 메서드 | Request 클래스 | Response 클래스 | QWeather 문서 |
|----------|--------------|----------------|--------------|
| `SolarRadiationForecastAsync` | `SolarRadiationForecastRequest` | `SolarRadiationForecastResponse` | [태양 복사 예보](https://dev.qweather.com/docs/api/solar-radiation/solar-radiation-forecast/) |

### 천문

| SDK 메서드 | Request 클래스 | Response 클래스 | QWeather 문서 |
|----------|--------------|----------------|--------------|
| `SunAsync` | `SunRequest` | `SunResponse` | [일출·일몰](https://dev.qweather.com/docs/api/astronomy/sunrise-sunset/) |
| `MoonAsync` | `MoonRequest` | `MoonResponse` | [월출·월몰 및 월상](https://dev.qweather.com/docs/api/astronomy/moon-and-moon-phase/) |
| `SolarElevationAngleAsync` | `SolarElevationAngleRequest` | `SolarElevationAngleResponse` | [태양 고도각](https://dev.qweather.com/docs/api/astronomy/solar-elevation-angle/) |

### 콘솔

| SDK 메서드 | Request 클래스 | Response 클래스 | QWeather 문서 |
|----------|--------------|----------------|--------------|
| `FinanceSummaryAsync` | `FinanceSummaryRequest` | `FinanceSummaryResponse` | [재무 요약](https://dev.qweather.com/docs/api/console/finance/) |
| `MetricsStatsAsync` | `MetricsStatsRequest` | `MetricsStatsResponse` | [요청량 통계](https://dev.qweather.com/docs/api/console/stats/) |
