namespace QLDH
{
    partial class FormSinhVien
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
            this.btn_XoaSV = new System.Windows.Forms.Button();
            this.btn_SuaSV = new System.Windows.Forms.Button();
            this.btn_ThemSV = new System.Windows.Forms.Button();
            this.dtg_SinhVien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoSV = new System.Windows.Forms.TextBox();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cbQueQuan = new System.Windows.Forms.ComboBox();
            this.cbTonGiao = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbDanToc = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbChiDoan = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_SinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_XoaSV
            // 
            this.btn_XoaSV.Location = new System.Drawing.Point(469, 294);
            this.btn_XoaSV.Name = "btn_XoaSV";
            this.btn_XoaSV.Size = new System.Drawing.Size(115, 37);
            this.btn_XoaSV.TabIndex = 12;
            this.btn_XoaSV.Text = "Xóa";
            this.btn_XoaSV.UseVisualStyleBackColor = true;
            this.btn_XoaSV.Click += new System.EventHandler(this.btn_XoaSV_Click);
            // 
            // btn_SuaSV
            // 
            this.btn_SuaSV.Location = new System.Drawing.Point(302, 294);
            this.btn_SuaSV.Name = "btn_SuaSV";
            this.btn_SuaSV.Size = new System.Drawing.Size(115, 37);
            this.btn_SuaSV.TabIndex = 11;
            this.btn_SuaSV.Text = "Sửa";
            this.btn_SuaSV.UseVisualStyleBackColor = true;
            this.btn_SuaSV.Click += new System.EventHandler(this.btn_SuaSV_Click);
            // 
            // btn_ThemSV
            // 
            this.btn_ThemSV.Location = new System.Drawing.Point(137, 294);
            this.btn_ThemSV.Name = "btn_ThemSV";
            this.btn_ThemSV.Size = new System.Drawing.Size(115, 37);
            this.btn_ThemSV.TabIndex = 10;
            this.btn_ThemSV.Text = "Thêm";
            this.btn_ThemSV.UseVisualStyleBackColor = true;
            this.btn_ThemSV.Click += new System.EventHandler(this.btn_ThemSV_Click);
            // 
            // dtg_SinhVien
            // 
            this.dtg_SinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_SinhVien.Location = new System.Drawing.Point(30, 17);
            this.dtg_SinhVien.Name = "dtg_SinhVien";
            this.dtg_SinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_SinhVien.Size = new System.Drawing.Size(661, 249);
            this.dtg_SinhVien.TabIndex = 4;
            this.dtg_SinhVien.SelectionChanged += new System.EventHandler(this.dtg_SinhVien_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Họ sinh viên";
            // 
            // txtHoSV
            // 
            this.txtHoSV.Location = new System.Drawing.Point(333, 354);
            this.txtHoSV.Name = "txtHoSV";
            this.txtHoSV.Size = new System.Drawing.Size(121, 20);
            this.txtHoSV.TabIndex = 2;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Location = new System.Drawing.Point(94, 388);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(60, 21);
            this.cbGioiTinh.TabIndex = 4;
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(568, 352);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(123, 20);
            this.txtTenSV.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên sinh viên";
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(94, 352);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(121, 20);
            this.txtMSSV.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "MSSV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ngày sinh";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(333, 383);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Quê quán";
            // 
            // cbQueQuan
            // 
            this.cbQueQuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQueQuan.FormattingEnabled = true;
            this.cbQueQuan.Location = new System.Drawing.Point(333, 416);
            this.cbQueQuan.Name = "cbQueQuan";
            this.cbQueQuan.Size = new System.Drawing.Size(121, 21);
            this.cbQueQuan.TabIndex = 8;
            //this.cbQueQuan.SelectedIndexChanged += new System.EventHandler(this.cbQueQuan_SelectedIndexChanged);
            // 
            // cbTonGiao
            // 
            this.cbTonGiao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTonGiao.FormattingEnabled = true;
            this.cbTonGiao.Location = new System.Drawing.Point(568, 380);
            this.cbTonGiao.Name = "cbTonGiao";
            this.cbTonGiao.Size = new System.Drawing.Size(123, 21);
            this.cbTonGiao.TabIndex = 6;
            this.cbTonGiao.SelectedValueChanged += new System.EventHandler(this.cbTonGiao_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(501, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Tôn giáo";
            // 
            // cbDanToc
            // 
            this.cbDanToc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDanToc.FormattingEnabled = true;
            this.cbDanToc.Location = new System.Drawing.Point(568, 413);
            this.cbDanToc.Name = "cbDanToc";
            this.cbDanToc.Size = new System.Drawing.Size(123, 21);
            this.cbDanToc.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(501, 416);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Dân tộc";
            // 
            // cbChiDoan
            // 
            this.cbChiDoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChiDoan.FormattingEnabled = true;
            this.cbChiDoan.Location = new System.Drawing.Point(94, 418);
            this.cbChiDoan.Name = "cbChiDoan";
            this.cbChiDoan.Size = new System.Drawing.Size(121, 21);
            this.cbChiDoan.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 416);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Chi đoàn";
            // 
            // FormSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 491);
            this.Controls.Add(this.cbChiDoan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbDanToc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbTonGiao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbQueQuan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenSV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbGioiTinh);
            this.Controls.Add(this.txtHoSV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_XoaSV);
            this.Controls.Add(this.btn_SuaSV);
            this.Controls.Add(this.btn_ThemSV);
            this.Controls.Add(this.dtg_SinhVien);
            this.Name = "FormSinhVien";
            this.Text = "FormSinhVien";
            this.Load += new System.EventHandler(this.FormSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_SinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_XoaSV;
        private System.Windows.Forms.Button btn_SuaSV;
        private System.Windows.Forms.Button btn_ThemSV;
        private System.Windows.Forms.DataGridView dtg_SinhVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoSV;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbQueQuan;
        private System.Windows.Forms.ComboBox cbTonGiao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbDanToc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbChiDoan;
        private System.Windows.Forms.Label label9;
    }
}