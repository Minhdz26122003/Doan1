using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using DTO;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_Nhomloaibanh
    {
        DAL_Nhomloaibanh dal_nb = new DAL_Nhomloaibanh();
        public DataTable Laydulieu()
        {
            try
            {
                return dal_nb.Laydulieu();
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
                return dal_nb.Lammoi(grb);
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
                return dal_nb.Kiemtrama(ma);
            }

            catch (Exception ex)
            {
                throw ex;
            }
           
        }
        public bool ThemSP(Nhomloaibanh nb)
        {
            try
            {
                return dal_nb.ThemNb(nb);
            }

            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        public bool XoaSP(Nhomloaibanh nb)
        {
            try
            {
                return dal_nb.XoaNb(nb);
            }

            catch (Exception ex)
            {
                throw ex;
            }
          
        }
        public bool SuaSP(Nhomloaibanh nb)
        {
            try
            {
                return dal_nb.SuaNb(nb);
            }

            catch (Exception ex)
            {
                throw ex;
            }
           
        }
        public DataTable TimKiemmanb(string ma)
        {
            try
            {
                return dal_nb.TimKiemmanb(ma);
            }

            catch (Exception ex)
            {
                throw ex;
            }
           
        }
        public DataTable TimKiemtennb(string ten)
        {
            try
            {
                return dal_nb.TimKiemtennb(ten);
            }

            catch (Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
