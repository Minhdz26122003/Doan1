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
    
    public class BUS_CTNhapnguyenlieu :DBConnect
    {
        DAL_CTNhapnguyenlieu dal_ctnnl = new DAL_CTNhapnguyenlieu();
        CTNhapNguyenLieu ct = new CTNhapNguyenLieu();
     
        public int kiemtrama(string ma)
        {
            try
            {
                return dal_ctnnl.Kiemtrama(ma);
            }

            catch (Exception ex)
            {
                throw ex;
            }
           
        }
        public DataTable report(string ma)
        {
            try
            {
                return dal_ctnnl.Repot(ma);
            }

            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable Laydulieu(string ma)
        {
            try
            {
                return dal_ctnnl.Laydulieu(ma);
            }

            catch (Exception ex)
            {
                throw ex;
            }
          
        }       
        public bool ThemCTNhap(CTNhapNguyenLieu ct)
        {
            try
            {
                return dal_ctnnl.ThemCTNhap(ct);
            }

            catch (Exception ex)
            {
                throw ex;
            }
          
        }
        public bool SuaCTNhap(CTNhapNguyenLieu ct)
        {
            try
            {
                return dal_ctnnl.SuaCTNhap(ct);
            }

            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        public bool XoaHang(string ma, string ma2)
        {
            try
            {
                return dal_ctnnl.XoaHang(ma, ma2);
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool XoaCTNhap(string ma)
        {
            try
            {
                return dal_ctnnl.XoaCTNhap(ma);
            }

            catch (Exception ex)
            {
                throw ex;
            }
           
        }
        public bool Kiemtranhap(string gtri1,string gtri2)
        {
            try
            {
                return dal_ctnnl.KiemtraNhap(gtri1, gtri2);
            }

            catch (Exception ex)
            {
                throw ex;
            }
           
        }     
        public string LayTenNL(string ma)
        {
            try
            {
                return dal_ctnnl.LayTenNL(ma);
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
                return dal_ctnnl.TimKiemmapn(ma);
            }

            catch (Exception ex)
            {
                throw ex;
            }
         
        }
        
    }
}
