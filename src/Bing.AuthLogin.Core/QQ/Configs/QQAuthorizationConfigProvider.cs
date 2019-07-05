﻿using Bing.AuthLogin.Configs;

namespace Bing.AuthLogin.QQ.Configs
{
    /// <summary>
    /// QQ 授权配置提供程序
    /// </summary>
    internal class QQAuthorizationConfigProvider : AuthorizationConfigProviderBase<QQAuthorizationConfig>, IQQAuthorizationConfigProvider
    {
        /// <summary>
        /// 初始化一个<see cref="QQAuthorizationConfigProvider"/>类型的实例
        /// </summary>
        /// <param name="config">QQ 授权配置</param>
        public QQAuthorizationConfigProvider(QQAuthorizationConfig config) : base(config)
        {
        }
    }
}
