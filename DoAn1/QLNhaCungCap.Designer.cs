namespace DoAn1
{
    partial class QLNhaCungCap
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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.cbbtkncc = new System.Windows.Forms.ComboBox();
            this.btntkncc = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.dgvnhacungcap = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnlmncc = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.grbthongtinncc = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txttenncc = new System.Windows.Forms.TextBox();
            this.txtmancc = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox6.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhacungcap)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.grbthongtinncc.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Controls.Add(this.cbbtkncc);
            this.groupBox6.Controls.Add(this.btntkncc);
            this.groupBox6.Location = new System.Drawing.Point(527, 184);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(487, 94);
            this.groupBox6.TabIndex = 24;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tìm Kiếm ";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(21, 40);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(174, 22);
            this.label23.TabIndex = 12;
            this.label23.Text = "Chọn Kiểu Tìm Kiếm";
            // 
            // cbbtkncc
            // 
            this.cbbtkncc.FormattingEnabled = true;
            this.cbbtkncc.Items.AddRange(new object[] {
            "Tìm Kiếm Theo Mã",
            "Tìm Kiếm Theo Tên"});
            this.cbbtkncc.Location = new System.Drawing.Point(212, 37);
            this.cbbtkncc.Name = "cbbtkncc";
            this.cbbtkncc.Size = new System.Drawing.Size(163, 30);
            this.cbbtkncc.TabIndex = 11;
            this.cbbtkncc.SelectedIndexChanged += new System.EventHandler(this.cbbtkncc_SelectedIndexChanged);
            // 
            // btntkncc
            // 
            this.btntkncc.Image = global::DoAn1.Properties.Resources.find__1_;
            this.btntkncc.Location = new System.Drawing.Point(394, 31);
            this.btntkncc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btntkncc.Name = "btntkncc";
            this.btntkncc.Size = new System.Drawing.Size(65, 47);
            this.btntkncc.TabIndex = 10;
            this.btntkncc.UseVisualStyleBackColor = true;
            this.btntkncc.Click += new System.EventHandler(this.btntkncc_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label24);
            this.panel3.Location = new System.Drawing.Point(4, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1007, 50);
            this.panel3.TabIndex = 23;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Firebrick;
            this.label24.Location = new System.Drawing.Point(303, 12);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(377, 32);
            this.label24.TabIndex = 19;
            this.label24.Text = "QUẢN LÝ NHÀ CUNG CẤP";
            // 
            // dgvnhacungcap
            // 
            this.dgvnhacungcap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvnhacungcap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnhacungcap.Location = new System.Drawing.Point(4, 284);
            this.dgvnhacungcap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvnhacungcap.Name = "dgvnhacungcap";
            this.dgvnhacungcap.RowHeadersWidth = 51;
            this.dgvnhacungcap.RowTemplate.Height = 24;
            this.dgvnhacungcap.Size = new System.Drawing.Size(1010, 252);
            this.dgvnhacungcap.TabIndex = 22;
            this.dgvnhacungcap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvnhacungcap_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnlmncc);
            this.groupBox3.Controls.Add(this.btnxoa);
            this.groupBox3.Controls.Add(this.btnthem);
            this.groupBox3.Controls.Add(this.btnsua);
            this.groupBox3.Location = new System.Drawing.Point(4, 184);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(517, 94);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức Năng";
            // 
            // btnlmncc
            // 
            this.btnlmncc.Image = global::DoAn1.Properties.Resources.if_gtk_refresh_4811121;
            this.btnlmncc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlmncc.Location = new System.Drawing.Point(14, 31);
            this.btnlmncc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnlmncc.Name = "btnlmncc";
            this.btnlmncc.Size = new System.Drawing.Size(106, 47);
            this.btnlmncc.TabIndex = 9;
            this.btnlmncc.Text = "Làm Mới";
            this.btnlmncc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlmncc.UseVisualStyleBackColor = true;
            this.btnlmncc.Click += new System.EventHandler(this.btnlmncc_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Image = global::DoAn1.Properties.Resources._3Xoa;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(389, 31);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(93, 47);
            this.btnxoa.TabIndex = 8;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Image = global::DoAn1.Properties.Resources._1Them;
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(146, 31);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(106, 44);
            this.btnthem.TabIndex = 1;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Image = global::DoAn1.Properties.Resources._2Sua;
            this.btnsua.Location = new System.Drawing.Point(270, 31);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(97, 47);
            this.btnsua.TabIndex = 7;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // grbthongtinncc
            // 
            this.grbthongtinncc.Controls.Add(this.label11);
            this.grbthongtinncc.Controls.Add(this.txtsdt);
            this.grbthongtinncc.Controls.Add(this.label10);
            this.grbthongtinncc.Controls.Add(this.txtdiachi);
            this.grbthongtinncc.Controls.Add(this.txttenncc);
            this.grbthongtinncc.Controls.Add(this.txtmancc);
            this.grbthongtinncc.Controls.Add(this.label14);
            this.grbthongtinncc.Controls.Add(this.label15);
            this.grbthongtinncc.Location = new System.Drawing.Point(4, 57);
            this.grbthongtinncc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbthongtinncc.Name = "grbthongtinncc";
            this.grbthongtinncc.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbthongtinncc.Size = new System.Drawing.Size(1007, 121);
            this.grbthongtinncc.TabIndex = 20;
            this.grbthongtinncc.TabStop = false;
            this.grbthongtinncc.Text = "Thông tin ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 22);
            this.label11.TabIndex = 18;
            this.label11.Text = "Đia Chỉ";
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(850, 36);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(128, 28);
            this.txtsdt.TabIndex = 17;
            this.txtsdt.TextChanged += new System.EventHandler(this.txtsdt_TextChanged);
            this.txtsdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsdt_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(717, 39);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 22);
            this.label10.TabIndex = 16;
            this.label10.Text = "Số Điện Thoại";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(192, 80);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(128, 28);
            this.txtdiachi.TabIndex = 15;
            // 
            // txttenncc
            // 
            this.txttenncc.Location = new System.Drawing.Point(523, 33);
            this.txttenncc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txttenncc.Name = "txttenncc";
            this.txttenncc.Size = new System.Drawing.Size(142, 28);
            this.txttenncc.TabIndex = 6;
            // 
            // txtmancc
            // 
            this.txtmancc.Location = new System.Drawing.Point(192, 33);
            this.txtmancc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtmancc.Name = "txtmancc";
            this.txtmancc.Size = new System.Drawing.Size(137, 28);
            this.txtmancc.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(351, 36);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(166, 22);
            this.label14.TabIndex = 10;
            this.label14.Text = "Tên Nhà Cung Cấp";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 36);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(158, 22);
            this.label15.TabIndex = 9;
            this.label15.Text = "Mã Nhà Cung Cấp";
            // 
            // QLNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1020, 548);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvnhacungcap);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grbthongtinncc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QLNhaCungCap";
            this.Text = "QLNhaCungCap";
            this.Load += new System.EventHandler(this.QLNhaCungCap_Load);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhacungcap)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.grbthongtinncc.ResumeLayout(false);
            this.grbthongtinncc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cbbtkncc;
        private System.Windows.Forms.Button btntkncc;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DataGridView dgvnhacungcap;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnlmncc;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.GroupBox grbthongtinncc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txttenncc;
        private System.Windows.Forms.TextBox txtmancc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}