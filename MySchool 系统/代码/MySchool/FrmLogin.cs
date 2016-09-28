using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient ;
using MySchool.StudentForm;

namespace MySchool
{
    public partial class FrmLogin : Form
    {
        #region  常量定义
        public const string CAPTION = "输入提示";
        public const string ADMIN = "系统管理员";
        public const string STUDENT = "学生";
        #endregion

        public FrmLogin()
        {
            InitializeComponent();
            cboLoginType.SelectedIndex = 0;
        }        

        #region 处理事件
        /// <summary>
        /// 响应“登录”按钮事件
        /// </summary>        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //用户名、密码和用户类型都不为空
            if (CheckInput())
            {
                string message = string.Empty; // 表示验证的消息
                //检索用户名、密码是否存在
                //if (CheckUser(ref message))
                if (CheckUser2(ref message))
                {
                    // 创建一个用户对象，代表当前登录的用户
                    User user = new User();

                    //分别显示系统管理员和学生主窗体
                    if (this.cboLoginType.Text.Equals(ADMIN))
                    {
                        FrmAdminMain frmAdmin = new FrmAdminMain();
                        // 数据传递
                        user.UserId = txtUserName.Text.Trim();
                        user.UserPwd = txtPwd.Text.Trim();
                        user.Type = LoginType.Admin;
                        frmAdmin.user = user;

                        frmAdmin.Show();
                    }
                    else if (this.cboLoginType.Text.Equals(STUDENT))
                    {
                        FrmStudentMain frmStudent = new FrmStudentMain();
                        // 数据传递
                        user.UserId = txtUserName.Text.Trim();
                        user.UserPwd = txtPwd.Text.Trim();
                        user.Type = LoginType.Student;
                        frmStudent.user = user;
                         
                        frmStudent.Show();
                    }                    
                    // 隐藏登录窗体
                    this.Hide();
                }
                else
                {
                    // 弹出提示消息
                    MessageBox.Show(message, CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }            
        }
        
        /// <summary>
        /// 响应“取消”按钮事件
        /// </summary>        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 输入验证
        /// <summary>
        /// 用户名、密码和用户类型的非空验证
        /// </summary>
        /// <returns>True都不为空，False其中一个为空</returns>
        public bool CheckInput()
        {
            //用户名为空
            if (this.txtUserName.Text.Trim ().Equals (string.Empty) )
            {
                MessageBox.Show("请输入用户名", CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtUserName.Focus();
                return false;
            }

            //密码为空
            else if (this.txtPwd.Text .Trim ().Equals (string.Empty))
            {
                MessageBox.Show("请输入密码", CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtPwd.Focus();
                return false;
            }

            //用户类型为空
            else if (this.cboLoginType .Text .Trim ().Equals (string.Empty ))
            {
                 MessageBox.Show("请选择登录类型", CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                 this.cboLoginType.Focus();
                 return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 检索用户名、密码是否存在
        /// </summary>        
        /// <param name="message">提示的消息</param>
        /// <returns>True：检索到用户，False：没有检索到用户</returns>
        public bool CheckUser(ref string message)
        {
            bool isValidUser = false; // 表示验证是否通过
            string userName = txtUserName.Text.Trim(); // 输入的用户名
            string userPwd = txtPwd.Text.Trim();  // 输入的密码

            // 确定查询用的SQL语句
            StringBuilder sb = new StringBuilder(); // 查询用的SQL语句
            if (cboLoginType.Equals(ADMIN)) //系统管理员登录
            {
                sb.AppendFormat("SELECT COUNT(*) FROM [Admin] WHERE [LoginId]='{0}' AND [LoginPwd]='{1}'",
                    userName,userPwd);
               
            }
            else if (cboLoginType.Equals(STUDENT)) //学生登录
            {
                sb.AppendFormat("SELECT COUNT(*) FROM [Student] WHERE [StudentNo]='{0}' AND [LoginPwd]='{1}'",
                    userName, userPwd);               
            }            

            // 执行查询
            int count = 0;  // 数据库查询的结果
            DBHelper dbhelper = new DBHelper(); 
            try
            {
                // 创建Command命令
                SqlCommand command = new SqlCommand(sb.ToString(),dbhelper.Connection);
                // 打开连接
                dbhelper.OpenConnection();
                // 执行查询语句
                count = (int)command.ExecuteScalar();

                // 如果结果 〉0，验证通过，否则是非法用户
                if (count > 0)
                {
                    isValidUser = true;
                }
                else
                {
                    message = "用户名或密码不存在！";
                    isValidUser = false;
                }
            }
            catch (Exception ex)
            {
                message = "系统发生错误，请稍后再试！";
                isValidUser = false;
            }
            finally
            {
                //关闭数据库连接
                dbhelper.CloseConnection();
            }

            return isValidUser;
        }

        /// <summary>
        /// 分别检查用户名、密码是否存在
        /// </summary>        
        /// <param name="message">提示的消息</param>
        /// <returns>True：检索到用户，False：没有检索到用户</returns>
        public bool CheckUser2(ref string message)
        {
            bool isValidUser = false; // 表示验证是否通过
            string userName = txtUserName.Text.Trim(); // 输入的用户名
            string userPwd = txtPwd.Text.Trim();  // 输入的密码

            // 确定查询用的SQL语句
            StringBuilder sqlLoginId = new StringBuilder(); // 查询用户名的SQL语句
            StringBuilder sqlLoginPwd = new StringBuilder();// 查询密码的SQL语句

            if (cboLoginType.SelectedItem.ToString().Equals(ADMIN)) //系统管理员登录
            {
                sqlLoginId.AppendFormat("SELECT COUNT(*) FROM [Admin] WHERE [LoginId]='{0}'",userName);
                sqlLoginPwd.AppendFormat("SELECT COUNT(*) FROM [Admin] WHERE [LoginId]='{0}' AND [LoginPwd]='{1}'",
                    userName,userPwd);

            }
            else if (cboLoginType.SelectedItem.ToString().Equals(STUDENT)) //学生登录
            {
                sqlLoginId.AppendFormat("SELECT COUNT(*) FROM [Student] WHERE [StudentNo]='{0}'",userName);
                sqlLoginPwd.AppendFormat("SELECT COUNT(*) FROM [Student] WHERE [StudentNo]='{0}' AND [LoginPwd]='{1}'",
                    userName, userPwd);
            }

            // 执行查询
            int count = 0;  // 数据库查询的结果
            DBHelper dbhelper = new DBHelper();
            try
            {
                // 创建Command命令
                SqlCommand command = new SqlCommand(sqlLoginId.ToString(), dbhelper.Connection);
                // 打开连接
                dbhelper.OpenConnection();
                // 查询用户名是否存在
                count = (int)command.ExecuteScalar();

                // 如果结果 〉0，验证通过，否则是非法用户
                if (count > 0)
                {
                    // 查询密码是否正确
                    command.CommandText = sqlLoginPwd.ToString();
                    count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        isValidUser = true;
                    }
                    else
                    {
                        message = "密码错误！";
                    }                    
                }
                else
                {
                    message = "用户名不存在！";
                    isValidUser = false;
                }
            }
            catch (Exception ex)
            {
                message = "系统发生错误，请稍后再试！";
                isValidUser = false;
            }
            finally
            {
                //关闭数据库连接
                dbhelper.CloseConnection();
            }

            return isValidUser;
        }    
        #endregion
    }
}
