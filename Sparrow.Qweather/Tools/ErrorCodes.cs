using System.Collections.Generic;

namespace Sparrow.Qweather.Tools
{
    /// <summary>
    /// 高德地图Web API错误码说明
    /// 根据高德地图官方文档生成：https://lbs.amap.com/api/webservice/guide/tools/info/
    /// 最后更新时间：2025-09-10
    /// </summary>
    public static class ErrorCodes
    {
        /// <summary>
        /// 高德地图API错误码字典 (使用info返回值作为key)
        /// </summary>
        public static readonly Dictionary<string, ErrorInfo> ErrorDictionary = new Dictionary<
            string,
            ErrorInfo
        >
        {
            // 使用 info 返回值作为 key
            { "OK", new ErrorInfo("10000", "OK", "请求正常", "请求正常") },
            {
                "INVALID_USER_KEY",
                new ErrorInfo("10001", "INVALID_USER_KEY", "key不正确或过期", "开发者发起请求时，传入的key不正确或者过期")
            },
            {
                "SERVICE_NOT_AVAILABLE",
                new ErrorInfo(
                    "10002",
                    "SERVICE_NOT_AVAILABLE",
                    "没有权限使用相应的服务或者请求接口的路径拼写错误",
                    "1.开发者没有权限使用相应的服务。2.开发者请求接口的路径拼写错误。"
                )
            },
            {
                "DAILY_QUERY_OVER_LIMIT",
                new ErrorInfo(
                    "10003",
                    "DAILY_QUERY_OVER_LIMIT",
                    "访问已超出日访问量",
                    "开发者的日访问量超限，被系统自动封停，第二天0:00会自动解封。"
                )
            },
            {
                "ACCESS_TOO_FREQUENT",
                new ErrorInfo(
                    "10004",
                    "ACCESS_TOO_FREQUENT",
                    "单位时间内访问过于频繁",
                    "开发者的单位时间内（1分钟）访问量超限，被系统自动封停，下一分钟自动解封。"
                )
            },
            {
                "INVALID_USER_IP",
                new ErrorInfo(
                    "10005",
                    "INVALID_USER_IP",
                    "IP白名单出错，发送请求的服务器IP不在IP白名单内",
                    "开发者在LBS官网控制台设置的IP白名单不正确。可到\"控制台>配置\"中设定IP白名单。"
                )
            },
            {
                "INVALID_USER_DOMAIN",
                new ErrorInfo("10006", "INVALID_USER_DOMAIN", "绑定域名无效", "开发者绑定的域名无效，需要在官网控制台重新设置")
            },
            {
                "INVALID_USER_SIGNATURE",
                new ErrorInfo(
                    "10007",
                    "INVALID_USER_SIGNATURE",
                    "数字签名未通过验证",
                    "开发者签名未通过开发者在key控制台中，开启了\"数字签名\"功能，但没有按照指定算法生成\"数字签名\"。"
                )
            },
            {
                "USERKEY_PLAT_NOMATCH",
                new ErrorInfo(
                    "10009",
                    "USERKEY_PLAT_NOMATCH",
                    "请求key与绑定平台不符",
                    "请求中使用的key与绑定平台不符，例如：开发者申请的是js api的key，却用来调web服务接口"
                )
            },
            {
                "INVALID_PARAMS",
                new ErrorInfo(
                    "20000",
                    "INVALID_PARAMS",
                    "请求参数非法",
                    "请求参数的值没有按照规范要求填写。例如，某参数值域范围为[1,3],开发者误填了'4'"
                )
            },
            {
                "MISSING_REQUIRED_PARAMS",
                new ErrorInfo("20001", "MISSING_REQUIRED_PARAMS", "缺少必填参数", "缺少接口中要求的必填参数")
            },
            {
                "ILLEGAL_REQUEST",
                new ErrorInfo(
                    "20002",
                    "ILLEGAL_REQUEST",
                    "请求协议非法",
                    "请求协议非法比如某接口仅支持get请求，结果用了POST方式"
                )
            },
            { "UNKNOWN_ERROR", new ErrorInfo("20003", "UNKNOWN_ERROR", "其他未知错误", "其他未知错误") },
            {
                "INSUFFICIENT_ABROAD_PRIVILEGES",
                new ErrorInfo(
                    "20011",
                    "INSUFFICIENT_ABROAD_PRIVILEGES",
                    "查询坐标或规划点在海外，但没有海外地图权限",
                    "使用逆地理编码接口、输入提示接口、周边搜索接口、路径规划接口时可能出现该问题"
                )
            },
            {
                "ILLEGAL_CONTENT",
                new ErrorInfo(
                    "20012",
                    "ILLEGAL_CONTENT",
                    "查询信息存在非法内容",
                    "使用搜索接口时可能出现该问题，通常是由于查询内容非法导致"
                )
            },
            {
                "OUT_OF_SERVICE",
                new ErrorInfo(
                    "20800",
                    "OUT_OF_SERVICE",
                    "规划点不在中国陆地范围内",
                    "使用路径规划服务接口时可能出现该问题，规划点不在中国陆地范围内"
                )
            },
            {
                "NO_ROADS_NEARBY",
                new ErrorInfo("20801", "NO_ROADS_NEARBY", "划点附近搜不到路", "使用路径规划服务接口时可能出现该问题，划点附近搜不到路")
            },
            {
                "ROUTE_FAIL",
                new ErrorInfo(
                    "20802",
                    "ROUTE_FAIL",
                    "路线计算失败，通常是由于道路连通关系导致",
                    "使用路径规划服务接口时可能出现该问题，路线计算失败，通常是由于道路连通关系导致"
                )
            },
            {
                "OVER_DIRECTION_RANGE",
                new ErrorInfo(
                    "20803",
                    "OVER_DIRECTION_RANGE",
                    "起点终点距离过长",
                    "使用路径规划服务接口时可能出现该问题，路线计算失败，通常是由于道路起点和终点距离过长导致。"
                )
            },
            {
                "ENGINE_RESPONSE_DATA_ERROR",
                new ErrorInfo(
                    "300**",
                    "ENGINE_RESPONSE_DATA_ERROR",
                    "服务响应失败",
                    "出现3开头的错误码，建议先检查传入参数是否正确，若无法解决，请提工单。"
                )
            },
            {
                "QUOTA_PLAN_RUN_OUT",
                new ErrorInfo("40000", "QUOTA_PLAN_RUN_OUT", "余额耗尽", "所购买服务的余额耗尽，无法继续使用服务")
            },
            {
                "SERVICE_EXPIRED",
                new ErrorInfo("40002", "SERVICE_EXPIRED", "购买服务到期", "所购买的服务期限已到，无法继续使用")
            },
            {
                "ABROAD_QUOTA_PLAN_RUN_OUT",
                new ErrorInfo(
                    "40003",
                    "ABROAD_QUOTA_PLAN_RUN_OUT",
                    "海外服务余额耗尽",
                    "所购买服务的海外余额耗尽，无法继续使用服务"
                )
            }
            // ... 可以根据高德官方文档继续添加其他 info 返回值对应的错误项
        };

