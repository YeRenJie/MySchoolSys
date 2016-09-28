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
    public partial class FrmEditStudent : Form
    {
        #region 常量定义        
        public const string CAPTION = "操作提示";
        public int studentNo = -1;  // 学号
        #endregion

        public FrmEditStudent()
        {
            InitializeComponent();
            if (this.studentNo == -1)
            {
                this.Text = "添加学生信息";
            }
        }        

        #region 事件处理
        /// <summary>
        /// “登录”按钮按下
        /// </summary>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //非空验证
            if (!CheckInput())
            {
                return;
            }

            if (this.studentNo == -1)
            {
                // 增加学生信息
                bool result = InsertStudent();
                if (result)
                {
                    MessageBox.Show("增加学生成功！", CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }
                else
                {
                    MessageBox.Show("增加失败，请重试！", CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // 更新学生信息               
                bool result = UpdateStudent();
                if (result)
                {
                    MessageBox.Show("更新学生成功！", CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("更新失败，请重试！", CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } 
        }

        /// <summary>
        /// 清空所有的输入
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtAddress.Text = string.Empty;            
            this.txtEmail.Text = string.Empty;
            this.txtName.Text = string.Empty;
            this.txtPhone.Text = string.Empty;
            this.txtPwd.Text = string.Empty;
            this.txtRePwd.Text = string.Empty;
            if (this.studentNo != -1)
            {
                this.txtStudentNo.Text = string.Empty;
            }
        }

        /// <summary>
        /// 窗体加载
        /// </summary>
        private void FrmAddStrudent_Load(object sender, EventArgs e)
        {
            // 绑定年级数据
            BindGrade();

            // 为更新信息，将原来的信息读取显示在窗体上
            if (this.studentNo != -1)
            {
                ShowStudent();
            }            
        }
        #endregion

        #region 方法
        /// <summary>
        /// 输入验证
        /// </summary>
        /// <returns>验证通过返回True，验证失败返回False</returns>
        public bool CheckInput()
        {
            //验证密码非空
            if (this.txtPwd.Text.Trim().Equals(string.Empty) || this.txtRePwd.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入密码！", CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtPwd.Focus();
                return false;
            }
            if (!this.txtPwd.Text.Trim().Equals(this.txtRePwd.Text.Trim()))
            {
                MessageBox.Show("两次输入的密码不一致！", CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtPwd.Focus();
                return false;
            }
            //验证姓名非空
            if (this.txtName.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入姓名！", CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtName.Focus();
                return false;
            }
            //性别非空
            if (!this.rbtnMale.Checked  &&  !this.rbtnFemale.Checked)
            {
                MessageBox.Show("请选择性别！", CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.rbtnMale.Focus();
                return false;          
            }
            //验证年级非空
            if (this.cboGrade.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请选择年级！", CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboGrade.Focus();
                return false;
            }            
            //Email输入非空验证格式是否包含“@”
            if (!this.txtEmail.Text.Trim().Equals(string.Empty))
            {
                if (!this.txtEmail.Text.Contains("@"))
                {
                    MessageBox.Show("电子邮件格式不正确！", CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtEmail.Focus();
                    return false;
                }
            }            
            return true;           
        } 
       
        /// <summary>
        /// 将输入数据插入学生表中
        /// </summary>        
        /// <returns>true：成功，false：失败</returns>
        public bool InsertStudent()
        {
            bool success = false;  // 返回值，表示是否添加成功

            // 获取数据
            string pwd = this.txtPwd.Text.Trim(); // 密码
            string name = this.txtName.Text.Trim(); // 学生姓名
            
            //获取性别
            Gender gender;
            if (this.rbtnFemale.Checked)
            {
                gender = Gender.Female;
            }
            else
            {
                gender = Gender.Male;
            }
            int genderId = (int)gender;

            int gradeId = Convert.ToInt32(this.cboGrade.SelectedValue); // 年级
            string phone = this.txtPhone.Text.Trim(); // 电话
            string address = this.txtAddress.Text.Trim(); // 地址
            DateTime date = this.dpBirthday.Value;  // 出生日期
            string birthday = string.Format("{0}-{1}-{2}", date.Year, date.Month, date.Day);
            string email = this.txtEmail.Text.Trim(); // 电子邮件

            //创建数据库连接            
            DBHelper dbhelper = new DBHelper();            

            try
            {
                // 构建 SQL 语句
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("INSERT INTO [Student] ([LoginPwd],[StudentName],[Gender],[GradeId] ,[Phone],[Address] ,[Birthday] ,[Email]) ");
                sql.AppendFormat(" VALUES('{0}','{1}',{2},{3},'{4}','{5}','{6}','{7}')",
                    pwd, name, genderId, gradeId, phone, address, birthday, email);               
                                                           
                // 创建command对象
                SqlCommand command = new SqlCommand(sql.ToString(), dbhelper.Connection);

                Console.WriteLine(sql.ToString());
                // 打开数据库连接
                dbhelper.OpenConnection();

                // 执行命令
                int result = command.ExecuteNonQuery();

                // 根据操作结果给出提示信息
                if (result == 1)
                {
                    // 获得学号
                    string sqlNo = "SELECT @@IDENTITY FROM [Student] ";
                    command.CommandText = sqlNo;
                    int studentNo = Convert.ToInt32(command.ExecuteScalar()); // 学号
                    this.txtStudentNo.Text = studentNo.ToString();                    
                    success = true;
                }                
            }
            catch (Exception)
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

        /// <summary>
        /// 将输入数据更新到学生表中
        /// </summary>        
        /// <returns>true：成功，false：失败</returns>
        public bool UpdateStudent()
        {
            bool success = false;  // 返回值，表示是否添加成功

            // 获取数据
            string pwd = this.txtPwd.Text.Trim(); // 密码
            string name = this.txtName.Text.Trim(); // 学生姓名

            //获取性别
            Gender gender;
            if (this.rbtnFemale.Checked)
            {
                gender = Gender.Female;
            }
            else
            {
                gender = Gender.Male;
            }
            int genderId = (int)gender;

            int gradeId = Convert.ToInt32(this.cboGrade.SelectedValue); // 年级
            string phone = this.txtPhone.Text.Trim(); // 电话
            string address = this.txtAddress.Text.Trim(); // 地址
            DateTime date = this.dpBirthday.Value;  // 出生日期
            string birthday = string.Format("{0}-{1}-{2}", date.Year, date.Month, date.Day);
            string email = this.txtEmail.Text.Trim(); // 电子邮件

            //创建数据库连接            
            DBHelper dbhelper = new DBHelper();

            try
            {
                // 构建 SQL 语句
                StringBuilder sql = new StringBuilder();
                sql.AppendFormat("UPDATE [Student] SET [LoginPwd]='{0}'",pwd); 
                sql.AppendFormat(" ,[StudentName]='{0}'",name);
                sql.AppendFormat(" ,[Gender]='{0}'", genderId);
                sql.AppendFormat(" ,[GradeId]='{0}'",gradeId);
                sql.AppendFormat(" ,[Phone]='{0}'",phone);
                sql.AppendFormat(" ,[Address]='{0}'",address);
                sql.AppendFormat(" ,[Birthday]='{0}'",birthday);
                sql.AppendFormat(" ,[Email]='{0}'",email);
                sql.AppendFormat(" WHERE [StudentNo]={0}",this.studentNo);

                // 创建command对象
                SqlCommand command = new SqlCommand(sql.ToString(), dbhelper.Connection);

                // 打开数据库连接
                dbhelper.OpenConnection();

                // 执行命令
                int result = command.ExecuteNonQuery();

                // 根据操作结果给出提示信息
                if (result == 1)
                {
                    success = true;
                }                
            }
            catch (Exception)
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

        /// <summary>
        /// 年级名称的绑定
        /// </summary>
        /// <returns>true：成功；false：失败</returns>
        public bool BindGrade()
        {
            //创建数据库连接            
            DBHelper dbhelper = new DBHelper();            

            try
            {
                // 查询年级的sql语句
                string sql = "SELECT * FROM [Grade]";

                // 打开数据库连接
                dbhelper.OpenConnection();                

                //填充DataSet
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sql, dbhelper.Connection);
                da.Fill(ds,"Grade");

                //绑定数据源
                this.cboGrade.DataSource = ds.Tables[0];
                this.cboGrade.ValueMember = "GradeId";
                this.cboGrade.DisplayMember = "GradeName";
                
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("系统发生错误！", CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            finally
            {
                //关闭连接
                dbhelper.CloseConnection();
            }
        }

        /// <summary>
        /// 显示学生信息
        /// </summary>
        public void ShowStudent()
        {
            string sql = "SELECT * FROM [Student] WHERE [StudentNo]=" + this.studentNo; // 构建 SQL 语句
            DBHelper dbHelper = new DBHelper();
            try
            {
                SqlCommand command = new SqlCommand(sql, dbHelper.Connection);
                dbHelper.OpenConnection();
                SqlDataReader reader = command.ExecuteReader();
                // 将学生的信息显示在窗体上
                if (reader.Read())
                {
                    this.txtStudentNo.Text = reader["StudentNo"].ToString();
                    this.txtPwd.Text = reader["LoginPwd"].ToString();
                    this.txtRePwd.Text = this.txtPwd.Text;
                    this.txtName.Text = reader["StudentName"].ToString();
                    int genderId = Convert.ToInt32(reader["Gender"]);
                    if (genderId == (int)Gender.Male)
                    {
                        rbtnMale.Checked = true;
                    }
                    else
                    {
                        rbtnFemale.Checked = true;
                    }
                    cboGrade.SelectedValue = Convert.ToInt32(reader["GradeId"]);
                    txtPhone.Text = reader["Phone"].ToString();                    
                    txtAddress.Text = reader["Address"].ToString();
                    dpBirthday.Value = Convert.ToDateTime(reader["Birthday"]);
                    txtEmail.Text = reader["Email"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("系统出现错误！", CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                dbHelper.CloseConnection();
            }
        }
        #endregion
    }
}
