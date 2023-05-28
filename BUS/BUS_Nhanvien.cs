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
    public class BUS_Nhanvien
    {
        DAL_NhanVien dal_nv=new DAL_NhanVien();
        public DataTable Laydulieu()
        {
            try
            {
                return dal_nv.Laydulieu();
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
                return dal_nv.Kiemtrama(ma);
            }

            catch (Exception ex)
            {
                throw ex;
            }
           
        }
        public bool Themnv( NhanVien nv)
        {
            try
            {
                return dal_nv.ThemNv(nv);
            }

            catch (Exception ex)
            {
                throw ex;
            }
           
        }
        public bool Suanv(NhanVien nv)
        {
            try
            {
                return dal_nv.Suanv(nv);
            }

            catch (Exception ex)
            {
                throw ex;
            }
           
        }
        public bool Xoanv(NhanVien nv)
        {
            try
            {
                return dal_nv.Xoanv(nv);
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
                return dal_nv.Lammoi(gr);
            }

            catch (Exception ex)
            {
                throw ex;
            }
           
        }
        public DataTable TimKiemmanv(string ma)
        {
            try
            {
                return dal_nv.TimKiemmanv(ma);
            }

            catch (Exception ex)
            {
                throw ex;
            }
          
        }
        public DataTable TimKiemtennv(string ten)
        {
            try
            {
                return dal_nv.TimKiemtennv(ten);
            }

            catch (Exception ex)
            {
                throw ex;
            }
           
        }
        
    }
}
