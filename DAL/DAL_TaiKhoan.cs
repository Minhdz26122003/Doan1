using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using DTO;
using System.Data;


namespace DAL
{   
    public class DAL_TaiKhoan :DBConnect
    {      
        DBConnect connect=new DBConnect();
        TaiKhoan tk = new TaiKhoan();
        public string Checklogin(TaiKhoan tk)
        {
            string info=Checklogintk(tk);
            return info;
        }
        public bool KiemTra(string tendangnhap, string matKhau)
        {
            int r = connect.ktradn("select * from Taikhoan where Taikhoan='" + tendangnhap + "'and Matkhau='" + matKhau + "'");
            if (r > 0)
                return true;
            else
                return false;
        }
        public bool Lammoi(GroupBox grb)
        {
            return connect.Lammoi(grb);
        }
        public DataTable Laydulieu()
        {
            return connect.Laydulieu("Select * from Taikhoan");
        }
        public int Kiemtrama(string ma)
        {
            return connect.Kiemtrama(ma, "SELECT count(*) FROM Taikhoan WHERE taikhoan='" + ma.Trim()+ "' ");
        }
        public int Kttknv(string manv)
        {
            return connect.Kiemtrama(manv, "SELECT COUNT(*) FROM Taikhoan where Manhanvien = '" + manv.Trim() + "'");
        }
        public bool ThemTK(TaiKhoan tk)
        {
            string query = string.Format("Insert into Taikhoan values('{0}','{1}','{2}','{3}')", tk.Taikhoan,tk.Matkhau,tk.Maquyen,tk.Manhanvien);
            int i = connect.ExecuteNonQuery(query);
            if (i > 0)
                return true;
            else
                return false;
        }
        public bool XoaTK(TaiKhoan tk)
        {
            string query = string.Format("Delete from Taikhoan where Taikhoan='" + tk.Taikhoan.Trim() + "'");
            int i = connect.ExecuteNonQuery(query);
            if (i > 0)
                return true;
            else
                return false;
        }
        public bool SuaTK(TaiKhoan tk)
        {
            string query = string.Format("Update Taikhoan set Matkhau=N'" + tk.Matkhau + "',Maquyen='" + tk.Maquyen + "',Manhanvien='" + tk.Manhanvien + "'   where Taikhoan='" + tk.Taikhoan.Trim() + "'");
            int i = connect.ExecuteNonQuery(query);
            if (i > 0)
                return true;
            else
                return false;
        }
        public bool Doimk(TaiKhoan tk ,string mk)
        {
            string query = string.Format("Update Taikhoan set Matkhau=N'" +mk+"' where Taikhoan='" + tk.Taikhoan.Trim() + "'");
            int i = connect.ExecuteNonQuery(query);
            if (i > 0)
                return true;
            else
                return false;
        }
        public DataTable TimKiemtk(string ma)
        {
            string query = string.Format("Select * from Taikhoan where Taikhoan LIKE '%" + ma + "%'");
            return Laydulieu(query);

        }

    }
}
