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
    public partial class FrmAddResult : Form
    {
        #region 常量和全局变量的定义
        public const string CAPTION = "操作提示";
        public int studentNo; // 学号
        private DataSet ds;   // 数据集
        #endregion     

        public FrmAddResult()
        {
            InitializeComponent();
        }        

        #region 事件处理
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmAddResult_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
            //科目的绑定
            BindSubject();

            // 显示所有成绩
            BindResult();
        }

        /// <summary>
        /// 点击“添加”按钮时
        /// </summary>
        private void btnAddResult_Click(object sender, EventArgs e)
        {
            //非空检查
            if (CheckInput())
            {
                //添加学生成绩
                InsertResult();
               
                //学生成绩的绑定
                BindResult();
            }
        }

        /// <summary>
        /// 点击“返回”按钮时
        /// </summary>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 方法
        /// <summary>
        /// 科目的绑定
        /// </summary>
        public void BindSubject()
        {
            //创建数据库连接            
            DBHelper dbhelper = new DBHelper();
            
            try
            {
                // 查询科目的sql语句
                string sql = "SELECT [SubjectId],[SubjectName] FROM [Subject]";

                // 打开数据库连接
                dbhelper.OpenConnection();
                
                //填充DataSet
                SqlDataAdapter adapter = new SqlDataAdapter(sql, dbhelper.Connection);
                ds = new DataSet();
                adapter.Fill(ds, "Subject");

                //绑定数据源
                this.cboSubject.DataSource = ds.Tables["Subject"];
                this.cboSubject.ValueMember = "SubjectId";
                this.cboSubject.DisplayMember = "SubjectName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("系统发生错误！", CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Warning);               
            }
            finally
            {
                //关闭连接
                dbhelper.CloseConnection();
            }
        }

        /// <summary>
        /// 学生成绩的绑定
        /// </summary>
        public void BindResult()
        {
            //创建数据库连接
            DBHelper dbhelper = new DBHelper();
            
            try
            {
                // 查询年级的sql语句
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT S.[StudentName] ,B.[SubjectName],R.[StudentResult] ,R.[ExamDate]");
                sql.AppendLine("  FROM [Student] AS S,[Result]  AS  R,[Subject]  AS B");
                sql.AppendLine("  WHERE S.[StudentNo]=R.[StudentNo] ");
                sql.AppendLine("  AND R.[SubjectId]=B.[SubjectId]");
                sql.AppendFormat(" AND S.[StudentNo]={0}", this.studentNo);
                
                // 填充DataSet
                SqlDataAdapter adapter = new SqlDataAdapter(sql.ToString(),dbhelper.Connection);

                // 如果数据表已经存在，清空数据
                if (ds.Tables["Result"] != null)
                {
                    ds.Tables["Result"].Clear();
                }
                adapter.Fill(ds, "Result");

                //绑定数据源
                this.dgvResult.DataSource = ds.Tables["Result"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("系统发生错误！", CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Warning);               
            }
        }       

        /// <summary>
        /// 非空检查
        /// </summary>
        /// <returns>true：成功；false：失败</returns>
        public bool CheckInput()
        {
            //科目选择不得为空
            if (this.cboSubject .Text .Equals (string.Empty ))
            {
                MessageBox.Show("请选择科目！", CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboSubject.Focus();
                return false;
            }
            //成绩输入不得为空
            else if (this.txtResult .Text .Equals (string.Empty ))
            {
                MessageBox.Show("请输入成绩！", CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtResult.Focus();
                return false;
            }           
            else
            {
                return true;
            }
        }
        
        /// <summary>
        /// 添加学生成绩
        /// </summary>
        public void InsertResult()
        {
            // 获得数据
            int subjectId = Convert.ToInt32(this.cboSubject.SelectedValue); // 科目编号
            double studentResult = Convert.ToDouble(this.txtResult.Text.Trim());   // 考试成绩
            DateTime date = this.dpExamDate.Value;   // 考试日期
            string examDate = string.Format("{0}-{1}-{2}",date.Year,date.Month,date.Day);

            //创建数据库连接            
            DBHelper dbhelper = new DBHelper();            

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("INSERT INTO [Result] ([StudentNo],[SubjectId],[StudentResult],[ExamDate]) ");
                sql.AppendFormat(" VALUES({0},{1},{2},'{3}')",
                    this.studentNo, subjectId, studentResult, examDate);
                
                // 创建command对象
                SqlCommand command = new SqlCommand(sql.ToString(), dbhelper.Connection);

                // 打开数据库连接
                dbhelper.OpenConnection();
                
                // 执行命令
                int result = command.ExecuteNonQuery();

                // 根据操作结果给出提示信息
                if (result < 1)
                {
                    MessageBox.Show("增加失败，请重试！", CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("增加成功！", CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("系统出现错误！", CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                //关闭数据库连接
                dbhelper.CloseConnection();                
            }
        }
        #endregion

    }
}
