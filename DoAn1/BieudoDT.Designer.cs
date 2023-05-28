namespace DoAn1
{
    partial class BieudoDT
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chrMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtmonth = new System.Windows.Forms.DateTimePicker();
            this.dtpyear = new System.Windows.Forms.DateTimePicker();
            this.cbbtime = new System.Windows.Forms.ComboBox();
            this.lblMain = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chrMain)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chrMain
            // 
            chartArea1.Name = "ChartArea1";
            this.chrMain.ChartAreas.Add(chartArea1);
            this.chrMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            this.chrMain.Legends.Add(legend1);
            this.chrMain.Location = new System.Drawing.Point(0, 125);
            this.chrMain.Margin = new System.Windows.Forms.Padding(4);
            this.chrMain.Name = "chrMain";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.LegendText = "Tổng tiền";
            series1.Name = "cot";
            series1.YValuesPerPoint = 2;
            this.chrMain.Series.Add(series1);
            this.chrMain.Size = new System.Drawing.Size(1000, 437);
            this.chrMain.TabIndex = 0;
            this.chrMain.Text = "chart1";
            // 
            // dtmonth
            // 
            this.dtmonth.CustomFormat = "MM";
            this.dtmonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmonth.Location = new System.Drawing.Point(478, 73);
            this.dtmonth.Margin = new System.Windows.Forms.Padding(4);
            this.dtmonth.Name = "dtmonth";
            this.dtmonth.ShowUpDown = true;
            this.dtmonth.Size = new System.Drawing.Size(62, 27);
            this.dtmonth.TabIndex = 1;
            this.dtmonth.ValueChanged += new System.EventHandler(this.dtmonth_ValueChanged);
            // 
            // dtpyear
            // 
            this.dtpyear.CustomFormat = "yyyy";
            this.dtpyear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpyear.Location = new System.Drawing.Point(637, 71);
            this.dtpyear.Margin = new System.Windows.Forms.Padding(4);
            this.dtpyear.Name = "dtpyear";
            this.dtpyear.ShowUpDown = true;
            this.dtpyear.Size = new System.Drawing.Size(89, 27);
            this.dtpyear.TabIndex = 2;
            this.dtpyear.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // cbbtime
            // 
            this.cbbtime.FormattingEnabled = true;
            this.cbbtime.Items.AddRange(new object[] {
            "Ngày của tháng",
            "Tháng của năm",
            "Hàng Năm"});
            this.cbbtime.Location = new System.Drawing.Point(203, 70);
            this.cbbtime.Margin = new System.Windows.Forms.Padding(4);
            this.cbbtime.Name = "cbbtime";
            this.cbbtime.Size = new System.Drawing.Size(150, 28);
            this.cbbtime.TabIndex = 3;
            this.cbbtime.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Location = new System.Drawing.Point(835, 88);
            this.lblMain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(13, 20);
            this.lblMain.TabIndex = 4;
            this.lblMain.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(370, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Biểu Đồ Thống Kê";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbbtime);
            this.panel1.Controls.Add(this.lblMain);
            this.panel1.Controls.Add(this.dtmonth);
            this.panel1.Controls.Add(this.dtpyear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 117);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(586, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Năm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Chọn kiểu thống kê ";
            // 
            // BieudoDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chrMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BieudoDT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biểu đồ";
            this.Load += new System.EventHandler(this.SaleChatr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrMain)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrMain;
        private System.Windows.Forms.DateTimePicker dtmonth;
        private System.Windows.Forms.DateTimePicker dtpyear;
        private System.Windows.Forms.ComboBox cbbtime;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}