        /// <summary>
        /// 根据错误码获取错误信息
        /// </summary>
        /// <param name="errorCode">错误码</param>
        /// <returns>错误信息对象</returns>
        public static ErrorInfo GetErrorInfo(this string errorCode)
        {
            if (ErrorDictionary.ContainsKey(errorCode))
            {
                return ErrorDictionary[errorCode];
            }

            // 处理通配符情况（如300**）
            if (errorCode.Length >= 2 && errorCode.StartsWith("30"))
            {
                return ErrorDictionary["300**"];
            }

            return new ErrorInfo(
                "UNKNOWN",
                errorCode,
                "未知的 info 返回值",
                "请参考高德地图官方 API 文档或检查您的请求参数。"
            );
        }

        /// <summary>
        /// 错误信息类
        /// </summary>
        public class ErrorInfo
        {
            public string Infocode { get; set; } // 错误码，例如 "10001"
            public string InfoValue { get; set; } // info 返回值，例如 "INVALID_USER_KEY"
            public string Message { get; set; } // 错误描述
            public string Solution { get; set; } // 解决方案

            public ErrorInfo(string infocode, string infoValue, string message, string solution)
            {
                Infocode = infocode;
                InfoValue = infoValue;
                Message = message;
                Solution = solution;
            }

            public override string ToString()
            {
                return $"Infocode: {Infocode}, Info返回值: {InfoValue}, 描述: {Message}, 解决方案: {Solution}";
            }
        }
    }
}
