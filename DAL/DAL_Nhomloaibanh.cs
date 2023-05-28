using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using DTO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_Nhomloaibanh :DBConnect
    {
        DBConnect connect = new DBConnect();
        SqlCommand cm;
        SqlDataAdapter da;
        public DataTable Laydulieu()
        {
            return connect.Laydulieu("Select * from Nhomloaibanh");
        }
        public int Kiemtrama(string ma)
        {
            return connect.Kiemtrama(ma, "Select count(*) from Nhomloaibanh where Manhom='" + ma.Trim() + "'");
        }
        
        public bool ThemNb(Nhomloaibanh nb)
        {
            string query = string.Format("Insert into Nhomloaibanh values('{0}',N'{1}','{2}','{3}')", nb.Manhom1,nb.Tennhom1);
            int i = connect.ExecuteNonQuery(query);
            if (i > 0)
                return true;
            else
                return false;
        }
        public bool XoaNb(Nhomloaibanh nb)
        {
            string query = string.Format("Delete from Nhomloaibanh where Manhom='" +nb.Manhom1.Trim() + "'");
            int i = connect.ExecuteNonQuery(query);
            if (i > 0)
                return true;
            else
                return false;
        }
        public bool SuaNb(Nhomloaibanh nb)
        {
            string query = string.Format("Update Nhomloaibanh set Tennhom=N'" + nb.Tennhom1 + "' where Manhom='" + nb.Manhom1.Trim() + "'");
            int i = connect.ExecuteNonQuery(query);
            if (i > 0)
                return true;
            else
                return false;
        }
        public DataTable TimKiemmanb(string ma)
        {
            string query = string.Format("Select * from Nhomloaibanh where Manhom LIKE '%" + ma + "%'");
            return Laydulieu(query);

        }
        public DataTable TimKiemtennb(string ten)
        {
            string query = string.Format("Select * from Nhomloaibanh where Tennhom LIKE N'%" + ten + "%'");
            return Laydulieu(query);

        }
    }
}
