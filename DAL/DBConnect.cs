using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using DTO;

namespace DAL
{
    public class DBConnect
    {
        public SqlConnection con;
        public SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        string chuoikn = @"Data Source=DESKTOP-MINHDZ\SQLEXPRESS01;Initial Catalog=QLQTS;Integrated Security=True";
        public void KN()
        {
            con = new SqlConnection(chuoikn);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void DKN()
        {
            con = new SqlConnection(chuoikn);
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        public DataTable Laydulieu(string query)
        {
            KN();
            da = new SqlDataAdapter(query, con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
            DKN();
        }
        public int ExecuteNonQuery(string query)
        {
            KN();
            cmd = new SqlCommand(query, con);
            int sodongbitd = cmd.ExecuteNonQuery();
            return sodongbitd;
            DKN();
        }

        public object ExecuteScalar(string query)
        {
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            KN();
            object ketqua = cmd.ExecuteScalar();
            DKN();
            return ketqua;
        }
        public int ktradn(string query)
        {
            KN();
            DataTable dtTong = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter(query, con);
            adap.Fill(dtTong);
            int sbg = dtTong.Rows.Count;
            return sbg;
            DKN();
        }

        public int Kiemtrama(string ma, string query)
        {
            KN();
            int i;
            cmd = new SqlCommand(query, con);
            i = (int)cmd.ExecuteScalar();
            return i; DKN();
        }
        public bool kiemTraNhap(string giaTri1, string giaTri2)
        {
            KN();
            string query = "Select count(*) from CTNhapNL where Maphieunhap='" + giaTri1 + "' and Manguyenlieu='" + giaTri2 + "'";
            SqlCommand command = new SqlCommand(query, con);
            int number = 0;
            try
            {
                number = (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            if (number > 0)
                return true;
            else
                return false;
            DKN();
        }

        public bool kiemTraBan(string giaTri1, string giaTri2)
        {
            KN();
            string query = "Select count(*) from CTHoadonban where MaHDB='" + giaTri1 + "' and Mamon='" + giaTri2 + "'";
            SqlCommand command = new SqlCommand(query, con);
            int number = 0;
            try
            {
                number = (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            if (number > 0)
                return true;
            else
                return false;
            DKN();
        }

        public bool Lammoi(GroupBox grb)
        {
            foreach (Control ctrl in grb.Controls)
            {
                if (ctrl is TextBox)
                {
                    (ctrl as TextBox).Text = "";
                }
                if (ctrl is ComboBox)
                {
                    (ctrl as ComboBox).Text = "";
                } //......   
            }
            return true;
        }


        public string Checklogintk(TaiKhoan tk)
        {
            string user = null;
            KN();
            SqlCommand cmd = new SqlCommand("Login");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Taikhoan ", tk.Taikhoan);
            cmd.Parameters.AddWithValue("@Matkhau ", tk.Matkhau);
            cmd.Connection = con;
            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    user = rd.GetString(0);//ma tk

                    return user;
                }
                rd.Close();
                DKN();
            }
            else
            {
                return "Tài khoản hoặc mật khẩu không chính xác";
            }
            return user;
        }
        public TaiKhoan Checkquyen(string tk, string pw)
        {

            TaiKhoan tkh = null;
            KN();
            SqlCommand cmd = new SqlCommand("Login");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Taikhoan ", tk);
            cmd.Parameters.AddWithValue("@Matkhau ", pw);
            cmd.Connection = con;
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                if (rd.Read())
                {
                    tkh = new TaiKhoan()
                    {
                        taikhoan = rd.GetString(0),
                        matkhau = rd.GetString(1),
                        Maquyen = rd.GetInt32(2),

                    };
                    rd.Close();
                    DKN();
                }
            }
            return tkh;
        }

        public void ExportExel(System.Data.DataTable dt, string sheetname, string title,string cot1,string cot2,string cot3,string cot4,string cot5 )
        {
            
            //tao cac doi tuong exel
            Microsoft.Office.Interop.Excel.Application oExel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook oBook;
            Microsoft.Office.Interop.Excel.Sheets oSheets;
            Microsoft.Office.Interop.Excel.Workbooks oBooks;
            Microsoft.Office.Interop.Excel.Worksheet oWorksheet;

            //Tao moi 1 exel workbookk
            oExel.Visible = true;
            oExel.DisplayAlerts = false;
            oExel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExel.Workbooks;
            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);
            oWorksheet.Name = sheetname;

            ///Tao phan tieu de
            Microsoft.Office.Interop.Excel.Range head = oWorksheet.get_Range("A1", "F1");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Size = "20";
            head.Font.Name = "Times New Roman";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            ///Tao tieu de cot
            Microsoft.Office.Interop.Excel.Range cl1 = oWorksheet.get_Range("A3", "A3");
            cl1.Value2 =cot1;
            cl1.Font.Bold = true;
            cl1.Font.Size = "14";
            cl1.ColumnWidth = 25;
            cl1.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range cl2 = oWorksheet.get_Range("B3", "B3");
            cl2.Value2 =cot2;
            cl2.Font.Bold = true;
            cl2.Font.Size = "14";
            cl2.ColumnWidth = 25;
            cl2.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range cl3 = oWorksheet.get_Range("C3", "C3");
            cl3.Value2 = cot3;
            cl3.Font.Bold = true;
            cl3.Font.Size = "14";
            cl3.ColumnWidth = 25;
            cl3.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range cl4 = oWorksheet.get_Range("D3", "D3");
            cl4.Value2 = cot4;
            cl4.Font.Bold = true;
            cl4.Font.Size = "14";
            cl4.ColumnWidth = 20;
            cl4.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range cl5 = oWorksheet.get_Range("E3", "E3");
            cl5.Value2 = cot5;
            cl5.Font.Bold = true;
            cl5.Font.Size = "14";
            cl5.ColumnWidth = 20;
            cl5.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            //tao mang theo datatable
            object[,] arr = new object[dt.Rows.Count, dt.Columns.Count];

            //chuye du lieu tu datable vao mang
            for (int row = 0; row < dt.Rows.Count; row++)
            {
                DataRow dtr = dt.Rows[row];
                for (int col = 0; col < dt.Columns.Count; col++)
                {
                    arr[row, col] = dtr[col];
                }
            }

            //thiet lap vung dien du lieu
            int rowStart = 4;
            int columStart = 1;
            int rowEnd = rowStart + dt.Rows.Count - 2;
            int columEnd = dt.Columns.Count;

            //o bat dau dien du lieu va o ket thuc dien du lieu
            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oWorksheet.Cells[rowStart, columStart];
            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oWorksheet.Cells[rowEnd, columEnd];

            //lay ve vung dien du lieu
            Microsoft.Office.Interop.Excel.Range range = oWorksheet.get_Range(c1, c2);
            //dien du lieu vao vung da thiet lap
            range.Value2 = arr;

            //ke vien
            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            //can giua bang
            oWorksheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

        }

       

    }
}
