using System.Threading.Tasks;
using Bing.AuthLogin.Parameters;
using Bing.AuthLogin.Results;

namespace Bing.AuthLogin.Operations
{
    /// <summary>
    /// 获取访问令牌提供程序
    /// </summary>
    /// <typeparam name="TAccessTokenParam">访问令牌参数类型</typeparam>
    /// <typeparam name="TAccessTokenResult">访问令牌结果类型</typeparam>
    public interface IAccessTokenProvider<in TAccessTokenParam, TAccessTokenResult> where TAccessTokenParam : IAccessTokenParam where TAccessTokenResult : IAccessTokenResult
    {
        /// <summary>
        /// 获取访问令牌
        /// </summary>
        /// <param name="param">访问令牌参数</param>
        Task<TAccessTokenResult> GetTokenAsync(TAccessTokenParam param);
    }
}
