namespace QuanLyCuaHangMayTinh.Views
{
    partial class DanhSachhanghoa
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
            this.components = new System.ComponentModel.Container();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.DTGV = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.bánHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sổQuỹToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đốiTácToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giaoDịchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnBánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tổngQuanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rdRam = new System.Windows.Forms.RadioButton();
            this.rdTenMay = new System.Windows.Forms.RadioButton();
            this.rdLoaiMay = new System.Windows.Forms.RadioButton();
            this.rdLoaiChip = new System.Windows.Forms.RadioButton();
            this.rdOCung = new System.Windows.Forms.RadioButton();
            this.rdCoManHinh = new System.Windows.Forms.RadioButton();
            this.rdUSB = new System.Windows.Forms.RadioButton();
            this.rdOCD = new System.Windows.Forms.RadioButton();
            this.rdHSX = new System.Windows.Forms.RadioButton();
            this.rdDL = new System.Windows.Forms.RadioButton();
            this.rdTD = new System.Windows.Forms.RadioButton();
            this.rdManHinh = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.rdKeyBoard = new System.Windows.Forms.RadioButton();
            this.rdMouse = new System.Windows.Forms.RadioButton();
            this.rdSpeaker = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DTGV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXem
            // 
            this.btnXem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.Location = new System.Drawing.Point(760, 96);
            this.btnXem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 40);
            this.btnXem.TabIndex = 37;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(686, 96);
            this.btnFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(68, 40);
            this.btnFind.TabIndex = 34;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(325, 98);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(355, 35);
            this.txtSearch.TabIndex = 33;
            // 
            // DTGV
            // 
            this.DTGV.AllowUserToAddRows = false;
            this.DTGV.AllowUserToDeleteRows = false;
            this.DTGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGV.Location = new System.Drawing.Point(300, 184);
            this.DTGV.Margin = new System.Windows.Forms.Padding(2);
            this.DTGV.Name = "DTGV";
            this.DTGV.ReadOnly = true;
            this.DTGV.RowHeadersWidth = 82;
            this.DTGV.RowTemplate.Height = 33;
            this.DTGV.Size = new System.Drawing.Size(759, 495);
            this.DTGV.TabIndex = 32;
            this.DTGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGV_CellDoubleClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(893, 98);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(200, 40);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "Thêm Hàng hóa";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // bánHàngToolStripMenuItem
            // 
            this.bánHàngToolStripMenuItem.Name = "bánHàngToolStripMenuItem";
            this.bánHàngToolStripMenuItem.Size = new System.Drawing.Size(119, 31);
            this.bánHàngToolStripMenuItem.Text = "Bán hàng";
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(107, 31);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // sổQuỹToolStripMenuItem
            // 
            this.sổQuỹToolStripMenuItem.Name = "sổQuỹToolStripMenuItem";
            this.sổQuỹToolStripMenuItem.Size = new System.Drawing.Size(94, 31);
            this.sổQuỹToolStripMenuItem.Text = "Sổ quỹ";
            // 
            // nhàCungCấpToolStripMenuItem
            // 
            this.nhàCungCấpToolStripMenuItem.Name = "nhàCungCấpToolStripMenuItem";
            this.nhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(246, 36);
            this.nhàCungCấpToolStripMenuItem.Text = "Nhà cung cấp";
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(246, 36);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            // 
            // đốiTácToolStripMenuItem
            // 
            this.đốiTácToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kháchHàngToolStripMenuItem,
            this.nhàCungCấpToolStripMenuItem});
            this.đốiTácToolStripMenuItem.Name = "đốiTácToolStripMenuItem";
            this.đốiTácToolStripMenuItem.Size = new System.Drawing.Size(98, 31);
            this.đốiTácToolStripMenuItem.Text = "Đối tác";
            // 
            // giaoDịchToolStripMenuItem
            // 
            this.giaoDịchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hóaĐơnBánToolStripMenuItem,
            this.hóaĐơnNhậpToolStripMenuItem});
            this.giaoDịchToolStripMenuItem.Name = "giaoDịchToolStripMenuItem";
            this.giaoDịchToolStripMenuItem.Size = new System.Drawing.Size(121, 31);
            this.giaoDịchToolStripMenuItem.Text = "Giao dịch";
            // 
            // hóaĐơnBánToolStripMenuItem
            // 
            this.hóaĐơnBánToolStripMenuItem.Name = "hóaĐơnBánToolStripMenuItem";
            this.hóaĐơnBánToolStripMenuItem.Size = new System.Drawing.Size(250, 36);
            this.hóaĐơnBánToolStripMenuItem.Text = "Hóa đơn bán";
            // 
            // hóaĐơnNhậpToolStripMenuItem
            // 
            this.hóaĐơnNhậpToolStripMenuItem.Name = "hóaĐơnNhậpToolStripMenuItem";
            this.hóaĐơnNhậpToolStripMenuItem.Size = new System.Drawing.Size(250, 36);
            this.hóaĐơnNhậpToolStripMenuItem.Text = "Hóa đơn nhập";
            // 
            // hàngHóaToolStripMenuItem
            // 
            this.hàngHóaToolStripMenuItem.Name = "hàngHóaToolStripMenuItem";
            this.hàngHóaToolStripMenuItem.Size = new System.Drawing.Size(120, 31);
            this.hàngHóaToolStripMenuItem.Text = "Hàng hóa";
            // 
            // tổngQuanToolStripMenuItem
            // 
            this.tổngQuanToolStripMenuItem.Name = "tổngQuanToolStripMenuItem";
            this.tổngQuanToolStripMenuItem.Size = new System.Drawing.Size(130, 31);
            this.tổngQuanToolStripMenuItem.Text = "Tổng quan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(14, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 36);
            this.label1.TabIndex = 30;
            this.label1.Text = "Hàng hóa";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tổngQuanToolStripMenuItem,
            this.hàngHóaToolStripMenuItem,
            this.giaoDịchToolStripMenuItem,
            this.đốiTácToolStripMenuItem,
            this.sổQuỹToolStripMenuItem,
            this.báoCáoToolStripMenuItem,
            this.bánHàngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1130, 35);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 184);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(281, 202);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm theo thiết bị nội vi";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.rdRam);
            this.flowLayoutPanel1.Controls.Add(this.rdTenMay);
            this.flowLayoutPanel1.Controls.Add(this.rdLoaiMay);
            this.flowLayoutPanel1.Controls.Add(this.rdLoaiChip);
            this.flowLayoutPanel1.Controls.Add(this.rdOCung);
            this.flowLayoutPanel1.Controls.Add(this.rdCoManHinh);
            this.flowLayoutPanel1.Controls.Add(this.rdUSB);
            this.flowLayoutPanel1.Controls.Add(this.rdOCD);
            this.flowLayoutPanel1.Controls.Add(this.rdHSX);
            this.flowLayoutPanel1.Controls.Add(this.rdDL);
            this.flowLayoutPanel1.Controls.Add(this.rdTD);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 32);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(275, 166);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // rdRam
            // 
            this.rdRam.AutoSize = true;
            this.rdRam.Location = new System.Drawing.Point(3, 3);
            this.rdRam.Name = "rdRam";
            this.rdRam.Size = new System.Drawing.Size(82, 31);
            this.rdRam.TabIndex = 12;
            this.rdRam.TabStop = true;
            this.rdRam.Text = "Ram";
            this.rdRam.UseVisualStyleBackColor = true;
            // 
            // rdTenMay
            // 
            this.rdTenMay.AutoSize = true;
            this.rdTenMay.Location = new System.Drawing.Point(3, 40);
            this.rdTenMay.Name = "rdTenMay";
            this.rdTenMay.Size = new System.Drawing.Size(188, 31);
            this.rdTenMay.TabIndex = 0;
            this.rdTenMay.TabStop = true;
            this.rdTenMay.Text = "Tên máy vi tính";
            this.rdTenMay.UseVisualStyleBackColor = true;
            // 
            // rdLoaiMay
            // 
            this.rdLoaiMay.AutoSize = true;
            this.rdLoaiMay.Location = new System.Drawing.Point(3, 77);
            this.rdLoaiMay.Name = "rdLoaiMay";
            this.rdLoaiMay.Size = new System.Drawing.Size(195, 31);
            this.rdLoaiMay.TabIndex = 1;
            this.rdLoaiMay.TabStop = true;
            this.rdLoaiMay.Text = "Loại máy vi tính";
            this.rdLoaiMay.UseVisualStyleBackColor = true;
            // 
            // rdLoaiChip
            // 
            this.rdLoaiChip.AutoSize = true;
            this.rdLoaiChip.Location = new System.Drawing.Point(3, 114);
            this.rdLoaiChip.Name = "rdLoaiChip";
            this.rdLoaiChip.Size = new System.Drawing.Size(133, 31);
            this.rdLoaiChip.TabIndex = 2;
            this.rdLoaiChip.TabStop = true;
            this.rdLoaiChip.Text = "Loại Chip";
            this.rdLoaiChip.UseVisualStyleBackColor = true;
            // 
            // rdOCung
            // 
            this.rdOCung.AutoSize = true;
            this.rdOCung.Location = new System.Drawing.Point(3, 151);
            this.rdOCung.Name = "rdOCung";
            this.rdOCung.Size = new System.Drawing.Size(152, 31);
            this.rdOCung.TabIndex = 3;
            this.rdOCung.TabStop = true;
            this.rdOCung.Text = "Loại ổ cứng";
            this.rdOCung.UseVisualStyleBackColor = true;
            // 
            // rdCoManHinh
            // 
            this.rdCoManHinh.AutoSize = true;
            this.rdCoManHinh.Location = new System.Drawing.Point(3, 188);
            this.rdCoManHinh.Name = "rdCoManHinh";
            this.rdCoManHinh.Size = new System.Drawing.Size(161, 31);
            this.rdCoManHinh.TabIndex = 5;
            this.rdCoManHinh.TabStop = true;
            this.rdCoManHinh.Text = "Cỡ màn hình";
            this.rdCoManHinh.UseVisualStyleBackColor = true;
            // 
            // rdUSB
            // 
            this.rdUSB.AutoSize = true;
            this.rdUSB.Location = new System.Drawing.Point(3, 225);
            this.rdUSB.Name = "rdUSB";
            this.rdUSB.Size = new System.Drawing.Size(104, 31);
            this.rdUSB.TabIndex = 6;
            this.rdUSB.TabStop = true;
            this.rdUSB.Text = "Ổ USB";
            this.rdUSB.UseVisualStyleBackColor = true;
            // 
            // rdOCD
            // 
            this.rdOCD.AutoSize = true;
            this.rdOCD.Location = new System.Drawing.Point(3, 262);
            this.rdOCD.Name = "rdOCD";
            this.rdOCD.Size = new System.Drawing.Size(137, 31);
            this.rdOCD.TabIndex = 7;
            this.rdOCD.TabStop = true;
            this.rdOCD.Text = "Loại OCD";
            this.rdOCD.UseVisualStyleBackColor = true;
            // 
            // rdHSX
            // 
            this.rdHSX.AutoSize = true;
            this.rdHSX.Location = new System.Drawing.Point(3, 299);
            this.rdHSX.Name = "rdHSX";
            this.rdHSX.Size = new System.Drawing.Size(174, 31);
            this.rdHSX.TabIndex = 8;
            this.rdHSX.TabStop = true;
            this.rdHSX.Text = "Hãng sản xuất";
            this.rdHSX.UseVisualStyleBackColor = true;
            // 
            // rdDL
            // 
            this.rdDL.AutoSize = true;
            this.rdDL.Location = new System.Drawing.Point(3, 336);
            this.rdDL.Name = "rdDL";
            this.rdDL.Size = new System.Drawing.Size(197, 31);
            this.rdDL.TabIndex = 10;
            this.rdDL.TabStop = true;
            this.rdDL.Text = "Dung lượng máy";
            this.rdDL.UseVisualStyleBackColor = true;
            // 
            // rdTD
            // 
            this.rdTD.AutoSize = true;
            this.rdTD.Location = new System.Drawing.Point(3, 373);
            this.rdTD.Name = "rdTD";
            this.rdTD.Size = new System.Drawing.Size(151, 31);
            this.rdTD.TabIndex = 11;
            this.rdTD.TabStop = true;
            this.rdTD.Text = "Tốc độ máy";
            this.rdTD.UseVisualStyleBackColor = true;
            // 
            // rdManHinh
            // 
            this.rdManHinh.AutoSize = true;
            this.rdManHinh.Location = new System.Drawing.Point(3, 114);
            this.rdManHinh.Name = "rdManHinh";
            this.rdManHinh.Size = new System.Drawing.Size(176, 31);
            this.rdManHinh.TabIndex = 4;
            this.rdManHinh.TabStop = true;
            this.rdManHinh.Text = "Loại màn hình";
            this.rdManHinh.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanel2);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 430);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(281, 202);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm theo thiết bị ngoại vi";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.rdKeyBoard);
            this.flowLayoutPanel2.Controls.Add(this.rdMouse);
            this.flowLayoutPanel2.Controls.Add(this.rdSpeaker);
            this.flowLayoutPanel2.Controls.Add(this.rdManHinh);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(6, 36);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(174, 166);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // rdKeyBoard
            // 
            this.rdKeyBoard.AutoSize = true;
            this.rdKeyBoard.Location = new System.Drawing.Point(3, 3);
            this.rdKeyBoard.Name = "rdKeyBoard";
            this.rdKeyBoard.Size = new System.Drawing.Size(130, 31);
            this.rdKeyBoard.TabIndex = 2;
            this.rdKeyBoard.TabStop = true;
            this.rdKeyBoard.Text = "Bàn phím";
            this.rdKeyBoard.UseVisualStyleBackColor = true;
            // 
            // rdMouse
            // 
            this.rdMouse.AutoSize = true;
            this.rdMouse.Location = new System.Drawing.Point(3, 40);
            this.rdMouse.Name = "rdMouse";
            this.rdMouse.Size = new System.Drawing.Size(96, 31);
            this.rdMouse.TabIndex = 0;
            this.rdMouse.TabStop = true;
            this.rdMouse.Text = "Chuột";
            this.rdMouse.UseVisualStyleBackColor = true;
            // 
            // rdSpeaker
            // 
            this.rdSpeaker.AutoSize = true;
            this.rdSpeaker.Location = new System.Drawing.Point(3, 77);
            this.rdSpeaker.Name = "rdSpeaker";
            this.rdSpeaker.Size = new System.Drawing.Size(75, 31);
            this.rdSpeaker.TabIndex = 1;
            this.rdSpeaker.TabStop = true;
            this.rdSpeaker.Text = "Loa";
            this.rdSpeaker.UseVisualStyleBackColor = true;
            // 
            // DanhSachhanghoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 694);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.DTGV);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DanhSachhanghoa";
            this.Text = "Hàng hóa";
            this.Load += new System.EventHandler(this.hanghoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView DTGV;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ToolStripMenuItem bánHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sổQuỹToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đốiTácToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giaoDịchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tổngQuanToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RadioButton rdLoaiMay;
        private System.Windows.Forms.RadioButton rdLoaiChip;
        private System.Windows.Forms.RadioButton rdOCung;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnBánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnNhậpToolStripMenuItem;
        private System.Windows.Forms.RadioButton rdManHinh;
        private System.Windows.Forms.RadioButton rdCoManHinh;
        private System.Windows.Forms.RadioButton rdUSB;
        private System.Windows.Forms.RadioButton rdOCD;
        private System.Windows.Forms.RadioButton rdHSX;
        private System.Windows.Forms.RadioButton rdTD;
        private System.Windows.Forms.RadioButton rdTenMay;
        private System.Windows.Forms.RadioButton rdDL;
        private System.Windows.Forms.RadioButton rdKeyBoard;
        private System.Windows.Forms.RadioButton rdMouse;
        private System.Windows.Forms.RadioButton rdSpeaker;
        private System.Windows.Forms.RadioButton rdRam;
    }
}