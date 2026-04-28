using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sparrow.Qweather.Tools
{
    /// <summary>
    /// 服务工厂
    /// </summary>
    public static class ServiceFactoryTool
    {
        private static readonly ConcurrentDictionary<Type, Type> ImplementationCache =
            new ConcurrentDictionary<Type, Type>();

        /// <summary>
        /// 根据接口类型自动获取对应的实现类实例（无参构造）
        /// </summary>
        public static T GetService<T>()
            where T : class
        {
            var interfaceType = typeof(T);
            var implType = ImplementationCache.GetOrAdd(interfaceType, ResolveImplementation);
            return (T)Activator.CreateInstance(implType);
        }

        private static Type ResolveImplementation(Type interfaceType)
        {
            // 约定1: 接口名去掉首字母 I，如 IGeoService -> GeoService
            var simpleName = interfaceType.Name;
            if (simpleName.StartsWith("I") && simpleName.Length > 1)
            {
                var expectedClassName = simpleName.Substring(1);
                var candidate = interfaceType.Assembly.GetType(
                    $"Sparrow.Qweather.Service.{expectedClassName}"
                );
                if (IsValidImplementation(candidate, interfaceType))
                {
                    return candidate;
                }
            }

            return interfaceType;
        }

        private static bool IsValidImplementation(Type type, Type interfaceType)
        {
            return type != null && !type.IsAbstract && interfaceType.IsAssignableFrom(type);
        }
    }
}