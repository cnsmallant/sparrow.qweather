using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace Sparrow.Qweather.Tools
{
    /// <summary>
    /// 实体转换请求参数
    /// </summary>
    public static class QueryStringTool
    {

        /// <summary>
        /// 将实体对象转换为GET请求查询字符串
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="t">要转换的实体对象</param>
        /// <param name="prefix">参数前缀（用于嵌套对象，默认为空）</param>
        /// <param name="ignoreNullValues">是否忽略null值（默认为true）</param>
        /// <returns>URL编码的查询字符串（不包含开头的?）</returns>
        public static string ToQueryString<T>(
            this T t,
            string prefix = "",
            bool ignoreNullValues = true
        )
            where T : class
        {
            if (t == null)
            {
                return string.Empty;
            }

            var properties = t.GetType()
                .GetProperties()
                .Where(p => p.CanRead && p.GetValue(t, null) != null)
                .ToArray();

            var queryStringList = new List<string>();

            foreach (var property in properties)
            {

                var value = property.GetValue(t, null);

                // 如果值为null且设置为忽略null值，则跳过
                if (value == null && ignoreNullValues)
                {
                    continue;
                }

                string key;
                if (string.IsNullOrEmpty(prefix))
                {
                    key = property.GetDescription().ToLower();
                }
                else
                {
                    key = $"{prefix}.{property.GetDescription().ToLower()}";
                }

                // 处理简单类型
                if (IsSimpleType(property.PropertyType))
                {
                    queryStringList.Add(
                        $"{key}={value.ToString()}"
                    );
                }
                // 处理集合类型（数组、列表等）
                else if (typeof(IEnumerable).IsAssignableFrom(property.PropertyType))
                {
                    var collection = value as IEnumerable;
                    int index = 0;
                    foreach (var item in collection)
                    {
                        if (IsSimpleType(item.GetType()))
                        {
                            queryStringList.Add(
                                $"{key}[{index}]={item.ToString()}"
                            );
                        }
                        else
                        {
                            // 递归处理复杂集合项
                            queryStringList.Add(
                                item.ToQueryString($"{key}[{index}]", ignoreNullValues)
                            );
                        }
                        index++;
                    }
                }
                // 处理复杂对象类型（嵌套对象）
                else
                {
                    // 递归处理嵌套对象
                    queryStringList.Add(value.ToQueryString(key, ignoreNullValues));
                }
            }
            queryStringList = queryStringList.OrderBy(x => x).ToList();
            return string.Join("&", queryStringList);
        }

        /// <summary>
        /// 判断类型是否为简单类型（值类型、字符串、日期等）
        /// </summary>
        /// <param name="type">要检查的类型</param>
        /// <returns>如果是简单类型返回true，否则返回false</returns>
        private static bool IsSimpleType(Type type)
        {
            if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                // 可空类型，获取基础类型
                type = type.GetGenericArguments()[0];
            }

            return type.IsPrimitive
                || type.IsEnum
                || type == typeof(string)
                || type == typeof(decimal)
                || type == typeof(DateTime)
                || type == typeof(DateTimeOffset)
                || type == typeof(TimeSpan)
                || type == typeof(Guid);
        }
        /// <summary>
        ///  根据类型和属性名获取 [Description] 特性值
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        public static string GetDescription(this PropertyInfo property)
        {
            return property.GetCustomAttribute<DescriptionAttribute>()?.Description ?? property.Name;
        }
    }
}
