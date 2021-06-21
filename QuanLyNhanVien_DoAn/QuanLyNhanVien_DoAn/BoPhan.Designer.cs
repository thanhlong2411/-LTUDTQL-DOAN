namespace QuanLyNhanVien_DoAn
{
    partial class BoPhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoPhan));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtmabophan = new System.Windows.Forms.TextBox();
            this.txttenbophan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.butshow = new System.Windows.Forms.Button();
            this.butthoat = new System.Windows.Forms.Button();
            this.butxoa = new System.Windows.Forms.Button();
            this.butthem = new System.Windows.Forms.Button();
            this.butsua = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DataGridView();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtmabophan);
            this.groupBox1.Controls.Add(this.txttenbophan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 171);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1086, 133);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin về bộ phận";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtmabophan
            // 
            this.txtmabophan.Location = new System.Drawing.Point(196, 64);
            this.txtmabophan.Margin = new System.Windows.Forms.Padding(4);
            this.txtmabophan.Name = "txtmabophan";
            this.txtmabophan.Size = new System.Drawing.Size(232, 28);
            this.txtmabophan.TabIndex = 3;
            // 
            // txttenbophan
            // 
            this.txttenbophan.Location = new System.Drawing.Point(675, 62);
            this.txttenbophan.Margin = new System.Windows.Forms.Padding(4);
            this.txttenbophan.Name = "txttenbophan";
            this.txttenbophan.Size = new System.Drawing.Size(232, 28);
            this.txttenbophan.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên bộ phận";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã bộ phận";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.butshow);
            this.groupBox2.Controls.Add(this.butthoat);
            this.groupBox2.Controls.Add(this.butxoa);
            this.groupBox2.Controls.Add(this.butthem);
            this.groupBox2.Controls.Add(this.butsua);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(36, 328);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1086, 80);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Các chức năng";
            // 
            // butshow
            // 
            this.butshow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butshow.BackgroundImage")));
            this.butshow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butshow.FlatAppearance.BorderSize = 0;
            this.butshow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.butshow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.butshow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butshow.Image = global::QuanLyNhanVien_DoAn.Properties.Resources.upload;
            this.butshow.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butshow.Location = new System.Drawing.Point(255, 20);
            this.butshow.Margin = new System.Windows.Forms.Padding(4);
            this.butshow.Name = "butshow";
            this.butshow.Size = new System.Drawing.Size(105, 43);
            this.butshow.TabIndex = 0;
            this.butshow.Text = "Hiện Thị";
            this.butshow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butshow.UseVisualStyleBackColor = true;
            this.butshow.Click += new System.EventHandler(this.butshow_Click);
            // 
            // butthoat
            // 
            this.butthoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butthoat.BackgroundImage")));
            this.butthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butthoat.FlatAppearance.BorderSize = 0;
            this.butthoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.butthoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.butthoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butthoat.Image = global::QuanLyNhanVien_DoAn.Properties.Resources._1;
            this.butthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butthoat.Location = new System.Drawing.Point(846, 20);
            this.butthoat.Margin = new System.Windows.Forms.Padding(4);
            this.butthoat.Name = "butthoat";
            this.butthoat.Size = new System.Drawing.Size(105, 43);
            this.butthoat.TabIndex = 5;
            this.butthoat.Text = "Thoát ";
            this.butthoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butthoat.UseVisualStyleBackColor = true;
            this.butthoat.Click += new System.EventHandler(this.butthoat_Click);
            // 
            // butxoa
            // 
            this.butxoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butxoa.BackgroundImage")));
            this.butxoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butxoa.FlatAppearance.BorderSize = 0;
            this.butxoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.butxoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.butxoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butxoa.Image = global::QuanLyNhanVien_DoAn.Properties.Resources.remove_user;
            this.butxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butxoa.Location = new System.Drawing.Point(697, 21);
            this.butxoa.Margin = new System.Windows.Forms.Padding(4);
            this.butxoa.Name = "butxoa";
            this.butxoa.Size = new System.Drawing.Size(105, 43);
            this.butxoa.TabIndex = 3;
            this.butxoa.Text = "Xóa   ";
            this.butxoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butxoa.UseVisualStyleBackColor = true;
            this.butxoa.Click += new System.EventHandler(this.butxoa_Click);
            // 
            // butthem
            // 
            this.butthem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butthem.BackgroundImage")));
            this.butthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butthem.FlatAppearance.BorderSize = 0;
            this.butthem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.butthem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.butthem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butthem.Image = global::QuanLyNhanVien_DoAn.Properties.Resources.add_user;
            this.butthem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butthem.Location = new System.Drawing.Point(407, 21);
            this.butthem.Margin = new System.Windows.Forms.Padding(4);
            this.butthem.Name = "butthem";
            this.butthem.Size = new System.Drawing.Size(105, 43);
            this.butthem.TabIndex = 1;
            this.butthem.Text = "Thêm ";
            this.butthem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butthem.UseVisualStyleBackColor = true;
            this.butthem.Click += new System.EventHandler(this.butthem_Click);
            // 
            // butsua
            // 
            this.butsua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butsua.BackgroundImage")));
            this.butsua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butsua.FlatAppearance.BorderSize = 0;
            this.butsua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.butsua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.butsua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butsua.Image = global::QuanLyNhanVien_DoAn.Properties.Resources.edit_user;
            this.butsua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butsua.Location = new System.Drawing.Point(551, 20);
            this.butsua.Margin = new System.Windows.Forms.Padding(4);
            this.butsua.Name = "butsua";
            this.butsua.Size = new System.Drawing.Size(105, 43);
            this.butsua.TabIndex = 2;
            this.butsua.Text = "Sửa   ";
            this.butsua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butsua.UseVisualStyleBackColor = true;
            this.butsua.Click += new System.EventHandler(this.butsua_Click);
            // 
            // data
            // 
            this.data.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(36, 448);
            this.data.Name = "data";
            this.data.RowHeadersWidth = 62;
            this.data.RowTemplate.Height = 28;
            this.data.Size = new System.Drawing.Size(1086, 249);
            this.data.TabIndex = 12;
            this.data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellContentClick);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.DarkViolet;
            this.label20.Location = new System.Drawing.Point(417, 71);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(323, 45);
            this.label20.TabIndex = 13;
            this.label20.Text = "Quản Lý Bộ Phận";
            // 
            // BoPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label20);
            this.Controls.Add(this.data);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BoPhan";
            this.Size = new System.Drawing.Size(1158, 734);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtmabophan;
        private System.Windows.Forms.TextBox txttenbophan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button butshow;
        private System.Windows.Forms.Button butthoat;
        private System.Windows.Forms.Button butxoa;
        private System.Windows.Forms.Button butthem;
        private System.Windows.Forms.Button butsua;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Label label20;
    }
}
