using Sparrow.Qweather.Client;
using Sparrow.Qweather.Models.Options;

namespace Sparrow.Qweather.Example
{
    public class WebApiClientSetting
    {
        public static WebApiClient WebApiClient()
        {
            //string folderPath = @"cert";
            //string relativeFilePath = @"您的私钥证书";

            //string certPath = Path.GetFullPath(Path.Combine(folderPath, relativeFilePath));//证书路径
            //var options = new WebApiOptions()
            //{
            //    Host = "您的API Host",
            //    Kid = "您的项目ID",
            //    Sub = "您的凭据ID",
            //    CertPath = certPath//证书路径
            //};

            //var client = WebApiClientBuilder.Create(options).Build();
            //return client;

            string folderPath = @"cert";
            string relativeFilePath = @"ed25519-private.pem";

            string certPath = Path.GetFullPath(Path.Combine(folderPath, relativeFilePath));//证书路径
            var options = new WebApiOptions()
            {
                Host = "mq5g7dtuj5.re.qweatherapi.com",
                Kid = "CN584P7RBD",
                Sub = "4K85Y9T2W9",
                CertPath = certPath//证书路径
            };

            var client = WebApiClientBuilder.Create(options).Build();
            return client;
        }
    }
}