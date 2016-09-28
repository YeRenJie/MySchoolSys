using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MySchool.AdminForm
{
    public partial class FrmAbout : Form
    {
        #region 字段定义
        int index = 0;  // 图片框中图片的索引
        #endregion

        public FrmAbout()
        {
            InitializeComponent();
        }        

        #region 事件处理
        /// <summary>
        /// “OK”按钮按下时
        /// </summary>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 计时器的Tick事件处理方法，定时变换图片框中的图片
        /// </summary>
        private void tmrAbout_Tick(object sender, EventArgs e)
        {
            // 如果当前显示的图片索引没有到最大值就继续增加
            if (index < this.ilAbout.Images.Count - 1)
            {
                index++;
            }
            else  // 否则从第一个图片开始显示，索引从0开始
            {
                index = 0;
            }
            // 设置图片框显示的图片   
            this.pbAbout.Image = ilAbout.Images[index];
        }
        #endregion
    }
}
