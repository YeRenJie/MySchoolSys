using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MySchool.AdminForm
{
    public partial class FrmModifyPwd : Form
    {
        #region  常量、字段、属性定义
        public const string CAPTION = "输入提示";
        public User user; // 当前登录的用户
        #endregion

        public FrmModifyPwd()
        {
            InitializeComponent();
        }

        #region 处理事件
        /// <summary>
        /// 响应“返回”按钮事件
        /// </summary>       
        private void btnReturn_Click(object sender, EventArgs e)
        {
            //关闭当前窗体
            this.Close();
        }       

        /// <summary>
        /// 点击“更新”按钮时
        /// </summary>       
        private void btnUpdatePwd_Click(object sender, EventArgs e)
        {
            bool result = false; // 更新结果
            
            //检查密码是否与登录密码一致
            if (CheckOldPwd() && CheckNewPwd())
            {
                result = UpdateInfoByPwd();
                if (result == true)
                {
                    MessageBox.Show("修改成功！", CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改失败，请重试！", CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } 
        }
        #endregion

        #region 方法 
        /// <summary>
        /// 检查密码是否与登录密码一致
        /// </summary>        
        /// <returns>true:一致,false:不一致</returns>
        public bool CheckOldPwd()
        {
            if (txtOldPwd.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入原密码！", CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOldPwd.Focus();
                return false;
            }
            else if (txtOldPwd.Text.Trim().Equals (this.user.UserPwd))
            {
                return true;
            }
            else
            {
                MessageBox.Show("原密码错误！", CAPTION,MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtOldPwd.Focus();
                return false;
            }
        }

        /// <summary>
        /// 检查新旧密码是否一致
        /// </summary>        
        /// <returns>true:一致,false:不一致</returns>
        public bool CheckNewPwd()
        {
            if (txtNewPwd.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入新密码！", CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPwd.Focus();
                return false;
            }
            else if (txtReNewPwd.Text.Trim().Equals(txtNewPwd.Text.Trim()))
            {
                return true;
            }
            else
            {
                MessageBox.Show("两次输入的密码不一致！", CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtReNewPwd.Focus();
                return false;
            }
        }
        
        /// <summary>
        /// 将新密码更新到数据库中
        /// </summary>        
        /// <returns>true:更新成功,false:更新失败</returns>
        public bool UpdateInfoByPwd()
        {
            bool success = false; // 更新结果
            StringBuilder sql = new StringBuilder();  // SQL 语句

            //创建数据库连接
            DBHelper dbhelper = new DBHelper();            

            try
            {
                //系统管理员修改密码
                if (this.user.Type == LoginType.Admin)
                {
                    sql.AppendFormat("UPDATE [Admin] SET [LoginPwd] = '{0}' WHERE [LoginId] ='{1}'",
                        txtNewPwd.Text.Trim(),this.user.UserId);
                }
                //学生修改密码
                else if (this.user.Type == LoginType.Student)
                {
                    sql.AppendFormat("UPDATE [Student] SET [LoginPwd] = '{0}' WHERE [StudentNo] ='{1}'",
                        txtNewPwd.Text.Trim(), this.user.UserId);                    
                }

                dbhelper.OpenConnection();
                //创建Command
                SqlCommand command = new SqlCommand(sql.ToString(),dbhelper.Connection);              

                int result = command.ExecuteNonQuery(); // 执行sql语句

                // 返回的值小于1，说明没有记录被影响，操作失败
                if(result == 1)
                {
                    success = true;
                }
            }
            catch (Exception ex)
            {
                success = false;
            }
            finally   
            {
                //关闭数据库连接
                dbhelper.CloseConnection();
            }
            return success;
        }
        #endregion
    }
}
