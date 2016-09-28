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
    public partial class FrmStudentList : Form
    {
        SqlDataAdapter adapter;
        DataSet dt;
        StringBuilder sql;
        
        public FrmStudentList()
        {
            InitializeComponent();
        }

        private void frmStudentList_Load(object sender, EventArgs e)
        {
            FillTable();
        }

        /// <summary>
        /// 填充数据集
        /// </summary>
        private void FillTable()
        {
            dt = new DataSet();
            DBHelper dbHelper = new DBHelper();
            sql = new StringBuilder();
            sql.AppendLine("SELECT [StudentNo],[StudentName],[Gender],[GradeName],[Phone]");
            sql.AppendLine(" FROM Student,Grade WHERE Student.[GradeId]=Grade.[GradeId]");
            adapter = new SqlDataAdapter(sql.ToString(), dbHelper.Connection);
            adapter.Fill(dt, "student");
            dgvStudent.DataSource = dt.Tables[0];
        }

        /// <summary>
        /// 选择树节点后
        /// </summary>
        private void tvMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Filter();
        }

        /// <summary>
        /// 按选择的条件筛选
        /// </summary>
        private void Filter()
        {
            DataView dv = new DataView(dt.Tables["Student"]);
            string rowFilter = string.Empty; // 筛选条件

            //string message = string.Format("选中了{0}节点，深度是{1}",
            //    tvMenu.SelectedNode.Text, tvMenu.SelectedNode.Level);
            //MessageBox.Show(message, "提示",
            //    MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 年级级别的节点
            if (tvMenu.SelectedNode.Level == 1)
            {
                string gradeName = tvMenu.SelectedNode.Text;
                rowFilter = string.Format("GradeName='{0}'", gradeName);
            }

            // 性别级别的节点
            if (tvMenu.SelectedNode.Level == 2)
            {
                // 性别的枚举值                
                Gender gender = (Gender)Enum.Parse(typeof(Gender), tvMenu.SelectedNode.Tag.ToString());
                int genderId = (int)gender; // 性别的编号

                // 筛选条件
                rowFilter = string.Format("GradeName='{0}' AND Gender={1}",
                    tvMenu.SelectedNode.Parent.Text, genderId);
            }

            dv.RowFilter = rowFilter;
            dv.Sort = "StudentName desc";
            dgvStudent.DataSource = dv;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Update(dt, "student");
        }

        /// <summary>
        /// 删除选中的学生
        /// </summary>
        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            // 确认删除操作
            DialogResult choice = MessageBox.Show("确定要删除该学生吗？同时会删除该学生的成绩！", "提示", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (choice == DialogResult.Yes)
            { 
                // 执行删除操作                
                if (dgvStudent.SelectedRows.Count > 0)
                {
                    // 获得选中学生的学号
                    int studentNo = Convert.ToInt32(dgvStudent.SelectedRows[0].Cells["StudentNo"].Value);

                    DBHelper dbHelper = new DBHelper();
                    try
                    {   
                        // 先删除成绩
                        string sql = string.Format("DELETE FROM Result WHERE StudentNo={0}", studentNo);
                        SqlCommand command = new SqlCommand(sql, dbHelper.Connection);
                        dbHelper.OpenConnection();
                        command.ExecuteNonQuery();
                        
                        // 删除学生信息
                        sql = string.Format("DELETE FROM Student WHERE StudentNo={0}",studentNo);
                        command.CommandText = sql;
                        int result = command.ExecuteNonQuery();
                        if (result == 1)
                        {
                            MessageBox.Show("删除成功！","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                           
                            // 重新查询数据，绑定数据源，重新筛选
                            FillTable();
                            Filter();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("系统出现错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        dbHelper.CloseConnection();
                    }                    
                }                
            }
        }
    }
}
