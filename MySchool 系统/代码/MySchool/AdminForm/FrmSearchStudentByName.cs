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
    public partial class FrmSearchStudentByName : Form
    {

        #region 常量定义
        public const string CAPTION = "操作提示";
        #endregion

        public FrmSearchStudentByName()
        {
            InitializeComponent();
        }

        #region 事件处理
        /// <summary>
        /// 查找学生信息，显示在窗体上
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            FillListView();
        }
        
        /// <summary>
        /// 打开编辑学生信息窗体
        /// </summary>
        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            if (this.lvResult.SelectedItems.Count > 0)
            {
                FrmEditStudent editStudent = new FrmEditStudent();
                // 将选中的学号传递到编辑学生信息窗体
                editStudent.studentNo = Convert.ToInt32(this.lvResult.SelectedItems[0].Text);
                editStudent.MdiParent = this.MdiParent;
                editStudent.Show();
            }
            else
            {
                MessageBox.Show("请选择一个学生！",CAPTION,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 删除选中的学生
        /// </summary>
        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            if (this.lvResult.SelectedItems.Count > 0)
            {
                DialogResult choice = MessageBox.Show("确定要删除吗？", CAPTION, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (choice == DialogResult.Yes)
                {
                    // 要删除学生的学号
                    int studentNo = Convert.ToInt32(this.lvResult.SelectedItems[0].Text);

                    // SQL语句
                    string sql = "DELETE FROM Student WHERE [StudentNo]="+studentNo;

                    // 删除学生
                    DBHelper dbHelper = new DBHelper();
                    try
                    {
                        SqlCommand command = new SqlCommand(sql.ToString(),dbHelper.Connection);
                        dbHelper.OpenConnection();
                        int result = command.ExecuteNonQuery();
                        if (result == 1)
                        {
                            MessageBox.Show("删除成功！", CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FillListView(); // 重新查询数据并显示
                        }
                        else
                        {
                            MessageBox.Show("删除失败，请重试！", CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("系统发生错误！", CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    finally
                    {
                        dbHelper.CloseConnection();
                    }
                }                
            }
            else
            {
                MessageBox.Show("请选择一个学生！", CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 打开增加成绩窗体
        /// </summary>
        private void tsmiResult_Click(object sender, EventArgs e)
        {
            FrmAddResult addResult = new FrmAddResult();
            addResult.MdiParent = this.MdiParent;
            addResult.studentNo = Convert.ToInt32(this.lvResult.SelectedItems[0].Text);
            addResult.Show();
        }
        #endregion

        #region 方法
        /// <summary>
        /// 查询学生信息，显示在窗体上
        /// </summary>
        private void FillListView()
        {
            // 先清空ListView中的数据
            if (lvResult.Items.Count > 0)
            {
                lvResult.Items.Clear();
            }

            // 构建 SQL 语句
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("SELECT S.[StudentNo],S.[StudentName],S.[Gender],G.[GradeName] ");
            sql.AppendLine(" FROM Student AS S, Grade AS G ");
            sql.AppendLine(" WHERE S.[GradeId]=G.[GradeId] ");
            sql.AppendFormat(" AND S.[StudentName] LIKE '%{0}%'", this.txtStudentName.Text.Trim());

            // 查询并显示
            DBHelper dbHelper = new DBHelper();
            try
            {
                SqlCommand command = new SqlCommand(sql.ToString(), dbHelper.Connection);
                dbHelper.OpenConnection();
                SqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows)
                {
                    MessageBox.Show("没有要查找的记录！", CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    while (reader.Read())
                    {
                        // 获得查询到的数据
                        string studentNo = reader["StudentNo"].ToString(); //  学号
                        string studentName = reader["StudentName"].ToString(); // 姓名
                        int genderId = Convert.ToInt32(reader["gender"]);      // 性别的值
                        string gender; // 性别的中文名称
                        if (genderId == (int)Gender.Male)
                        {
                            gender = "男";
                        }
                        else
                        {
                            gender = "女";
                        }

                        string gradeName = reader["GradeName"].ToString(); // 年级

                        // 创建ListViewItem
                        ListViewItem item = new ListViewItem(studentNo);

                        // 添加子项
                        item.SubItems.Add(studentName);
                        item.SubItems.Add(Convert.ToString(gender));
                        item.SubItems.Add(gradeName);

                        // 将ListViewItem添加到ListView中
                        lvResult.Items.Add(item);
                    }
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("系统出现错误！", CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbHelper.CloseConnection();
            }
        }
        #endregion

        
    }
}