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
    public class DAL_CTHoadonban :DBConnect
    {
       CTHoadonban ct=new CTHoadonban();
        DBConnect con = new DBConnect();

        public int Kiemtrama(string ma)
        {
            return con.Kiemtrama(ma, "Select count(*) from CTHoadonban where MaHDB='" + ma.Trim() + "'");
        }
        public DataTable Repot(string ma)
        {
            return con.Laydulieu(" Select * from CTHoadonban where MaHDB ='" + ma + "'");
        }
        public bool KiemtraBan(string gtri1, string gtri2)
        {
            return con.kiemTraBan(gtri1, gtri2);
        }
        public DataTable Laydulieu(string ma)
        {
            string query = "select * from CTHoadonban where MaHDB='" + ma + "' ";
            return con.Laydulieu(query);
        }
        public bool ThemCTBan(CTHoadonban ct)
        {
            con.KN();
            string query = string.Format("insert into CTHoadonban values('" + ct.MaHDB + "','" + ct.Mamon + "',N'" + ct.Tenmon + "','" + ct.Soluong + "','" + ct.Dongia + "','" + ct.Giamgia + "','" + ct.Thanhtien + "')");
            int i = con.ExecuteNonQuery(query);
            if (i > 0)
                return true;
            else
                return false;
            con.DKN();
        }

        public bool SuaCTBan(CTHoadonban ct)
        {
            con.KN();
            string query = string.Format("Update CTHoadonban set Tenmon=N'" + ct.Tenmon + "',Soluong='" + ct.Soluong + "',Dongia='" + ct.Dongia + "',Giamgia='"+ct.Giamgia+"',Thanhtien='" + ct.Thanhtien + "' where MaHDB=N'" + ct.MaHDB + "' and Mamon=N'" + ct.Mamon + "'");
            int i= con.ExecuteNonQuery(query);
            if (i > 0)
                return true;
            else
                return false;
            con.DKN();
        }
        public bool XoaCTBan(string ma)
        {
            string query = string.Format("Delete from CTHoadonban where MaHDB='" + ma + "'");
            int i = con.ExecuteNonQuery(query);
            if (i > 0)
                return true;
            else
                return false;
        }
        public bool XoaCthangban(string ma, string ma2)
        {
            string query = string.Format("Delete from CTHoadonban where MaHDB='" + ma + "' and Mamon='" + ma2 + "' ");
            int i = con.ExecuteNonQuery(query);
            if (i > 0)
                return true;
            else
                return false;
        }
        public DataTable TimKiemmapn(string ma)
        {
            string query = string.Format("Select * from CTHoadonban where MaHDB LIKE '%" + ma + "%'");
            return con.Laydulieu(query);

        }
        public DataTable Thongkespbanchay()
        {
            string query = string.Format("select top (5) Dsbanh.mamon,Dsbanh.tenmon,sum(CTHoadonban.soluong) [Số lượng bán] from Dsbanh, CTHoadonban where Dsbanh.mamon = CTHoadonban.mamon group by Dsbanh.mamon, Dsbanh.tenmon order by[Số lượng bán] desc");
            return con.Laydulieu(query);
        }
    }
}
