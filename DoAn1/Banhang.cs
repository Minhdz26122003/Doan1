using DTO;
using System.Data;
using BUS;
using System.Windows.Forms;
using System.Data.SqlClient;
using System;
using DoAn1.Reportt;
using CrystalDecisions.CrystalReports.Engine;
using DAL;
namespace DoAn1
{
    public partial class Banhang : Form
    {
        CTHoadonban cthdb = new CTHoadonban();
        Hoadonban hdb=new Hoadonban();  
        Dsbanh dsbanh=new Dsbanh();
        DBConnect con =new DBConnect();

        BUS_Nhanvien bus_nv = new BUS_Nhanvien();
        BUS_Khachhang bus_khachhang=new BUS_Khachhang();
        BUS_CTHoadonban bus_cthdb = new BUS_CTHoadonban();
        BUS_Hoadonban bus_hdb = new BUS_Hoadonban();
        BUS_Dsbanh bus_dsbanh=new BUS_Dsbanh();

        public Banhang()
        {
            InitializeComponent();
        }

        private void btnthemhd_Click(object sender, EventArgs e)
        {
            txtmahdb.Enabled = true;
            txtmahdb.Text = "";
            txtsl.Text = "";
            txtdg.Text = "";
            txtgiamgia.Text = "";
            txtthanhtien.Text = "";
            btnluu.Enabled = true;
            btbhuyhang.Enabled = true;
            btnhuyhd.Enabled = true;
            btnin.Enabled = true;
            loadHD();
            
        }
        public void Loadcbbkhach()
        {
            cbbmakhach.DataSource = bus_khachhang.Laydulieu();
            cbbmakhach.DisplayMember = "Tenkhach";
            cbbmakhach.ValueMember = "Makhach";
        }
        public void Loadcbbnv()
        {
            cbbmanv.DataSource = bus_nv.Laydulieu();
            cbbmanv.DisplayMember = "Tennhanvien";
            cbbmanv.ValueMember = "Manhanvien";
        }
        public void Loadsp()
        {
            cbbmasp.DataSource = bus_dsbanh.Laydulieu();
            cbbmasp.DisplayMember = "Tenmon";
            cbbmasp.ValueMember = "Mamon";
        }

