namespace MySchool.StudentForm
{
    partial class FrmStudentMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudentMain));
            this.msStudent = new System.Windows.Forms.MenuStrip();
            this.tsmiAccountManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModifyPwd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCLose = new System.Windows.Forms.ToolStripMenuItem();
            this.tsStudent = new System.Windows.Forms.ToolStrip();
            this.tslResult = new System.Windows.Forms.ToolStripLabel();
            this.tslOwnInfor = new System.Windows.Forms.ToolStripLabel();
            this.msStudent.SuspendLayout();
            this.tsStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // msStudent
            // 
            this.msStudent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAccountManage,
            this.tsmiCLose});
            this.msStudent.Location = new System.Drawing.Point(0, 0);
            this.msStudent.Name = "msStudent";
            this.msStudent.Size = new System.Drawing.Size(505, 24);
            this.msStudent.TabIndex = 0;
            this.msStudent.Text = "menuStrip1";
            // 
            // tsmiAccountManage
            // 
            this.tsmiAccountManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiModifyPwd});
            this.tsmiAccountManage.Name = "tsmiAccountManage";
            this.tsmiAccountManage.Size = new System.Drawing.Size(65, 20);
            this.tsmiAccountManage.Text = "帐户管理";
            // 
            // tsmiModifyPwd
            // 
            this.tsmiModifyPwd.Name = "tsmiModifyPwd";
            this.tsmiModifyPwd.Size = new System.Drawing.Size(118, 22);
            this.tsmiModifyPwd.Text = "修改密码";
            this.tsmiModifyPwd.Click += new System.EventHandler(this.tsmiModifyPwd_Click);
            // 
            // tsmiCLose
            // 
            this.tsmiCLose.Name = "tsmiCLose";
            this.tsmiCLose.Size = new System.Drawing.Size(41, 20);
            this.tsmiCLose.Text = "退出";
            this.tsmiCLose.Click += new System.EventHandler(this.tsmiCLose_Click);
            // 
            // tsStudent
            // 
            this.tsStudent.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsStudent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslResult,
            this.tslOwnInfor});
            this.tsStudent.Location = new System.Drawing.Point(0, 24);
            this.tsStudent.Name = "tsStudent";
            this.tsStudent.Size = new System.Drawing.Size(505, 35);
            this.tsStudent.TabIndex = 1;
            // 
            // tslResult
            // 
            this.tslResult.Image = ((System.Drawing.Image)(resources.GetObject("tslResult.Image")));
            this.tslResult.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tslResult.Name = "tslResult";
            this.tslResult.Size = new System.Drawing.Size(85, 32);
            this.tslResult.Text = "查看成绩";
            this.tslResult.Click += new System.EventHandler(this.tslResult_Click);
            // 
            // tslOwnInfor
            // 
            this.tslOwnInfor.Image = ((System.Drawing.Image)(resources.GetObject("tslOwnInfor.Image")));
            this.tslOwnInfor.Name = "tslOwnInfor";
            this.tslOwnInfor.Size = new System.Drawing.Size(109, 32);
            this.tslOwnInfor.Text = "查看个人信息";
            this.tslOwnInfor.Click += new System.EventHandler(this.tslOwnInfor_Click);
            // 
            // FrmStudentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 316);
            this.Controls.Add(this.tsStudent);
            this.Controls.Add(this.msStudent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msStudent;
            this.Name = "FrmStudentMain";
            this.Text = "MySchool-学生";
            this.msStudent.ResumeLayout(false);
            this.msStudent.PerformLayout();
            this.tsStudent.ResumeLayout(false);
            this.tsStudent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msStudent;
        private System.Windows.Forms.ToolStripMenuItem tsmiAccountManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiModifyPwd;
        private System.Windows.Forms.ToolStripMenuItem tsmiCLose;
        private System.Windows.Forms.ToolStrip tsStudent;
        private System.Windows.Forms.ToolStripLabel tslResult;
        private System.Windows.Forms.ToolStripLabel tslOwnInfor;
    }
}