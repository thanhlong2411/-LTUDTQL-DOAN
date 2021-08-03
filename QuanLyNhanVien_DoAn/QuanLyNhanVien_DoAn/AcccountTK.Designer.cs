
namespace QuanLyNhanVien_DoAn
{
    partial class AcccountTK
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcccountTK));
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nmAccountType = new System.Windows.Forms.NumericUpDown();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNewUserName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.btnViewAcc = new System.Windows.Forms.Button();
            this.btnDeleteAcc = new System.Windows.Forms.Button();
            this.btnAddAcc = new System.Windows.Forms.Button();
            this.btnEditAcc = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmAccountType)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Purple;
            this.label20.Location = new System.Drawing.Point(420, 34);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(359, 45);
            this.label20.TabIndex = 29;
            this.label20.Text = "Quản Lý Tài Khoản";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nmAccountType);
            this.groupBox3.Controls.Add(this.txtDisplayName);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtNewUserName);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtUserName);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Purple;
            this.groupBox3.Location = new System.Drawing.Point(16, 110);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1150, 178);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Cơ Bản";
            // 
            // nmAccountType
            // 
            this.nmAccountType.Location = new System.Drawing.Point(809, 105);
            this.nmAccountType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nmAccountType.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmAccountType.Name = "nmAccountType";
            this.nmAccountType.Size = new System.Drawing.Size(265, 28);
            this.nmAccountType.TabIndex = 1;
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Location = new System.Drawing.Point(809, 43);
            this.txtDisplayName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(265, 28);
            this.txtDisplayName.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(600, 111);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "Loại tài khoản:";
            // 
            // txtNewUserName
            // 
            this.txtNewUserName.Location = new System.Drawing.Point(246, 110);
            this.txtNewUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNewUserName.Name = "txtNewUserName";
            this.txtNewUserName.Size = new System.Drawing.Size(257, 28);
            this.txtNewUserName.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(600, 49);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 23);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tên hiển thị:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(246, 45);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(257, 28);
            this.txtUserName.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(23, 115);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(173, 23);
            this.label13.TabIndex = 0;
            this.label13.Text = "Tên tài khoản mới: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(23, 48);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 23);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tên tài khoản:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnResetPassword);
            this.groupBox2.Controls.Add(this.btnViewAcc);
            this.groupBox2.Controls.Add(this.btnDeleteAcc);
            this.groupBox2.Controls.Add(this.btnAddAcc);
            this.groupBox2.Controls.Add(this.btnEditAcc);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Purple;
            this.groupBox2.Location = new System.Drawing.Point(16, 300);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1150, 103);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvAccount);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Purple;
            this.groupBox1.Location = new System.Drawing.Point(16, 418);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1150, 302);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hiện Thị Thông Tin";
            // 
            // dgvAccount
            // 
            this.dgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccount.BackgroundColor = System.Drawing.Color.White;
            this.dgvAccount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.GridColor = System.Drawing.Color.DarkGray;
            this.dgvAccount.Location = new System.Drawing.Point(18, 27);
            this.dgvAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAccount.MultiSelect = false;
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.RowHeadersWidth = 62;
            this.dgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccount.Size = new System.Drawing.Size(1116, 259);
            this.dgvAccount.TabIndex = 14;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnResetPassword.BackgroundImage")));
            this.btnResetPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnResetPassword.FlatAppearance.BorderSize = 0;
            this.btnResetPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnResetPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPassword.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResetPassword.Location = new System.Drawing.Point(886, 35);
            this.btnResetPassword.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(205, 48);
            this.btnResetPassword.TabIndex = 14;
            this.btnResetPassword.Text = "Đặt Lại Mật Khẩu";
            this.btnResetPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetPassword.UseVisualStyleBackColor = true;
            // 
            // btnViewAcc
            // 
            this.btnViewAcc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewAcc.BackgroundImage")));
            this.btnViewAcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewAcc.FlatAppearance.BorderSize = 0;
            this.btnViewAcc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnViewAcc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnViewAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAcc.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewAcc.Location = new System.Drawing.Point(288, 35);
            this.btnViewAcc.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewAcc.Name = "btnViewAcc";
            this.btnViewAcc.Size = new System.Drawing.Size(113, 48);
            this.btnViewAcc.TabIndex = 10;
            this.btnViewAcc.Text = "Hiện Thị";
            this.btnViewAcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewAcc.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAcc
            // 
            this.btnDeleteAcc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteAcc.BackgroundImage")));
            this.btnDeleteAcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteAcc.FlatAppearance.BorderSize = 0;
            this.btnDeleteAcc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteAcc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAcc.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteAcc.Location = new System.Drawing.Point(720, 35);
            this.btnDeleteAcc.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteAcc.Name = "btnDeleteAcc";
            this.btnDeleteAcc.Size = new System.Drawing.Size(105, 48);
            this.btnDeleteAcc.TabIndex = 13;
            this.btnDeleteAcc.Text = "Xóa   ";
            this.btnDeleteAcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAcc.UseVisualStyleBackColor = true;
            // 
            // btnAddAcc
            // 
            this.btnAddAcc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddAcc.BackgroundImage")));
            this.btnAddAcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddAcc.FlatAppearance.BorderSize = 0;
            this.btnAddAcc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddAcc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAcc.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddAcc.Location = new System.Drawing.Point(430, 35);
            this.btnAddAcc.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAcc.Name = "btnAddAcc";
            this.btnAddAcc.Size = new System.Drawing.Size(105, 48);
            this.btnAddAcc.TabIndex = 11;
            this.btnAddAcc.Text = "Thêm ";
            this.btnAddAcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAcc.UseVisualStyleBackColor = true;
            // 
            // btnEditAcc
            // 
            this.btnEditAcc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditAcc.BackgroundImage")));
            this.btnEditAcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditAcc.FlatAppearance.BorderSize = 0;
            this.btnEditAcc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEditAcc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEditAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAcc.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditAcc.Location = new System.Drawing.Point(580, 35);
            this.btnEditAcc.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditAcc.Name = "btnEditAcc";
            this.btnEditAcc.Size = new System.Drawing.Size(105, 48);
            this.btnEditAcc.TabIndex = 12;
            this.btnEditAcc.Text = "Sửa   ";
            this.btnEditAcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditAcc.UseVisualStyleBackColor = true;
            // 
            // AcccountTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label20);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AcccountTK";
            this.Size = new System.Drawing.Size(1182, 755);
            this.Load += new System.EventHandler(this.AcccountTK_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmAccountType)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown nmAccountType;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNewUserName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Button btnViewAcc;
        private System.Windows.Forms.Button btnDeleteAcc;
        private System.Windows.Forms.Button btnAddAcc;
        private System.Windows.Forms.Button btnEditAcc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvAccount;
    }
}
