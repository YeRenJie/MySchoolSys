namespace MySchool
{
    partial class FrmAdminMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminMain));
            this.msAdmin = new System.Windows.Forms.MenuStrip();
            this.tsmiAccountManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModifyPwd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStudentManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSearchByName = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSearchByGrade = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStudentList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSubject = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSubjectList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAdmin = new System.Windows.Forms.ToolStrip();
            this.tsbtnNewStudent = new System.Windows.Forms.ToolStripButton();
            this.tsbtnStudentByName = new System.Windows.Forms.ToolStripButton();
            this.tsbtnStudentByGrade = new System.Windows.Forms.ToolStripButton();
            this.tsbtnStudentList = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSubjectList = new System.Windows.Forms.ToolStripButton();
            this.msAdmin.SuspendLayout();
            this.tsAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // msAdmin
            // 
            this.msAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAccountManage,
            this.tsmiStudentManage,
            this.tsmiSubject,
            this.tsmiWindow,
            this.tsmiHelp});
            this.msAdmin.Location = new System.Drawing.Point(0, 0);
            this.msAdmin.MdiWindowListItem = this.tsmiWindow;
            this.msAdmin.Name = "msAdmin";
            this.msAdmin.Size = new System.Drawing.Size(611, 24);
            this.msAdmin.TabIndex = 1;
            this.msAdmin.Text = "menuStrip1";
            // 
            // tsmiAccountManage
            // 
            this.tsmiAccountManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiModifyPwd,
            this.toolStripSeparator1,
            this.tsmiExit});
            this.tsmiAccountManage.Name = "tsmiAccountManage";
            this.tsmiAccountManage.ShortcutKeyDisplayString = "";
            this.tsmiAccountManage.Size = new System.Drawing.Size(83, 20);
            this.tsmiAccountManage.Text = "帐户管理(&U)";
            // 
            // tsmiModifyPwd
            // 
            this.tsmiModifyPwd.Name = "tsmiModifyPwd";
            this.tsmiModifyPwd.Size = new System.Drawing.Size(136, 22);
            this.tsmiModifyPwd.Text = "修改密码(&P)";
            this.tsmiModifyPwd.Click += new System.EventHandler(this.tsmiModifyPwd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(133, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.ShortcutKeyDisplayString = "";
            this.tsmiExit.Size = new System.Drawing.Size(136, 22);
            this.tsmiExit.Text = "退出(&X)";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiStudentManage
            // 
            this.tsmiStudentManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewStudent,
            this.tsmiSearchByName,
            this.tsmiSearchByGrade,
            this.tsmiStudentList});
            this.tsmiStudentManage.Name = "tsmiStudentManage";
            this.tsmiStudentManage.Size = new System.Drawing.Size(107, 20);
            this.tsmiStudentManage.Text = "学生用户管理(&S)";
            // 
            // tsmiNewStudent
            // 
            this.tsmiNewStudent.Name = "tsmiNewStudent";
            this.tsmiNewStudent.Size = new System.Drawing.Size(148, 22);
            this.tsmiNewStudent.Text = "新增学生(&N)";
            this.tsmiNewStudent.Click += new System.EventHandler(this.tslNewStudent_Click);
            // 
            // tsmiSearchByName
            // 
            this.tsmiSearchByName.Name = "tsmiSearchByName";
            this.tsmiSearchByName.Size = new System.Drawing.Size(148, 22);
            this.tsmiSearchByName.Text = "按姓名查询(&M)";
            this.tsmiSearchByName.Click += new System.EventHandler(this.tsmiSearchByName_Click);
            // 
            // tsmiSearchByGrade
            // 
            this.tsmiSearchByGrade.Name = "tsmiSearchByGrade";
            this.tsmiSearchByGrade.Size = new System.Drawing.Size(148, 22);
            this.tsmiSearchByGrade.Text = "按年级查询(&G)";
            this.tsmiSearchByGrade.Click += new System.EventHandler(this.tsmiSearchByGrade_Click);
            // 
            // tsmiStudentList
            // 
            this.tsmiStudentList.Name = "tsmiStudentList";
            this.tsmiStudentList.Size = new System.Drawing.Size(148, 22);
            this.tsmiStudentList.Text = "学生列表(&L)";
            this.tsmiStudentList.Click += new System.EventHandler(this.tsmiStudentList_Click);
            // 
            // tsmiSubject
            // 
            this.tsmiSubject.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSubjectList});
            this.tsmiSubject.Name = "tsmiSubject";
            this.tsmiSubject.Size = new System.Drawing.Size(83, 20);
            this.tsmiSubject.Text = "科目管理(&C)";
            // 
            // tsmiSubjectList
            // 
            this.tsmiSubjectList.Name = "tsmiSubjectList";
            this.tsmiSubjectList.Size = new System.Drawing.Size(136, 22);
            this.tsmiSubjectList.Text = "科目列表(&L)";
            this.tsmiSubjectList.Click += new System.EventHandler(this.tsmiSubjectList_Click);
            // 
            // tsmiWindow
            // 
            this.tsmiWindow.Name = "tsmiWindow";
            this.tsmiWindow.Size = new System.Drawing.Size(59, 20);
            this.tsmiWindow.Text = "窗口(&W)";
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(59, 20);
            this.tsmiHelp.Text = "帮助(&H)";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(112, 22);
            this.tsmiAbout.Text = "关于(&A)";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // tsAdmin
            // 
            this.tsAdmin.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnNewStudent,
            this.tsbtnStudentByName,
            this.tsbtnStudentByGrade,
            this.tsbtnStudentList,
            this.tsbtnSubjectList});
            this.tsAdmin.Location = new System.Drawing.Point(0, 24);
            this.tsAdmin.Name = "tsAdmin";
            this.tsAdmin.Size = new System.Drawing.Size(611, 39);
            this.tsAdmin.TabIndex = 3;
            this.tsAdmin.Text = "toolStrip1";
            // 
            // tsbtnNewStudent
            // 
            this.tsbtnNewStudent.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnNewStudent.Image")));
            this.tsbtnNewStudent.Name = "tsbtnNewStudent";
            this.tsbtnNewStudent.Size = new System.Drawing.Size(113, 36);
            this.tsbtnNewStudent.Text = "新建学生用户";
            this.tsbtnNewStudent.Click += new System.EventHandler(this.tslNewStudent_Click);
            // 
            // tsbtnStudentByName
            // 
            this.tsbtnStudentByName.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnStudentByName.Image")));
            this.tsbtnStudentByName.Name = "tsbtnStudentByName";
            this.tsbtnStudentByName.Size = new System.Drawing.Size(149, 36);
            this.tsbtnStudentByName.Text = "按姓名查询学生信息";
            this.tsbtnStudentByName.Click += new System.EventHandler(this.tsmiSearchByName_Click);
            // 
            // tsbtnStudentByGrade
            // 
            this.tsbtnStudentByGrade.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnStudentByGrade.Image")));
            this.tsbtnStudentByGrade.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnStudentByGrade.Name = "tsbtnStudentByGrade";
            this.tsbtnStudentByGrade.Size = new System.Drawing.Size(149, 36);
            this.tsbtnStudentByGrade.Text = "按年级查询学生信息";
            this.tsbtnStudentByGrade.Click += new System.EventHandler(this.tsmiSearchByGrade_Click);
            // 
            // tsbtnStudentList
            // 
            this.tsbtnStudentList.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnStudentList.Image")));
            this.tsbtnStudentList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnStudentList.Name = "tsbtnStudentList";
            this.tsbtnStudentList.Size = new System.Drawing.Size(89, 36);
            this.tsbtnStudentList.Text = "学生列表";
            this.tsbtnStudentList.Click += new System.EventHandler(this.tsmiStudentList_Click);
            // 
            // tsbtnSubjectList
            // 
            this.tsbtnSubjectList.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSubjectList.Image")));
            this.tsbtnSubjectList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSubjectList.Name = "tsbtnSubjectList";
            this.tsbtnSubjectList.Size = new System.Drawing.Size(89, 36);
            this.tsbtnSubjectList.Text = "科目列表";
            this.tsbtnSubjectList.Click += new System.EventHandler(this.tsmiSubjectList_Click);
            // 
            // FrmAdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 400);
            this.Controls.Add(this.tsAdmin);
            this.Controls.Add(this.msAdmin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msAdmin;
            this.Name = "FrmAdminMain";
            this.Text = "MySchool-管理员";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAdminMain_FormClosed);
            this.msAdmin.ResumeLayout(false);
            this.msAdmin.PerformLayout();
            this.tsAdmin.ResumeLayout(false);
            this.tsAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msAdmin;
        private System.Windows.Forms.ToolStripMenuItem tsmiAccountManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiModifyPwd;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStrip tsAdmin;
        private System.Windows.Forms.ToolStripMenuItem tsmiStudentManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewStudent;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearchByName;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnNewStudent;
        private System.Windows.Forms.ToolStripButton tsbtnStudentByName;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearchByGrade;
        private System.Windows.Forms.ToolStripMenuItem tsmiStudentList;
        private System.Windows.Forms.ToolStripMenuItem tsmiSubject;
        private System.Windows.Forms.ToolStripMenuItem tsmiSubjectList;
        private System.Windows.Forms.ToolStripButton tsbtnStudentByGrade;
        private System.Windows.Forms.ToolStripButton tsbtnStudentList;
        private System.Windows.Forms.ToolStripButton tsbtnSubjectList;
        private System.Windows.Forms.ToolStripMenuItem tsmiWindow;
    }
}