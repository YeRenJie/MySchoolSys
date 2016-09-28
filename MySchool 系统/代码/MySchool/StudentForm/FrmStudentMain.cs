using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySchool.AdminForm;

namespace MySchool.StudentForm
{
    public partial class FrmStudentMain : Form
    {
        #region 属性定义
        public User user;
        #endregion

        public FrmStudentMain()
        {
            InitializeComponent();
        }       

        #region 事件处理
        /// <summary>
        /// 点击“退出”菜单按钮时
        /// </summary>
        private void tsmiCLose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 点击“修改密码”菜单按钮时
        /// </summary>
        private void tsmiModifyPwd_Click(object sender, EventArgs e)
        {
            FrmModifyPwd frmModifyPwd = new FrmModifyPwd();
            frmModifyPwd.MdiParent = this;
            frmModifyPwd.user = this.user;
            frmModifyPwd.Show();
        }

        /// <summary>
        /// 点击“查询成绩”菜单按钮时
        /// </summary>
        private void tslResult_Click(object sender, EventArgs e)
        {
            FrmReviewResult frmReviewresult = new FrmReviewResult();
            frmReviewresult.MdiParent = this;
            frmReviewresult.user = this.user;
            frmReviewresult.Show();
        }

        /// <summary>
        /// 点击“查看个人信息”菜单按钮时
        /// </summary>
        private void tslOwnInfor_Click(object sender, EventArgs e)
        {
            FrmOwnInfo frmOwninfo = new FrmOwnInfo();
            frmOwninfo.MdiParent = this;
            frmOwninfo.user = this.user;
            frmOwninfo.Show();
        }
        #endregion
    }
}
