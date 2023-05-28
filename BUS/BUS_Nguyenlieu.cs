using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_Nguyenlieu
    {
        DAL_Nguyenlieu dal_nl=new DAL_Nguyenlieu();
        public DataTable Laydulieu()
        {
            try
            {
                return dal_nl.Laydulieu();
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
                return dal_nl.Lammoi(grb);
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
                return dal_nl.Kiemtrama(ma);
            }

            catch (Exception ex)
            {
                throw ex;
            }

           
        }
        public string LaySLNL(string ma)
        {
            try
            {
                return dal_nl.LaySLNL(ma);
            }

            catch (Exception ex)
            {
                throw ex;
            }

          
        }
        public bool SuaSLNL(Nguyenlieu nl,int sl)
        {
            try
            {
                return dal_nl.SuaSLNL(nl, sl);
            }

            catch (Exception ex)
            {
                throw ex;
            }

           
        }
        public bool Suanl(Nguyenlieu nl)
        {
            try
            {
                return dal_nl.SuaNL(nl);
            }

            catch (Exception ex)
            {
                throw ex;
            }

           
        }

        public bool Themnl(Nguyenlieu nl)
        {
            try
            {
                return dal_nl.ThemNL(nl);
            }

            catch (Exception ex)
            {
                throw ex;
            }

          
        }  
        public bool Xoanl(Nguyenlieu nl)
        {
            try
            {
                return dal_nl.XoaNL(nl);
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
                return dal_nl.LayDG(ma);
            }

            catch (Exception ex)
            {
                throw ex;
            }

           
        }
        public DataTable TimKiemmanl(string ma)
        {
            try
            {
                return dal_nl.TimKiemmanl(ma);
            }

            catch (Exception ex)
            {
                throw ex;
            }

          
        }
        public DataTable TimKiemtennl(string ten)
        {
            try
            {
                return dal_nl.TimKiemtennl(ten);
            }

            catch (Exception ex)
            {
                throw ex;
            }

           
        }
    }
}
