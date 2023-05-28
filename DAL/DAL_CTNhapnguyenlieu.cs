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
    public class DAL_CTNhapnguyenlieu :DBConnect
    {
        CTNhapNguyenLieu ctnnl = new CTNhapNguyenLieu();
        DBConnect con = new DBConnect();

        public int Kiemtrama(string ma)
        {
            return con.Kiemtrama(ma, "Select count(*) from CTNhapNL where Maphieunhap='" + ma.Trim() + "'");
        }
        public DataTable Repot(string ma)
        {
            return con.Laydulieu(" Select * from CTNhapNL where Maphieunhap ='" + ma + "'");
        }
        public bool KiemtraNhap(string gtri1,string gtri2)
        {
            return con.kiemTraNhap(gtri1 , gtri2);
        }
        public DataTable Laydulieu( string ma)
        {
            string query = "select * from CTNhapNL where Maphieunhap='" + ma + "' ";
            return con.Laydulieu(query);
        }
        public bool ThemCTNhap(CTNhapNguyenLieu ct)
        {
            con.KN();
            string query = string.Format("insert into CTNhapNL values('" + ct.Maphieunhap1 + "','" + ct.Manguyenlieu1 + "',N'" + ct.Tennguyenlieu1 + "','" + ct.Soluong1 + "','" + ct.Dongia1 + "','" + ct.Thanhtien1 + "')");
            int i = con.ExecuteNonQuery(query);
            if (i > 0)
                return true;
            else
                return false;
            con.DKN();
        }

        public bool SuaCTNhap(CTNhapNguyenLieu ct)
        {
            con.KN();
            string query = string.Format("Update CTNhapNL set Tennguyenlieu=N'" +ct.Tennguyenlieu1 + "',Soluong='" +ct.Soluong1 + "',Dongia='" + ct.Dongia1 + "',Thanhtien='" +ct.Thanhtien1 + "' where Maphieunhap=N'" + ct.Maphieunhap1 + "' and Manguyenlieu=N'" + ct.Manguyenlieu1 + "'");
            int i = con.ExecuteNonQuery(query);
            if (i > 0)
                return true;
            else
                return false;
            con.DKN();
        }
        public bool XoaCTNhap(string ma)
        {
            string query = string.Format("Delete from CTNhapNL where Maphieunhap='" + ma + "'");
            int i = con.ExecuteNonQuery(query);
            if (i > 0)
                return true;
            else
                return false;
        }
        public bool XoaHang(string ma,string ma2)
        {
            string query = string.Format("Delete from CTNhapNL where Maphieunhap='"+ma+"' and Manguyenlieu='"+ma2+"' ");
            int i = con.ExecuteNonQuery(query);
            if (i > 0)
                return true;
            else
                return false;
        }
        public string LayTenNL(string ma)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            string tennl = "";
            string query = "Select Tennguyenlieu from Nguyenlieu where Manguyenlieu='" + ma + "'";
            da.SelectCommand = new SqlCommand(query, con.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Nguyenlieu");
            DataTable dt = ds.Tables["Nguyenlieu"];
            foreach (DataRow row in dt.Rows)
                tennl = row["Tennguyenlieu"].ToString();
            return tennl;

        }
        public DataTable TimKiemmapn(string ma)
        {
            string query = string.Format("Select * from CTNhapNL where Maphieunhap LIKE '%"+ ma +"%'");
            return con.Laydulieu(query);

        }
      
    }
}
