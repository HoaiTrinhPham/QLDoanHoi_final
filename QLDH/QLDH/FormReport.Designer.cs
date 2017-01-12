namespace QLDH
{
    partial class FormReport
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
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTongDiem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(12, 57);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(170, 20);
            this.txtMSSV.TabIndex = 1;
            this.txtMSSV.TextChanged += new System.EventHandler(this.txtMSSV_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã số sinh viên";
            // 
            // flowLayoutPnl
            // 
            this.flowLayoutPnl.Location = new System.Drawing.Point(12, 94);
            this.flowLayoutPnl.Name = "flowLayoutPnl";
            this.flowLayoutPnl.Size = new System.Drawing.Size(397, 204);
            this.flowLayoutPnl.TabIndex = 3;
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tổng điểm rèn luyện";
            // 
            // lblTongDiem
            // 
            this.lblTongDiem.AutoSize = true;
            this.lblTongDiem.Location = new System.Drawing.Point(313, 57);
            this.lblTongDiem.Name = "lblTongDiem";
            this.lblTongDiem.Size = new System.Drawing.Size(0, 13);
            this.lblTongDiem.TabIndex = 5;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 310);
            this.Controls.Add(this.lblTongDiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPnl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMSSV);
            this.Name = "FormReport";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.FormReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPnl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTongDiem;
    }
}