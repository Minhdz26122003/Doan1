namespace DoAn1
{
    partial class QuanLyTaiKhoan
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
            this.grbcn = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cbbtktk = new System.Windows.Forms.ComboBox();
            this.btntk = new System.Windows.Forms.Button();
            this.btnlmtk = new System.Windows.Forms.Button();
            this.btnxoatk = new System.Windows.Forms.Button();
            this.btnthemtk = new System.Windows.Forms.Button();
            this.btnsuatk = new System.Windows.Forms.Button();
            this.grbThongtintk = new System.Windows.Forms.GroupBox();
            this.cbbmanv = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbquyen = new System.Windows.Forms.ComboBox();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.txttk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvtk = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.grbcn.SuspendLayout();
            this.grbThongtintk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtk)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label20);
            this.panel2.Location = new System.Drawing.Point(3, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(903, 50);
            this.panel2.TabIndex = 21;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Firebrick;
            this.label20.Location = new System.Drawing.Point(288, 10);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(311, 32);
            this.label20.TabIndex = 12;
            this.label20.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // grbcn
            // 
            this.grbcn.Controls.Add(this.label22);
            this.grbcn.Controls.Add(this.cbbtktk);
            this.grbcn.Controls.Add(this.btntk);
            this.grbcn.Controls.Add(this.btnlmtk);
            this.grbcn.Controls.Add(this.btnxoatk);
            this.grbcn.Controls.Add(this.btnthemtk);
            this.grbcn.Controls.Add(this.btnsuatk);
            this.grbcn.Location = new System.Drawing.Point(13, 299);
            this.grbcn.Name = "grbcn";
            this.grbcn.Size = new System.Drawing.Size(374, 200);
            this.grbcn.TabIndex = 19;
            this.grbcn.TabStop = false;
            this.grbcn.Text = "Chức Năng";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(21, 44);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(174, 22);
            this.label22.TabIndex = 15;
            this.label22.Text = "Chọn Kiểu Tìm Kiếm";
            // 
            // cbbtktk
            // 
            this.cbbtktk.FormattingEnabled = true;
            this.cbbtktk.Items.AddRange(new object[] {
            "Tìm Kiếm Theo Tên Tài Khoản"});
            this.cbbtktk.Location = new System.Drawing.Point(213, 41);
            this.cbbtktk.Name = "cbbtktk";
            this.cbbtktk.Size = new System.Drawing.Size(142, 30);
            this.cbbtktk.TabIndex = 14;
            // 
            // btntk
            // 
            this.btntk.Image = global::DoAn1.Properties.Resources.find__1_;
            this.btntk.Location = new System.Drawing.Point(296, 81);
            this.btntk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btntk.Name = "btntk";
            this.btntk.Size = new System.Drawing.Size(59, 44);
            this.btntk.TabIndex = 13;
            this.btntk.UseVisualStyleBackColor = true;
            this.btntk.Click += new System.EventHandler(this.btntk_Click);
            // 
            // btnlmtk
            // 
            this.btnlmtk.Image = global::DoAn1.Properties.Resources.if_gtk_refresh_4811122;
            this.btnlmtk.Location = new System.Drawing.Point(25, 81);
            this.btnlmtk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnlmtk.Name = "btnlmtk";
            this.btnlmtk.Size = new System.Drawing.Size(104, 44);
            this.btnlmtk.TabIndex = 9;
            this.btnlmtk.Text = "Làm Mới";
            this.btnlmtk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlmtk.UseVisualStyleBackColor = true;
            this.btnlmtk.Click += new System.EventHandler(this.btnlmtk_Click);
            // 
            // btnxoatk
            // 
            this.btnxoatk.Image = global::DoAn1.Properties.Resources._3Xoa;
            this.btnxoatk.Location = new System.Drawing.Point(273, 146);
            this.btnxoatk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnxoatk.Name = "btnxoatk";
            this.btnxoatk.Size = new System.Drawing.Size(94, 48);
            this.btnxoatk.TabIndex = 8;
            this.btnxoatk.Text = "Xóa";
            this.btnxoatk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnxoatk.UseVisualStyleBackColor = true;
            this.btnxoatk.Click += new System.EventHandler(this.btnxoatk_Click);
            // 
            // btnthemtk
            // 
            this.btnthemtk.Image = global::DoAn1.Properties.Resources._1Them;
            this.btnthemtk.Location = new System.Drawing.Point(25, 146);
            this.btnthemtk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnthemtk.Name = "btnthemtk";
            this.btnthemtk.Size = new System.Drawing.Size(104, 48);
            this.btnthemtk.TabIndex = 1;
            this.btnthemtk.Text = "Thêm";
            this.btnthemtk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnthemtk.UseVisualStyleBackColor = true;
            this.btnthemtk.Click += new System.EventHandler(this.btnthemtk_Click);
            // 
            // btnsuatk
            // 
            this.btnsuatk.Image = global::DoAn1.Properties.Resources._2Sua;
            this.btnsuatk.Location = new System.Drawing.Point(146, 146);
            this.btnsuatk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnsuatk.Name = "btnsuatk";
            this.btnsuatk.Size = new System.Drawing.Size(98, 48);
            this.btnsuatk.TabIndex = 7;
            this.btnsuatk.Text = "Sửa";
            this.btnsuatk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsuatk.UseVisualStyleBackColor = true;
            this.btnsuatk.Click += new System.EventHandler(this.btnthetk_Click);
            // 
            // grbThongtintk
            // 
            this.grbThongtintk.Controls.Add(this.cbbmanv);
            this.grbThongtintk.Controls.Add(this.label4);
            this.grbThongtintk.Controls.Add(this.cbbquyen);
            this.grbThongtintk.Controls.Add(this.txtmk);
            this.grbThongtintk.Controls.Add(this.txttk);
            this.grbThongtintk.Controls.Add(this.label3);
            this.grbThongtintk.Controls.Add(this.label2);
            this.grbThongtintk.Controls.Add(this.label1);
            this.grbThongtintk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbThongtintk.Location = new System.Drawing.Point(13, 64);
            this.grbThongtintk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbThongtintk.Name = "grbThongtintk";
            this.grbThongtintk.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbThongtintk.Size = new System.Drawing.Size(386, 211);
            this.grbThongtintk.TabIndex = 18;
            this.grbThongtintk.TabStop = false;
            this.grbThongtintk.Text = "Thông tin ";
            // 
            // cbbmanv
            // 
            this.cbbmanv.FormattingEnabled = true;
            this.cbbmanv.Items.AddRange(new object[] {
            "Nhân viên",
            "Admin"});
            this.cbbmanv.Location = new System.Drawing.Point(198, 167);
            this.cbbmanv.Name = "cbbmanv";
            this.cbbmanv.Size = new System.Drawing.Size(142, 30);
            this.cbbmanv.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mã Nhân Viên ";
            // 
            // cbbquyen
            // 
            this.cbbquyen.FormattingEnabled = true;
            this.cbbquyen.Items.AddRange(new object[] {
            "Nhân viên",
            "Admin"});
            this.cbbquyen.Location = new System.Drawing.Point(198, 123);
            this.cbbquyen.Name = "cbbquyen";
            this.cbbquyen.Size = new System.Drawing.Size(142, 30);
            this.cbbquyen.TabIndex = 12;
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(198, 78);
            this.txtmk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(142, 28);
            this.txtmk.TabIndex = 6;
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(198, 37);
            this.txttk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(142, 28);
            this.txttk.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Quyền Truy Cập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mật Khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tài Khoản";
            // 
            // dgvtk
            // 
            this.dgvtk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtk.Location = new System.Drawing.Point(407, 74);
            this.dgvtk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvtk.Name = "dgvtk";
            this.dgvtk.RowHeadersWidth = 51;
            this.dgvtk.RowTemplate.Height = 24;
            this.dgvtk.Size = new System.Drawing.Size(499, 425);
            this.dgvtk.TabIndex = 17;
            this.dgvtk.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtk_CellClick);
            // 
            // QuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(917, 511);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.grbcn);
            this.Controls.Add(this.grbThongtintk);
            this.Controls.Add(this.dgvtk);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLyTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyTaiKhoan";
            this.Load += new System.EventHandler(this.QuanLyTaiKhoan_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grbcn.ResumeLayout(false);
            this.grbcn.PerformLayout();
            this.grbThongtintk.ResumeLayout(false);
            this.grbThongtintk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox grbcn;
        private System.Windows.Forms.Button btnlmtk;
        private System.Windows.Forms.Button btnxoatk;
        private System.Windows.Forms.Button btnthemtk;
        private System.Windows.Forms.Button btnsuatk;
        private System.Windows.Forms.GroupBox grbThongtintk;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvtk;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cbbtktk;
        private System.Windows.Forms.Button btntk;
        private System.Windows.Forms.ComboBox cbbquyen;
        private System.Windows.Forms.ComboBox cbbmanv;
        private System.Windows.Forms.Label label4;
    }
}