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
    public class BUS_Khachhang
    {
       DAL_Khachhang dal_kh = new DAL_Khachhang();
        public DataTable Laydulieu()
        {
            try
            {
                return dal_kh.Laydulieu();
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
                return dal_kh.Kiemtrama(ma);
            }

            catch (Exception ex)
            {
                throw ex;
            }

            
        }
        public bool ThemKh(Khachhang kh)
        {
            try
            {
                return dal_kh.ThemKh(kh);
            }


            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool SuaKh(Khachhang kh)
        {
            try
            {
                return dal_kh.SuaKh(kh);
            }

            catch (Exception ex)
            {
                throw ex;
            }

           
        }
        public bool XoaKh(Khachhang kh)
        {
            try
            {
                return dal_kh.XoaKh(kh);
            }

            catch (Exception ex)
            {
                throw ex;
            }

            

        }
        public bool Lammoi(GroupBox gr)
        {
            try
            {
                return dal_kh.Lammoi(gr);
            }

            catch (Exception ex)
            {
                throw ex;
            }

          
        }
        public DataTable TimKiemmaKh(string ma)
        {
            try
            {
                return dal_kh.TimKiemmanKh(ma);
            }

            catch (Exception ex)
            {
                throw ex;
            }

           
        }
        public DataTable TimKiemtenKh(string ten)
        {
            try
            {
                return dal_kh.TimKiemtenKh(ten);
            }

            catch (Exception ex)
            {
                throw ex;
            }

    
        }

    }
}
