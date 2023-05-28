using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
namespace DAL
{
    public class Bieudo 
    {
        DBConnect con = new DBConnect();     
        public Bieudo()
        {

        }
        public DataTable GetBillForChart(int mode, DateTime getMonth, DateTime getYear)
        {
            DataTable dt = null; 
            try
            {
                StringBuilder sql = new StringBuilder();//StringBuilder là một lớp trong C# được sử dụng để tạo và sửa đổi chuỗi.
                sql.Append("select Day(Ngay) as Ngay,").Append(" ");
                sql.Append("sum(Tongtien) as Tongtien").Append(" ");
                sql.Append("from Hoadonban").Append(" ");
                sql.Append("where (MONTH(Ngay) = MONTH('" + getMonth + "')").Append(" ");
                sql.Append("and year(Ngay) = year('" + getYear + "'))").Append(" ");
                sql.Append("GROUP BY Day(Ngay)").Append(" ");

                if (mode == 1)
                {
                    sql.Clear();
                    sql.Append("select month(Ngay) as Thang,").Append(" ");
                    sql.Append("sum(Tongtien) as Tongtien").Append(" ");
                    sql.Append("from Hoadonban").Append(" ");
                    sql.Append("where year(Ngay) = YEAR('" + getYear + "')").Append(" ");
                    sql.Append("GROUP BY month(Ngay)").Append(" ");
                }

                if (mode == 2)
                {
                    sql.Clear();
                    sql.Append("select year(Ngay) as Nam,").Append(" ");
                    sql.Append("sum(Tongtien) as Tongtien").Append(" ");
                    sql.Append("from Hoadonban").Append(" ");
                    sql.Append("GROUP BY year(Ngay)").Append(" ");
                }

                con.KN();               
                SqlCommand cmd = new SqlCommand(sql.ToString(), con.con);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sqlDataAdapter.Fill(dt);

                if (dt == null)
                {
                    MessageBox.Show("ERROR");
                    
                }
            }
            catch (Exception ex)
            {
                dt = null;
                MessageBox.Show(ex.Message);
            }

            return dt;
        }

    }
}
