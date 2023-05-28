namespace DoAn1
{
    partial class QlNhanvien
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
            this.cbbtknv = new System.Windows.Forms.ComboBox();
            this.btntknv = new System.Windows.Forms.Button();
            this.dgvnhanvien = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnlmnv = new System.Windows.Forms.Button();
            this.btnxoanv = new System.Windows.Forms.Button();
            this.btnthemnv = new System.Windows.Forms.Button();
            this.btnsuanv = new System.Windows.Forms.Button();
            this.grbthongtinnv = new System.Windows.Forms.GroupBox();
            this.cbbgt = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtdiachinv = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtsdtnv = new System.Windows.Forms.TextBox();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.txtmanhanvien = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhanvien)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.grbthongtinnv.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label26);
            this.panel4.Location = new System.Drawing.Point(6, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(999, 53);
            this.panel4.TabIndex = 26;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Firebrick;
            this.label26.Location = new System.Drawing.Point(341, 9);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(312, 32);
            this.label26.TabIndex = 21;
            this.label26.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label25);
            this.groupBox7.Controls.Add(this.cbbtknv);
            this.groupBox7.Controls.Add(this.btntknv);
            this.groupBox7.Location = new System.Drawing.Point(519, 182);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(486, 81);
            this.groupBox7.TabIndex = 25;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Tìm Kiếm ";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(21, 36);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(162, 20);
            this.label25.TabIndex = 12;
            this.label25.Text = "Chọn Kiểu Tìm Kiếm";
            // 
            // cbbtknv
            // 
            this.cbbtknv.FormattingEnabled = true;
            this.cbbtknv.Items.AddRange(new object[] {
            "Tìm Kiếm Theo Mã",
            "Tìm Kiếm Theo Tên"});
            this.cbbtknv.Location = new System.Drawing.Point(202, 33);
            this.cbbtknv.Name = "cbbtknv";
            this.cbbtknv.Size = new System.Drawing.Size(182, 28);
            this.cbbtknv.TabIndex = 11;
            this.cbbtknv.SelectedIndexChanged += new System.EventHandler(this.cbbtknv_SelectedIndexChanged);
            // 
            // btntknv
            // 
            this.btntknv.Image = global::DoAn1.Properties.Resources.find__1_;
            this.btntknv.Location = new System.Drawing.Point(391, 26);
            this.btntknv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btntknv.Name = "btntknv";
            this.btntknv.Size = new System.Drawing.Size(68, 40);
            this.btntknv.TabIndex = 10;
            this.btntknv.UseVisualStyleBackColor = true;
            this.btntknv.Click += new System.EventHandler(this.btntknv_Click);
            // 
            // dgvnhanvien
            // 
            this.dgvnhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnhanvien.Location = new System.Drawing.Point(4, 268);
            this.dgvnhanvien.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvnhanvien.Name = "dgvnhanvien";
            this.dgvnhanvien.RowHeadersWidth = 51;
            this.dgvnhanvien.RowTemplate.Height = 24;
            this.dgvnhanvien.Size = new System.Drawing.Size(1001, 288);
            this.dgvnhanvien.TabIndex = 24;
            this.dgvnhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvnhanvien_CellClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnlmnv);
            this.groupBox5.Controls.Add(this.btnxoanv);
            this.groupBox5.Controls.Add(this.btnthemnv);
            this.groupBox5.Controls.Add(this.btnsuanv);
            this.groupBox5.Location = new System.Drawing.Point(6, 182);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(507, 81);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chức Năng";
            // 
            // btnlmnv
            // 
            this.btnlmnv.Image = global::DoAn1.Properties.Resources.if_gtk_refresh_4811122;
            this.btnlmnv.Location = new System.Drawing.Point(21, 26);
            this.btnlmnv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnlmnv.Name = "btnlmnv";
            this.btnlmnv.Size = new System.Drawing.Size(108, 42);
            this.btnlmnv.TabIndex = 9;
            this.btnlmnv.Text = "Làm Mới";
            this.btnlmnv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlmnv.UseVisualStyleBackColor = true;
            this.btnlmnv.Click += new System.EventHandler(this.btnlmnv_Click);
            // 
            // btnxoanv
            // 
            this.btnxoanv.Image = global::DoAn1.Properties.Resources._3Xoa;
            this.btnxoanv.Location = new System.Drawing.Point(379, 26);
            this.btnxoanv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnxoanv.Name = "btnxoanv";
            this.btnxoanv.Size = new System.Drawing.Size(104, 42);
            this.btnxoanv.TabIndex = 8;
            this.btnxoanv.Text = "Xóa";
            this.btnxoanv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnxoanv.UseVisualStyleBackColor = true;
            this.btnxoanv.Click += new System.EventHandler(this.btnxoanv_Click);
            // 
            // btnthemnv
            // 
            this.btnthemnv.Image = global::DoAn1.Properties.Resources._1Them;
            this.btnthemnv.Location = new System.Drawing.Point(137, 26);
            this.btnthemnv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnthemnv.Name = "btnthemnv";
            this.btnthemnv.Size = new System.Drawing.Size(94, 42);
            this.btnthemnv.TabIndex = 1;
            this.btnthemnv.Text = "Thêm";
            this.btnthemnv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnthemnv.UseVisualStyleBackColor = true;
            this.btnthemnv.Click += new System.EventHandler(this.btnthemnv_Click);
            // 
            // btnsuanv
            // 
            this.btnsuanv.Image = global::DoAn1.Properties.Resources._2Sua;
            this.btnsuanv.Location = new System.Drawing.Point(251, 26);
            this.btnsuanv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnsuanv.Name = "btnsuanv";
            this.btnsuanv.Size = new System.Drawing.Size(97, 42);
            this.btnsuanv.TabIndex = 7;
            this.btnsuanv.Text = "Sửa";
            this.btnsuanv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsuanv.UseVisualStyleBackColor = true;
            this.btnsuanv.Click += new System.EventHandler(this.btnsuanv_Click);
            // 
            // grbthongtinnv
            // 
            this.grbthongtinnv.Controls.Add(this.cbbgt);
            this.grbthongtinnv.Controls.Add(this.label18);
            this.grbthongtinnv.Controls.Add(this.label12);
            this.grbthongtinnv.Controls.Add(this.txtdiachinv);
            this.grbthongtinnv.Controls.Add(this.label13);
            this.grbthongtinnv.Controls.Add(this.txtsdtnv);
            this.grbthongtinnv.Controls.Add(this.txttennv);
            this.grbthongtinnv.Controls.Add(this.txtmanhanvien);
            this.grbthongtinnv.Controls.Add(this.label16);
            this.grbthongtinnv.Controls.Add(this.label17);
            this.grbthongtinnv.Location = new System.Drawing.Point(4, 59);
            this.grbthongtinnv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbthongtinnv.Name = "grbthongtinnv";
            this.grbthongtinnv.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbthongtinnv.Size = new System.Drawing.Size(1001, 117);
            this.grbthongtinnv.TabIndex = 22;
            this.grbthongtinnv.TabStop = false;
            this.grbthongtinnv.Text = "Thông tin ";
            // 
            // cbbgt
            // 
            this.cbbgt.FormattingEnabled = true;
            this.cbbgt.Items.AddRange(new object[] {
            "nam",
            "nữ"});
            this.cbbgt.Location = new System.Drawing.Point(772, 30);
            this.cbbgt.Name = "cbbgt";
            this.cbbgt.Size = new System.Drawing.Size(121, 28);
            this.cbbgt.TabIndex = 20;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(688, 35);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 20);
            this.label18.TabIndex = 19;
            this.label18.Text = "Giới Tính";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "Địa Chỉ";
            // 
            // txtdiachinv
            // 
            this.txtdiachinv.Location = new System.Drawing.Point(157, 85);
            this.txtdiachinv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtdiachinv.Name = "txtdiachinv";
            this.txtdiachinv.Size = new System.Drawing.Size(128, 27);
            this.txtdiachinv.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(347, 88);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 20);
            this.label13.TabIndex = 16;
            this.label13.Text = "Số Điện Thoại";
            // 
            // txtsdtnv
            // 
            this.txtsdtnv.Location = new System.Drawing.Point(487, 85);
            this.txtsdtnv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtsdtnv.Name = "txtsdtnv";
            this.txtsdtnv.Size = new System.Drawing.Size(128, 27);
            this.txtsdtnv.TabIndex = 15;
            this.txtsdtnv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsdtnv_KeyPress);
            // 
            // txttennv
            // 
            this.txttennv.Location = new System.Drawing.Point(487, 33);
            this.txttennv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(142, 27);
            this.txttennv.TabIndex = 6;
            this.txttennv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttennv_KeyPress);
            // 
            // txtmanhanvien
            // 
            this.txtmanhanvien.Location = new System.Drawing.Point(157, 36);
            this.txtmanhanvien.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtmanhanvien.Name = "txtmanhanvien";
            this.txtmanhanvien.Size = new System.Drawing.Size(137, 27);
            this.txtmanhanvien.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(347, 39);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 20);
            this.label16.TabIndex = 10;
            this.label16.Text = "Tên Nhân Viên";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(19, 39);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(114, 20);
            this.label17.TabIndex = 9;
            this.label17.Text = "Mã Nhân Viên";
            // 
            // QlNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1008, 566);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.dgvnhanvien);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.grbthongtinnv);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QlNhanvien";
            this.Text = "QlNhanvien";
            this.Load += new System.EventHandler(this.QlNhanvien_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhanvien)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.grbthongtinnv.ResumeLayout(false);
            this.grbthongtinnv.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox cbbtknv;
        private System.Windows.Forms.Button btntknv;
        private System.Windows.Forms.DataGridView dgvnhanvien;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnlmnv;
        private System.Windows.Forms.Button btnxoanv;
        private System.Windows.Forms.Button btnthemnv;
        private System.Windows.Forms.Button btnsuanv;
        private System.Windows.Forms.GroupBox grbthongtinnv;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtdiachinv;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtsdtnv;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.TextBox txtmanhanvien;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbbgt;
    }
}