namespace QuanLyCuaHangMayTinh.Views
{
    partial class FormHoaDonNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.DTGV = new System.Windows.Forms.DataGridView();
            this.grbNhanVien = new System.Windows.Forms.GroupBox();
            this.cbNhanVien = new System.Windows.Forms.ComboBox();
            this.grbNCC = new System.Windows.Forms.GroupBox();
            this.cbNCC = new System.Windows.Forms.ComboBox();
            this.grbTime = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTGV)).BeginInit();
            this.grbNhanVien.SuspendLayout();
            this.grbNCC.SuspendLayout();
            this.grbTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(20, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 36);
            this.label1.TabIndex = 55;
            this.label1.Text = "Hóa Đơn Nhập";
            // 
            // DTGV
            // 
            this.DTGV.AllowUserToAddRows = false;
            this.DTGV.AllowUserToDeleteRows = false;
            this.DTGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGV.Location = new System.Drawing.Point(319, 131);
            this.DTGV.Margin = new System.Windows.Forms.Padding(4);
            this.DTGV.Name = "DTGV";
            this.DTGV.RowHeadersWidth = 62;
            this.DTGV.RowTemplate.Height = 28;
            this.DTGV.Size = new System.Drawing.Size(818, 500);
            this.DTGV.TabIndex = 54;
            // 
            // grbNhanVien
            // 
            this.grbNhanVien.Controls.Add(this.cbNhanVien);
            this.grbNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNhanVien.Location = new System.Drawing.Point(15, 315);
            this.grbNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.grbNhanVien.Name = "grbNhanVien";
            this.grbNhanVien.Padding = new System.Windows.Forms.Padding(4);
            this.grbNhanVien.Size = new System.Drawing.Size(296, 105);
            this.grbNhanVien.TabIndex = 52;
            this.grbNhanVien.TabStop = false;
            this.grbNhanVien.Text = "Nhân viên";
            // 
            // cbNhanVien
            // 
            this.cbNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNhanVien.FormattingEnabled = true;
            this.cbNhanVien.Location = new System.Drawing.Point(9, 45);
            this.cbNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.cbNhanVien.Name = "cbNhanVien";
            this.cbNhanVien.Size = new System.Drawing.Size(279, 33);
            this.cbNhanVien.TabIndex = 0;
            this.cbNhanVien.Text = "Chọn nhân viên";
            // 
            // grbNCC
            // 
            this.grbNCC.Controls.Add(this.cbNCC);
            this.grbNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNCC.Location = new System.Drawing.Point(15, 442);
            this.grbNCC.Margin = new System.Windows.Forms.Padding(4);
            this.grbNCC.Name = "grbNCC";
            this.grbNCC.Padding = new System.Windows.Forms.Padding(4);
            this.grbNCC.Size = new System.Drawing.Size(296, 105);
            this.grbNCC.TabIndex = 53;
            this.grbNCC.TabStop = false;
            this.grbNCC.Text = "Nhà cung cấp";
            // 
            // cbNCC
            // 
            this.cbNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNCC.FormattingEnabled = true;
            this.cbNCC.Location = new System.Drawing.Point(9, 45);
            this.cbNCC.Margin = new System.Windows.Forms.Padding(4);
            this.cbNCC.Name = "cbNCC";
            this.cbNCC.Size = new System.Drawing.Size(279, 33);
            this.cbNCC.TabIndex = 0;
            this.cbNCC.Text = "Chọn nhà cung cấp";
            // 
            // grbTime
            // 
            this.grbTime.Controls.Add(this.dateTimePicker2);
            this.grbTime.Controls.Add(this.label3);
            this.grbTime.Controls.Add(this.label2);
            this.grbTime.Controls.Add(this.dateTimePicker1);
            this.grbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTime.Location = new System.Drawing.Point(15, 169);
            this.grbTime.Margin = new System.Windows.Forms.Padding(4);
            this.grbTime.Name = "grbTime";
            this.grbTime.Padding = new System.Windows.Forms.Padding(4);
            this.grbTime.Size = new System.Drawing.Size(296, 125);
            this.grbTime.TabIndex = 51;
            this.grbTime.TabStop = false;
            this.grbTime.Text = "Thời gian";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(67, 78);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(221, 30);
            this.dateTimePicker2.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Đến: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Từ: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(67, 31);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(221, 30);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // btnXem
            // 
            this.btnXem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.Location = new System.Drawing.Point(743, 66);
            this.btnXem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 40);
            this.btnXem.TabIndex = 59;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(669, 66);
            this.btnFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(68, 40);
            this.btnFind.TabIndex = 58;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(308, 68);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(355, 35);
            this.txtSearch.TabIndex = 57;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(876, 68);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 40);
            this.button1.TabIndex = 56;
            this.button1.Text = "Nhập hàng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 694);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTGV);
            this.Controls.Add(this.grbNhanVien);
            this.Controls.Add(this.grbNCC);
            this.Controls.Add(this.grbTime);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.button1);
            this.Name = "HoaDonNhap";
            this.Text = "Hóa Đơn Nhập";
            ((System.ComponentModel.ISupportInitialize)(this.DTGV)).EndInit();
            this.grbNhanVien.ResumeLayout(false);
            this.grbNCC.ResumeLayout(false);
            this.grbTime.ResumeLayout(false);
            this.grbTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DTGV;
        private System.Windows.Forms.GroupBox grbNhanVien;
        private System.Windows.Forms.ComboBox cbNhanVien;
        private System.Windows.Forms.GroupBox grbNCC;
        private System.Windows.Forms.ComboBox cbNCC;
        private System.Windows.Forms.GroupBox grbTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button button1;
    }
}