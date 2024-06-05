namespace QuanLyCuaHangMayTinh.Views
{
    partial class FormNhanVien
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdDESC = new System.Windows.Forms.RadioButton();
            this.rdASC = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdNgaySinh = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rdGioitinh = new System.Windows.Forms.RadioButton();
            this.rdPhone = new System.Windows.Forms.RadioButton();
            this.rdName = new System.Windows.Forms.RadioButton();
            this.rdID = new System.Windows.Forms.RadioButton();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.DTGV = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGV)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(787, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 44;
            this.button1.Text = "Xem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.rdDESC);
            this.groupBox2.Controls.Add(this.rdASC);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(42, 482);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 174);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cách sắp xếp";
            // 
            // rdDESC
            // 
            this.rdDESC.AutoSize = true;
            this.rdDESC.Location = new System.Drawing.Point(5, 91);
            this.rdDESC.Name = "rdDESC";
            this.rdDESC.Size = new System.Drawing.Size(130, 31);
            this.rdDESC.TabIndex = 5;
            this.rdDESC.TabStop = true;
            this.rdDESC.Text = "Giảm dần";
            this.rdDESC.UseVisualStyleBackColor = true;
            // 
            // rdASC
            // 
            this.rdASC.AutoSize = true;
            this.rdASC.Location = new System.Drawing.Point(5, 43);
            this.rdASC.Name = "rdASC";
            this.rdASC.Size = new System.Drawing.Size(126, 31);
            this.rdASC.TabIndex = 0;
            this.rdASC.TabStop = true;
            this.rdASC.Text = "Tăng dần";
            this.rdASC.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.rdNgaySinh);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.rdGioitinh);
            this.groupBox1.Controls.Add(this.rdPhone);
            this.groupBox1.Controls.Add(this.rdName);
            this.groupBox1.Controls.Add(this.rdID);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(42, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 304);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cách tìm kiếm";
            // 
            // rdNgaySinh
            // 
            this.rdNgaySinh.AutoSize = true;
            this.rdNgaySinh.Location = new System.Drawing.Point(7, 88);
            this.rdNgaySinh.Name = "rdNgaySinh";
            this.rdNgaySinh.Size = new System.Drawing.Size(183, 31);
            this.rdNgaySinh.TabIndex = 10;
            this.rdNgaySinh.TabStop = true;
            this.rdNgaySinh.Text = "Theo ngày sinh";
            this.rdNgaySinh.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(209, 35);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 239);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(214, 31);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Theo số điện thoại";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rdGioitinh
            // 
            this.rdGioitinh.AutoSize = true;
            this.rdGioitinh.Location = new System.Drawing.Point(6, 200);
            this.rdGioitinh.Name = "rdGioitinh";
            this.rdGioitinh.Size = new System.Drawing.Size(171, 31);
            this.rdGioitinh.TabIndex = 7;
            this.rdGioitinh.TabStop = true;
            this.rdGioitinh.Text = "Theo giới tính";
            this.rdGioitinh.UseVisualStyleBackColor = true;
            // 
            // rdPhone
            // 
            this.rdPhone.AutoSize = true;
            this.rdPhone.Location = new System.Drawing.Point(-23, 162);
            this.rdPhone.Name = "rdPhone";
            this.rdPhone.Size = new System.Drawing.Size(21, 20);
            this.rdPhone.TabIndex = 6;
            this.rdPhone.TabStop = true;
            this.rdPhone.UseVisualStyleBackColor = true;
            // 
            // rdName
            // 
            this.rdName.AutoSize = true;
            this.rdName.Location = new System.Drawing.Point(6, 162);
            this.rdName.Name = "rdName";
            this.rdName.Size = new System.Drawing.Size(122, 31);
            this.rdName.TabIndex = 5;
            this.rdName.TabStop = true;
            this.rdName.Text = "Theo tên";
            this.rdName.UseVisualStyleBackColor = true;
            // 
            // rdID
            // 
            this.rdID.AutoSize = true;
            this.rdID.Location = new System.Drawing.Point(6, 125);
            this.rdID.Name = "rdID";
            this.rdID.Size = new System.Drawing.Size(221, 31);
            this.rdID.TabIndex = 4;
            this.rdID.TabStop = true;
            this.rdID.Text = "Theo mã nhân viên";
            this.rdID.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(713, 73);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(68, 40);
            this.btnFind.TabIndex = 41;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(338, 76);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(355, 35);
            this.txtSearch.TabIndex = 40;
            // 
            // DTGV
            // 
            this.DTGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DTGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGV.Location = new System.Drawing.Point(327, 161);
            this.DTGV.Margin = new System.Windows.Forms.Padding(2);
            this.DTGV.Name = "DTGV";
            this.DTGV.ReadOnly = true;
            this.DTGV.RowHeadersWidth = 82;
            this.DTGV.RowTemplate.Height = 33;
            this.DTGV.Size = new System.Drawing.Size(759, 495);
            this.DTGV.TabIndex = 39;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(878, 73);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(197, 40);
            this.btnAdd.TabIndex = 38;
            this.btnAdd.Text = "Thêm nhân viên";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(41, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 36);
            this.label1.TabIndex = 37;
            this.label1.Text = "Nhân viên";
            // 
            // Nhân_viên
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 706);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.DTGV);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Nhân_viên";
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.nhanvien_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdDESC;
        private System.Windows.Forms.RadioButton rdASC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rdGioitinh;
        private System.Windows.Forms.RadioButton rdPhone;
        private System.Windows.Forms.RadioButton rdName;
        private System.Windows.Forms.RadioButton rdID;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView DTGV;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton rdNgaySinh;
    }
}