using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private bool CheckExistForm(string name)
        {
            bool check=false;
            foreach (Form frm in this.MdiChildren)
            {
                if(frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        private void ActiveChildForm(string name)
        {
            foreach(Form frm in this.MdiChildren)
            {
                if( frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!CheckExistForm("DoiMatKhau"))
            {
                DoiMatKhau mk = new DoiMatKhau();
                mk.MdiParent = this;
                mk.Dock = DockStyle.None;
                mk.Show();
            }
            else
                ActiveChildForm("DoiMatKhau");
        }

        private void quanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("QlNhanvien"))
            {
                QlNhanvien nv = new QlNhanvien();
                nv.MdiParent = this;
                nv.Dock = DockStyle.Fill;
                nv.Show();
            }
            else
                ActiveChildForm("QlNhanvien");
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("QuanLyTaiKhoan"))
            {
                QuanLyTaiKhoan tk = new QuanLyTaiKhoan();
                tk.MdiParent = this;
                tk.Dock = DockStyle.Fill;
                tk.Show();
            }
            else
                ActiveChildForm("QuanLyTaiKhoan");
           
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhap dn = new DangNhap();
            dn.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chác chắn muốn thoát không??", " Thông Báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (r == DialogResult.OK)
                Application.Exit();

        }

        private void quảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("QlNguyenLieu"))
            {
                QlNguyenLieu nl = new QlNguyenLieu();
                nl.MdiParent = this;
                nl.Dock = DockStyle.Fill;
                nl.Show();
            }
            else
                ActiveChildForm("QlNguyenLieu");
            
        }

        private void quảnLýMónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("QLDSbanh"))
            {
                QLDSbanh banh = new QLDSbanh();
                banh.MdiParent = this;
                banh.Dock = DockStyle.Fill;
                banh.Show();
            }
            else
                ActiveChildForm("QLDSbanh");
        }

        private void quảnLýNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("QLNhaCungCap"))
            {
                QLNhaCungCap ncc = new QLNhaCungCap();
                ncc.MdiParent = this;
                ncc.Dock = DockStyle.Fill;
                ncc.Show();
            }
            else
                ActiveChildForm("QLNhaCungCap");

        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("QLKH"))
            {
                QLKH kh = new QLKH();
                kh.MdiParent = this;
                kh.Dock = DockStyle.Fill;
                kh.Show();
            }
            else
                ActiveChildForm("QLKH");

        }

        private void quảnLýHàngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Nhaphang"))
            {
                Nhaphang qlnh = new Nhaphang();
                qlnh.MdiParent = this;
                qlnh.Dock = DockStyle.Fill;
                qlnh.Show();
            }
            else
                ActiveChildForm("Nhaphang");
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Trogiup"))
            {
                Trogiup tg = new Trogiup();
                tg.MdiParent = this;
                tg.Dock = DockStyle.Fill;
                tg.Show();
            }
            else
                ActiveChildForm("Trogiup");
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {          
               
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (Program.code == 0)
            {
                quanlytaikhoanToolStripMenuItem.Enabled = false;    
                quanToolStripMenuItem.Enabled = false;  
                quảnLýKháchHàngToolStripMenuItem.Enabled = false;
                quảnLýNhàCungCấpToolStripMenuItem.Enabled = false;
                quảnLýHàngNhậpToolStripMenuItem.Enabled=false;
                quảnLýHóaĐơnBánToolStripMenuItem.Enabled = false;
            }
            else
            {
                quanlytaikhoanToolStripMenuItem.Enabled = true;
                quanToolStripMenuItem.Enabled = true;
                quảnLýKháchHàngToolStripMenuItem.Enabled = true;
                quảnLýNhàCungCấpToolStripMenuItem.Enabled = true;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m = new Main();
            m.ShowDialog();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Thongke"))
            {
                Thongke tg = new Thongke();
                tg.MdiParent = this;
                tg.Dock = DockStyle.Fill;
                tg.Show();
            }
            else
                ActiveChildForm("Thongke");
        }

        private void biểuĐồThốngKêDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("BieudoDT"))
            {
                BieudoDT tg = new BieudoDT();
                tg.MdiParent = this;
                tg.Dock = DockStyle.Fill;
                tg.Show();
            }
            else
                ActiveChildForm("BieudoDT");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Trogiup"))
            {
                Trogiup tg = new Trogiup();
                tg.MdiParent = this;
                tg.Dock = DockStyle.Fill;
                tg.Show();
            }
            else
                ActiveChildForm("Trogiup");
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            if (!CheckExistForm("Thongke"))
            {
                Thongke tg = new Thongke();
                tg.MdiParent = this;
                tg.Dock = DockStyle.Fill;
                tg.Show();
            }
            else
                ActiveChildForm("Thongke");
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Banhang"))
            {
                Banhang tg = new Banhang();
                tg.MdiParent = this;
                tg.Dock = DockStyle.Fill;
                tg.Show();
            }
            else
                ActiveChildForm("Banhang");
        }

        private void quảnLýHóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