        void loadHD()
        {
            string ma = txtmahdb.Text;
            dgvhangban.DataSource = bus_cthdb.Laydulieu(ma);
            dgvhangban.Columns[0].HeaderText = "Mã Hóa Đơn";
            dgvhangban.Columns[1].HeaderText = "Mã Sản Phẩm";
            dgvhangban.Columns[2].HeaderText = "Tên Sản Phẩm";
            dgvhangban.Columns[3].HeaderText = "Số lượng";
            dgvhangban.Columns[4].HeaderText = "Đơn giá";
            dgvhangban.Columns[5].HeaderText = "Giảm giá";
            dgvhangban.Columns[6].HeaderText = "Thành tiền";

            dgvhangban.Columns[4].DefaultCellStyle.Format = "#,#";
            dgvhangban.Columns[6].DefaultCellStyle.Format = "#,#";
        }
        private Dsbanh getb()
        {
            dsbanh.Mamon = cbbmasp.SelectedValue.ToString();
            dsbanh.Tenmon = cbbmasp.Text;       
            dsbanh.Soluong = int.Parse(txtsl.Text);
            dsbanh.Dongia = float.Parse(txtdg.Text);
            return dsbanh;
        }
        private Hoadonban gethdb()
        {
            hdb.MaHDB = txtmahdb.Text;
            hdb.Makhach = cbbmakhach.SelectedValue.ToString();
            hdb.Manhanvien = cbbmanv.SelectedValue.ToString();
            hdb.Ngay = dtngay.Value;
            return hdb;
        }
        private CTHoadonban getct()
        {
            cthdb.MaHDB = txtmahdb.Text;
            cthdb.Mamon = cbbmasp.SelectedValue.ToString();
            cthdb.Tenmon = cbbmasp.Text;
            cthdb.Soluong =int.Parse( txtsl.Text);
            cthdb.Dongia =float.Parse( txtdg.Text);
            cthdb.Giamgia = float.Parse(txtgiamgia.Text);
            cthdb.Thanhtien = float.Parse(txtthanhtien.Text);
            return cthdb;
        }
        private void btnluu_Click(object sender, EventArgs e)
        {
            Hoadonban hdb = gethdb();
            Dsbanh dsbanh = getb();
            CTHoadonban ct = getct();           
            if (bus_hdb.Kiemtrama(txtmahdb.Text) == 1)
            {

                if (bus_cthdb.KiemtraBan(txtmahdb.Text, cbbmasp.SelectedValue.ToString()))
                {
                    DialogResult r = MessageBox.Show("Sản phâm đã có trong hóa đơn bạn có muốn sửa lại!", "Thông báo", MessageBoxButtons.OKCancel);
                    if (r == DialogResult.OK)
                    {
                        bus_cthdb.SuaCTNhap(ct);
                        MessageBox.Show("Sửa thành công <3");
                    }
                }
                else
                {
                    bus_cthdb.ThemCTBan(ct);
                    MessageBox.Show("Thêm thành công <3");
                }

            }
            else
            {
                int so=int.Parse( bus_dsbanh.LaySL(cbbmasp.SelectedValue.ToString()));
                if (txtsl.Text!="0"  && txtmahdb.Text != "" && float.Parse(txtgiamgia.Text)<100) 
                {
                    if (so > 0)
                    {
                        cbbin.Text=txtmahdb.Text;
                        txtgiamgia.Enabled = false;
                        txtgiamgia.Enabled= false;
                        bus_hdb.ThemHDB(hdb);
                        bus_cthdb.ThemCTBan(ct);
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                        loadHD();
                    }
                    else
                    {
                        MessageBox.Show("Mặt hàng này hiện đã hết", "Thông báo", MessageBoxButtons.OK);
                    }
                  
                }
                else
                {
                    MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
            bus_hdb.updatett(txtmahdb.Text);
            txttongtien.Text = bus_hdb.laytt(txtmahdb.Text);


            string sl = bus_dsbanh.LaySL(cbbmasp.SelectedValue.ToString());//update so luong hang
            int slcon = Convert.ToInt32(sl) - (Convert.ToInt32(txtsl.Text));
            bus_dsbanh.SuaSLSP(dsbanh, slcon);
            loadHD();

        }

        private void btbhuyhang_Click(object sender, EventArgs e)
        {
            Hoadonban hdb = gethdb();
            if (MessageBox.Show("Bạn chắc muốn xóa sản phẩm: " + cbbmasp.Text + " ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (bus_cthdb.XoaCThangban(txtmahdb.Text,cbbmasp.SelectedValue.ToString()))
                {
                    if (bus_cthdb.kiemtrama(txtmahdb.Text) == 0)
                    {
                        bus_hdb.XoaHDB(hdb);
                    }
                    MessageBox.Show("Xóa thành công");
                }
                else
                    MessageBox.Show("không thể xóa");
            }   
            txttongtien.Text = bus_hdb.laytt(txtmahdb.Text);
            bus_hdb.updatett(txtmahdb.Text);
            txttongtien.Text = bus_hdb.laytt(txtmahdb.Text);

            string sl = bus_dsbanh.LaySL(cbbmasp.SelectedValue.ToString());//update so luong hang
            int slcon = Convert.ToInt32(sl) + (Convert.ToInt32(txtsl.Text));
            bus_dsbanh.SuaSLSP(dsbanh, slcon);
            loadHD();
        }

        private void btnhuyhd_Click(object sender, EventArgs e)
        {
            Hoadonban hdb = gethdb();

            if (bus_cthdb.XoaCTban(txtmahdb.Text) == true && bus_hdb.XoaHDB(hdb) == true)
            {

                DialogResult r = MessageBox.Show("Bạn có muốn xóa hóa đơn không?", " Tông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    MessageBox.Show("Xóa thành công!");
                                 
                    bus_cthdb.Lammoi(gbttc);
                    bus_cthdb.Lammoi(gbttsp);
                    bus_cthdb.Lammoi(grbcn);
                }
            }
            loadHD();
        }

       

        private void Banhang_Load(object sender, EventArgs e)
        {
            btnluu.Enabled = false;
            btbhuyhang.Enabled = false;
            btnhuyhd.Enabled = false;
            btnin.Enabled = false;
            loadHD();
            Loadcbbkhach();
            Loadsp();
            Loadcbbnv();
           
        }

        private void dgvhangban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            int i = e.RowIndex;
            txtmahdb.Text = dgvhangban[0, i].Value.ToString();
            cbbmasp.SelectedValue = dgvhangban[1, i].Value.ToString();
            cbbmasp.Text = dgvhangban[2, i].Value.ToString();
            txtsl.Text = dgvhangban[3, i].Value.ToString();
            txtdg.Text = dgvhangban[4, i].Value.ToString();
            txtgiamgia.Text = dgvhangban[5, i].Value.ToString();
            txtthanhtien.Text = dgvhangban[6, i].Value.ToString();
        }

        private void txtsl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
            //if (System.Text.RegularExpressions.Regex.IsMatch(txtsl.Text.Trim(), @"[!@#$%^&*()_+=\[{\]};:<>|./?,-`~]"))
            //{
            //    MessageBox.Show("Không được nhập kí tự đặc biệt");
            //}
        }

        private void txtgiamgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

        private void txttongtien_TextChanged(object sender, EventArgs e)
        {
            if (txttongtien.Text == "" || txttongtien.Text == "0") return;
            decimal number;
            number = decimal.Parse(txttongtien.Text, System.Globalization.NumberStyles.Currency);
            txttongtien.Text = number.ToString("#,#");
            txttongtien.SelectionStart = txttongtien.Text.Length;
        }

        private void cbbmasp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbmasp.Text != "")
            {
                txtsl.Text = "";
                txtthanhtien.Text = "";
            }
            
