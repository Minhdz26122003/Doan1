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
    public class BUS_Dsbanh
    {
        DAL_Dsbanh dal_ba=new DAL_Dsbanh();
        public DataTable Laydulieu()
        {
            try
            {
                return dal_ba.Laydulieu();
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
                return dal_ba.Lammoi(grb);
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
                return dal_ba.Kiemtrama(ma);
            }

            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        public bool ThemSP(Dsbanh du)
        {
            try
            {
                return dal_ba.ThemSP(du);
            }

            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        public bool XoaSP(Dsbanh du)
        {
            try
            {
                return dal_ba.XoaSP(du);
            }

            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        public bool SuaSP(Dsbanh du)
        {
            try
            {
                return dal_ba.SuaSP(du);
            }

            catch (Exception ex)
            {
                throw ex;
            }
           
        }
        public bool SuaSLSP(Dsbanh du,int sl)
        {
            try
            {
                return dal_ba.SuaSLSP(du,sl);
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }
        public DataTable TimKiemmadu(string ma)
        {
            try
            {
                return dal_ba.TimKiemmadu(ma);
            }

            catch (Exception ex)
            {
                throw ex;
            }
           
        }
        public DataTable TimKiemtendu(string ten)
        {
            try
            {
                return dal_ba.TimKiemtendu(ten);
            }

            catch (Exception ex)
            {
                throw ex;
            }
           
        }
        public DataTable Timkiemgiadu(string gia1)
        {
            try
            {
                return dal_ba.TimKiemgiadu(gia1);
            }

            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        public string LayDG(string ma)
        {
            try
            {
                return dal_ba.LayDG(ma);
            }

            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        public string LayTenB(string ma)
        {
            try
            {
                return dal_ba.LayTenB(ma);
            }

            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        public string LaySL(string ma)
        {
            try
            {
                return dal_ba.LaySLNL(ma);
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
