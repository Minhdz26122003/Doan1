namespace DoAn1
{
    partial class QLKH
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.cbbtkkh = new System.Windows.Forms.ComboBox();
            this.btntkkh = new System.Windows.Forms.Button();
            this.dgvkhachhang = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnlmnv = new System.Windows.Forms.Button();
            this.btnxoakh = new System.Windows.Forms.Button();
            this.btnthemkh = new System.Windows.Forms.Button();
            this.btnsuakh = new System.Windows.Forms.Button();
            this.grbthongtinkh = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtdiachikh = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtsdtkh = new System.Windows.Forms.TextBox();
            this.txttenkh = new System.Windows.Forms.TextBox();
            this.txtmakh = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhachhang)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.grbthongtinkh.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label26);
            this.panel4.Location = new System.Drawing.Point(8, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1001, 46);
            this.panel4.TabIndex = 31;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Firebrick;
            this.label26.Location = new System.Drawing.Point(341, 10);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(348, 32);
            this.label26.TabIndex = 21;
            this.label26.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label25);
            this.groupBox7.Controls.Add(this.cbbtkkh);
            this.groupBox7.Controls.Add(this.btntkkh);
            this.groupBox7.Location = new System.Drawing.Point(677, 55);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(332, 224);
            this.groupBox7.TabIndex = 30;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Tìm Kiếm ";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(79, 66);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(174, 22);
            this.label25.TabIndex = 12;
            this.label25.Text = "Chọn Kiểu Tìm Kiếm";
            // 
            // cbbtkkh
            // 
            this.cbbtkkh.FormattingEnabled = true;
            this.cbbtkkh.Items.AddRange(new object[] {
            "Tìm Kiếm Theo Mã",
            "Tìm Kiếm Theo Tên"});
            this.cbbtkkh.Location = new System.Drawing.Point(83, 91);
            this.cbbtkkh.Name = "cbbtkkh";
            this.cbbtkkh.Size = new System.Drawing.Size(170, 30);
            this.cbbtkkh.TabIndex = 11;
            this.cbbtkkh.SelectedIndexChanged += new System.EventHandler(this.cbbtkkh_SelectedIndexChanged);
            // 
            // btntkkh
            // 
            this.btntkkh.Image = global::DoAn1.Properties.Resources.find__1_;
            this.btntkkh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntkkh.Location = new System.Drawing.Point(120, 148);
            this.btntkkh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btntkkh.Name = "btntkkh";
            this.btntkkh.Size = new System.Drawing.Size(109, 43);
            this.btntkkh.TabIndex = 10;
            this.btntkkh.Text = "  Tìm Kiếm";
            this.btntkkh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntkkh.UseVisualStyleBackColor = true;
            this.btntkkh.Click += new System.EventHandler(this.btntkkh_Click);
            // 
            // dgvkhachhang
            // 
            this.dgvkhachhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkhachhang.Location = new System.Drawing.Point(8, 285);
            this.dgvkhachhang.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvkhachhang.Name = "dgvkhachhang";
            this.dgvkhachhang.RowHeadersWidth = 51;
            this.dgvkhachhang.RowTemplate.Height = 24;
            this.dgvkhachhang.Size = new System.Drawing.Size(1001, 244);
            this.dgvkhachhang.TabIndex = 29;
            this.dgvkhachhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvkhachhang_CellClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnlmnv);
            this.groupBox5.Controls.Add(this.btnxoakh);
            this.groupBox5.Controls.Add(this.btnthemkh);
            this.groupBox5.Controls.Add(this.btnsuakh);
            this.groupBox5.Location = new System.Drawing.Point(8, 190);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(662, 89);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chức Năng";
            // 
            // btnlmnv
            // 
            this.btnlmnv.BackColor = System.Drawing.Color.LightGray;
            this.btnlmnv.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnlmnv.Image = global::DoAn1.Properties.Resources.if_gtk_refresh_4811121;
            this.btnlmnv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlmnv.Location = new System.Drawing.Point(46, 27);
            this.btnlmnv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnlmnv.Name = "btnlmnv";
            this.btnlmnv.Size = new System.Drawing.Size(111, 47);
            this.btnlmnv.TabIndex = 9;
            this.btnlmnv.Text = " Làm Mới";
            this.btnlmnv.UseVisualStyleBackColor = false;
            this.btnlmnv.Click += new System.EventHandler(this.btnlmnv_Click);
            // 
            // btnxoakh
            // 
            this.btnxoakh.Image = global::DoAn1.Properties.Resources._3Xoa;
            this.btnxoakh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoakh.Location = new System.Drawing.Point(453, 27);
            this.btnxoakh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnxoakh.Name = "btnxoakh";
            this.btnxoakh.Size = new System.Drawing.Size(94, 47);
            this.btnxoakh.TabIndex = 8;
            this.btnxoakh.Text = "Xóa";
            this.btnxoakh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoakh.UseVisualStyleBackColor = true;
            this.btnxoakh.Click += new System.EventHandler(this.btnxoakh_Click);
            // 
            // btnthemkh
            // 
            this.btnthemkh.BackColor = System.Drawing.Color.LightGray;
            this.btnthemkh.Image = global::DoAn1.Properties.Resources._1Them;
            this.btnthemkh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthemkh.Location = new System.Drawing.Point(189, 27);
            this.btnthemkh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnthemkh.Name = "btnthemkh";
            this.btnthemkh.Size = new System.Drawing.Size(96, 47);
            this.btnthemkh.TabIndex = 1;
            this.btnthemkh.Text = "Thêm";
            this.btnthemkh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthemkh.UseVisualStyleBackColor = false;
            this.btnthemkh.Click += new System.EventHandler(this.btnthemkh_Click);
            // 
            // btnsuakh
            // 
            this.btnsuakh.Image = global::DoAn1.Properties.Resources._2Sua;
            this.btnsuakh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsuakh.Location = new System.Drawing.Point(316, 27);
            this.btnsuakh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnsuakh.Name = "btnsuakh";
            this.btnsuakh.Size = new System.Drawing.Size(97, 47);
            this.btnsuakh.TabIndex = 7;
            this.btnsuakh.Text = "Sửa";
            this.btnsuakh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsuakh.UseVisualStyleBackColor = true;
            this.btnsuakh.Click += new System.EventHandler(this.btnsuakh_Click);
            // 
            // grbthongtinkh
            // 
            this.grbthongtinkh.Controls.Add(this.label12);
            this.grbthongtinkh.Controls.Add(this.txtdiachikh);
            this.grbthongtinkh.Controls.Add(this.label13);
            this.grbthongtinkh.Controls.Add(this.txtsdtkh);
            this.grbthongtinkh.Controls.Add(this.txttenkh);
            this.grbthongtinkh.Controls.Add(this.txtmakh);
            this.grbthongtinkh.Controls.Add(this.label16);
            this.grbthongtinkh.Controls.Add(this.label17);
            this.grbthongtinkh.Location = new System.Drawing.Point(8, 55);
            this.grbthongtinkh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbthongtinkh.Name = "grbthongtinkh";
            this.grbthongtinkh.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbthongtinkh.Size = new System.Drawing.Size(662, 129);
            this.grbthongtinkh.TabIndex = 27;
            this.grbthongtinkh.TabStop = false;
            this.grbthongtinkh.Text = "Thông tin ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 22);
            this.label12.TabIndex = 18;
            this.label12.Text = "Địa Chỉ";
            // 
            // txtdiachikh
            // 
            this.txtdiachikh.Location = new System.Drawing.Point(157, 94);
            this.txtdiachikh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtdiachikh.Name = "txtdiachikh";
            this.txtdiachikh.Size = new System.Drawing.Size(137, 28);
            this.txtdiachikh.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(343, 97);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 22);
            this.label13.TabIndex = 16;
            this.label13.Text = "Số Điện Thoại";
            // 
            // txtsdtkh
            // 
            this.txtsdtkh.Location = new System.Drawing.Point(491, 95);
            this.txtsdtkh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtsdtkh.Name = "txtsdtkh";
            this.txtsdtkh.Size = new System.Drawing.Size(142, 28);
            this.txtsdtkh.TabIndex = 15;
            this.txtsdtkh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsdtkh_KeyPress);
            // 
            // txttenkh
            // 
            this.txttenkh.Location = new System.Drawing.Point(491, 37);
            this.txttenkh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txttenkh.Name = "txttenkh";
            this.txttenkh.Size = new System.Drawing.Size(142, 28);
            this.txttenkh.TabIndex = 6;
            this.txttenkh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttenkh_KeyPress);
            // 
            // txtmakh
            // 
            this.txtmakh.Location = new System.Drawing.Point(157, 40);
            this.txtmakh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Size = new System.Drawing.Size(137, 28);
            this.txtmakh.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(337, 43);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(146, 22);
            this.label16.TabIndex = 10;
            this.label16.Text = "Tên Khách Hàng";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(19, 43);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(138, 22);
            this.label17.TabIndex = 9;
            this.label17.Text = "Mã Khách Hàng";
            // 
            // QLKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1015, 544);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.dgvkhachhang);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.grbthongtinkh);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QLKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLKH";
            this.Load += new System.EventHandler(this.QLKH_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhachhang)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.grbthongtinkh.ResumeLayout(false);
            this.grbthongtinkh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox cbbtkkh;
        private System.Windows.Forms.Button btntkkh;
        private System.Windows.Forms.DataGridView dgvkhachhang;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnlmnv;
        private System.Windows.Forms.Button btnxoakh;
        private System.Windows.Forms.Button btnthemkh;
        private System.Windows.Forms.Button btnsuakh;
        private System.Windows.Forms.GroupBox grbthongtinkh;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtdiachikh;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtsdtkh;
        private System.Windows.Forms.TextBox txttenkh;
        private System.Windows.Forms.TextBox txtmakh;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}