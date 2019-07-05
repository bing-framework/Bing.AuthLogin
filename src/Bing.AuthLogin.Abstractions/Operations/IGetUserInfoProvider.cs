using System.Threading.Tasks;
using Bing.AuthLogin.Parameters;
using Bing.AuthLogin.Results;

namespace Bing.AuthLogin.Operations
{
    /// <summary>
    /// 获取用户信息提供程序
    /// </summary>
    /// <typeparam name="TAuthorizationUserParam">授权用户参数</typeparam>
    /// <typeparam name="TUserInfoResult">用户信息结果</typeparam>
    public interface IGetUserInfoProvider<in TAuthorizationUserParam, TUserInfoResult>
        where TAuthorizationUserParam : IAuthorizationUserParam 
        where TUserInfoResult : IUserInfoResult
    {
        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="param">授权用户参数</param>
        Task<TUserInfoResult> GetUserInfoAsync(TAuthorizationUserParam param);
    }
}
