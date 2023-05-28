using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using DTO;
using System.Windows.Forms;

namespace DoAn1
{
    public partial class QLNhaCungCap : Form
    {
        NhaCungCap ncc=new NhaCungCap();
        BUS_NhaCungCap bus_ncc=new BUS_NhaCungCap();
        public QLNhaCungCap()
        {
            InitializeComponent();
        }
        void Loaddgvncc()
        {
            dgvnhacungcap.DataSource = bus_ncc.Laydulieu();
            dgvnhacungcap.Columns[0].HeaderText = "Mã Nhà Cung Cấp";
            dgvnhacungcap.Columns[1].HeaderText = "Tên Nhà Cung Cấp";
            dgvnhacungcap.Columns[2].HeaderText = "Địa Chỉ";
            dgvnhacungcap.Columns[3].HeaderText = "Số Điện Thoại";
        }
        private void dgvnhacungcap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtmancc.Text = dgvnhacungcap[0, i].Value.ToString();
            txttenncc.Text = dgvnhacungcap[1, i].Value.ToString();
            txtdiachi.Text = dgvnhacungcap[2, i].Value.ToString();
            txtsdt.Text = dgvnhacungcap[3, i].Value.ToString();
        }

        private void btnlmncc_Click(object sender, EventArgs e)
        {
            bus_ncc.Lammoi(grbthongtinncc);
            Loaddgvncc();
        }

        private NhaCungCap getncc() 
        {
            ncc.Mancc1 = txtmancc.Text;
            ncc.Tenncc1 = txttenncc.Text;
            ncc.Diachi1 = txtdiachi.Text;
            ncc.SDT1 = txtsdt.Text;
            return ncc;
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            
            if (txtmancc.Text.Trim() != "" && txttenncc.Text.Trim() != "" && txtdiachi.Text.Trim() != "" && txtsdt.Text.Trim() != "")
            {
                NhaCungCap ncc=getncc();
                if (bus_ncc.Kiemtrama(txtmancc.Text) == 1)
                {
                    MessageBox.Show("Mã đã tồn tại, vui lòng nhập lại mã!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (bus_ncc.ThemNCC(ncc) == true)
                    {
                        MessageBox.Show("Thêm thành công!");
                        Loaddgvncc();
                    }
                }
            }
            else
            {
                MessageBox.Show("Phải nhập dữ liệu vào để thêm !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            NhaCungCap ncc = getncc();
            if (bus_ncc.SuaNCC(ncc) == true)
            {
                MessageBox.Show("Sửa thành công!");
                Loaddgvncc();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            NhaCungCap ncc = getncc();
            if (bus_ncc.XoaNCC(ncc) == true)
            {
                DialogResult r = MessageBox.Show("Bạn có muốn xóa không?", " Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    MessageBox.Show("Xóa thành công!");
                    Loaddgvncc();
                    bus_ncc.Lammoi(grbthongtinncc);
                }
            }
        }

        private void btntkncc_Click(object sender, EventArgs e)
        {
            if (cbbtkncc.Text == "Tìm Kiếm Theo Mã")
            {
                dgvnhacungcap.DataSource = bus_ncc.TimKiemmancc(txtmancc.Text);

                if (txtmancc.Text == "")
                {
                    MessageBox.Show("Hãy Nhập Dữ Liệu Vào Phần Cần Tìm!!!", "Thông Báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }

            }
            if (cbbtkncc.Text == "Tìm Kiếm Theo Tên")
            {
                dgvnhacungcap.DataSource = bus_ncc.TimKiemtenncc(txttenncc.Text);
                if (txttenncc.Text == "")
                {
                    MessageBox.Show("Hãy Nhập Dữ Liệu Vào Phần Cần Tìm!!!", "Thông Báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
        }

        private void cbbtkncc_SelectedIndexChanged(object sender, EventArgs e)
        {
            bus_ncc.Lammoi(grbthongtinncc);
            Loaddgvncc();
        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem kí tự nhập vào có phải là số hay không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Chỉ cho phép nhập tối đa 10 kí tự
            if (txtsdt.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void QLNhaCungCap_Load(object sender, EventArgs e)
        {
            Loaddgvncc();
        }

        private void txtsdt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
