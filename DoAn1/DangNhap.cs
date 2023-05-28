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
    public partial class DangNhap : Form
    {
        TaiKhoan tk = new TaiKhoan();
        BUS_TaiKhoan bus_tk=new BUS_TaiKhoan();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tk.Taikhoan = txttaikhoan.Text;
            tk.Matkhau = txtmatkhua.Text;
            tk = bus_tk.Checkquyen(txttaikhoan.Text, txtmatkhua.Text);
            if (tk != null)
            {
                string user = bus_tk.Checklogin(tk);
                switch (user)
                {
                    case "Nhập tài khoản":
                        MessageBox.Show("Nhap tai khoan di");
                        return;
                    case "Nhập mật khẩu":
                        MessageBox.Show("Nhập mật khẩu di");
                        return;
                    case "Tài khoản hoặc mật khẩu không chính xác":
                        MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
                        return;
                }                
                if (tk.Maquyen == 0)
                {
                    MessageBox.Show("Chào mừng nhân viên đăng nhập");
                    Program.code = 0;
                    Main mn = new Main();
                    mn.Show();
                    this.Hide();
                }
                if (tk.Maquyen == 1)
                {
                    MessageBox.Show("Chào mừng quản lý đăng nhập");
                    Program.code = 1;
                    Main mn = new Main();
                    mn.Show();
                    this.Hide();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkmk_CheckedChanged(object sender, EventArgs e)
        {

            if (checkmk.Checked)
            {
                txtmatkhua.PasswordChar = (char)0;
            }
            else txtmatkhua.PasswordChar = '*';
        }

        private void label4_Click(object sender, EventArgs e)
        {
            DangKy dk = new DangKy();
            dk.ShowDialog();
            this.Hide();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
           
        }

        private void txttaikhoan_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
