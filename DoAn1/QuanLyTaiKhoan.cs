using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace DoAn1
{
    public partial class QuanLyTaiKhoan : Form
    {
        TaiKhoan tk = new TaiKhoan();
        BUS_TaiKhoan bus_tk = new BUS_TaiKhoan();
        BUS_Nhanvien bus_nv = new BUS_Nhanvien();
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
        }
        void loaddgv()
        {
            dgvtk.DataSource = bus_tk.Laydulieu();
            dgvtk.Columns[0].HeaderText = "Tài Khoản";
            dgvtk.Columns[1].HeaderText = "Mật Khẩu";
            dgvtk.Columns[2].HeaderText = "Quyền";
            dgvtk.Columns[3].HeaderText = "Mã Nhân Viên";
        }
        void loadnv()
        {
            cbbmanv.DataSource = bus_nv.Laydulieu();
            cbbmanv.DisplayMember = "Manhanvien";
            cbbmanv.ValueMember = "Manhanvien";
        }
        private TaiKhoan gettk()
        {
            tk.Taikhoan = txttk.Text;
            tk.Matkhau = txtmk.Text;
            tk.Maquyen = cbbquyen.SelectedIndex;
            tk.Manhanvien = cbbmanv.SelectedValue.ToString();
            return tk;
        }
        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            loadnv();
            loaddgv();
        }

        private void btntk_Click(object sender, EventArgs e)
        {
            if (cbbtktk.Text == "Tìm Kiếm Theo Tên Tài Khoản")
            {
                dgvtk.DataSource = bus_tk.Timkiemtk(txttk.Text);

                if (txttk.Text == "")
                {
                    MessageBox.Show("Hãy Nhập Dữ Liệu Vào Phần Cần Tìm!!!", "Thông Báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }

        }

        private void btnthetk_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = gettk();
            if (bus_tk.SuaTK(tk) == true)
            {
                MessageBox.Show("Sửa thành công");
                loaddgv();
            }

        }

        private void btnxoatk_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = gettk();
            if (bus_tk.XoaTk(tk) == true)
            {
                DialogResult r = MessageBox.Show("Bạn có muốn xóa không?", " Tông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    MessageBox.Show("Xóa thành công!");
                    loaddgv();
                    bus_tk.Lammoi(grbThongtintk);
                }
            }

        }

        private void btnlmtk_Click(object sender, EventArgs e)
        {
            bus_tk.Lammoi(grbThongtintk);
            bus_tk.Lammoi(grbcn);
        }

        private void btnthemtk_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = gettk();
            if (txttk.Text.Trim() == " " && txtmk.Text.Trim() == " ")
            {
                MessageBox.Show("Bạn phải nhập đủ thông tin cần thiết ");
            }
            else
            {
                if (bus_tk.Kiemtrama(txttk.Text) == 1)
                {
                    MessageBox.Show("Tài khoản đã tồn tại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }                             
                else if (bus_tk.Kttknv(cbbmanv.SelectedValue.ToString()) == 1)
                {
                    MessageBox.Show("Đã tồn tại nhân viên sở hữu tài khoản, vui lòng tạo tài khoản mới!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                
                else
                {
                    bus_tk.ThemTK(tk);
                    MessageBox.Show("Thêm thành công");
                }

            }
            loaddgv();
        }

        private void dgvtk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txttk.Text = dgvtk[0, i].Value.ToString();
            txtmk.Text = dgvtk[1, i].Value.ToString();
            cbbquyen.Text = dgvtk[2, i].Value.ToString();
            cbbmanv.Text = dgvtk[3, i].Value.ToString();
        }
    }
}
