namespace Bing.AuthLogin.Parameters
{
    /// <summary>
    /// 授权参数
    /// </summary>
    public interface IAuthorizationParam
    {
        /// <summary>
        /// 授权类型
        /// </summary>
        string ResponseType { get; set; }

        /// <summary>
        /// 重定向地址
        /// </summary>
        string RedirectUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        string State { get; set; }

        /// <summary>
        /// 初始化
        /// </summary>
        void Init();

        /// <summary>
        /// 转换为授权参数
        /// </summary>
        /// <typeparam name="T">授权参数类型</typeparam>
        T ToParam<T>() where T : IAuthorizationParam;
    }
}
