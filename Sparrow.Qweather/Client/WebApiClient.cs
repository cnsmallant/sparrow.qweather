using Sparrow.Qweather.Models.Options;

namespace Sparrow.Qweather.Client
{
    /// <summary>
    /// 接口客户端
    /// </summary>
    public class WebApiClient
    {
        private readonly WebApiOptions _options;

        /// <summary>
        /// 接口客户端构造函数
        /// </summary>
        /// <param name="options"></param>
        public WebApiClient(WebApiOptions options)
        {
            _options = options;
        }

        /// <summary>
        /// 获取配置选项
        /// </summary>
        public WebApiOptions Options => _options;
    }
}