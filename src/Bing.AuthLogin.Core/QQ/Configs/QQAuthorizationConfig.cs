using Bing.AuthLogin.Configs;

namespace Bing.AuthLogin.QQ.Configs
{
    /// <summary>
    /// QQ 授权配置
    /// </summary>
    public class QQAuthorizationConfig : AuthorizationConfigBase
    {
        /// <summary>
        /// 初始化一个<see cref="QQAuthorizationConfig"/>类型的实例
        /// </summary>
        public QQAuthorizationConfig()
        {
            AuthorizationUrl = "https://graph.qq.com/oauth2.0/authorize";
            AccessTokenUrl = "https://graph.qq.com/oauth2.0/token";
        }
    }
}