            txtdg.Text = bus_dsbanh.LayDG(cbbmasp.SelectedValue.ToString());           
        }

        private void cbbin_DropDown(object sender, EventArgs e)
        {
            cbbin.DataSource = bus_hdb.Laydulieu();
            cbbin.DisplayMember = "MaHDB";
            cbbin.ValueMember = "MaHDB";
        }

        private void cbbtim_DropDown(object sender, EventArgs e)
        {
            cbbtim.DataSource = bus_hdb.Laydulieu();
            cbbtim.DisplayMember = "MaHDB";
            cbbtim.ValueMember = "MaHDB";
        }

        private void txtdg_TextChanged(object sender, EventArgs e)
        {
            if (txtdg.Text == "" || txtdg.Text == "0") return;
            decimal number;
            number = decimal.Parse(txtdg.Text, System.Globalization.NumberStyles.Currency);
            txtdg.Text = number.ToString("#,#");
            txtdg.SelectionStart = txtdg.Text.Length;
        }

        private void txtsl_TextChanged(object sender, EventArgs e)
        {
            double dg, tt;int sl=1; Control c = new Control();          
            string slcu = bus_dsbanh.LaySL(cbbmasp.SelectedValue.ToString());

            if (txtsl.Text != "")
            {
                sl=int.Parse(txtsl.Text);
                dg = Convert.ToDouble(txtdg.Text);
                tt = sl * dg; txtthanhtien.Text = tt.ToString();
            }

            if (txtsl.Text == "0")
                this.errorProvider1.SetError(txtsl, "Số lượng phải lớn hơn 0");
            else if(sl>int.Parse(slcu))
                this.errorProvider1.SetError(txtsl, "Số lượng trong kho không đủ");
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            if (cbbtim.Text=="")           
                MessageBox.Show("Tìm kiếm không thành công!");      
            else
            {
                btnluu.Enabled = true;
                btbhuyhang.Enabled = true;
                btnhuyhd.Enabled = true;
                btnin.Enabled = true;
                cbbin.Text=cbbtim.Text;

                txtmahdb.Text = cbbtim.SelectedValue.ToString();
                dgvhangban.DataSource = bus_cthdb.Timkiemmapn(cbbtim.SelectedValue.ToString().Trim());
                bus_hdb.updatett(txtmahdb.Text);
                txttongtien.Text = bus_hdb.laytt(txtmahdb.Text);

                cbbmanv.DataSource= bus_hdb.Laytennv(txtmahdb.Text);
                cbbmakhach.DataSource = bus_hdb.Laytenkh(txtmahdb.Text);

                
                MessageBox.Show("Tìm kiếm thành công!");
            }    
        
        }

        private void btnin_Click(object sender, EventArgs e)
        {
            string ma = cbbin.SelectedValue.ToString();

            DataTable dt = new DataTable();
            dt = bus_cthdb.Report(cbbin.Text);
            dgvhangban.DataSource = dt;
            CRHDB hd = new CRHDB();
            ((TextObject)hd.ReportDefinition.ReportObjects["txtmahdb"]).Text = ma;
            hd.SetDataSource(dt);
            hd.Refresh();
            ReportHDB rp = new ReportHDB();
            rp.crystalReportViewer1.ReportSource = hd;
            rp.Show();
        }

        private void txtthanhtien_TextChanged(object sender, EventArgs e)
        {
            if (txtthanhtien.Text == "" || txtthanhtien.Text == "0") return;
            decimal number;
            number = decimal.Parse(txtthanhtien.Text, System.Globalization.NumberStyles.Currency);
            txtthanhtien.Text = number.ToString("#,#");
            txtthanhtien.SelectionStart = txtthanhtien.Text.Length;
        }

        private void txtgiamgia_TextChanged(object sender, EventArgs e)
        {
            Control c = new Control();
            float gg = 1;
            if (txtgiamgia.Text != "")
                gg = float.Parse(txtgiamgia.Text);

            if (gg < 0 || gg > 100)
                this.errorProvider1.SetError(txtgiamgia, "Giảm giá không hợp lệ");
            else
            {
                this.errorProvider1.Clear();
            }
        }
    }
    
}
