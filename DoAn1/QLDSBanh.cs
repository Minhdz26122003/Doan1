using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using DTO;
using System.Windows.Forms;
namespace DoAn1
{
    public partial class QLDSbanh : Form
    {
        BUS_Nhomloaibanh bus_nb = new BUS_Nhomloaibanh();
        BUS_Dsbanh bus_ba = new BUS_Dsbanh();
        Dsbanh ba = new Dsbanh();
       
        public QLDSbanh()
        {
            InitializeComponent();
        }
        void Loaddgvsp()
        {
            dgvsanpham.DataSource = bus_ba.Laydulieu();
            dgvsanpham.Columns[0].HeaderText = "Mã Món Ăn";
            dgvsanpham.Columns[1].HeaderText = "Tên Món Ăn";
            dgvsanpham.Columns[2].HeaderText = "Mã Nhóm";
            dgvsanpham.Columns[3].HeaderText = "Số Lượng";
            dgvsanpham.Columns[4].HeaderText = "Đơn Giá";

            dgvsanpham.Columns[4].DefaultCellStyle.Format = "#,#";
         
        }
        private void loadmaloai()
        {
            cbbmaloai.DataSource = bus_nb.Laydulieu();
            cbbmaloai.DisplayMember = "Tennhom";
            cbbmaloai.ValueMember = "Manhom";
        }
        private void QlDSMon_Load(object sender, EventArgs e)
        {
            loadmaloai();
            Loaddgvsp();
        }

        private void dgvsanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtmabanh.Text = dgvsanpham[0, i].Value.ToString();
            txtmabbanh.Text = dgvsanpham[1, i].Value.ToString();
            cbbmaloai.Text = dgvsanpham[2, i].Value.ToString();
            txtsl.Text = dgvsanpham[3, i].Value.ToString();
            txtdongia.Text = dgvsanpham[4, i].Value.ToString();
        }

        private void btnlmsp_Click(object sender, EventArgs e)
        {
            bus_ba.Lammoi(grbThongtinsp);
            Loaddgvsp();
        }
        private Dsbanh GetDsbanh()
        {
            ba.Mamon = txtmabanh.Text;
            ba.Tenmon = txtmabbanh.Text;
            ba.Manhom = cbbmaloai.SelectedValue.ToString();
            ba.Soluong = int.Parse(txtsl.Text);
            ba.Dongia = float.Parse(txtdongia.Text);
            return ba;
        }
        private void btnthemsp_Click(object sender, EventArgs e)
        {
           

            if (txtmabanh.Text.Trim() != "" && cbbmaloai.Text.Trim() != "" && txtdongia.Text.Trim() != "" && txtmabbanh.Text.Trim() != "")
            {
                Dsbanh bs = GetDsbanh();
                if (bus_ba.Kiemtrama(txtmabanh.Text) == 1)
                {
                    MessageBox.Show("Mã đã tồn tại, vui lòng nhập lại mã!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (bus_ba.ThemSP(ba) == true)
                    {
                        MessageBox.Show("Thêm thành công!");
                        Loaddgvsp();
                    }
                }
            }
            else
            {
                MessageBox.Show("Phải nhập dữ liệu vào để thêm !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnsuasp_Click(object sender, EventArgs e)
        {

            Dsbanh ba = GetDsbanh();
            if (bus_ba.SuaSP(ba) == true)
            {
                MessageBox.Show("Sửa thành công!");
                Loaddgvsp();
            }
        }

        private void btnxoasp_Click(object sender, EventArgs e)
        {
            Dsbanh bs = GetDsbanh();
            if (bus_ba.XoaSP(ba) == true)
            {
                DialogResult r = MessageBox.Show("Bạn có muốn xóa không?", " Tông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    MessageBox.Show("Xóa thành công!");
                    Loaddgvsp();
                    bus_ba.Lammoi(grbThongtinsp);
                }
            }
        }

        private void btntk_Click(object sender, EventArgs e)
        {
            if (cbbtksp.Text == "Tìm Kiếm Theo Mã")
            {
                dgvsanpham.DataSource = bus_ba.TimKiemmadu(txtmabanh.Text);

                if (txtmabanh.Text == "")
                {
                    MessageBox.Show("Hãy Nhập Dữ Liệu Vào Phần Cần Tìm!!!", "Thông Báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }

            }
            if (cbbtksp.Text == "Tìm Kiếm Theo Tên")
            {
                dgvsanpham.DataSource = bus_ba.TimKiemtendu(txtmabbanh.Text);
                if (txtmabbanh.Text == "")
                {
                    MessageBox.Show("Hãy Nhập Dữ Liệu Vào Phần Cần Tìm!!!", "Thông Báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            if (cbbtksp.Text == "Tìm Kiếm Theo Giá Tiền")
            {
                dgvsanpham.DataSource = bus_ba.Timkiemgiadu(txtdongia.Text);
                if (txtdongia.Text == "")
                {
                    MessageBox.Show("Hãy Nhập Dữ Liệu Vào Phần Cần Tìm!!!", "Thông Báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
        }

     
        private void txtdongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

        private void cbbtksp_SelectedIndexChanged(object sender, EventArgs e)
        {
            bus_ba.Lammoi(grbThongtinsp);
            Loaddgvsp();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtsl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void txtdongia_TextChanged(object sender, EventArgs e)
        {
            if (txtdongia.Text == "" || txtdongia.Text == "0") return;
            decimal number;
            number = decimal.Parse(txtdongia.Text, System.Globalization.NumberStyles.Currency);
            txtdongia.Text = number.ToString("#,#");
            txtdongia.SelectionStart = txtdongia.Text.Length;
        }
    }
}
