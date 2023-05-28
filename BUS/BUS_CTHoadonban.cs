using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Globalization;

namespace BUS
{
    public class BUS_CTHoadonban
    {
       CTHoadonban ct=new CTHoadonban();
        DAL_CTHoadonban dal_cthdb=new  DAL_CTHoadonban();

        public int kiemtrama(string ma)
        {
            try
            {
                return dal_cthdb.Kiemtrama(ma);
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
                return dal_cthdb.Laydulieu(ma);
            }

            catch (Exception ex)
            {
                throw ex;
            }
           
        }
        public DataTable Report(string ma)
        {
            try
            {
                return dal_cthdb.Repot(ma);
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
                return dal_cthdb.Lammoi(grb);
            }

            catch (Exception ex)
            {
                throw ex;
            }


        }
        public bool ThemCTBan(CTHoadonban ct)
        {
            try
            {
                return dal_cthdb.ThemCTBan(ct);
            }

            catch (Exception ex)
            {
                throw ex;
            }
          
        }
        public bool SuaCTNhap(CTHoadonban ct)
        {
            try
            {
                return dal_cthdb.SuaCTBan(ct);
            }

            catch (Exception ex)
            {
                throw ex;
            }
         
        }
        public bool XoaCTban(string ma)
        {
            try
            {
                return dal_cthdb.XoaCTBan(ma);
            }

            catch (Exception ex)
            {
                throw ex;
            }
           
        }
        public bool XoaCThangban(string ma,string ma2)
        {
            try
            {
                return dal_cthdb.XoaCthangban(ma,ma2);
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool KiemtraBan(string gtri1, string gtri2)
        {
            try
            {
                return dal_cthdb.KiemtraBan(gtri1, gtri2);
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
                return dal_cthdb.TimKiemmapn(ma);
            }

            catch (Exception ex)
            {
                throw ex;
            }
          
        }
        public DataTable Thongkespbanchay()
        {
            try
            {
                return dal_cthdb.Thongkespbanchay();
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
