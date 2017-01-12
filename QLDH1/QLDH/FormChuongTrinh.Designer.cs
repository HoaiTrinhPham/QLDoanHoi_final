namespace QLDH
{
    partial class FormChuongTrinh
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
            this.dtg_ChuongTrinh = new System.Windows.Forms.DataGridView();
            this.btn_ThemCT = new System.Windows.Forms.Button();
            this.btn_SuaCT = new System.Windows.Forms.Button();
            this.btn_XoaCT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenCT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMaCT = new System.Windows.Forms.Label();
            this.txtThoiGianBatDau = new System.Windows.Forms.TextBox();
            this.cbCapDo = new System.Windows.Forms.ComboBox();
            this.txtMaCT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ChuongTrinh)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_ChuongTrinh
            // 
            this.dtg_ChuongTrinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ChuongTrinh.Location = new System.Drawing.Point(12, 11);
            this.dtg_ChuongTrinh.Name = "dtg_ChuongTrinh";
            this.dtg_ChuongTrinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_ChuongTrinh.Size = new System.Drawing.Size(448, 249);
            this.dtg_ChuongTrinh.TabIndex = 0;
            this.dtg_ChuongTrinh.SelectionChanged += new System.EventHandler(this.dtg_ChuongTrinh_SelectionChanged);
            // 
            // btn_ThemCT
            // 
            this.btn_ThemCT.Location = new System.Drawing.Point(15, 282);
            this.btn_ThemCT.Name = "btn_ThemCT";
            this.btn_ThemCT.Size = new System.Drawing.Size(115, 37);
            this.btn_ThemCT.TabIndex = 5;
            this.btn_ThemCT.Text = "Thêm";
            this.btn_ThemCT.UseVisualStyleBackColor = true;
            this.btn_ThemCT.Click += new System.EventHandler(this.btn_ThemCT_Click);
            // 
            // btn_SuaCT
            // 
            this.btn_SuaCT.Location = new System.Drawing.Point(180, 282);
            this.btn_SuaCT.Name = "btn_SuaCT";
            this.btn_SuaCT.Size = new System.Drawing.Size(115, 37);
            this.btn_SuaCT.TabIndex = 6;
            this.btn_SuaCT.Text = "Sửa";
            this.btn_SuaCT.UseVisualStyleBackColor = true;
            this.btn_SuaCT.Click += new System.EventHandler(this.btn_SuaCT_Click);
            // 
            // btn_XoaCT
            // 
            this.btn_XoaCT.Location = new System.Drawing.Point(347, 282);
            this.btn_XoaCT.Name = "btn_XoaCT";
            this.btn_XoaCT.Size = new System.Drawing.Size(115, 37);
            this.btn_XoaCT.TabIndex = 7;
            this.btn_XoaCT.Text = "Xóa";
            this.btn_XoaCT.UseVisualStyleBackColor = true;
            this.btn_XoaCT.Click += new System.EventHandler(this.btn_XoaCT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã chương trình";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên chương trình";
            // 
            // txtTenCT
            // 
            this.txtTenCT.AcceptsReturn = true;
            this.txtTenCT.Location = new System.Drawing.Point(96, 385);
            this.txtTenCT.Name = "txtTenCT";
            this.txtTenCT.Size = new System.Drawing.Size(136, 20);
            this.txtTenCT.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cấp độ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Thời gian bắt đầu";
            // 
            // lblMaCT
            // 
            this.lblMaCT.AutoSize = true;
            this.lblMaCT.Location = new System.Drawing.Point(109, 340);
            this.lblMaCT.Name = "lblMaCT";
            this.lblMaCT.Size = new System.Drawing.Size(0, 13);
            this.lblMaCT.TabIndex = 10;
            // 
            // txtThoiGianBatDau
            // 
            this.txtThoiGianBatDau.Location = new System.Drawing.Point(344, 381);
            this.txtThoiGianBatDau.Name = "txtThoiGianBatDau";
            this.txtThoiGianBatDau.Size = new System.Drawing.Size(119, 20);
            this.txtThoiGianBatDau.TabIndex = 4;
            // 
            // cbCapDo
            // 
            this.cbCapDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCapDo.FormattingEnabled = true;
            this.cbCapDo.Location = new System.Drawing.Point(342, 335);
            this.cbCapDo.Name = "cbCapDo";
            this.cbCapDo.Size = new System.Drawing.Size(121, 21);
            this.cbCapDo.TabIndex = 3;
            // 
            // txtMaCT
            // 
            this.txtMaCT.Location = new System.Drawing.Point(96, 336);
            this.txtMaCT.Name = "txtMaCT";
            this.txtMaCT.Size = new System.Drawing.Size(136, 20);
            this.txtMaCT.TabIndex = 1;
            // 
            // FormChuongTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 417);
            this.Controls.Add(this.txtMaCT);
            this.Controls.Add(this.cbCapDo);
            this.Controls.Add(this.txtThoiGianBatDau);
            this.Controls.Add(this.lblMaCT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenCT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_XoaCT);
            this.Controls.Add(this.btn_SuaCT);
            this.Controls.Add(this.btn_ThemCT);
            this.Controls.Add(this.dtg_ChuongTrinh);
            this.Name = "FormChuongTrinh";
            this.Text = "Form Chương Trình";
            this.Load += new System.EventHandler(this.FormChuongTrinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ChuongTrinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_ChuongTrinh;
        private System.Windows.Forms.Button btn_ThemCT;
        private System.Windows.Forms.Button btn_SuaCT;
        private System.Windows.Forms.Button btn_XoaCT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenCT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMaCT;
        private System.Windows.Forms.TextBox txtThoiGianBatDau;
        private System.Windows.Forms.ComboBox cbCapDo;
        private System.Windows.Forms.TextBox txtMaCT;
    }
}