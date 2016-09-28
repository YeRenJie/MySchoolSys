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
    public partial class FrmSearchStudenByGrade : Form
    {
        #region 常量、字段的定义
        public const string CAPTION = "操作提示";
        DataSet ds;  // 数据集
        SqlDataAdapter adapterGrade;  // 读取年级信息的数据适配器
        SqlDataAdapter adapterStudent; // 读取学生信息的数据适配器
        #endregion

        public FrmSearchStudenByGrade()
        {
            InitializeComponent();
        }        

        #region 事件处理
        /// <summary>
        /// 窗体加载时，绑定年级数据
        /// </summary>
        private void FrmSearchStudentNew_Load(object sender, EventArgs e)
        {
            // 查询用的SQL语句
            string sql = "SELECT * FROM Grade";

            // 查询并填充数据集
            DBHelper dbHelper = new DBHelper();
            this.ds = new DataSet(); // 创建数据集
            adapterGrade = new SqlDataAdapter(sql, dbHelper.Connection);
            adapterGrade.Fill(ds, "Grade");

            // 向年级表的第1行添加数据“全部”
            DataRow row = ds.Tables["Grade"].NewRow();
            row[0] = -1;
            row[1] = "全部";
            ds.Tables["Grade"].Rows.InsertAt(row, 0);

            // 绑定年级数据
            this.cboGrade.DataSource = ds.Tables["Grade"];
            this.cboGrade.ValueMember = "GradeId";
            this.cboGrade.DisplayMember = "GradeName";

            // 默认显示所有年级的学生
            SearchStudent();

            // 说明
            this.lblComment.Text = string.Format("说明：{0}代表男，{1}代表女",
                (int)Gender.Male,(int)Gender.Female);
        }
        
        /// <summary>
        /// 点击“查找”按钮按下时
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //按照用户选择的年级，查找学生的信息
            SearchStudent();
        }

        /// <summary>
        /// “返回”按钮按下时
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            // 确定是否修改
            DialogResult choice = MessageBox.Show("确定要修改吗？",CAPTION,MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (choice == DialogResult.Yes)
            {
                // 使用SqlCommandBuilder构建增删改的Command命令
                SqlCommandBuilder builder = new SqlCommandBuilder(adapterStudent);
                // 更新数据
                adapterStudent.Update(ds, "Student");
            }            
        }        
        #endregion

        #region 查找学生
        /// <summary>
        /// 按照用户选择的年级查询学生信息
        /// </summary>
        /// <returns>true：查找成功；false：查找失败</returns>
        public void SearchStudent()
        {
            //创建数据库连接            
            DBHelper dbhelper = new DBHelper();            

            try
            {
                // 查询年级的sql语句
                StringBuilder sql = new StringBuilder("SELECT [StudentNo],[StudentName],[Gender],[Birthday] FROM [Student]");
                
                if (Convert.ToInt32(this.cboGrade.SelectedValue) != -1)
                {
                    sql.AppendFormat(" WHERE [GradeId]={0}", Convert.ToInt32(this.cboGrade.SelectedValue));
                }
                sql.Append(" ORDER BY [StudentNo]");

                //填充DataSet
                //SqlDataAdapter adapter = new SqlDataAdapter(sql.ToString(), dbhelper.Connection);

                adapterStudent = new SqlDataAdapter();
                SqlCommand command = new SqlCommand(sql.ToString(), dbhelper.Connection);
                adapterStudent.SelectCommand = command;
                
                // 填充前，先清空原有的数据
                if (ds.Tables["Student"] != null)
                {
                    ds.Tables["Student"].Clear();
                }

                adapterStudent.Fill(ds, "Student");

                //绑定数据源
                this.dgvStuName.DataSource = ds.Tables["Student"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Warning);               
            }
        }
        #endregion

        private void tsmiAddResult_Click(object sender, EventArgs e)
        {
            FrmEditStudent fedit = new FrmEditStudent();
            fedit.studentNo = -1;
            fedit.Show();
        }

        
    }
}
