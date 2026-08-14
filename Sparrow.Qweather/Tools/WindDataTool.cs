using System;
using System.Collections.Generic;
using System.Text;

namespace Sparrow.Qweather.Tools
{
    /// <summary>
    /// 风向信息
    /// </summary>
    public class WindDirectionInfo
    {
        /// <summary>
        /// 风向描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 风向角度
        /// </summary>
        public double? Angle { get; set; } // 对应角度（度），无持续风向和变化不定为null

        /// <summary>
        /// 风向范围
        /// </summary>
        public (double Min, double Max)? Range { get; set; } // 角度范围（度），无持续风向和变化不定为null
    }

    /// <summary>
    /// 风向信息
    /// </summary>
    public static class WindDataTool
    {
        /// <summary>
        /// 风向信息字典
        /// </summary>
        public static readonly Dictionary<string, WindDirectionInfo> WindDirections =
            new Dictionary<string, WindDirectionInfo>
            {
                {
                    "n",
                    new WindDirectionInfo
                    {
                        Description = "北风",
                        Angle = 0,
                        Range = (348.75, 11.25)
                    }
                },
                {
                    "nne",
                    new WindDirectionInfo
                    {
                        Description = "东北偏北风",
                        Angle = 22.5,
                        Range = (11.25, 33.75)
                    }
                },
                {
                    "ne",
                    new WindDirectionInfo
                    {
                        Description = "东北风",
                        Angle = 45,
                        Range = (33.75, 56.25)
                    }
                },
                {
                    "ene",
                    new WindDirectionInfo
                    {
                        Description = "东北偏东风",
                        Angle = 67.5,
                        Range = (56.25, 78.75)
                    }
                },
                {
                    "e",
                    new WindDirectionInfo
                    {
                        Description = "东风",
                        Angle = 90,
                        Range = (78.75, 101.25)
                    }
                },
                {
                    "ese",
                    new WindDirectionInfo
                    {
                        Description = "东南偏东风",
                        Angle = 112.5,
                        Range = (101.25, 123.75)
                    }
                },
                {
                    "se",
                    new WindDirectionInfo
                    {
                        Description = "东南风",
                        Angle = 135,
                        Range = (123.75, 146.25)
                    }
                },
                {
                    "sse",
                    new WindDirectionInfo
                    {
                        Description = "东南偏南风",
                        Angle = 157.5,
                        Range = (146.25, 168.75)
                    }
                },
                {
                    "s",
                    new WindDirectionInfo
                    {
                        Description = "南风",
                        Angle = 180,
                        Range = (168.75, 191.25)
                    }
                },
                {
                    "ssw",
                    new WindDirectionInfo
                    {
                        Description = "西南偏南风",
                        Angle = 202.5,
                        Range = (191.25, 213.75)
                    }
                },
                {
                    "sw",
                    new WindDirectionInfo
                    {
                        Description = "西南风",
                        Angle = 225,
                        Range = (213.75, 236.25)
                    }
                },
                {
                    "wsw",
                    new WindDirectionInfo
                    {
                        Description = "西南偏西风",
                        Angle = 247.5,
                        Range = (236.25, 258.75)
                    }
                },
                {
                    "w",
                    new WindDirectionInfo
                    {
                        Description = "西风",
                        Angle = 270,
                        Range = (258.75, 281.25)
                    }
                },
                {
                    "wnw",
                    new WindDirectionInfo
                    {
                        Description = "西北偏西风",
                        Angle = 292.5,
                        Range = (281.25, 303.75)
                    }
                },
                {
                    "nw",
                    new WindDirectionInfo
                    {
                        Description = "西北风",
                        Angle = 315,
                        Range = (303.75, 326.25)
                    }
                },
                {
                    "nnw",
                    new WindDirectionInfo
                    {
                        Description = "西北偏北风",
                        Angle = 337.5,
                        Range = (326.25, 348.75)
                    }
                },
                {
                    "none",
                    new WindDirectionInfo
                    {
                        Description = "无持续风向",
                        Angle = null,
                        Range = null
                    }
                },
                {
                    "vrb",
                    new WindDirectionInfo
                    {
                        Description = "风向变化不定",
                        Angle = null,
                        Range = null
                    }
                }
            };
    }
}