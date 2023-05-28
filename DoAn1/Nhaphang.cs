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
    public partial class Nhaphang : Form
    {
        DBConnect con = new DBConnect();
        CTNhapNguyenLieu ctnnl = new CTNhapNguyenLieu();
        NhapNguyenLieu nnl = new NhapNguyenLieu();  
        Nguyenlieu nl = new Nguyenlieu();

        BUS_NhaCungCap bus_ncc = new BUS_NhaCungCap();
        BUS_Nguyenlieu bus_nl = new BUS_Nguyenlieu();
        BUS_Nhapnguyenlieu bus_nnl = new BUS_Nhapnguyenlieu();
        BUS_Nhanvien bus_nv = new BUS_Nhanvien();
        BUS_CTNhapnguyenlieu bus_ctnnl = new BUS_CTNhapnguyenlieu();


        public Nhaphang()
        {
            InitializeComponent();
        }
        #region load
        public void Loadcbbnv()
        {
            cbbtennv.DataSource = bus_nv.Laydulieu();
            cbbtennv.DisplayMember = "Tennhanvien";
            cbbtennv.ValueMember = "Manhanvien";
        }
        public void Loadcbbncc()
        {
            cbbtenncc.DataSource = bus_ncc.Laydulieu();
            cbbtenncc.DisplayMember = "Tencc";
            cbbtenncc.ValueMember = "Mancc";
        }
        public void Loadcbbnl()
        {
            cbbmanl.DataSource = bus_nl.Laydulieu();
            cbbmanl.DisplayMember = "Tennguyenlieu";
            cbbmanl.ValueMember = "Manguyenlieu";
        }
        void loadHD()
        {
            string ma = txtmapn.Text;
            dgvhangnhap.DataSource = bus_ctnnl.Laydulieu(ma);
            dgvhangnhap.Columns[0].HeaderText = "Mã Phiếu Nhập";
            dgvhangnhap.Columns[1].HeaderText = "Mã Nguyên Liệu";
            dgvhangnhap.Columns[2].HeaderText = "Tên Nguyên Liệu";
            dgvhangnhap.Columns[3].HeaderText = "Số lượng";
            dgvhangnhap.Columns[4].HeaderText = "Đơn giá";
            dgvhangnhap.Columns[5].HeaderText = "Thành tiền";

            dgvhangnhap.Columns[4].DefaultCellStyle.Format = "#,#";
            dgvhangnhap.Columns[5].DefaultCellStyle.Format = "#,#";
        }
        #endregion
    
        private void btnthemhd_Click(object sender, System.EventArgs e)
        {
            txtmapn.Enabled = true;
            txtmapn.Text = "";
            txtsl.Text = "";
            txtdg.Text = "";
            txtthanhtien.Text = "";
            txttongtien.Text = "";
            btnluu.Enabled = true;  
            btbhuyhang.Enabled = true;
            btnhuyhd.Enabled = true;
            btnin.Enabled = true;
            loadHD();
        }

        private void QLHangNhap_Load(object sender, System.EventArgs e)
        {
            btnluu.Enabled = false;
            btbhuyhang.Enabled = false;
            btnhuyhd.Enabled = false;
            btnin.Enabled = false;
            loadHD();
            Loadcbbnv();
            Loadcbbncc();
            Loadcbbnl();

        }
        private CTNhapNguyenLieu GetCT()
        {
            ctnnl.Maphieunhap1 = txtmapn.Text;
            ctnnl.Manguyenlieu1 = cbbmanl.SelectedValue.ToString() ;
            ctnnl.Tennguyenlieu1 = cbbmanl.Text;
            ctnnl.Soluong1 = int.Parse(txtsl.Text);
            ctnnl.Dongia1 = float.Parse(txtdg.Text);
            ctnnl.Thanhtien1 = float.Parse(txtthanhtien.Text);
            return ctnnl;
        }
        private NhapNguyenLieu getNNL()
        {
            nnl.Maphieunhap = txtmapn.Text;
            nnl.Mancc = cbbtenncc.SelectedValue.ToString();
            nnl.Manhanvien = cbbtennv.SelectedValue.ToString();
            nnl.Ngaynhap = dtngay.Value;
            return nnl;
        }
        private Nguyenlieu getNL()
        {
            nl.Manguyenlieu = cbbmanl.SelectedValue.ToString();
            nl.Tennguyenlieu = cbbmanl.Text;
            nl.Soluong = int.Parse(txtsl.Text);
            nl.Dongia = float.Parse(txtdg.Text);
            return nl;
        }
        private void label7_Click(object sender, System.EventArgs e)
        {

        }

        private void btntim_Click(object sender, System.EventArgs e)
        {
            if (bus_nnl.Kiemtrama(cbbtim.SelectedValue.ToString()) == 1)
            {
                btnluu.Enabled = true;
                btbhuyhang.Enabled = true;
                btnhuyhd.Enabled = true;
                btnin.Enabled = true;
                cbbin.Text = cbbtim.Text;

                txtmapn.Text = cbbtim.SelectedValue.ToString();
                dgvhangnhap.DataSource = bus_ctnnl.Timkiemmapn(cbbtim.SelectedValue.ToString().Trim());
                bus_nnl.updatett(txtmapn.Text);
                txttongtien.Text = bus_nnl.laytt(txtmapn.Text);

                cbbtennv.DataSource = bus_nnl.Laytennv(txtmapn.Text);
                cbbtenncc.DataSource = bus_nnl.Laytenncc(txtmapn.Text);
                MessageBox.Show("Tìm kiếm thành công!");
            }
            else
                MessageBox.Show("Mã hóa đơn không tồn tại!");
        }

        private void btnhuyhd_Click(object sender, System.EventArgs e)
        {
            NhapNguyenLieu nnl = getNNL();

            if (bus_ctnnl.XoaCTNhap(txtmapn.Text) == true && bus_nnl.XoaHDN(nnl) == true)
            {

                DialogResult r = MessageBox.Show("Bạn có muốn xóa hoá đơn không?", " Tông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    MessageBox.Show("Xóa thành công!");
                    loadHD();
                    bus_nl.Lammoi(gbttc);
                    bus_nl.Lammoi(gbttsp);
                    bus_nl.Lammoi(grbcn);
                }
            }
        }

        private void btnluu_Click(object sender, System.EventArgs e)
        {
            Nguyenlieu nl = getNL();
            NhapNguyenLieu nnl = getNNL();
            CTNhapNguyenLieu ctn = GetCT();
            if (bus_nnl.Kiemtrama(txtmapn.Text) == 1)
            {
                if (bus_ctnnl.kiemTraNhap(txtmapn.Text, cbbmanl.SelectedValue.ToString()))
                {
                    DialogResult r = MessageBox.Show("Nguyên liệu đã có trong hóa đơn bạn có muốn sửa lại!", "Thông báo", MessageBoxButtons.OKCancel);
                    if (r == DialogResult.OK)
                    {
                        bus_ctnnl.SuaCTNhap(ctn);
                        MessageBox.Show("Sửa thành công <3");
                    }
                }
                else
                {
                    bus_ctnnl.ThemCTNhap(ctn);
                    MessageBox.Show("Thêm thành công <3");
                }
            }         
            else
            {                
                if ( txtmapn.Text == "" || txtsl.Text.Trim().Length == 0)
                {
                     MessageBox.Show("Số lượng phải lớn 0, mã hóa đơn không được để rỗng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cbbin.Text=txtmapn.Text;
                    bus_nnl.ThemHDN(nnl);
                    bus_ctnnl.ThemCTNhap(ctn);
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);                 
                }
            }
            bus_nnl.updatett(txtmapn.Text);
            txttongtien.Text = bus_nnl.laytt(txtmapn.Text);
            loadHD();

            string sl = bus_nl.LaySLNL(cbbmanl.SelectedValue.ToString());//update so luong hang
            int slcon = Convert.ToInt32(sl) + (Convert.ToInt32(txtsl.Text));
            bus_nl.SuaSLNL(nl, slcon);

        }


        private void txtsl_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi số lượng thì thực hiện tính lại thành tiền
            double dg, tt; Control c = new Control();
            int sl=0;
            if (txtsl.Text != "")
            {
                 sl = Convert.ToInt32(txtsl.Text);
                 if (sl <= 0)
                 {
                    MessageBox.Show("Số lượng phải lớn hơn 0");
                    txtsl.Clear();
                 }
            }                   
            if (txtdg.Text != "")
            {
                dg = Convert.ToDouble(txtdg.Text);
                tt = sl * dg; txtthanhtien.Text = tt.ToString();
            }

            if (c.Text.Trim().Length > 0 && !char.IsDigit(c.Text, c.Text.Length - 1))
            {
                this.errorProvider1.SetError(txtsl, "Không được nhập chữ!!!");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txtsl_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cbbtennl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbmanl.Text != "")
            {
                txtsl.Text = "";
                txtthanhtien.Text = "";
            }
            txtdg.Text = bus_nl.LayDG(cbbmanl.SelectedValue.ToString());
           
        }

        private void txtdg_TextChanged(object sender, EventArgs e)
        {
            if (txtdg.Text == "" || txtdg.Text == "0") return;
            decimal number;
            number = decimal.Parse(txtdg.Text, System.Globalization.NumberStyles.Currency);
            txtdg.Text = number.ToString("#,#");
            txtdg.SelectionStart = txtdg.Text.Length;
        }

        private void btbhuyhang_Click(object sender, EventArgs e)
        {
            Nguyenlieu nl = getNL();
            CTNhapNguyenLieu ct = GetCT();
            NhapNguyenLieu nnl = getNNL();
            string sl = bus_nl.LaySLNL(cbbmanl.SelectedValue.ToString());//update so luong hang
            int slcon = Convert.ToInt32(sl) - (Convert.ToInt32(txtsl.Text));
            if (MessageBox.Show("Bạn chắc muốn xóa nguyên liệu: " + cbbmanl.Text + " ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (bus_ctnnl.XoaHang(txtmapn.Text, cbbmanl.SelectedValue.ToString()))
                {
                    if (bus_ctnnl.kiemtrama(txtmapn.Text) == 0)
                    {
                        bus_nnl.XoaHDN(nnl);
                    }
                    MessageBox.Show("Xóa thành công");
                }
                   
            }
            else
                MessageBox.Show("không thể xóa");
            
            
            txttongtien.Text = bus_nnl.laytt(txtmapn.Text);
            bus_nnl.updatett(txtmapn.Text);
            txttongtien.Text = bus_nnl.laytt(txtmapn.Text);

            string slcu = bus_nl.LaySLNL(cbbmanl.SelectedValue.ToString());//update so luong hang
            int slmoi = Convert.ToInt32(slcu) + (Convert.ToInt32(txtsl.Text));
            bus_nl.SuaSLNL(nl, slmoi);
            loadHD();
        }

        private void btnin_Click(object sender, EventArgs e)
        {        
            string ma = cbbin.SelectedValue.ToString();

            DataTable dt = new DataTable();
            dt= bus_ctnnl.report(cbbin.Text);
            dgvhangnhap.DataSource = dt;
            CRHDN hd = new CRHDN();
            ((TextObject)hd.ReportDefinition.ReportObjects["txtmapn"]).Text = ma;
            hd.SetDataSource(dt);
            hd.Refresh();
            ReportHDN rp = new ReportHDN();
            rp.crystalReportViewer1.ReportSource = hd;
            rp.ShowDialog();
            
        }

        private void cbbtim_DropDown(object sender, EventArgs e)
        {
            cbbtim.DataSource = bus_nnl.Laydulieu();
            cbbtim.DisplayMember = "Maphieunhap";
            cbbtim.ValueMember = "Maphieunhap";
        }

        private void cbbin_DropDown(object sender, EventArgs e)
        {
            cbbin.DataSource = bus_nnl.Laydulieu();
            cbbin.DisplayMember = "Maphieunhap";
            cbbin.ValueMember = "Maphieunhap";
        }

        private void dgvhangnhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtmapn.Text = dgvhangnhap[0, i].Value.ToString();
            cbbmanl.SelectedValue = dgvhangnhap[1, i].Value.ToString();
            cbbmanl.Text = dgvhangnhap[2, i].Value.ToString();
            txtsl.Text = dgvhangnhap[3, i].Value.ToString();
            txtdg.Text = dgvhangnhap[4, i].Value.ToString();
            txtthanhtien.Text = dgvhangnhap[5, i].Value.ToString();
        }

        private void txtthanhtien_TextChanged(object sender, EventArgs e)
        {
            if (txtthanhtien.Text == "" || txtthanhtien.Text == "0") return;
            decimal number;
            number = decimal.Parse(txtthanhtien.Text, System.Globalization.NumberStyles.Currency);
            txtthanhtien.Text = number.ToString("#,#");
        }
    }
}
