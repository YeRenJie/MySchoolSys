using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySchool
{
    /// <summary>
    /// 枚举：代表登录类型
    /// </summary>
    public enum LoginType
    {
        Admin,  // 管理员
        Student // 学生
    }

    /// <summary>
    /// 代表登录的用户
    /// </summary>
    public class User
    {
        private string userId; // 学号
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        private string userPwd; // 密码
        /// <summary>
        /// 密码
        /// </summary>
        public string UserPwd
        {
            get { return userPwd; }
            set { userPwd = value; }
        }

        private LoginType type; // 登录类型
        /// <summary>
        /// 登录类型
        /// </summary>
        public LoginType Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}
