namespace PowerPointToImg
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.cmbBrowseFile = new System.Windows.Forms.Button();
            this.cmbBrowseFolder = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOutput = new System.Windows.Forms.Button();
            this.fbdOutput = new System.Windows.Forms.FolderBrowserDialog();
            this.ofdInput = new System.Windows.Forms.OpenFileDialog();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "PowerPoint文件：";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(120, 48);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(321, 21);
            this.txtInput.TabIndex = 1;
            // 
            // cmbBrowseFile
            // 
            this.cmbBrowseFile.Location = new System.Drawing.Point(449, 47);
            this.cmbBrowseFile.Name = "cmbBrowseFile";
            this.cmbBrowseFile.Size = new System.Drawing.Size(75, 23);
            this.cmbBrowseFile.TabIndex = 2;
            this.cmbBrowseFile.Text = "浏览(&B)";
            this.cmbBrowseFile.UseVisualStyleBackColor = true;
            this.cmbBrowseFile.Click += new System.EventHandler(this.cmbBrowseFile_Click);
            // 
            // cmbBrowseFolder
            // 
            this.cmbBrowseFolder.Location = new System.Drawing.Point(450, 86);
            this.cmbBrowseFolder.Name = "cmbBrowseFolder";
            this.cmbBrowseFolder.Size = new System.Drawing.Size(75, 23);
            this.cmbBrowseFolder.TabIndex = 5;
            this.cmbBrowseFolder.Text = "浏览(&R)";
            this.cmbBrowseFolder.UseVisualStyleBackColor = true;
            this.cmbBrowseFolder.Click += new System.EventHandler(this.cmbBrowseFolder_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(121, 87);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(321, 21);
            this.txtOutput.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "输出文件夹：";
            // 
            // cmbOutput
            // 
            this.cmbOutput.Location = new System.Drawing.Point(209, 160);
            this.cmbOutput.Name = "cmbOutput";
            this.cmbOutput.Size = new System.Drawing.Size(75, 23);
            this.cmbOutput.TabIndex = 6;
            this.cmbOutput.Text = "导出(&E)";
            this.cmbOutput.UseVisualStyleBackColor = true;
            this.cmbOutput.Click += new System.EventHandler(this.cmbOutput_Click);
            // 
            // ofdInput
            // 
            this.ofdInput.FileName = "openFileDialog1";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(163, 124);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(67, 21);
            this.txtWidth.TabIndex = 7;
            this.txtWidth.Text = "2853";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "x";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(270, 124);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(67, 21);
            this.txtHeight.TabIndex = 9;
            this.txtHeight.Text = "1440";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 195);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.cmbOutput);
            this.Controls.Add(this.cmbBrowseFolder);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBrowseFile);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "PowerPoint To Image Tool";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button cmbBrowseFile;
        private System.Windows.Forms.Button cmbBrowseFolder;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmbOutput;
        private System.Windows.Forms.FolderBrowserDialog fbdOutput;
        private System.Windows.Forms.OpenFileDialog ofdInput;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHeight;
    }
}

