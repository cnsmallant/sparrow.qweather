using System;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Sparrow.Qweather.Tools
{
    /// <summary>
    /// 签名
    /// </summary>
    public static class SignatureTool
    {
        /// <summary>
        /// 生成 JWT Token
        /// </summary>
        /// <param name="kid"></param>
        /// <param name="sub"></param>
        /// <param name="certPath"></param>
        /// <param name="exp"></param>
        /// <returns></returns>
        /// <exception cref="FileNotFoundException"></exception>
        public static string GenerateJwtToken(string kid, string sub, string certPath, long exp = 86400)
        {
            // 1. 构建私钥文件的绝对路径
            string privateKeyPath = Path.Combine(certPath);

            if (!File.Exists(privateKeyPath))
            {
                throw new FileNotFoundException($"私钥文件未找到: {privateKeyPath}");
            }

            // 2. 读取 PEM 格式的私钥文件 Jose.JWT 库需要的是原始的字节数据，或者特定格式的字符串 这里我们读取文件内容并去除头尾标记
            string privateKeyPem = File.ReadAllText(privateKeyPath);

            // ── 1. 构造 Header ────────────────────────────────────────────── alg 固定为 EdDSA；kid 为凭据
            // ID；不添加 typ/iss/aud/nbf
            var header = new { alg = "EdDSA", kid = kid };

            // ── 2. 构造 Payload ─────────────────────────────────────────────
            long now = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            long iat = now - 30; // 当前时间提前 30 秒，容忍时钟误差

            var payload = new
            {
                sub = sub,
                iat = iat,
                exp = iat + exp
            };

            // ── 3. Base64URL 编码 Header 和 Payload ────────────────────────
            string headerB64 = Base64UrlEncode(JsonSerializer.SerializeToUtf8Bytes(header));
            string payloadB64 = Base64UrlEncode(JsonSerializer.SerializeToUtf8Bytes(payload));
            string signingInput = $"{headerB64}.{payloadB64}";

            // ── 4. Ed25519 签名 ─────────────────────────────────────────────
            byte[] signingBytes = Encoding.ASCII.GetBytes(signingInput);
            byte[] signature = SignWithNSec(privateKeyPem, signingBytes);
            string sigB64 = Base64UrlEncode(signature);

            // ── 5. 拼接最终 Token ───────────────────────────────────────────
            return $"{signingInput}.{sigB64}";
        }

        /// <summary>
        /// 使用 NSec 库对数据进行签名
        /// </summary>
        /// <param name="privateKeyPem"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static byte[] SignWithNSec(string privateKeyPem, byte[] data)
        {
            // 从 PEM 中提取 PKCS#8 DER 字节
            byte[] derBytes = PemToDer(privateKeyPem, "PRIVATE KEY");

            var algorithm = NSec.Cryptography.SignatureAlgorithm.Ed25519;
            //using var key = NSec.Cryptography.Key.Import(
            //    algorithm,
            //    derBytes,
            //    NSec.Cryptography.KeyBlobFormat.PkixPrivateKey
            //);
            using (
                var key = NSec.Cryptography.Key.Import(
                    algorithm,
                    derBytes,
                    NSec.Cryptography.KeyBlobFormat.PkixPrivateKey
                )
            )
            {
                return algorithm.Sign(key, data);
            }
        }

        /// <summary>
        /// Base64URL 编码（RFC 4648 §5，无填充 '='）
        /// </summary>
        public static string Base64UrlEncode(byte[] input)
        {
            return Convert.ToBase64String(input).TrimEnd('=').Replace('+', '-').Replace('/', '_');
        }

        /// <summary>
        /// Base64URL 解码
        /// </summary>
        public static byte[] Base64UrlDecode(string input)
        {
            string padded = input.Replace('-', '+').Replace('_', '/');
            switch (padded.Length % 4)
            {
                case 2:
                    padded += "==";
                    break;

                case 3:
                    padded += "=";
                    break;
            }
            return Convert.FromBase64String(padded);
        }

        /// <summary>
        /// 将 PEM 字符串解析为 DER 字节（去除头尾行并 Base64 解码）
        /// </summary>
        private static byte[] PemToDer(string pem, string label)
        {
            string header = $"-----BEGIN {label}-----";
            string footer = $"-----END {label}-----";
            string base64 = pem.Replace(header, "")
                .Replace(footer, "")
                .Replace("\r\n", "")
                .Replace("\n", "")
                .Trim();
            return Convert.FromBase64String(base64);
        }
    }
}