using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class DAL_NhaCungCap: DBConnect
    {
        DBConnect connect = new DBConnect();
        public DataTable Laydulieu()
        {
            return connect.Laydulieu("Select * from Nhacungcap");

        }
        public int Kiemtrama(string ma)
        {
            return connect.Kiemtrama(ma, "Select count(*) from Nhacungcap where Mancc='" + ma.Trim() + "'");
        }
        public bool ThemNCC(NhaCungCap ncc)
        {
            string query = string.Format("Insert into Nhacungcap values('{0}',N'{1}',N'{2}','{3}')", ncc.Mancc1, ncc.Tenncc1, ncc.Diachi1, ncc.SDT1);
            int i = connect.ExecuteNonQuery(query);
            if (i > 0)
                return true;
            else
                return false;
        }
        public bool XoaNCC(NhaCungCap ncc)
        {
            string query = string.Format("Delete from Nhacungcap where Mancc='" + ncc.Mancc1.Trim() + "'");
            int i = connect.ExecuteNonQuery(query);
            if (i > 0)
                return true;
            else
                return false;
        }
        public bool SuaNCC(NhaCungCap ncc)
        {
            string query = string.Format("Update Nhacungcap set Tencc=N'" + ncc.Tenncc1 + "',Diachi=N'" + ncc.Diachi1 + "',SDT='" + ncc.SDT1 + "' where Mancc='" + ncc.Mancc1.Trim() + "'");
            int i = connect.ExecuteNonQuery(query);
            if (i > 0)
                return true;
            else
                return false;
        }
        public DataTable TimKiemmancc(string ma)
        {
            string query = string.Format("Select * from Nhacungcap where Mancc LIKE '%" + ma + "%'");
            return Laydulieu(query);

        }
        public DataTable TimKiemtenncc(string ten)
        {
            string query = string.Format("Select * from Nhacungcap where Tencc LIKE N'%" + ten + "%'");
            return Laydulieu(query);

        }
    }
}
