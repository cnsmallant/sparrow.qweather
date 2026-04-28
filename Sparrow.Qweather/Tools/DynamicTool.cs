using System;
using System.Collections.Generic;

namespace Sparrow.Qweather.Tools
{
    /// <summary>
    /// dynamic转换具体实体帮助类
    /// </summary>
    public static class DynamicTool
    {
        public static T ToEntity<T>(object obj) where T : new()
        {
            var entity = new T();
            var entityType = typeof(T);
            var properties = entityType.GetProperties();

            foreach (var prop in properties)
            {
                // 获取 object 对象中的对应属性值
                var value = GetPropertyValue(obj, prop.Name);

                if (value != null)
                {
                    // 设置实体类属性值
                    prop.SetValue(entity, Convert.ChangeType(value, prop.PropertyType), null);
                }
            }

            return entity;
        }

        private static object GetPropertyValue(object obj, string propertyName)
        {
            try
            {
                // 如果是 ExpandoObject
                if (obj is IDictionary<string, object> expando)
                {
                    return expando.ContainsKey(propertyName) ? expando[propertyName] : null;
                }

                // 如果是普通对象
                return obj.GetType().GetProperty(propertyName)?.GetValue(obj);
            }
            catch
            {
                return null;
            }
        }
    }
}