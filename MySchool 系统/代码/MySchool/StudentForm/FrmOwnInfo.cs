using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MySchool.StudentForm
{
    public partial class FrmOwnInfo : Form
    {
        #region 常量定义
        public const string CAPTION = "操作提示";
        public User user;  // 表示当前登录的用户
        #endregion

        public FrmOwnInfo()
        {
            InitializeComponent();
        }        

        #region 事件处理
        /// <summary>
        /// 窗体加载
        /// </summary>      
        private void FrmOwnInfor_Load(object sender, EventArgs e)
        {
            //检索该学生的所有信息
            GetStudentInfor();
        }

        /// <summary>
        /// 点击“返回”按钮时
        /// </summary>        
        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 检索学生所有信息
        /// <summary>
        /// 检索该学生的所有信息
        /// </summary>
        public void  GetStudentInfor()
        {
            // 查询学生信息的sql语句
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("SELECT  A.[StudentNo] ,A.[LoginPwd] ,A.[StudentName] ,A.[Sex] ,B.[GradeName] ,A.[Phone] ,A.[Adress],A.[BornDate],A.[Email]");
            sql.AppendLine("  FROM [Student] AS A,[Grade]  AS  B");
            sql.AppendLine(" WHERE A.[GradeId] = B.[GradeId]");
            sql.AppendFormat(" AND A.[StudentNo] = '{0}'",this.user.UserId);

            //实例化SqlConnection
            DBHelper dbhelper = new DBHelper(); 

            // 设置command命令执行的语句
            SqlCommand command = new SqlCommand(sql.ToString(),dbhelper.Connection);

            try
            {
                // 打开数据库连接
                dbhelper.OpenConnection();
                
                // 执行查询
                SqlDataReader dataReader = command.ExecuteReader();

                // 读出所有信息
                if (dataReader.Read())
                {
                    this.txtStuNo.Text = Convert.ToString(dataReader["StudentNo"]);
                    this.txtPwd.Text = Convert.ToString(dataReader["LoginPwd"]);
                    this.txtStuNo.Text = Convert.ToString(dataReader["StudentName"]);
                    this.txtSex.Text = Convert.ToString(dataReader["Sex"]);
                    this.txtGrade.Text = Convert.ToString(dataReader["GradeName"]);
                    this.txtPhone.Text = Convert.ToString(dataReader["Phone"]);
                    this.txtAddress.Text = Convert.ToString(dataReader["Adress"]);
                    string strDate= Convert.ToString(dataReader["BornDate"]);
                    this.txtBornDate.Text =strDate.Substring (0,8);
                    this.txtEmail.Text = Convert.ToString(dataReader["Email"]);
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("系统发生错误！", CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                dbhelper.CloseConnection();
            }
        }
        #endregion
    }
}
