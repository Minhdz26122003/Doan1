using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_Dsbanh :DBConnect
    {
        //chứa mọi xử lý liên quan đến CSDL
        //xử lý lấy dữ liệu để đưa ra dgv
        //khởi tạo đối tượng thuộc lớp DBConnect

        DBConnect connect=new DBConnect();
        public DataTable Laydulieu()
        {
            return connect.Laydulieu("Select * from DSbanh");

        }
        public int Kiemtrama( string ma)
        {
            return connect.Kiemtrama(ma, "Select count(*) from DSbanh where Mamon='" + ma.Trim() + "'");
        }
        public bool ThemSP( Dsbanh du)
        {
            string query = string.Format("Insert into DSbanh values('{0}',N'{1}','{2}','{3}','{4}')", du.Mamon,du.Tenmon,du.Manhom,du.Soluong,du.Dongia);
            int i = connect.ExecuteNonQuery(query);
            if (i > 0)
                return true;
            else
                return false;
        }
        public bool XoaSP(Dsbanh du)
        {
            string query = string.Format("Delete from DSbanh where Mamon='" + du.Mamon.Trim() + "'");
            int i = connect.ExecuteNonQuery(query);
            if (i > 0)
                return true;
            else
                return false;
        }
        public bool SuaSP(Dsbanh du)
        {
            string query = string.Format("Update DSbanh set Tenmon=N'" + du.Tenmon + "',Manhom='" + du.Manhom.Trim() + "',Soluong='" + du.Soluong + "' ,Dongia='" + du.Dongia + "' where Mamon='" + du.Mamon.Trim() + "'");
            int i = connect.ExecuteNonQuery(query);
            if (i > 0)
                return true;
            else
                return false;
        }
        public bool SuaSLSP(Dsbanh du, int sl)
        {
            string query = string.Format("Update DSbanh set Soluong='" + sl + "' where Mamon='" + du.Mamon.Trim() + "'");
            int i = connect.ExecuteNonQuery(query);
            if (i > 0)
                return true;
            else
                return false;

        }
        public DataTable TimKiemmadu(string ma)
        {
            string query = string.Format("Select * from Dsbanh where Mamon LIKE '%" + ma + "%'");
            return Laydulieu(query);

        }
        public DataTable TimKiemtendu(string ten)
        {
            string query = string.Format("Select * from Dsbanh where Tenmon LIKE N'%" + ten + "%'");
            return Laydulieu(query);

        }
        public DataTable TimKiemgiadu(string gia1)
        {
            string query = string.Format("Select * from DSbanh where Dongia LIKE N'%" + gia1 + "%'");
            return Laydulieu(query);

        }
        public string LayDG(string ma)
        {
            string donGia = "";
            SqlDataAdapter da = new SqlDataAdapter();
            string query = "select Dongia from Dsbanh where Mamon = '" + ma + "'";
            da.SelectCommand = new SqlCommand(query,connect.con);
            DataSet ds = new DataSet();
            da.Fill(ds,"Dsbanh");
            DataTable dt = ds.Tables["Dsbanh"];
            foreach (DataRow row in dt.Rows)
                donGia = row["Dongia"].ToString();
            return donGia;

        }
        public string LayTenB(string ma)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            string tennl = "";
            string query = "Select Tenmon from Dsbanh where Mamon='" + ma + "'";
            da.SelectCommand = new SqlCommand(query,connect.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Dsbanh");
            DataTable dt = ds.Tables["Dsbanh"];
            foreach (DataRow row in dt.Rows)
                tennl = row["Tenmon"].ToString();
            return tennl;

        }
        public string LaySLNL(string ma)
        {
            string sl = "";
            string query = "Select Soluong from Dsbanh where Mamon='" + ma.Trim() + "' ";
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand(query, connect.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Dsbanh");
            DataTable dt = ds.Tables["Dsbanh"];
            foreach (DataRow row in dt.Rows)
                sl = row["Soluong"].ToString();
            return sl;

        }
    }
}
