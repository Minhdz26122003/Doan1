namespace DoAn1
{
    partial class QlNguyenLieu
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.grbtk = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cbbtimkiemnl = new System.Windows.Forms.ComboBox();
            this.btntimkiemlsp = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnlmlsp = new System.Windows.Forms.Button();
            this.btnxoalsp = new System.Windows.Forms.Button();
            this.btnthemlsp = new System.Windows.Forms.Button();
            this.btnsualsp = new System.Windows.Forms.Button();
            this.grbThongtinlsp = new System.Windows.Forms.GroupBox();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttennl = new System.Windows.Forms.TextBox();
            this.txtmanl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvnl = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.grbtk.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grbThongtinlsp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnl)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label20);
            this.panel2.Location = new System.Drawing.Point(3, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1004, 49);
            this.panel2.TabIndex = 21;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Firebrick;
            this.label20.Location = new System.Drawing.Point(349, 14);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(303, 29);
            this.label20.TabIndex = 12;
            this.label20.Text = "QUẢN LÝ NGUYÊN LIỆU";
            // 
            // grbtk
            // 
            this.grbtk.Controls.Add(this.label19);
            this.grbtk.Controls.Add(this.cbbtimkiemnl);
            this.grbtk.Controls.Add(this.btntimkiemlsp);
            this.grbtk.Location = new System.Drawing.Point(530, 185);
            this.grbtk.Name = "grbtk";
            this.grbtk.Size = new System.Drawing.Size(476, 91);
            this.grbtk.TabIndex = 20;
            this.grbtk.TabStop = false;
            this.grbtk.Text = "Tìm Kiếm ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(26, 48);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(174, 22);
            this.label19.TabIndex = 12;
            this.label19.Text = "Chọn Kiểu Tìm Kiếm";
            // 
            // cbbtimkiemnl
            // 
            this.cbbtimkiemnl.FormattingEnabled = true;
            this.cbbtimkiemnl.Items.AddRange(new object[] {
            "Tìm Kiếm Theo Mã",
            "Tìm Kiếm Theo Tên",
            "Tìm Kiếm Theo Nhà Cung Cấp"});
            this.cbbtimkiemnl.Location = new System.Drawing.Point(219, 40);
            this.cbbtimkiemnl.Name = "cbbtimkiemnl";
            this.cbbtimkiemnl.Size = new System.Drawing.Size(167, 30);
            this.cbbtimkiemnl.TabIndex = 11;
            this.cbbtimkiemnl.SelectedIndexChanged += new System.EventHandler(this.cbbtimkiemlsp_SelectedIndexChanged);
            // 
            // btntimkiemlsp
            // 
            this.btntimkiemlsp.Image = global::DoAn1.Properties.Resources.find__1_;
            this.btntimkiemlsp.Location = new System.Drawing.Point(404, 32);
            this.btntimkiemlsp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btntimkiemlsp.Name = "btntimkiemlsp";
            this.btntimkiemlsp.Size = new System.Drawing.Size(64, 43);
            this.btntimkiemlsp.TabIndex = 10;
            this.btntimkiemlsp.UseVisualStyleBackColor = true;
            this.btntimkiemlsp.Click += new System.EventHandler(this.btntimkiemlsp_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnlmlsp);
            this.groupBox2.Controls.Add(this.btnxoalsp);
            this.groupBox2.Controls.Add(this.btnthemlsp);
            this.groupBox2.Controls.Add(this.btnsualsp);
            this.groupBox2.Location = new System.Drawing.Point(4, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(521, 95);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btnlmlsp
            // 
            this.btnlmlsp.Image = global::DoAn1.Properties.Resources.if_gtk_refresh_4811122;
            this.btnlmlsp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlmlsp.Location = new System.Drawing.Point(19, 36);
            this.btnlmlsp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnlmlsp.Name = "btnlmlsp";
            this.btnlmlsp.Size = new System.Drawing.Size(109, 43);
            this.btnlmlsp.TabIndex = 9;
            this.btnlmlsp.Text = "Làm Mới";
            this.btnlmlsp.UseVisualStyleBackColor = true;
            this.btnlmlsp.Click += new System.EventHandler(this.btnlmlsp_Click);
            // 
            // btnxoalsp
            // 
            this.btnxoalsp.Image = global::DoAn1.Properties.Resources._3Xoa;
            this.btnxoalsp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoalsp.Location = new System.Drawing.Point(391, 36);
            this.btnxoalsp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnxoalsp.Name = "btnxoalsp";
            this.btnxoalsp.Size = new System.Drawing.Size(97, 43);
            this.btnxoalsp.TabIndex = 8;
            this.btnxoalsp.Text = "Xóa";
            this.btnxoalsp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoalsp.UseVisualStyleBackColor = true;
            this.btnxoalsp.Click += new System.EventHandler(this.btnxoalsp_Click);
            // 
            // btnthemlsp
            // 
            this.btnthemlsp.Image = global::DoAn1.Properties.Resources._1Them;
            this.btnthemlsp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthemlsp.Location = new System.Drawing.Point(145, 36);
            this.btnthemlsp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnthemlsp.Name = "btnthemlsp";
            this.btnthemlsp.Size = new System.Drawing.Size(98, 43);
            this.btnthemlsp.TabIndex = 1;
            this.btnthemlsp.Text = "Thêm";
            this.btnthemlsp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthemlsp.UseVisualStyleBackColor = true;
            this.btnthemlsp.Click += new System.EventHandler(this.btnthemlsp_Click);
            // 
            // btnsualsp
            // 
            this.btnsualsp.Image = global::DoAn1.Properties.Resources._2Sua;
            this.btnsualsp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsualsp.Location = new System.Drawing.Point(260, 36);
            this.btnsualsp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnsualsp.Name = "btnsualsp";
            this.btnsualsp.Size = new System.Drawing.Size(100, 43);
            this.btnsualsp.TabIndex = 7;
            this.btnsualsp.Text = "Sửa";
            this.btnsualsp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsualsp.UseVisualStyleBackColor = true;
            this.btnsualsp.Click += new System.EventHandler(this.btnsualsp_Click);
            // 
            // grbThongtinlsp
            // 
            this.grbThongtinlsp.Controls.Add(this.txtdongia);
            this.grbThongtinlsp.Controls.Add(this.label4);
            this.grbThongtinlsp.Controls.Add(this.txttennl);
            this.grbThongtinlsp.Controls.Add(this.txtmanl);
            this.grbThongtinlsp.Controls.Add(this.label3);
            this.grbThongtinlsp.Controls.Add(this.txtsl);
            this.grbThongtinlsp.Controls.Add(this.label2);
            this.grbThongtinlsp.Controls.Add(this.label1);
            this.grbThongtinlsp.Location = new System.Drawing.Point(3, 60);
            this.grbThongtinlsp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbThongtinlsp.Name = "grbThongtinlsp";
            this.grbThongtinlsp.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbThongtinlsp.Size = new System.Drawing.Size(1003, 121);
            this.grbThongtinlsp.TabIndex = 18;
            this.grbThongtinlsp.TabStop = false;
            this.grbThongtinlsp.Text = "Thông tin ";
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(198, 83);
            this.txtdongia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(142, 28);
            this.txtdongia.TabIndex = 13;
            this.txtdongia.TextChanged += new System.EventHandler(this.txtdongia_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Đơn Giá";
            // 
            // txttennl
            // 
            this.txttennl.Location = new System.Drawing.Point(544, 34);
            this.txttennl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txttennl.Name = "txttennl";
            this.txttennl.Size = new System.Drawing.Size(159, 28);
            this.txttennl.TabIndex = 6;
            // 
            // txtmanl
            // 
            this.txtmanl.Location = new System.Drawing.Point(198, 34);
            this.txtmanl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtmanl.Name = "txtmanl";
            this.txtmanl.Size = new System.Drawing.Size(142, 28);
            this.txtmanl.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(773, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Số Lượng";
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(883, 37);
            this.txtsl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(112, 28);
            this.txtsl.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên Nguyên Liệu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã Nguyên Liệu";
            // 
            // dgvnl
            // 
            this.dgvnl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvnl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnl.Location = new System.Drawing.Point(3, 282);
            this.dgvnl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvnl.Name = "dgvnl";
            this.dgvnl.RowHeadersWidth = 51;
            this.dgvnl.RowTemplate.Height = 24;
            this.dgvnl.Size = new System.Drawing.Size(1003, 264);
            this.dgvnl.TabIndex = 17;
            this.dgvnl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiSP_CellClick);
            // 
            // QlNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1012, 551);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.grbtk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbThongtinlsp);
            this.Controls.Add(this.dgvnl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QlNguyenLieu";
            this.Text = "QlNguyenLieu";
            this.Load += new System.EventHandler(this.QlNguyenLieu_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grbtk.ResumeLayout(false);
            this.grbtk.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.grbThongtinlsp.ResumeLayout(false);
            this.grbThongtinlsp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox grbtk;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbbtimkiemnl;
        private System.Windows.Forms.Button btntimkiemlsp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnlmlsp;
        private System.Windows.Forms.Button btnxoalsp;
        private System.Windows.Forms.Button btnthemlsp;
        private System.Windows.Forms.Button btnsualsp;
        private System.Windows.Forms.GroupBox grbThongtinlsp;
        private System.Windows.Forms.TextBox txttennl;
        private System.Windows.Forms.TextBox txtmanl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvnl;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.Label label4;
    }
}