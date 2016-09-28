using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySchool.AdminForm;

namespace MySchool
{
    public partial class FrmAdminMain : Form
    {
        #region 属性的定义 
        public User user;  // 当前登录的用户
        #endregion

        public FrmAdminMain()
        {
            InitializeComponent();
        }       

        #region 事件处理
        /// <summary>
        /// 响应“退出”按钮事件
        /// </summary>
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            DialogResult choice;　　// 用户的选择
            choice = MessageBox.Show("确定要退出吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (choice == DialogResult.OK)
            {
                // 退出应用程序
                Application.Exit();  
            }            
        }
 
        /// <summary>
        /// 响应“修改密码”按钮事件
        /// </summary>
        private void tsmiModifyPwd_Click(object sender, EventArgs e)
        {
            //显示修改密码界面
            FrmModifyPwd frmModifyPwd = new FrmModifyPwd();
            frmModifyPwd.MdiParent  = this;
            frmModifyPwd.user = this.user;
            frmModifyPwd.Show();
        }

        /// <summary>
        /// “新建学生用户”按钮按下时
        /// </summary>
        private void tslNewStudent_Click(object sender, EventArgs e)
        {
            FrmEditStudent frmEditStudent = new FrmEditStudent();
            frmEditStudent.MdiParent = this;
            frmEditStudent.Show();
        }

        /// <summary>
        /// 点击“查询学生信息”按钮时
        /// </summary>
        private void tsmiSearchByName_Click(object sender, EventArgs e)
        {
            FrmSearchStudentByName frmSearchStudent = new FrmSearchStudentByName();
            frmSearchStudent.MdiParent = this;
            frmSearchStudent.Show();
        }

        /// <summary>
        /// 点击“关于”菜单按钮时
        /// </summary>
        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            FrmAbout frmAbout = new FrmAbout();            
            frmAbout.ShowDialog();
        }                
        

        private void tsmiSearchByGrade_Click(object sender, EventArgs e)
        {
            FrmSearchStudenByGrade searchStudentNew = new FrmSearchStudenByGrade();
            searchStudentNew.MdiParent = this;
            searchStudentNew.Show();
        }

        /// <summary>
        /// 学生列表
        /// </summary>
        private void tsmiStudentList_Click(object sender, EventArgs e)
        {
            FrmStudentList studentList = new FrmStudentList();
            studentList.MdiParent = this;
            studentList.Show();
        }
        
        /// <summary>
        /// 科目列表
        /// </summary>
        private void tsmiSubjectList_Click(object sender, EventArgs e)
        {
            FrmSubjectList subjectList = new FrmSubjectList();
            subjectList.MdiParent = this;
            subjectList.Show();
        }
        
        /// <summary>
        /// 窗体关闭后触发
        /// </summary>
        private void FrmAdminMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // 退出应用程序
        }
        #endregion
    }
}
