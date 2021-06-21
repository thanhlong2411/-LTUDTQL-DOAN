namespace QuanLyNhanVien_DoAn
{
    partial class FormDoiMK
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbtennguoidungdmk = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtmkcudmk = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txthotendmk = new System.Windows.Forms.TextBox();
            this.txtdmk = new System.Windows.Forms.TextBox();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(98, 41);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(368, 57);
            this.labelX3.TabIndex = 20;
            this.labelX3.Text = "Phần Mền Quản Lý Nhân Sự";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.cbtennguoidungdmk);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtmkcudmk);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txthotendmk);
            this.groupBox3.Controls.Add(this.txtdmk);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(56, 106);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(452, 263);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Đổi Mật Khẩu";
            // 
            // cbtennguoidungdmk
            // 
            this.cbtennguoidungdmk.FormattingEnabled = true;
            this.cbtennguoidungdmk.Location = new System.Drawing.Point(221, 39);
            this.cbtennguoidungdmk.Name = "cbtennguoidungdmk";
            this.cbtennguoidungdmk.Size = new System.Drawing.Size(181, 30);
            this.cbtennguoidungdmk.TabIndex = 21;
            this.cbtennguoidungdmk.SelectedIndexChanged += new System.EventHandler(this.cbtennguoidungdmk_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(11, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 26);
            this.label9.TabIndex = 20;
            this.label9.Text = "Mật Khẩu Cũ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtmkcudmk
            // 
            this.txtmkcudmk.Location = new System.Drawing.Point(221, 92);
            this.txtmkcudmk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmkcudmk.Name = "txtmkcudmk";
            this.txtmkcudmk.PasswordChar = '*';
            this.txtmkcudmk.Size = new System.Drawing.Size(181, 30);
            this.txtmkcudmk.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(11, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 26);
            this.label6.TabIndex = 17;
            this.label6.Text = "Họ Tên";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(11, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 26);
            this.label7.TabIndex = 15;
            this.label7.Text = "Mật Khẩu Mới";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(11, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 26);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tên Người Dùng";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txthotendmk
            // 
            this.txthotendmk.Location = new System.Drawing.Point(220, 202);
            this.txthotendmk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txthotendmk.Name = "txthotendmk";
            this.txthotendmk.Size = new System.Drawing.Size(181, 30);
            this.txthotendmk.TabIndex = 2;
            // 
            // txtdmk
            // 
            this.txtdmk.Location = new System.Drawing.Point(220, 147);
            this.txtdmk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdmk.Name = "txtdmk";
            this.txtdmk.PasswordChar = '*';
            this.txtdmk.Size = new System.Drawing.Size(181, 30);
            this.txtdmk.TabIndex = 1;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Image = global::QuanLyNhanVien_DoAn.Properties.Resources.add;
            this.buttonX1.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.buttonX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.buttonX1.Location = new System.Drawing.Point(117, 377);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(135, 39);
            this.buttonX1.TabIndex = 22;
            this.buttonX1.Text = "Đổi Mật Khẩu";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Image = global::QuanLyNhanVien_DoAn.Properties.Resources.delete;
            this.buttonX2.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.buttonX2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.buttonX2.Location = new System.Drawing.Point(300, 377);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(120, 39);
            this.buttonX2.TabIndex = 21;
            this.buttonX2.Text = "Thoát";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // FormDoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyNhanVien_DoAn.Properties.Resources.afsadfdafdfaf;
            this.ClientSize = new System.Drawing.Size(565, 457);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.groupBox3);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(587, 513);
            this.Name = "FormDoiMK";
            this.Text = "FormDoiMK";
            this.Load += new System.EventHandler(this.FormDoiMK_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbtennguoidungdmk;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtmkcudmk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txthotendmk;
        private System.Windows.Forms.TextBox txtdmk;
    }
}