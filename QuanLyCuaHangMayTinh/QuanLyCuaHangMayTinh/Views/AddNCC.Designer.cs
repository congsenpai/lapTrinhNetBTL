namespace QuanLyCuaHangMayTinh.Views
{
    partial class AddNCC
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
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Boqua = new System.Windows.Forms.Button();
            this.txt_Diachi = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_TenNCC = new System.Windows.Forms.TextBox();
            this.txt_MaNCC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(778, 400);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(122, 43);
            this.btn_Luu.TabIndex = 31;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Boqua
            // 
            this.btn_Boqua.Location = new System.Drawing.Point(636, 400);
            this.btn_Boqua.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Boqua.Name = "btn_Boqua";
            this.btn_Boqua.Size = new System.Drawing.Size(122, 43);
            this.btn_Boqua.TabIndex = 30;
            this.btn_Boqua.Text = "Bỏ qua";
            this.btn_Boqua.UseVisualStyleBackColor = true;
            this.btn_Boqua.Click += new System.EventHandler(this.btn_Boqua_Click);
            // 
            // txt_Diachi
            // 
            this.txt_Diachi.Location = new System.Drawing.Point(293, 297);
            this.txt_Diachi.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Diachi.Multiline = true;
            this.txt_Diachi.Name = "txt_Diachi";
            this.txt_Diachi.Size = new System.Drawing.Size(265, 34);
            this.txt_Diachi.TabIndex = 29;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(293, 233);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(2);
            this.txt_SDT.Multiline = true;
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(265, 34);
            this.txt_SDT.TabIndex = 28;
            this.txt_SDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckKeyPress);
            // 
            // txt_TenNCC
            // 
            this.txt_TenNCC.Location = new System.Drawing.Point(293, 171);
            this.txt_TenNCC.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TenNCC.Multiline = true;
            this.txt_TenNCC.Name = "txt_TenNCC";
            this.txt_TenNCC.Size = new System.Drawing.Size(265, 34);
            this.txt_TenNCC.TabIndex = 27;
            // 
            // txt_MaNCC
            // 
            this.txt_MaNCC.Location = new System.Drawing.Point(293, 105);
            this.txt_MaNCC.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MaNCC.Multiline = true;
            this.txt_MaNCC.Name = "txt_MaNCC";
            this.txt_MaNCC.Size = new System.Drawing.Size(265, 34);
            this.txt_MaNCC.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(148, 170);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Tên nhà cung cấp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 233);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 297);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Địa chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mã nhà cung cấp";
            // 
            // AddNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 548);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Boqua);
            this.Controls.Add(this.txt_Diachi);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.txt_TenNCC);
            this.Controls.Add(this.txt_MaNCC);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddNCC";
            this.Text = "Thêm nhà cung cấp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddNCC_FormClosed);
            this.Load += new System.EventHandler(this.AddNCC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Boqua;
        private System.Windows.Forms.TextBox txt_Diachi;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_TenNCC;
        private System.Windows.Forms.TextBox txt_MaNCC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}