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
    public partial class FrmReviewResult : Form
    {
        #region 常量、字段、属性的定义
        public const string CAPTION = "操作提示";
        public User user;
        private SqlDataAdapter adp;
        private DataSet ds;        
        #endregion

        public FrmReviewResult()
        {
            InitializeComponent();
        }       

        #region 事件处理
        /// <summary>
        /// 窗体加载
        /// </summary>       
        private void FrmReviewResult_Load(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter();
            ds = new DataSet();

            //科目的绑定
            BindSubject();

            //成绩的绑定
            BindResult();
        }

        /// <summary>
        /// 点击“返回”按钮时
        /// </summary>       
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 查询成绩
        /// </summary>      
        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindResult();
        }
        #endregion

        #region 数据绑定
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
                string sql = "SELECT [SubjectNo],[SubjectName]  FROM  [Subject]";
                
                //填充DataSet
                adp.SelectCommand.Connection = dbhelper.Connection;
                adp.SelectCommand.CommandText = sql;                
                adp.Fill(ds, "Subject");

                DataRow row = ds.Tables["Subject"].NewRow();
                row[0] = -1;
                row[1] = "请选择";
                ds.Tables["Subject"].Rows.InsertAt(row,0);

                //绑定数据源 
                this.cboSubject.DataSource = ds.Tables["Subject"];
                this.cboSubject.ValueMember = "SubjectNo";
                this.cboSubject.DisplayMember = "SubjectName";                
            }
            catch (Exception ex)
            {
                MessageBox.Show("系统发生错误！", CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Warning);                
            }            
        }

        /// <summary>
        /// 成绩的绑定
        /// </summary>        
        public void BindResult()
        {
            //创建数据库连接            
            DBHelper dbhelper = new DBHelper();
           
            try
            {
                //初始化Sql语句
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT A.[StudentNo],B.[SubjectName] ,A.[StudentResult], A.[ExamDate]");
                sql.AppendLine(" FROM [Result] AS A,[Subject] AS B");
                sql.AppendFormat(" WHERE A.[StudentNo]='{0}'",user.UserId);

                // 为sql语句附加条件
                if (Convert.ToInt32(cboSubject.SelectedValue) != -1)
                {
                    sql.AppendFormat(" AND B.[SubjectNo]={0}",cboSubject.SelectedValue);
                }
                if (cboPass.SelectedIndex != 0)
                {
                    if (cboPass.SelectedIndex == 1)
                    {
                        sql.AppendLine(" AND A.[StudentResult] >= 60");
                    }
                    else if (cboPass.SelectedIndex == 2)
                    {
                        sql.AppendLine(" AND A.[StudentResult] < 60");
                    }
                }

                //填充DataSet
                if (ds.Tables["Result"] != null)
                {
                    ds.Tables["Result"].Clear();
                }
                adp.Fill(ds, "Result");

                //绑定数据源
                this.dgvResult.DataSource = ds.Tables["Result"]; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("系统发生错误！", CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Warning);                
            }
        }
        #endregion
    }
}
