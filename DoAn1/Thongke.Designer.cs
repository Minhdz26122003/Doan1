namespace DoAn1
{
    partial class Thongke
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
            this.label4 = new System.Windows.Forms.Label();
            this.dgvtke = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.denngay = new System.Windows.Forms.DateTimePicker();
            this.tungay = new System.Windows.Forms.DateTimePicker();
            this.btnin = new System.Windows.Forms.Button();
            this.btntk = new System.Windows.Forms.Button();
            this.cbbtk = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtke)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(366, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 36);
            this.label4.TabIndex = 29;
            this.label4.Text = "Thống Kê Báo Cáo ";
            // 
            // dgvtke
            // 
            this.dgvtke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtke.Location = new System.Drawing.Point(17, 254);
            this.dgvtke.Name = "dgvtke";
            this.dgvtke.RowHeadersWidth = 51;
            this.dgvtke.RowTemplate.Height = 24;
            this.dgvtke.Size = new System.Drawing.Size(1040, 336);
            this.dgvtke.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.denngay);
            this.groupBox1.Controls.Add(this.tungay);
            this.groupBox1.Controls.Add(this.btnin);
            this.groupBox1.Controls.Add(this.btntk);
            this.groupBox1.Controls.Add(this.cbbtk);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1040, 183);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(893, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 22);
            this.label6.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Đến Ngày\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(799, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 22);
            this.label5.TabIndex = 37;
            this.label5.Text = "Tổng Tiền:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Từ Ngày\r\n";
            // 
            // denngay
            // 
            this.denngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.denngay.Location = new System.Drawing.Point(488, 125);
            this.denngay.Name = "denngay";
            this.denngay.Size = new System.Drawing.Size(222, 27);
            this.denngay.TabIndex = 34;
            // 
            // tungay
            // 
            this.tungay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tungay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tungay.Location = new System.Drawing.Point(102, 125);
            this.tungay.Name = "tungay";
            this.tungay.Size = new System.Drawing.Size(222, 27);
            this.tungay.TabIndex = 33;
            // 
            // btnin
            // 
            this.btnin.Image = global::DoAn1.Properties.Resources.excel;
            this.btnin.Location = new System.Drawing.Point(866, 32);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(138, 49);
            this.btnin.TabIndex = 32;
            this.btnin.Text = "In Thống Kê";
            this.btnin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnin.UseVisualStyleBackColor = true;
            this.btnin.Click += new System.EventHandler(this.btnin_Click);
            // 
            // btntk
            // 
            this.btntk.Image = global::DoAn1.Properties.Resources.invoice;
            this.btntk.Location = new System.Drawing.Point(686, 32);
            this.btntk.Name = "btntk";
            this.btntk.Size = new System.Drawing.Size(129, 49);
            this.btntk.TabIndex = 31;
            this.btntk.Text = "Thống Kê";
            this.btntk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btntk.UseVisualStyleBackColor = true;
            this.btntk.Click += new System.EventHandler(this.btntk_Click);
            // 
            // cbbtk
            // 
            this.cbbtk.FormattingEnabled = true;
            this.cbbtk.Items.AddRange(new object[] {
            "Thống Kê Doanh Thu Theo Thời Gian",
            "Thống Kê Nguyên Liệu Tồn",
            "Thống Kê Sản Phẩm Bán Chạy"});
            this.cbbtk.Location = new System.Drawing.Point(201, 42);
            this.cbbtk.Name = "cbbtk";
            this.cbbtk.Size = new System.Drawing.Size(281, 28);
            this.cbbtk.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Chọn Kiểu Thống Kê";
            // 
            // Thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1070, 602);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvtke);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Thongke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thongke";
            this.Load += new System.EventHandler(this.Thongke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtke)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvtke;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker denngay;
        private System.Windows.Forms.DateTimePicker tungay;
        private System.Windows.Forms.Button btnin;
        private System.Windows.Forms.Button btntk;
        private System.Windows.Forms.ComboBox cbbtk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}