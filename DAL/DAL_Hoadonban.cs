using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Hoadonban:DBConnect
    {
        DBConnect con = new DBConnect();
        Hoadonban hdb = new Hoadonban();

        public DataTable Laydulieu()
        {
            return con.Laydulieu("Select * from Hoadonban");
        }
        public DataTable laytennv(string ma)
        {
            return con.Laydulieu("select tennhanvien from Nhanvien nv inner join hoadonban hdb on nv.Manhanvien=hdb.Manhanvien where hdb.MaHDB ='"+ ma+"'");
        }
        public DataTable laytenkh(string ma)
        {
            return con.Laydulieu("select Tenkhach from Khachhang kh inner join hoadonban hdb on kh.Makhach=hdb.Makhach where hdb.MaHDB ='" + ma + "'");
        }
        public int Kiemtrama(string ma)
        {
            return con.Kiemtrama(ma, "Select count(*) from Hoadonban where MaHDB='" + ma.Trim() + "'");
        }
        public bool ThemHDB(Hoadonban hdb)
        {
            string query = string.Format("Insert into Hoadonban values('{0}','{1}','{2}','{3}','{4}')", hdb.MaHDB, hdb.Makhach, hdb.Manhanvien, hdb.Ngay, hdb.Tongtien);
            int i = con.ExecuteNonQuery(query);
            if (i > 0)
                return true;
            else
                return false;
        }
        public bool SuaHDB(Hoadonban hdb)
        {
            string query = string.Format("Update Hoadonban set Makhach=N'" + hdb.Makhach + "',Manhavnien=N'" + hdb.Manhanvien + "',Ngay='" + hdb.Ngay + "',Tongtien='" + hdb.Tongtien + "' where MaHDB=N'" + hdb.MaHDB + "'");
            int i = con.ExecuteNonQuery(query);
            if (i > 0)
                return true;
            else
                return false;
        }
        public bool XoaHDB(Hoadonban hdb)
        {

            string query = string.Format("Delete from Hoadonban where MaHDB='" + hdb.MaHDB.Trim() + "'");
            int i = con.ExecuteNonQuery(query);
            if (i > 0)
                return true;
            else
                return false;
        }
        public bool SuaTT(Hoadonban hdn, double tongtien)
        {
            string query = string.Format("Update Hoadonban set Tongtien='" + tongtien + "' where MaHDB='" + hdb.MaHDB.Trim() + "'");
            //con.Laydulieu(query);
            int i = con.ExecuteNonQuery(query);
            if (i > 0)
                return true;
            else
                return false;
        }
        public DataTable TimKiemmapn(string ma)
        {
            string query = string.Format("Select * from Hoadonban where MaHDB LIKE '%" + ma + "%'");
            return con.Laydulieu(query);

        }
        public bool updattt(string ma)
        {
            string query = string.Format("update Hoadonban set Tongtien=(SELECT sum(Thanhtien*((100-Giamgia)/100)) FROM CTHoadonban  where MaHDB='" + ma + "')  where MaHDB='" + ma + "'");
            int i = con.ExecuteNonQuery(query);
            if (i > 0)
                return true;
            else
                return false; 
        }
        public string LayTT(string ma)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            string tennl = "";
            string query = "Select Tongtien from Hoadonban where MaHDB='" + ma + "'";
            da.SelectCommand = new SqlCommand(query, con.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Hoadonban");
            DataTable dt = ds.Tables["Hoadonban"];
            foreach (DataRow row in dt.Rows)
                tennl = row["Tongtien"].ToString();
            return tennl;

        }
        public DataTable Thongketheongay(Hoadonban hd1,Hoadonban hd2)
        {          
            string query=String.Format("Select * from Hoadonban where Ngay between '{0}'and'{1}'",hd1.Ngay,hd2.Ngay);
            return con.Laydulieu(query);
        }
        public object tt(Hoadonban hd1, Hoadonban hd2)
        {
            string query = string.Format("Select sum(tongtien) from Hoadonban where Ngay between '{0}'and'{1}'", hd1.Ngay, hd2.Ngay);
            return con.ExecuteScalar(query);
        }
    }
}
