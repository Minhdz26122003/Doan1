
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using DTO;
using System.Windows.Forms;
using BUS;

namespace DoAn1
{
    public partial class QLKH : Form
    {
         BUS_Khachhang bus_kh = new  BUS_Khachhang();
        Khachhang kh = new Khachhang();
 
        void loaddgvnv()
        {
            dgvkhachhang.DataSource = bus_kh.Laydulieu();
            dgvkhachhang.Columns[0].HeaderText = "Mã Khách Hàng";
            dgvkhachhang.Columns[1].HeaderText = "Tên Khách Hàng";
            dgvkhachhang.Columns[2].HeaderText = "Địa Chỉ";
            dgvkhachhang.Columns[3].HeaderText = "Số Điện Thoại";
        }
        public QLKH()
        {
            InitializeComponent();
        }
        public Khachhang getKH()
        {
            kh.Makhachhang1 = txtmakh.Text;
            kh.Tenkhachhang1 = txttenkh.Text;
            kh.Diachi = txtdiachikh.Text;
            kh.SDT = txtsdtkh.Text;
            return kh;
        }
        private void btnlmnv_Click(object sender, EventArgs e)
        {
            bus_kh.Lammoi(grbthongtinkh);
            loaddgvnv();
        }

        private void btnthemkh_Click(object sender, EventArgs e)
        {
            Khachhang kh=getKH();
            if (txtmakh.Text.Trim() != "" && txttenkh.Text.Trim() != "" && txtdiachikh.Text.Trim() != "" && txtsdtkh.Text.Trim() != "")
            {
                if (bus_kh.Kiemtrama(txtmakh.Text) == 1)
                {
                    MessageBox.Show("Mã đã tồn tại, vui lòng nhập lại mã!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (bus_kh.ThemKh(kh) == true)
                    {
                        MessageBox.Show("Thêm thành công!");
                        loaddgvnv();
                    }
                }
            }
            else
            {
                MessageBox.Show("Phải nhập dữ liệu vào để thêm !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnsuakh_Click(object sender, EventArgs e)
        {
            Khachhang kh = getKH();
            if (bus_kh.SuaKh(kh) == true)
            {
                MessageBox.Show("Sửa Thành Công");
                loaddgvnv();
            }
        }

        private void btnxoakh_Click(object sender, EventArgs e)
        {
            Khachhang kh = getKH();
            if (bus_kh.XoaKh(kh) == true)
            {
                DialogResult r = MessageBox.Show("Bạn có muốn xóa không?", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    MessageBox.Show("Xóa Thành Công");
                    loaddgvnv();
                    bus_kh.Lammoi(grbthongtinkh);
                }
            }
        }

        private void btntkkh_Click(object sender, EventArgs e)
        {
            Khachhang kh = getKH();
            if (cbbtkkh.Text == "Tìm Kiếm Theo Mã")
            {
                dgvkhachhang.DataSource = bus_kh.TimKiemmaKh(txtmakh.Text);

                if (txtmakh.Text == "")
                {
                    MessageBox.Show("Hãy Nhập Dữ Liệu Vào Phần Cần Tìm!!!", "Thông Báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }

            }
            if (cbbtkkh.Text == "Tìm Kiếm Theo Tên")
            {
                dgvkhachhang.DataSource = bus_kh.TimKiemtenKh(txttenkh.Text);
                if (txttenkh.Text == "")
                {
                    MessageBox.Show("Hãy Nhập Dữ Liệu Vào Phần Cần Tìm!!!", "Thông Báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
        }

        private void QLKH_Load(object sender, EventArgs e)
        {
            loaddgvnv();
        }

        private void txtsdtkh_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem kí tự nhập vào có phải là số hay không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Chỉ cho phép nhập tối đa 10 kí tự
            if (txtsdtkh.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvkhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtmakh.Text = dgvkhachhang[0, i].Value.ToString();
            txttenkh.Text = dgvkhachhang[1, i].Value.ToString();
            txtdiachikh.Text = dgvkhachhang[2, i].Value.ToString();
            txtsdtkh.Text = dgvkhachhang[3, i].Value.ToString();
            
        }

        private void cbbtkkh_SelectedIndexChanged(object sender, EventArgs e)
        {
            bus_kh.Lammoi(grbthongtinkh);
        }

        private void txttenkh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
    }
}
