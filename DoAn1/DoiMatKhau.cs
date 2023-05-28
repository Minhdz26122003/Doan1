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
    public partial class DoiMatKhau : Form
    {
        BUS_TaiKhoan bus_tk = new BUS_TaiKhoan();
        TaiKhoan tk = new TaiKhoan();
        public DoiMatKhau()
        {
            TaiKhoan tk = new TaiKhoan();
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            tk.Taikhoan = txttk.Text;
            tk.Matkhau = txtmkcu.Text;
            string mkmoi = txtmkmoi.Text;
            string nlmkmoi = txtnlmkmoi.Text;
            if (bus_tk.Kiemtra(txttk.Text, txtmkcu.Text) == true)
            {
                if (txtmkmoi.Text != txtnlmkmoi.Text)
                {
                    MessageBox.Show("Mật khẩu mới không khớp ");
                }
                else
                {
                    bus_tk.Doimk(tk, txtnlmkmoi.Text);
                    MessageBox.Show("Đổi Mật Khẩu Thành Công!!");
                }
            }
            else
            {
                MessageBox.Show("Sai Tài Khoản Hoặc Mật khẩu");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Main m=new Main();
            m.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtmkcu.PasswordChar = (char)0;
                txtmkmoi.PasswordChar = (char)0;
                txtnlmkmoi.PasswordChar = (char)0;
            }
            else
            {
                txtmkcu.PasswordChar = '*';
                txtmkmoi.PasswordChar = '*';
                txtnlmkmoi.PasswordChar = '*';
            }
        }
                
    }
}
