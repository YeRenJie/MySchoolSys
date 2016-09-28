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
    public partial class FrmSubjectList : Form
    {
        DataSet ds;
        SqlDataAdapter adapter;

        public FrmSubjectList()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 加载时，显示所有科目信息
        /// </summary>
        private void FrmSubjectList_Load(object sender, EventArgs e)
        {
            DBHelper dbHelper = new DBHelper();
            
            // 查询的SQL语句
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("SELECT [SubjectName],[ClassHour],[GradeName]");
            sql.AppendLine(" FROM Subject,Grade");
            sql.AppendLine(" WHERE Subject.[GradeId]=Grade.[GradeId]");

            // 填充数据集
            ds = new DataSet();
            adapter = new SqlDataAdapter(sql.ToString(),dbHelper.Connection);
            adapter.Fill(ds, "Subject");

            // 绑定数据源
            dgvSubject.DataSource = ds.Tables["Subject"];
        }

        // 实现数据筛选和排序
        private void tvGrade_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DataView dv = new DataView(ds.Tables["Subject"]);
            
            // 选择了年级
            if (tvGrade.SelectedNode.Level == 1)
            {
                dv.RowFilter = string.Format("GradeName ='{0}'", tvGrade.SelectedNode.Text);                
            }

            dv.Sort = "SubjectName";
            // 绑定数据源
            dgvSubject.DataSource = dv;            
        }
    }
}
