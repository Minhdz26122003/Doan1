using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using BUS;
using DTO;

namespace DoAn1
{
    public partial class DangKy : Form
    {
        TaiKhoan tk = new TaiKhoan();
        BUS_Nhanvien bus_nv = new BUS_Nhanvien();
        BUS_TaiKhoan bus_taikhoan = new BUS_TaiKhoan();
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
            tk.Maquyen = cbbltk.SelectedIndex;
            tk.Manhanvien = cbbmanv.SelectedValue.ToString();
            return tk;
        }
        public DangKy()
        {
            InitializeComponent();
        }
        private void Chkpass_CheckedChanged(object sender, EventArgs e)
        {
            if (Chkpass.Checked)
            {
                txtmk.PasswordChar = (char)0;
                txtnlmk.PasswordChar = (char)0;
            }
            else
            {
                txtmk.PasswordChar = (char)0;
                txtnlmk.PasswordChar = (char)0;
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhap dn = new DangNhap();
            dn.ShowDialog();
        }
        public bool ktranull( )
        {
            if (txttk.Text == "")
            {
                MessageBox.Show("Vui long nhâp tên tài khoản!", "Thông báo");
                return false;
            }
            else if (txtmk.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu !", "Thông báo");
                return false;
            }
            else if (cbbltk.Text == "")
            {
                MessageBox.Show("Vui lòng nhập loại tài khoản!", "Thông báo");
                return false;
            }
            else if (txtmk.Text != txtnlmk.Text)
            {
                MessageBox.Show("Mật khẩu mới không trùng nhau!", "Thông báo");
                return false;
            }
        
            return true;
        }
        private void btndangky_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = gettk();
            if (ktranull()==false)
            {
                MessageBox.Show("Bạn phải nhập đủ thông tin cần thiết ");
            }
            else
            {
                if (bus_taikhoan.Kiemtrama(txttk.Text) == 1)
                {
                    MessageBox.Show("Tài khoản đã tồn tại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (bus_taikhoan.Kttknv(cbbmanv.SelectedValue.ToString()) == 1)
                {
                    MessageBox.Show("Nhân viên đã có tài khoản, vui lòng chọ nhân viên mới!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    bus_taikhoan.ThemTK(tk);
                    MessageBox.Show("Thêm thành công");
                }

            }


        }

        private void DangKy_Load(object sender, EventArgs e)
        {
            loadnv();
        }
    }
}
