namespace Sparrow.Qweather.Models.Options
{
    /// <summary>
    /// Web服务选项
    /// </summary>
    public class WebApiOptions
    {
        /// <summary>
        /// 请求协议 仅支持HTTPS协议
        /// </summary>
        public string Scheme { get; set; } = "https://";

        /// <summary>
        /// Host都是独立、唯一的，同时API Host也是身份认证的一部分，这意味着即使开发者的凭据泄露了，盗用者如果不知道API Host也是无法请求数据的。查看你的API
        /// Host你可以在控制台 - 设置中查看你的API Host，API Host 看起来像是：abc1234xyz.def.qweatherapi.com
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// 语言
        /// </summary>
        public string Lang { get; set; } = "zh";

        /// <summary>
        /// 项目ID，你可以在控制台-项目管理中查看
        /// </summary>
        public string Kid { get; set; }

        /// <summary>
        /// 凭据ID，你可以在控制台-项目管理中查看
        /// </summary>
        public string Sub { get; set; }

        /// <summary>
        /// 密钥文件路径
        /// </summary>
        public string CertPath { get; set; }
    }
}