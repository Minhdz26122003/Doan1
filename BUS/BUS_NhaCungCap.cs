using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Windows.Forms;
using System.Data;

namespace BUS
{
    public class BUS_NhaCungCap
    {
        DAL_NhaCungCap dal_ncc = new DAL_NhaCungCap();
        public DataTable Laydulieu()
        {
            try
            {
                return dal_ncc.Laydulieu();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        public bool Lammoi(GroupBox grb)
        {
            try
            {
                return dal_ncc.Lammoi(grb);
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
                return dal_ncc.Kiemtrama(ma);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        public bool ThemNCC(NhaCungCap ncc)
        {
            try
            {
                return dal_ncc.ThemNCC(ncc);
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }
        public bool XoaNCC(NhaCungCap ncc)
        {
            try
            {
                return dal_ncc.XoaNCC(ncc);
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }
        public bool SuaNCC(NhaCungCap ncc)
        {
            try
            {
                return dal_ncc.SuaNCC(ncc);
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }
        public DataTable TimKiemmancc(string ma)
        {
            try
            {
                return dal_ncc.TimKiemmancc(ma);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        public DataTable TimKiemtenncc(string ten)
        {
            try
            {
                return dal_ncc.TimKiemtenncc(ten);
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }

    }
}
