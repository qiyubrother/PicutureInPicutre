namespace PictureInPicture
{
    partial class FrmMain
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.listBoxSize = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLeft = new System.Windows.Forms.TextBox();
            this.txtTop = new System.Windows.Forms.TextBox();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtScale = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.listBoxVideoNo = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkAuxiliaryLines = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // listBoxSize
            // 
            this.listBoxSize.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.listBoxSize.FormattingEnabled = true;
            this.listBoxSize.ItemHeight = 21;
            this.listBoxSize.Items.AddRange(new object[] {
            "160X90",
            "240X135",
            "320X180",
            "400X225",
            "480X270",
            "560X315",
            "640X360",
            "720X405",
            "800X450",
            "880X495"});
            this.listBoxSize.Location = new System.Drawing.Point(12, 145);
            this.listBoxSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxSize.Name = "listBoxSize";
            this.listBoxSize.Size = new System.Drawing.Size(96, 214);
            this.listBoxSize.TabIndex = 0;
            this.listBoxSize.SelectedIndexChanged += new System.EventHandler(this.listBoxSize_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "左边距";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "上边距";
            // 
            // txtLeft
            // 
            this.txtLeft.Location = new System.Drawing.Point(117, 335);
            this.txtLeft.Name = "txtLeft";
            this.txtLeft.ReadOnly = true;
            this.txtLeft.Size = new System.Drawing.Size(53, 23);
            this.txtLeft.TabIndex = 3;
            this.txtLeft.Text = "0";
            // 
            // txtTop
            // 
            this.txtTop.Location = new System.Drawing.Point(176, 335);
            this.txtTop.Name = "txtTop";
            this.txtTop.ReadOnly = true;
            this.txtTop.Size = new System.Drawing.Size(53, 23);
            this.txtTop.TabIndex = 4;
            this.txtTop.Text = "0";
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.Black;
            this.pnlContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlContainer.Location = new System.Drawing.Point(117, 33);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(480, 270);
            this.pnlContainer.TabIndex = 5;
            this.pnlContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContainer_Paint);
            this.pnlContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlContainer_MouseDown);
            this.pnlContainer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlContainer_MouseMove);
            this.pnlContainer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlContainer_MouseUp);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(443, 334);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(524, 334);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "尺寸（宽X高）";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "快速布局（16:9）";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(235, 335);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.ReadOnly = true;
            this.txtWidth.Size = new System.Drawing.Size(53, 23);
            this.txtWidth.TabIndex = 15;
            this.txtWidth.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(232, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "窗口宽度";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(294, 335);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.ReadOnly = true;
            this.txtHeight.Size = new System.Drawing.Size(53, 23);
            this.txtHeight.TabIndex = 17;
            this.txtHeight.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(291, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "窗口高度";
            // 
            // txtScale
            // 
            this.txtScale.Location = new System.Drawing.Point(353, 335);
            this.txtScale.Name = "txtScale";
            this.txtScale.ReadOnly = true;
            this.txtScale.Size = new System.Drawing.Size(77, 23);
            this.txtScale.TabIndex = 19;
            this.txtScale.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(350, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "布局缩放比例";
            // 
            // listBoxVideoNo
            // 
            this.listBoxVideoNo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.listBoxVideoNo.FormattingEnabled = true;
            this.listBoxVideoNo.ItemHeight = 21;
            this.listBoxVideoNo.Items.AddRange(new object[] {
            "0 教师图像",
            "1 学生图像",
            "2 全班图像"});
            this.listBoxVideoNo.Location = new System.Drawing.Point(12, 33);
            this.listBoxVideoNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxVideoNo.Name = "listBoxVideoNo";
            this.listBoxVideoNo.Size = new System.Drawing.Size(99, 88);
            this.listBoxVideoNo.TabIndex = 20;
            this.listBoxVideoNo.SelectedIndexChanged += new System.EventHandler(this.listBoxVideoNo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "摄像头列表";
            // 
            // chkAuxiliaryLines
            // 
            this.chkAuxiliaryLines.AutoSize = true;
            this.chkAuxiliaryLines.Location = new System.Drawing.Point(534, 9);
            this.chkAuxiliaryLines.Name = "chkAuxiliaryLines";
            this.chkAuxiliaryLines.Size = new System.Drawing.Size(63, 21);
            this.chkAuxiliaryLines.TabIndex = 22;
            this.chkAuxiliaryLines.Text = "辅助线";
            this.chkAuxiliaryLines.UseVisualStyleBackColor = true;
            this.chkAuxiliaryLines.CheckedChanged += new System.EventHandler(this.chkAuxiliaryLines_CheckedChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 369);
            this.Controls.Add(this.chkAuxiliaryLines);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBoxVideoNo);
            this.Controls.Add(this.txtScale);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.txtTop);
            this.Controls.Add(this.txtLeft);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxSize);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "画中画布局设置";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLeft;
        private System.Windows.Forms.TextBox txtTop;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtScale;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBoxVideoNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkAuxiliaryLines;
    }
}

