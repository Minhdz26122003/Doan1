using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_Hoadonban
    {
        DBConnect con =new DBConnect();
        Hoadonban hdb=new Hoadonban();
        DAL_Hoadonban dal_hdb = new DAL_Hoadonban();
        public DataTable Laydulieu()
        {
            try
            {
                return dal_hdb.Laydulieu();
            }

            catch (Exception ex)
            {
                throw ex;
            }
         
        }
        public DataTable Laytennv(string ma)
        {
            try
            {
                return dal_hdb.laytennv( ma);
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }
        public DataTable Laytenkh(string ma)
        {
            try
            {
                return dal_hdb.laytenkh(ma);
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }
        public int Kiemtrama(string ma)
        {
            try
            {
                return dal_hdb.Kiemtrama(ma);
            }

            catch (Exception ex)
            {
                throw ex;
            }
           
        }
        public bool ThemHDB(Hoadonban hdb)
        {
            try
            {
                return dal_hdb.ThemHDB(hdb);
            }

            catch (Exception ex)
            {
                throw ex;
            }
           
        }
        public bool SuaHDB(Hoadonban hdb)
        {
            try
            {
                return dal_hdb.SuaHDB(hdb);
            }

            catch (Exception ex)
            {
                throw ex;
            }
          
        }
        public bool XoaHDB(Hoadonban hdb)
        {
            try
            {
                return dal_hdb.XoaHDB(hdb);
            }

            catch (Exception ex)
            {
                throw ex;
            }
           
        }
        public bool SuaTT(Hoadonban hdb, double tongtien)
        {
            try
            {
                return dal_hdb.SuaTT(hdb, tongtien);
            }

            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        public DataTable Timkiemmapn(string ma)
        {
            try
            {
                return dal_hdb.TimKiemmapn(ma);
            }

            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        public bool updatett(string ma)
        {
            try
            {
                return dal_hdb.updattt(ma);
            }

            catch (Exception ex)
            {
                throw ex;
            }
          
        }
        public string laytt(string ma)
        {
            try
            {
                return dal_hdb.LayTT(ma);
            }

            catch (Exception ex)
            {
                throw ex;
            }
           
        }
        public DataTable Thongketheongay(Hoadonban hd1,Hoadonban hd2)
        {
            try
            {
                return dal_hdb.Thongketheongay(hd1, hd2);
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }
        public object tt(Hoadonban hd1, Hoadonban hd2)
        {
            try
            {
                return dal_hdb.tt(hd1,hd2);
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void tke(DataTable dt, string sheetname, string title,string cot1,string cot2,string cot3,string cot4,string cot5)
        {
            con.ExportExel(dt, sheetname, title,cot1,cot2,cot3,cot4,cot5);
        }
    }
}
