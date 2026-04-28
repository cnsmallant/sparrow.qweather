using Sparrow.Qweather.Models.Options;

namespace Sparrow.Qweather.Client
{
    /// <summary>
    /// 接口客户端编译
    /// </summary>
    public class WebApiClientBuilder
    {
        private readonly WebApiOptions _options;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="options"></param>
        public WebApiClientBuilder(WebApiOptions options)
        {
            _options = options;
        }

        /// <summary>
        /// 创建接口客户端
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public static WebApiClientBuilder Create(WebApiOptions options)
        {
            return new WebApiClientBuilder(options);
        }

        /// <summary>
        /// 编译接口客户端
        /// </summary>
        /// <returns></returns>
        public WebApiClient Build()
        {
            return new WebApiClient(_options);
        }
    }
}