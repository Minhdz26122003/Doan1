using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DTO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_Nhapnguyenlieu :DBConnect
    {
        DBConnect con =new DBConnect();
        NhapNguyenLieu nnl=new NhapNguyenLieu();

        public DataTable Laydulieu()
        {
            return con.Laydulieu("Select * from Nhapnguyenlieu");
        }
        public DataTable laytennv(string ma)
        {
            return con.Laydulieu("select tennhanvien from Nhanvien nv inner join Nhapnguyenlieu hdn on nv.Manhanvien=hdn.Manhanvien where hdn.Maphieunhap ='" + ma + "'");
        }
        public DataTable laytenNcc(string ma)
        {
            return con.Laydulieu("select Tencc from Nhacungcap ncc inner join Nhapnguyenlieu hdn on ncc.mancc=hdn.mancc where hdn.Maphieunhap ='" + ma + "'");
        }
        public int Kiemtrama(string ma)
        {
            return con.Kiemtrama(ma, "Select count(*) from Nhapnguyenlieu where Maphieunhap='" + ma.Trim() + "'");
        }
        public bool ThemHDN(NhapNguyenLieu nnl)
        {
            string query = string.Format("insert into Nhapnguyenlieu values('" + nnl.Maphieunhap + "','" + nnl.mancc + "','" + nnl.Manhanvien + "','" + nnl.Ngaynhap + "','" + nnl.tongtien + "')");
            int i = con.ExecuteNonQuery(query);
            if (i > 0)
                return true;
            else
                return false;
        }
        public bool SuaHDN(NhapNguyenLieu nnl)
        {
            //con.thucthi("Update CTNhapNL set Mancc=N'"+nnl.Mancc + "',Manhanvien='" + nnl.Manhanvien + "',Ngaynhap='" +nnl.Ngaynhap+ "',Tongtien='" + nnl.tongtien+ "' where Maphieunhap=N'" +nnl.Maphieunhap+ "'");
            //return true;
            string query = string.Format("Update CTNhapNL set Mancc=N'" + nnl.Mancc + "',Manhanvien='" + nnl.Manhanvien + "',Ngaynhap='" + nnl.Ngaynhap + "',Tongtien='" + nnl.tongtien + "' where Maphieunhap=N'" + nnl.Maphieunhap + "'");
            int i = con.ExecuteNonQuery(query);
            if (i > 0)
                return true;
            else
                return false;
        }
        public bool XoaHDN(NhapNguyenLieu nnl)
        {
            //con.thucthi("Delete Nhapnguyenlieu where Maphieunhap='" + nnl.Maphieunhap.Trim() + "'");
            //return true;
            string query = string.Format("Delete Nhapnguyenlieu where Maphieunhap='" + nnl.Maphieunhap.Trim() + "'");
            int i = con.ExecuteNonQuery(query);
            if (i > 0)
                return true;
            else
                return false;
        }     
        public bool SuaTT(NhapNguyenLieu nnl ,double tongtien)
        {
            string query = string.Format("Update Nhapnguyenlieu set Soluong='"+tongtien+"' where Maphieunhap='" + nnl.Maphieunhap + "'");
            //con.Laydulieu(query);
            int i = con.ExecuteNonQuery(query);
            if (i > 0)
                return true;
            else
                return false;
        }
        public DataTable TimKiemmapn(string ma)
        {
            string query = string.Format("Select * from Nhapnguyenlieu where Maphieunhap LIKE '%" + ma + "%'");
            return con.Laydulieu(query);

        }
        public bool updattt(string ma)
        {
            string query = string.Format("update Nhapnguyenlieu set Tongtien=(SELECT sum(Thanhtien) FROM CTNhapNL where Maphieunhap='" + ma + "') where Maphieunhap='" + ma + "'");
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
            string query = "Select Tongtien from Nhapnguyenlieu where Maphieunhap='" + ma + "'";
            da.SelectCommand = new SqlCommand(query, con.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Nhapnguyenlieu");
            DataTable dt = ds.Tables["Nhapnguyenlieu"];
            foreach (DataRow row in dt.Rows)
                tennl = row["Tongtien"].ToString();
            return tennl;

        }
    }
}