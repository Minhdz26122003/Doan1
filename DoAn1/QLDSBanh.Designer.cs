namespace DoAn1
{
    partial class QLDSbanh
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cbbtksp = new System.Windows.Forms.ComboBox();
            this.btntk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.dgvsanpham = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnlmsp = new System.Windows.Forms.Button();
            this.btnxoasp = new System.Windows.Forms.Button();
            this.btnthemsp = new System.Windows.Forms.Button();
            this.btnsuasp = new System.Windows.Forms.Button();
            this.grbThongtinsp = new System.Windows.Forms.GroupBox();
            this.cbbmaloai = new System.Windows.Forms.ComboBox();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtmabbanh = new System.Windows.Forms.TextBox();
            this.txtmabanh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsanpham)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.grbThongtinsp.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.cbbtksp);
            this.groupBox1.Controls.Add(this.btntk);
            this.groupBox1.Location = new System.Drawing.Point(536, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 77);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm ";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(21, 34);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(174, 22);
            this.label22.TabIndex = 12;
            this.label22.Text = "Chọn Kiểu Tìm Kiếm";
            // 
            // cbbtksp
            // 
            this.cbbtksp.FormattingEnabled = true;
            this.cbbtksp.Items.AddRange(new object[] {
            "Tìm Kiếm Theo Mã",
            "Tìm Kiếm Theo Tên",
            "Tìm Kiếm Theo Giá Tiền"});
            this.cbbtksp.Location = new System.Drawing.Point(202, 31);
            this.cbbtksp.Name = "cbbtksp";
            this.cbbtksp.Size = new System.Drawing.Size(168, 30);
            this.cbbtksp.TabIndex = 11;
            this.cbbtksp.SelectedIndexChanged += new System.EventHandler(this.cbbtksp_SelectedIndexChanged);
            // 
            // btntk
            // 
            this.btntk.Image = global::DoAn1.Properties.Resources.find__1_;
            this.btntk.Location = new System.Drawing.Point(396, 27);
            this.btntk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btntk.Name = "btntk";
            this.btntk.Size = new System.Drawing.Size(50, 40);
            this.btntk.TabIndex = 10;
            this.btntk.UseVisualStyleBackColor = true;
            this.btntk.Click += new System.EventHandler(this.btntk_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label21);
            this.panel1.Location = new System.Drawing.Point(10, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 52);
            this.panel1.TabIndex = 22;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Firebrick;
            this.label21.Location = new System.Drawing.Point(306, 9);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(403, 32);
            this.label21.TabIndex = 18;
            this.label21.Text = "QUẢN LÝ THÔNG TIN BÁNH";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // dgvsanpham
            // 
            this.dgvsanpham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvsanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsanpham.Location = new System.Drawing.Point(10, 282);
            this.dgvsanpham.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvsanpham.Name = "dgvsanpham";
            this.dgvsanpham.RowHeadersWidth = 51;
            this.dgvsanpham.RowTemplate.Height = 24;
            this.dgvsanpham.Size = new System.Drawing.Size(1002, 268);
            this.dgvsanpham.TabIndex = 21;
            this.dgvsanpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsanpham_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnlmsp);
            this.groupBox4.Controls.Add(this.btnxoasp);
            this.groupBox4.Controls.Add(this.btnthemsp);
            this.groupBox4.Controls.Add(this.btnsuasp);
            this.groupBox4.Location = new System.Drawing.Point(9, 199);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(521, 77);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức Năng";
            // 
            // btnlmsp
            // 
            this.btnlmsp.Image = global::DoAn1.Properties.Resources.if_gtk_refresh_4811122;
            this.btnlmsp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlmsp.Location = new System.Drawing.Point(24, 26);
            this.btnlmsp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnlmsp.Name = "btnlmsp";
            this.btnlmsp.Size = new System.Drawing.Size(110, 45);
            this.btnlmsp.TabIndex = 9;
            this.btnlmsp.Text = "Làm Mới";
            this.btnlmsp.UseVisualStyleBackColor = true;
            this.btnlmsp.Click += new System.EventHandler(this.btnlmsp_Click);
            // 
            // btnxoasp
            // 
            this.btnxoasp.Image = global::DoAn1.Properties.Resources._3Xoa;
            this.btnxoasp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoasp.Location = new System.Drawing.Point(399, 26);
            this.btnxoasp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnxoasp.Name = "btnxoasp";
            this.btnxoasp.Size = new System.Drawing.Size(104, 45);
            this.btnxoasp.TabIndex = 8;
            this.btnxoasp.Text = "  Xóa";
            this.btnxoasp.UseVisualStyleBackColor = true;
            this.btnxoasp.Click += new System.EventHandler(this.btnxoasp_Click);
            // 
            // btnthemsp
            // 
            this.btnthemsp.Image = global::DoAn1.Properties.Resources._1Them;
            this.btnthemsp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthemsp.Location = new System.Drawing.Point(160, 29);
            this.btnthemsp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnthemsp.Name = "btnthemsp";
            this.btnthemsp.Size = new System.Drawing.Size(94, 42);
            this.btnthemsp.TabIndex = 1;
            this.btnthemsp.Text = "      Thêm";
            this.btnthemsp.UseVisualStyleBackColor = true;
            this.btnthemsp.Click += new System.EventHandler(this.btnthemsp_Click);
            // 
            // btnsuasp
            // 
            this.btnsuasp.Image = global::DoAn1.Properties.Resources._2Sua;
            this.btnsuasp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsuasp.Location = new System.Drawing.Point(280, 26);
            this.btnsuasp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnsuasp.Name = "btnsuasp";
            this.btnsuasp.Size = new System.Drawing.Size(97, 45);
            this.btnsuasp.TabIndex = 7;
            this.btnsuasp.Text = "   Sửa";
            this.btnsuasp.UseVisualStyleBackColor = true;
            this.btnsuasp.Click += new System.EventHandler(this.btnsuasp_Click);
            // 
            // grbThongtinsp
            // 
            this.grbThongtinsp.Controls.Add(this.cbbmaloai);
            this.grbThongtinsp.Controls.Add(this.txtsl);
            this.grbThongtinsp.Controls.Add(this.label1);
            this.grbThongtinsp.Controls.Add(this.label9);
            this.grbThongtinsp.Controls.Add(this.txtdongia);
            this.grbThongtinsp.Controls.Add(this.label8);
            this.grbThongtinsp.Controls.Add(this.txtmabbanh);
            this.grbThongtinsp.Controls.Add(this.txtmabanh);
            this.grbThongtinsp.Controls.Add(this.label5);
            this.grbThongtinsp.Controls.Add(this.label6);
            this.grbThongtinsp.Location = new System.Drawing.Point(13, 64);
            this.grbThongtinsp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbThongtinsp.Name = "grbThongtinsp";
            this.grbThongtinsp.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbThongtinsp.Size = new System.Drawing.Size(1000, 129);
            this.grbThongtinsp.TabIndex = 19;
            this.grbThongtinsp.TabStop = false;
            this.grbThongtinsp.Text = "Thông tin ";
            // 
            // cbbmaloai
            // 
            this.cbbmaloai.FormattingEnabled = true;
            this.cbbmaloai.Location = new System.Drawing.Point(799, 30);
            this.cbbmaloai.Name = "cbbmaloai";
            this.cbbmaloai.Size = new System.Drawing.Size(142, 30);
            this.cbbmaloai.TabIndex = 13;
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(173, 83);
            this.txtsl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(137, 28);
            this.txtsl.TabIndex = 19;
            this.txtsl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsl_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "Số Lượng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(667, 33);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 22);
            this.label9.TabIndex = 16;
            this.label9.Text = " Loại Nhóm";
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(483, 83);
            this.txtdongia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(137, 28);
            this.txtdongia.TabIndex = 15;
            this.txtdongia.TextChanged += new System.EventHandler(this.txtdongia_TextChanged);
            this.txtdongia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdongia_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(345, 89);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 22);
            this.label8.TabIndex = 13;
            this.label8.Text = "Đơn Giá";
            // 
            // txtmabbanh
            // 
            this.txtmabbanh.Location = new System.Drawing.Point(483, 30);
            this.txtmabbanh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtmabbanh.Name = "txtmabbanh";
            this.txtmabbanh.Size = new System.Drawing.Size(142, 28);
            this.txtmabbanh.TabIndex = 6;
            // 
            // txtmabanh
            // 
            this.txtmabanh.Location = new System.Drawing.Point(173, 29);
            this.txtmabanh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtmabanh.Name = "txtmabanh";
            this.txtmabanh.Size = new System.Drawing.Size(137, 28);
            this.txtmabanh.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tên Sản Phẩm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 36);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Mã Sản Phẩm";
            // 
            // QLDSbanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1020, 562);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvsanpham);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.grbThongtinsp);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QLDSbanh";
            this.Text = "QlDSBanh";
            this.Load += new System.EventHandler(this.QlDSMon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsanpham)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.grbThongtinsp.ResumeLayout(false);
            this.grbThongtinsp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cbbtksp;
        private System.Windows.Forms.Button btntk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView dgvsanpham;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnlmsp;
        private System.Windows.Forms.Button btnxoasp;
        private System.Windows.Forms.Button btnthemsp;
        private System.Windows.Forms.Button btnsuasp;
        private System.Windows.Forms.GroupBox grbThongtinsp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtmabbanh;
        private System.Windows.Forms.TextBox txtmabanh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbmaloai;
    }
}