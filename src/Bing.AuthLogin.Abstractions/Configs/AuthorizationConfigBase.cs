﻿using System.ComponentModel.DataAnnotations;

namespace Bing.AuthLogin.Configs
{
    /// <summary>
    /// 授权配置基类
    /// </summary>
    public abstract class AuthorizationConfigBase : IAuthorizationConfig
    {
        /// <summary>
        /// 应用标识
        /// </summary>
        [Required(ErrorMessage = "应用标识[AppId]不能为空")]
        public virtual string AppId { get; set; }

        /// <summary>
        /// 应用密钥
        /// </summary>
        [Required(ErrorMessage = "应用密钥[AppKey]不能为空")]
        public virtual string AppKey { get; set; }

        /// <summary>
        /// 回调地址
        /// </summary>
        [Required(ErrorMessage = "回调地址[CallbackUrl]不能为空")]
        public virtual string CallbackUrl { get; set; }

        /// <summary>
        /// 授权地址
        /// </summary>
        [Required(ErrorMessage = "授权地址[AuthorizationUrl]不能为空")]
        public string AuthorizationUrl { get; set; }

        /// <summary>
        /// 获取授权令牌地址
        /// </summary>
        [Required(ErrorMessage = "获取授权令牌地址[AccessTokenUrl]不能为空")]
        public string AccessTokenUrl { get; set; }

        /// <summary>
        /// 验证
        /// </summary>
        public virtual void Validate()
        {

        }
    }
}
