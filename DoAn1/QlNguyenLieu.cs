using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using DTO;
using System.Windows.Forms;

namespace DoAn1
{
    public partial class QlNguyenLieu : Form
    {
        BUS_Nguyenlieu bus_nl = new BUS_Nguyenlieu();
        Nguyenlieu nl = new Nguyenlieu();
        
        public QlNguyenLieu()
        {
            InitializeComponent();
        }
        void Loaddgvlsp()
        {
            txtdongia.Text = "0";
            txtsl.Text = "0";
            dgvnl.DataSource = bus_nl.Laydulieu();
            dgvnl.Columns[0].HeaderText = "Mã Nguyên Liệu";
            dgvnl.Columns[1].HeaderText = "Tên Nguyên Liệu";
            dgvnl.Columns[2].HeaderText = "Số Lượng";
            dgvnl.Columns[3].HeaderText = "Đơn Giá";

            dgvnl.Columns[3].DefaultCellStyle.Format = "#,#";
        }

        private void QlNguyenLieu_Load(object sender, EventArgs e)
        {
            Loaddgvlsp();
        }

        private Nguyenlieu getnl()
        {
            nl.Manguyenlieu = txtmanl.Text;
            nl.Tennguyenlieu = txttennl.Text;
            nl.Soluong = int.Parse(txtsl.Text);
            nl.Dongia = float.Parse(txtdongia.Text);
            return nl;
        }
        private void btnlmlsp_Click(object sender, EventArgs e)
        {
            bus_nl.Lammoi(grbThongtinlsp);
            Loaddgvlsp();
        }

        private void btnthemlsp_Click(object sender, EventArgs e)
        {
                      
            if (txtmanl.Text.Trim() != "" && txttennl.Text.Trim() != "" && txtsl.Text.Trim() != "" && txtdongia.Text.Trim() !="")
            {
                Nguyenlieu nl = getnl();
                if (bus_nl.Kiemtrama(txtmanl.Text) == 1)
                {
                    MessageBox.Show("Mã đã tồn tại, vui lòng nhập lại mã!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (bus_nl.Themnl(nl) == true)
                    {
                        MessageBox.Show("Thêm thành công!");
                        Loaddgvlsp();
                    }
                }
            }
            else
            {
                MessageBox.Show("Phải nhập dữ liệu vào để thêm !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnsualsp_Click(object sender, EventArgs e)
        {
            Nguyenlieu nl = getnl();
            if (bus_nl.Suanl(nl) == true)
            {
                MessageBox.Show("Sửa thành công!");
                Loaddgvlsp();
            }
        }

        private void btnxoalsp_Click(object sender, EventArgs e)
        {
            Nguyenlieu nl = getnl();
            if (bus_nl.Xoanl(nl) == true)
            {
                DialogResult r = MessageBox.Show("Bạn có muốn xóa không?", " Tông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    MessageBox.Show("Xóa thành công!");
                    Loaddgvlsp();
                    bus_nl.Lammoi(grbThongtinlsp);
                }
            }
        }

        private void btntimkiemlsp_Click(object sender, EventArgs e)
        {
            if (cbbtimkiemnl.Text == "Tìm Kiếm Theo Mã")
            {
                dgvnl.DataSource = bus_nl.TimKiemmanl(txtmanl.Text);
                if (txtmanl.Text == "")
                {
                    MessageBox.Show("Hãy Nhập Dữ Liệu Vào Phần Cần Tìm!!!", "Thông Báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            if (cbbtimkiemnl.Text == "Tìm Kiếm Theo Tên")
            {
                dgvnl.DataSource = bus_nl.TimKiemtennl(txttennl.Text);
                if (txttennl.Text == "")
                {
                    MessageBox.Show("Hãy Nhập Dữ Liệu Vào Phần Cần Tìm!!!", "Thông Báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
        }

        private void dgvLoaiSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtmanl.Text = dgvnl[0, i].Value.ToString();
            txttennl.Text = dgvnl[1, i].Value.ToString();
            txtsl.Text = dgvnl[2, i].Value.ToString();
            txtdongia.Text=dgvnl[3, i].Value.ToString();
        }

        private void cbbtimkiemlsp_SelectedIndexChanged(object sender, EventArgs e)
        {
            bus_nl.Lammoi(grbThongtinlsp);
            Loaddgvlsp();
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
