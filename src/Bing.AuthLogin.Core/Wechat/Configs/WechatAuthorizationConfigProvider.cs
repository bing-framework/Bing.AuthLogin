using Bing.AuthLogin.Configs;

namespace Bing.AuthLogin.Wechat.Configs
{
    /// <summary>
    /// 微信授权配置提供程序
    /// </summary>
    internal class WechatAuthorizationConfigProvider : AuthorizationConfigProviderBase<WechatAuthorizationConfig>, IWechatAuthorizationConfigProvider
    {
        /// <summary>
        /// 初始一个<see cref="WechatAuthorizationConfigProvider"/>类型的实例
        /// </summary>
        /// <param name="config">微信授权配置</param>
        public WechatAuthorizationConfigProvider(WechatAuthorizationConfig config) : base(config)
        {
        }
    }
}
