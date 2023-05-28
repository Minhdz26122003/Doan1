using System;
using DAL;
using DTO;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_Khachhang :DBConnect
    {
        DBConnect con = new DBConnect();
        public DataTable Laydulieu()
        {
            return con.Laydulieu("Select * from Khachhang");
        }
        public int Kiemtrama(string ma)
        {
            return con.Kiemtrama(ma, "Select count(*) from Khachhang where Makhach='" + ma.Trim() + "'");
        }
        public bool ThemKh(Khachhang kh)
        { 
            string query = string.Format("Insert INTO Khachhang values ('{0}',N'{1}',N'{2}','{3}')",kh.Makhachhang1,kh.Tenkhachhang1,kh.Diachi,kh.SDT );
            int i = con.ExecuteNonQuery(query);
            if (i > 0)
                return true;
            else
                return false;
        }
        public bool SuaKh(Khachhang kh)
        {
            string query = string.Format("Update Khachhang set Tenkhach =N'" +kh.Tenkhachhang1 + "', Diachi=N'" + kh.Diachi + "' , SDT='" + kh.SDT + "' where Makhach='" + kh.Makhachhang1 + "'");
            int i = con.ExecuteNonQuery(query);
            if (i > 0)
                return true;
            else
                return false;
        }
        public bool XoaKh(Khachhang kh)
        {
            string query = string.Format("Delete Khachhang where Makhach='"+kh.Makhachhang1+ "'");
            int i = con.ExecuteNonQuery(query);
            if (i > 0)
                return true;
            else
                return false;
        }
        public DataTable TimKiemmanKh(string ma)
        {
            string query = string.Format("Select * from Khachhang where Makhach LIKE '%" + ma + "%'");
            return con.Laydulieu(query);

        }
        public DataTable TimKiemtenKh(string ten)
        {
            string query = string.Format("Select * from Khachhang where Tenkhach LIKE N'%" + ten + "%'");
            return con.Laydulieu(query);

        }
    }
}
