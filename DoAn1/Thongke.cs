using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using DTO;
using BUS;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace DoAn1
{
    public partial class Thongke : Form
    {
        BUS_CTNhapnguyenlieu bus_ctn = new BUS_CTNhapnguyenlieu();
        BUS_Nguyenlieu bus_nl = new BUS_Nguyenlieu();
        BUS_Hoadonban bus_hdb=new BUS_Hoadonban();
        BUS_CTHoadonban bus_cthdb=new BUS_CTHoadonban();   
        public Thongke()
        {
            InitializeComponent();
        }
      

        public void thongke(string title,int cscot,int cot,string c1,string c2, string c3, string c4, string c5)
        {
           System.Data.DataTable dt = new System.Data.DataTable();
            //DataColumn col1 = new DataColumn(c1);

            //dt.Columns.Add(col1);
            for (int i = 1; i <= cscot; i++)//1-5
            {
                string columnName = "c" + i.ToString();
                DataColumn column = new DataColumn(columnName);
                dt.Columns.Add(column);
            }
            foreach (DataGridViewRow dtgvrow in dgvtke.Rows)
            {
                DataRow dtrow = dt.NewRow();
                for (int i = 0; i <= cot; i++)//0-4
                {
                    dtrow[i] = dtgvrow.Cells[i].Value;
                }
                //dtrow[0] = dtgvrow.Cells[0].Value;
                dt.Rows.Add(dtrow);
            }
            bus_hdb.tke(dt, "Thống Kê" ,title,c1,c2,c3,c4,c5);

        }

        private void btntk_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbtk.Text == "Thống Kê Doanh Thu Theo Thời Gian")
                {
                    CultureInfo culture = CultureInfo.CreateSpecificCulture("vi-VN");
                    Hoadonban hd1 = new Hoadonban();
                    Hoadonban hd2 = new Hoadonban();
                    hd1.Ngay = tungay.Value;
                    hd2.Ngay = denngay.Value;
                    dgvtke.DataSource = bus_hdb.Thongketheongay(hd1, hd2);
                    object a= bus_hdb.tt(hd1, hd2);
                    string.Format("#,##0", label6.Text);
                    dgvtke.Columns["Tongtien"].DefaultCellStyle.Format = "#,#";
                    MessageBox.Show("Thông kê thành công");
                    btnin.Enabled = true;
                }
                else if (cbbtk.Text == "Thống Kê Nguyên Liệu Tồn")
                {
                    dgvtke.DataSource = bus_nl.Laydulieu();
                    MessageBox.Show("Thông kê thành công");
                    btnin.Enabled = true;
                }
                else if (cbbtk.Text == "Thống Kê Sản Phẩm Bán Chạy")
                {
                    dgvtke.DataSource = bus_cthdb.Thongkespbanchay();
                    MessageBox.Show("Thông kê thành công");
                    btnin.Enabled = true;
                }
                else
                    MessageBox.Show("Hãy chọn kiểu thống kê");
                   
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnin_Click(object sender, EventArgs e)
        {
            if (cbbtk.Text == "Thống Kê Doanh Thu Theo Thời Gian")
            {
                thongke("Thống Kê Doanh Thu Theo Thời Gian", 5,4, "Mã Hóa Đơn", "Mã khách", "Mã nhân viên", "Ngày", "Tông tiền");
            }
            if (cbbtk.Text == "Thống Kê Nguyên Liệu Tồn")
            {
                thongke("Thống Kê Nguyên Liệu Tồn", 4,3,"Mã Nguyên Liệu ", "Tên Nguyên Liệu", "Số Lượng", "Đơn giá"," ");
            }
            if (cbbtk.Text == "Thống Kê Sản Phẩm Bán Chạy")
            {
                thongke("Thống Kê Sản Phẩm Bán Chạy", 3, 2, "Mã Sản Phẩm", "Tên Sản Phẩm", "Số Lượng"," "," ");
            }
        }
        private void Thongke_Load(object sender, EventArgs e)
        {
            btnin.Enabled = false;
        }
    }
}
