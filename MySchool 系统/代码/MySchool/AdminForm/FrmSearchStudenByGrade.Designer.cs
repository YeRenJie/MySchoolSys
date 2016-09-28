namespace MySchool.AdminForm
{
    partial class FrmSearchStudenByGrade
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearchStudenByGrade));
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvStuName = new System.Windows.Forms.DataGridView();
            this.StudentNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenderId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsAddResult = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAddResult = new System.Windows.Forms.ToolStripMenuItem();
            this.lblGrade = new System.Windows.Forms.Label();
            this.cboGrade = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblComment = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuName)).BeginInit();
            this.cmsAddResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(194, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "查 找";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvStuName
            // 
            this.dgvStuName.AllowUserToAddRows = false;
            this.dgvStuName.AllowUserToDeleteRows = false;
            this.dgvStuName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStuName.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStuName.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStuName.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStuName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStuName.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentNO,
            this.StudentName,
            this.GenderId,
            this.Birthday});
            this.dgvStuName.ContextMenuStrip = this.cmsAddResult;
            this.dgvStuName.Location = new System.Drawing.Point(14, 66);
            this.dgvStuName.Name = "dgvStuName";
            this.dgvStuName.RowHeadersVisible = false;
            this.dgvStuName.RowTemplate.Height = 23;
            this.dgvStuName.Size = new System.Drawing.Size(566, 231);
            this.dgvStuName.TabIndex = 2;
            // 
            // StudentNO
            // 
            this.StudentNO.DataPropertyName = "StudentNO";
            this.StudentNO.HeaderText = "学生学号";
            this.StudentNO.Name = "StudentNO";
            this.StudentNO.ReadOnly = true;
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "StudentName";
            this.StudentName.HeaderText = "学生姓名";
            this.StudentName.Name = "StudentName";
            // 
            // GenderId
            // 
            this.GenderId.DataPropertyName = "Gender";
            this.GenderId.HeaderText = "性别";
            this.GenderId.Items.AddRange(new object[] {
            "1",
            "0"});
            this.GenderId.Name = "GenderId";
            this.GenderId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GenderId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Birthday
            // 
            this.Birthday.DataPropertyName = "Birthday";
            this.Birthday.HeaderText = "出生年月日";
            this.Birthday.Name = "Birthday";
            // 
            // cmsAddResult
            // 
            this.cmsAddResult.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddResult});
            this.cmsAddResult.Name = "cmsAddResult";
            this.cmsAddResult.Size = new System.Drawing.Size(153, 48);
            // 
            // tsmiAddResult
            // 
            this.tsmiAddResult.Name = "tsmiAddResult";
            this.tsmiAddResult.Size = new System.Drawing.Size(152, 22);
            this.tsmiAddResult.Text = "添加成绩";
            this.tsmiAddResult.Click += new System.EventHandler(this.tsmiAddResult_Click);
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(23, 25);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(29, 12);
            this.lblGrade.TabIndex = 4;
            this.lblGrade.Text = "年级";
            // 
            // cboGrade
            // 
            this.cboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Location = new System.Drawing.Point(58, 21);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(121, 20);
            this.cboGrade.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(505, 303);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "保  存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(19, 311);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(0, 12);
            this.lblComment.TabIndex = 6;
            // 
            // FrmSearchStudenByGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(592, 335);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.cboGrade);
            this.Controls.Add(this.dgvStuName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.btnSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSearchStudenByGrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生列表";
            this.Load += new System.EventHandler(this.FrmSearchStudentNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuName)).EndInit();
            this.cmsAddResult.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvStuName;
        private System.Windows.Forms.ContextMenuStrip cmsAddResult;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddResult;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.ComboBox cboGrade;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewComboBoxColumn GenderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
    }
}