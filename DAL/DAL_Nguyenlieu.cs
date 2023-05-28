using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_Nguyenlieu : DBConnect
    {
        DBConnect connect = new DBConnect();
        SqlCommand cm;
        SqlDataAdapter da;
        public DataTable Laydulieu()
        {
            return connect.Laydulieu("Select * from Nguyenlieu");
        }
        public int Kiemtrama(string ma)
        {
            return connect.Kiemtrama(ma, "Select count(*) from Nguyenlieu where Manguyenlieu='" + ma.Trim() + "'");
        }
       
        public bool SuaSLNL(Nguyenlieu nl,int sl)
        {
            string query = string.Format("Update Nguyenlieu set Soluong='" + sl + "' where Manguyenlieu='" + nl.Manguyenlieu.Trim() + "'");
            int i = connect.ExecuteNonQuery(query);
            if (i > 0)
                return true;
            else
                return false;

        }
        public bool ThemNL(Nguyenlieu nl)
        {
            string query = string.Format("Insert into Nguyenlieu values('{0}',N'{1}','{2}','{3}')", nl.Manguyenlieu, nl.Tennguyenlieu, nl.Soluong, nl.Dongia);
            int i = connect.ExecuteNonQuery(query);
            if (i > 0)
                return true;
            else
                return false;
        }
        public bool XoaNL(Nguyenlieu nl)
        {
            string query = string.Format("Delete from Nguyenlieu where Manguyenlieu='" + nl.Manguyenlieu.Trim() + "'");
            int i = connect.ExecuteNonQuery(query);
            if (i > 0)
                return true;
            else
                return false;
        }
        public bool SuaNL(Nguyenlieu nl)
        {
            string query = string.Format("Update Nguyenlieu set Tennguyenlieu=N'" + nl.Tennguyenlieu + "',Soluong='" + nl.Soluong + "' ,Dongia='" + nl.Dongia + "' where Manguyenlieu='" + nl.Manguyenlieu.Trim() + "'");
            int i = connect.ExecuteNonQuery(query);
            if (i > 0)
                return true;
            else
                return false;
        }  
        public DataTable TimKiemmanl(string ma)
        {
            string query = string.Format("Select * from Nguyenlieu where Manguyenlieu LIKE '%" + ma + "%'");
            return Laydulieu(query);

        }
        public DataTable TimKiemtennl(string ten)
        {
            string query = string.Format("Select * from Nguyenlieu where Tennguyenlieu LIKE N'%" + ten + "%'");
            return Laydulieu(query);

        }
        public string LayDG(string ma)
        {
            string donGia = "";
            SqlDataAdapter da = new SqlDataAdapter();
            string query = "select Dongia from Nguyenlieu where Manguyenlieu = '" + ma + "'";
            da.SelectCommand = new SqlCommand(query, connect.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Nguyenlieu");
            DataTable dt = ds.Tables["Nguyenlieu"];
            foreach (DataRow row in dt.Rows)
                donGia = row["Dongia"].ToString();
            return donGia;

        }
        public string LaySLNL(string ma)
        {
            string sl = "";
            string query = "Select Soluong from Nguyenlieu where Manguyenlieu='" + ma.Trim() + "' ";
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand(query, connect.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Nguyenlieu");
            DataTable dt = ds.Tables["Nguyenlieu"];
            foreach (DataRow row in dt.Rows)
                sl = row["Soluong"].ToString();
            return sl;

        }
    }
}
