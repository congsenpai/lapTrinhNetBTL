namespace QuanLyCuaHangMayTinh.Views
{
    partial class BanHang
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
            this.lbPayBack = new System.Windows.Forms.Label();
            this.txtCusPay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTotalCost = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbTime = new System.Windows.Forms.Label();
            this.groupbox = new System.Windows.Forms.GroupBox();
            this.lbCustomer = new System.Windows.Forms.ListBox();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DtgvItems = new System.Windows.Forms.DataGridView();
            this.lbComputerItems = new System.Windows.Forms.ListBox();
            this.groupBox2.SuspendLayout();
            this.groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPayBack
            // 
            this.lbPayBack.AutoSize = true;
            this.lbPayBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPayBack.ForeColor = System.Drawing.Color.Blue;
            this.lbPayBack.Location = new System.Drawing.Point(211, 300);
            this.lbPayBack.Name = "lbPayBack";
            this.lbPayBack.Size = new System.Drawing.Size(26, 29);
            this.lbPayBack.TabIndex = 12;
            this.lbPayBack.Text = "0";
            // 
            // txtCusPay
            // 
            this.txtCusPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusPay.Location = new System.Drawing.Point(216, 228);
            this.txtCusPay.Name = "txtCusPay";
            this.txtCusPay.Size = new System.Drawing.Size(155, 35);
            this.txtCusPay.TabIndex = 11;
            this.txtCusPay.TextChanged += new System.EventHandler(this.txtCusPay_TextChanged);
            this.txtCusPay.Enter += new System.EventHandler(this.txtCusPay_Enter);
            this.txtCusPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCusPay_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cần trả lại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Khách thanh toán";
            // 
            // lbTotalCost
            // 
            this.lbTotalCost.AutoSize = true;
            this.lbTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalCost.ForeColor = System.Drawing.Color.Blue;
            this.lbTotalCost.Location = new System.Drawing.Point(211, 162);
            this.lbTotalCost.Name = "lbTotalCost";
            this.lbTotalCost.Size = new System.Drawing.Size(26, 29);
            this.lbTotalCost.TabIndex = 8;
            this.lbTotalCost.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tổng tiền hàng";
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.Aqua;
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.Location = new System.Drawing.Point(143, 478);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(171, 54);
            this.btnBuy.TabIndex = 6;
            this.btnBuy.Text = "Thanh toán";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhân viên";
            // 
            // cbEmployee
            // 
            this.cbEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(130, 29);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(241, 37);
            this.cbEmployee.TabIndex = 2;
            this.cbEmployee.Click += new System.EventHandler(this.cbEmployee_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.txtSoluong);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.lbTime);
            this.groupBox2.Location = new System.Drawing.Point(12, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1116, 67);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(12, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(440, 35);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            // 
            // txtSoluong
            // 
            this.txtSoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoluong.Location = new System.Drawing.Point(471, 19);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(88, 35);
            this.txtSoluong.TabIndex = 10;
            this.txtSoluong.Enter += new System.EventHandler(this.txtSoluong_Enter);
            this.txtSoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCusPay_KeyPress);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(659, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 52);
            this.button2.TabIndex = 8;
            this.button2.Text = "Tạo hóa đơn mới";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(565, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 52);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(912, 30);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(73, 20);
            this.lbTime.TabIndex = 4;
            this.lbTime.Text = "Thời gian";
            // 
            // groupbox
            // 
            this.groupbox.Controls.Add(this.lbCustomer);
            this.groupbox.Controls.Add(this.txtCustomer);
            this.groupbox.Controls.Add(this.lbPayBack);
            this.groupbox.Controls.Add(this.txtCusPay);
            this.groupbox.Controls.Add(this.label6);
            this.groupbox.Controls.Add(this.label5);
            this.groupbox.Controls.Add(this.lbTotalCost);
            this.groupbox.Controls.Add(this.label3);
            this.groupbox.Controls.Add(this.btnBuy);
            this.groupbox.Controls.Add(this.label2);
            this.groupbox.Controls.Add(this.label1);
            this.groupbox.Controls.Add(this.cbEmployee);
            this.groupbox.Controls.Add(this.button1);
            this.groupbox.Location = new System.Drawing.Point(712, 118);
            this.groupbox.Name = "groupbox";
            this.groupbox.Size = new System.Drawing.Size(404, 570);
            this.groupbox.TabIndex = 8;
            this.groupbox.TabStop = false;
            // 
            // lbCustomer
            // 
            this.lbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomer.FormattingEnabled = true;
            this.lbCustomer.ItemHeight = 25;
            this.lbCustomer.Location = new System.Drawing.Point(123, 123);
            this.lbCustomer.Name = "lbCustomer";
            this.lbCustomer.Size = new System.Drawing.Size(234, 79);
            this.lbCustomer.TabIndex = 14;
            this.lbCustomer.SelectedIndexChanged += new System.EventHandler(this.lbCustomer_SelectedIndexChanged);
            // 
            // txtCustomer
            // 
            this.txtCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomer.Location = new System.Drawing.Point(130, 82);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(219, 35);
            this.txtCustomer.TabIndex = 13;
            this.txtCustomer.TextChanged += new System.EventHandler(this.txtCustomer_TextChanged);
            this.txtCustomer.Enter += new System.EventHandler(this.txtCustomer_Enter);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // DtgvItems
            // 
            this.DtgvItems.AllowUserToAddRows = false;
            this.DtgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvItems.Location = new System.Drawing.Point(24, 129);
            this.DtgvItems.Name = "DtgvItems";
            this.DtgvItems.ReadOnly = true;
            this.DtgvItems.RowHeadersWidth = 62;
            this.DtgvItems.RowTemplate.Height = 28;
            this.DtgvItems.Size = new System.Drawing.Size(682, 559);
            this.DtgvItems.TabIndex = 10;
            // 
            // lbComputerItems
            // 
            this.lbComputerItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComputerItems.FormattingEnabled = true;
            this.lbComputerItems.ItemHeight = 25;
            this.lbComputerItems.Location = new System.Drawing.Point(12, 116);
            this.lbComputerItems.Name = "lbComputerItems";
            this.lbComputerItems.Size = new System.Drawing.Size(494, 129);
            this.lbComputerItems.TabIndex = 11;
            this.lbComputerItems.SelectedIndexChanged += new System.EventHandler(this.lbComputerItems_SelectedIndexChanged);
            this.lbComputerItems.Enter += new System.EventHandler(this.txtSearch_Enter);
            // 
            // BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 694);
            this.Controls.Add(this.lbComputerItems);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupbox);
            this.Controls.Add(this.DtgvItems);
            this.Name = "BanHang";
            this.Text = "Bán hàng";
            this.Load += new System.EventHandler(this.Sale1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupbox.ResumeLayout(false);
            this.groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbPayBack;
        private System.Windows.Forms.TextBox txtCusPay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTotalCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.GroupBox groupbox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView DtgvItems;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.ListBox lbComputerItems;
        private System.Windows.Forms.ListBox lbCustomer;
    }
}