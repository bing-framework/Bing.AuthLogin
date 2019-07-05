using System.Threading.Tasks;
using Bing.AuthLogin.Parameters;

namespace Bing.AuthLogin.Operations
{
    /// <summary>
    /// 授权地址提供程序
    /// </summary>
    /// <typeparam name="TAuthorizationParam">授权参数</typeparam>
    public interface IAuthorizationUrlProvider<in TAuthorizationParam> where TAuthorizationParam : IAuthorizationParam
    {
        /// <summary>
        /// 生成授权地址
        /// </summary>
        Task<string> GenerateUrlAsync();

        /// <summary>
        /// 生成授权地址
        /// </summary>
        /// <param name="param">授权参数</param>
        Task<string> GenerateUrlAsync(TAuthorizationParam param);
    }
}
