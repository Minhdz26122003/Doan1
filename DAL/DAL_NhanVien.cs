using System;
using DAL;
using DTO;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_NhanVien : DBConnect
    {
        DBConnect con = new DBConnect();
        public DataTable Laydulieu()
        {
            return con.Laydulieu("Select * from Nhanvien");
        }
        public int Kiemtrama(string ma)
        {
            return con.Kiemtrama(ma, "Select count(*) from Nhanvien where Manhanvien='" + ma.Trim() + "'");
        }
        public bool ThemNv(NhanVien nv)
        {
            string query = string.Format("Insert INTO Nhanvien values ('{0}',N'{1}',N'{2}',N'{3}','{4}')", nv.Manhanvien1, nv.Tennhanvien1, nv.Gioitinh1, nv.Diachi1, nv.SDT1);
            int i = con.ExecuteNonQuery(query);
            if (i > 0)
                return true;
            else
                return false;
        }
        public bool Suanv(NhanVien nv)
        {
            string query = string.Format("Update Nhanvien set Tennhanvien =N'" + nv.Tennhanvien1 + "' ,Gioitinh=N'" + nv.Gioitinh1 + "', Diachi=N'" + nv.Diachi1 + "' , SDT='" + nv.SDT1 + "' where Manhanvien='" + nv.Manhanvien1 + "'");
            int i = con.ExecuteNonQuery(query);
            if (i > 0)
                return true;
            else
                return false;
        }
        public bool Xoanv(NhanVien nv)
        {
            string query = string.Format("Delete Nhanvien where Manhanvien='" + nv.Manhanvien1.Trim() + "'");
            int i = con.ExecuteNonQuery(query);
            if (i > 0)
                return true;
            else
                return false;
        }
        public DataTable TimKiemmanv(string ma)
        {
            string query = string.Format("Select * from Nhanvien where Manhanvien LIKE '%" + ma + "%'");
            return Laydulieu(query);

        }
        public DataTable TimKiemtennv(string ten)
        {
            string query = string.Format("Select * from Nhanvien where Tennhanvien LIKE N'%" + ten + "%'");
            return Laydulieu(query);

        }
       
    }
}
