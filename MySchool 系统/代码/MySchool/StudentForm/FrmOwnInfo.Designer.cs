namespace MySchool.StudentForm
{
    partial class FrmOwnInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOwnInfo));
            this.lblStuNo = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblBornDate = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtStuNo = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtBornDate = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnCLose = new System.Windows.Forms.Button();
            this.gbLoginInfo = new System.Windows.Forms.GroupBox();
            this.gbBaseInfor = new System.Windows.Forms.GroupBox();
            this.gbBaseInfor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStuNo
            // 
            this.lblStuNo.AutoSize = true;
            this.lblStuNo.Location = new System.Drawing.Point(44, 31);
            this.lblStuNo.Name = "lblStuNo";
            this.lblStuNo.Size = new System.Drawing.Size(29, 12);
            this.lblStuNo.TabIndex = 0;
            this.lblStuNo.Text = "学号";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(44, 63);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(29, 12);
            this.lblPwd.TabIndex = 1;
            this.lblPwd.Text = "密码";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(44, 135);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(29, 12);
            this.lblSex.TabIndex = 2;
            this.lblSex.Text = "性别";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(44, 164);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(29, 12);
            this.lblGrade.TabIndex = 3;
            this.lblGrade.Text = "年级";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(44, 194);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(29, 12);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "电话";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(44, 228);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(29, 12);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "地址";
            // 
            // lblBornDate
            // 
            this.lblBornDate.AutoSize = true;
            this.lblBornDate.Location = new System.Drawing.Point(8, 156);
            this.lblBornDate.Name = "lblBornDate";
            this.lblBornDate.Size = new System.Drawing.Size(53, 12);
            this.lblBornDate.TabIndex = 6;
            this.lblBornDate.Text = "出生日期";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(38, 294);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 12);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            // 
            // txtStuNo
            // 
            this.txtStuNo.BackColor = System.Drawing.Color.Gainsboro;
            this.txtStuNo.Location = new System.Drawing.Point(89, 28);
            this.txtStuNo.Name = "txtStuNo";
            this.txtStuNo.ReadOnly = true;
            this.txtStuNo.Size = new System.Drawing.Size(263, 21);
            this.txtStuNo.TabIndex = 8;
            // 
            // txtPwd
            // 
            this.txtPwd.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPwd.Location = new System.Drawing.Point(89, 55);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.ReadOnly = true;
            this.txtPwd.Size = new System.Drawing.Size(263, 21);
            this.txtPwd.TabIndex = 9;
            // 
            // txtSex
            // 
            this.txtSex.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSex.Location = new System.Drawing.Point(89, 127);
            this.txtSex.Name = "txtSex";
            this.txtSex.ReadOnly = true;
            this.txtSex.Size = new System.Drawing.Size(263, 21);
            this.txtSex.TabIndex = 10;
            // 
            // txtGrade
            // 
            this.txtGrade.BackColor = System.Drawing.Color.Gainsboro;
            this.txtGrade.Location = new System.Drawing.Point(89, 157);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.ReadOnly = true;
            this.txtGrade.Size = new System.Drawing.Size(263, 21);
            this.txtGrade.TabIndex = 11;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPhone.Location = new System.Drawing.Point(89, 190);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(263, 21);
            this.txtPhone.TabIndex = 12;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.Gainsboro;
            this.txtAddress.Location = new System.Drawing.Point(89, 222);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(263, 21);
            this.txtAddress.TabIndex = 13;
            // 
            // txtBornDate
            // 
            this.txtBornDate.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBornDate.Location = new System.Drawing.Point(89, 253);
            this.txtBornDate.Name = "txtBornDate";
            this.txtBornDate.ReadOnly = true;
            this.txtBornDate.Size = new System.Drawing.Size(263, 21);
            this.txtBornDate.TabIndex = 14;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Gainsboro;
            this.txtEmail.Location = new System.Drawing.Point(89, 287);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(263, 21);
            this.txtEmail.TabIndex = 15;
            // 
            // btnCLose
            // 
            this.btnCLose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCLose.Location = new System.Drawing.Point(291, 324);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(75, 23);
            this.btnCLose.TabIndex = 16;
            this.btnCLose.Text = "返 回";
            this.btnCLose.UseVisualStyleBackColor = true;
            this.btnCLose.Click += new System.EventHandler(this.btnCLose_Click);
            // 
            // gbLoginInfo
            // 
            this.gbLoginInfo.Location = new System.Drawing.Point(12, 12);
            this.gbLoginInfo.Name = "gbLoginInfo";
            this.gbLoginInfo.Size = new System.Drawing.Size(354, 76);
            this.gbLoginInfo.TabIndex = 17;
            this.gbLoginInfo.TabStop = false;
            this.gbLoginInfo.Text = "用户注册信息";
            // 
            // gbBaseInfor
            // 
            this.gbBaseInfor.Controls.Add(this.lblBornDate);
            this.gbBaseInfor.Location = new System.Drawing.Point(12, 106);
            this.gbBaseInfor.Name = "gbBaseInfor";
            this.gbBaseInfor.Size = new System.Drawing.Size(354, 212);
            this.gbBaseInfor.TabIndex = 18;
            this.gbBaseInfor.TabStop = false;
            this.gbBaseInfor.Text = "用户基本信息";
            // 
            // FrmOwnInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 353);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtStuNo);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblStuNo);
            this.Controls.Add(this.gbLoginInfo);
            this.Controls.Add(this.btnCLose);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtBornDate);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.gbBaseInfor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmOwnInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查看个人信息";
            this.Load += new System.EventHandler(this.FrmOwnInfor_Load);
            this.gbBaseInfor.ResumeLayout(false);
            this.gbBaseInfor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStuNo;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblBornDate;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtStuNo;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtBornDate;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnCLose;
        private System.Windows.Forms.GroupBox gbLoginInfo;
        private System.Windows.Forms.GroupBox gbBaseInfor;
    }
}