using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sparrow.Qweather.Tools
{
    /// <summary>
    /// JSON工具
    /// </summary>
    public static class JsonTool
    {
        /// <summary>
        /// 反序列化 JSON 字符串到指定类型，并过滤掉 null 值字段
        /// </summary>
        /// <typeparam name="T">目标类型</typeparam>
        /// <param name="@this">JSON 字符串</param>
        /// <returns>反序列化后的对象</returns>
        public static T DeserializeWithNullFilter<T>(this string @this)
        {
            var options = new JsonSerializerOptions
            {
                // 设置反序列化时忽略 JSON 中的 null 值
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                // 允许大小写不敏感匹配属性名
                PropertyNameCaseInsensitive = true,
                // 读取 JSON 时忽略额外字段
                ReadCommentHandling = JsonCommentHandling.Skip,
                WriteIndented = true,
            };

            return JsonSerializer.Deserialize<T>(@this, options);
        }

        /// <summary>
        /// 实体序列换成JSON，并过滤掉 null 值字段
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="this"></param>
        /// <returns></returns>
        public static string SerializeWithNullFilter<T>(this T @this)
        {
            var options = new JsonSerializerOptions
            {
                // 设置反序列化时忽略 JSON 中的 null 值
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                // 允许大小写不敏感匹配属性名
                PropertyNameCaseInsensitive = true,
                // 读取 JSON 时忽略额外字段
                ReadCommentHandling = JsonCommentHandling.Skip,
                WriteIndented = true,
            };

            return JsonSerializer.Serialize(@this);
        }
    }
}
