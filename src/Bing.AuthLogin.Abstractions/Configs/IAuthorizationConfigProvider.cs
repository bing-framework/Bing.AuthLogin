using System.Threading.Tasks;

namespace Bing.AuthLogin.Configs
{
    /// <summary>
    /// 授权配置提供程序
    /// </summary>
    /// <typeparam name="TAuthorizationConfig">授权配置类型</typeparam>
    public interface IAuthorizationConfigProvider<TAuthorizationConfig> where TAuthorizationConfig : IAuthorizationConfig
    {
        /// <summary>
        /// 获取配置
        /// </summary>
        Task<TAuthorizationConfig> GetConfigAsync();
    }
}
