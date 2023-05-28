using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using DTO;
using System.Windows.Forms;


namespace DoAn1
{
    public partial class QlNhanvien : Form
    {
        BUS_Nhanvien bus_nv = new BUS_Nhanvien();
        NhanVien nv = new NhanVien();
        public QlNhanvien()
        {
            InitializeComponent();
        }
        void loaddgvnv()
        {
            dgvnhanvien.DataSource = bus_nv.Laydulieu();
            dgvnhanvien.Columns[0].HeaderText = "Mã Nhân Viên";
            dgvnhanvien.Columns[1].HeaderText = "Tên Nhân Viên";
            dgvnhanvien.Columns[2].HeaderText = "Giới tính";
            dgvnhanvien.Columns[3].HeaderText = "Địa Chỉ";
            dgvnhanvien.Columns[4].HeaderText = "Số Điện Thoại";
        }

        private void QlNhanvien_Load(object sender, EventArgs e)
        {
            loaddgvnv();
        }

        private void btnlmnv_Click(object sender, EventArgs e)
        {
            bus_nv.Lammoi(grbthongtinnv);
            loaddgvnv();
        }
        private NhanVien getnv()
        {
            nv.Manhanvien1 = txtmanhanvien.Text;
            nv.Tennhanvien1 = txttennv.Text;
            nv.Gioitinh1 = cbbgt.Text;
            nv.Diachi1 = txtdiachinv.Text;
            nv.SDT1 = txtsdtnv.Text;
            return nv;
        }

        private void btnthemnv_Click(object sender, EventArgs e)
        {
         
            if (txtmanhanvien.Text.Trim() != "" && txttennv.Text.Trim() != "" && cbbgt.Text.Trim() != "" && txtdiachinv.Text.Trim() != "" && txtsdtnv.Text.Trim() != "")
            {
                NhanVien nv = getnv();
                if (bus_nv.Kiemtrama(txtmanhanvien.Text) == 1)
                {
                    MessageBox.Show("Mã đã tồn tại, vui lòng nhập lại mã!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (bus_nv.Themnv(nv) == true)
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

        private void btnsuanv_Click(object sender, EventArgs e)
        {
            NhanVien nv = getnv();
            if (bus_nv.Suanv(nv) == true)
            {
                MessageBox.Show("Sửa Thành Công");
                loaddgvnv();
            }
        }

        private void btnxoanv_Click(object sender, EventArgs e)
        {
            NhanVien nv = getnv();
            if (bus_nv.Xoanv(nv) == true)
            {
                DialogResult r = MessageBox.Show("Bạn có muốn xóa không?", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    MessageBox.Show("Xóa Thành Công");
                    loaddgvnv();
                    bus_nv.Lammoi(grbthongtinnv);
                }
            }
        }

        private void btntknv_Click(object sender, EventArgs e)
        {
            if (cbbtknv.Text == "Tìm Kiếm Theo Mã")
            {
                dgvnhanvien .DataSource = bus_nv.TimKiemmanv(txtmanhanvien.Text);

                if (txtmanhanvien.Text == "")
                {
                    MessageBox.Show("Hãy Nhập Dữ Liệu Vào Phần Cần Tìm!!!", "Thông Báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }

            }
            if (cbbtknv.Text == "Tìm Kiếm Theo Tên")
            {
                dgvnhanvien.DataSource = bus_nv.TimKiemtennv(txttennv.Text);
                if (txttennv.Text == "")
                {
                    MessageBox.Show("Hãy Nhập Dữ Liệu Vào Phần Cần Tìm!!!", "Thông Báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtsdtnv_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem kí tự nhập vào có phải là số hay không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Chỉ cho phép nhập tối đa 10 kí tự
            if (txtsdtnv.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbbtknv_SelectedIndexChanged(object sender, EventArgs e)
        {
            bus_nv.Lammoi(grbthongtinnv);
        }

        private void dgvnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtmanhanvien.Text = dgvnhanvien[0, i].Value.ToString();
            txttennv.Text = dgvnhanvien[1, i].Value.ToString();
            cbbgt.Text = dgvnhanvien[2, i].Value.ToString();
            txtdiachinv.Text = dgvnhanvien[3, i].Value.ToString();
            txtsdtnv.Text = dgvnhanvien[4, i].Value.ToString();
        }

        private void txtgioitinh_TextChanged(object sender, EventArgs e)
        {
          
        }
     
        private void txtgioitinh_KeyPress(object sender, KeyPressEventArgs e)
        {
             
            
        }

        private void txttennv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
    }
}
