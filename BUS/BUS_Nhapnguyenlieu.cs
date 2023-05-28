using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;
using System.Windows.Forms;
namespace BUS
{
    public class BUS_Nhapnguyenlieu :DBConnect
    {
        DAL_Nhapnguyenlieu dal_nnl=new DAL_Nhapnguyenlieu();
        DBConnect con=new DBConnect();
        public DataTable Laydulieu()
        {
            try
            {
                return dal_nnl.Laydulieu();
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
                return dal_nnl.laytennv(ma);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable Laytenncc(string ma)
        {
            try
            {
                return dal_nnl.laytenNcc(ma);
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
                return dal_nnl.Kiemtrama(ma);
            }

            catch (Exception ex)
            {
                throw ex;
            }

            
        }
        public bool ThemHDN(NhapNguyenLieu nnl)
        {
            try
            {
                return dal_nnl.ThemHDN(nnl);
            }

            catch (Exception ex)
            {
                throw ex;
            }

           
        }
        public bool SuaHDN(NhapNguyenLieu nnl)
        {
            try
            {
                return dal_nnl.SuaHDN(nnl);
            }

            catch (Exception ex)
            {
                throw ex;
            }

           
        }
        public bool XoaHDN(NhapNguyenLieu nnl)
        {
            try
            {
                return dal_nnl.XoaHDN(nnl);
            }

            catch (Exception ex)
            {
                throw ex;
            }

          
        }
        public bool SuaTT(NhapNguyenLieu nnl ,double tongtien)
        {
            try
            {
                return dal_nnl.SuaTT(nnl, tongtien);
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
                return dal_nnl.TimKiemmapn(ma);
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
                return dal_nnl.updattt(ma);
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
                return dal_nnl.LayTT(ma);
            }

            catch (Exception ex)
            {
                throw ex;
            }

            
        }
        //public void tk(DataTable dt,string sheetname ,string title)
        //{
        //     con.ExportExel(dt, sheetname, title);
        //}
            
    }
}
