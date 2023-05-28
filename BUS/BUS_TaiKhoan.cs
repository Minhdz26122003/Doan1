using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_TaiKhoan
    {
        TaiKhoan tk =new TaiKhoan();
        DBConnect tkacess=new DBConnect();
        DAL_TaiKhoan dal_tk=new DAL_TaiKhoan();
        public string Checklogin(TaiKhoan tk)
        {
            try
            {
                //kiem tra nghiep vu
                if (tk.Taikhoan == "")
                {
                    return "Nhập tài khoản";
                }
                if (tk.Matkhau == "")
                {
                    return "Nhập mật khẩu";
                }
                string infor = tkacess.Checklogintk(tk);  
                return infor;
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
                return dal_tk.Lammoi(grb);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
           
        public bool Kiemtra(string tk,string mk)
        {
            try
            {
                return dal_tk.KiemTra(tk, mk);
            }

            catch (Exception ex)
            {
                throw ex;
            }
           
        }
        public int Kiemtrama(string ma )
        {
            try
            {
                return dal_tk.Kiemtrama(ma);
            }

            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        public int Kttknv(string manv)
        {
            try
            {
                return dal_tk.Kttknv(manv);
            }

            catch (Exception ex)
            {
                throw ex;
            }
          
        }
        public DataTable Laydulieu()
        {
            try
            {
                return dal_tk.Laydulieu();
            }

            catch (Exception ex)
            {
                throw ex;
            }

            
        }
             
        public bool ThemTK(TaiKhoan tk)
        {
            try
            {
                return dal_tk.ThemTK(tk);
            }

            catch (Exception ex)
            {
                throw ex;
            }

           
        }
        public bool SuaTK(TaiKhoan tk)
        {
            try
            {
                return dal_tk.SuaTK(tk);
            }

            catch (Exception ex)
            {
                throw ex;
            }
          
        }
        public bool Doimk(TaiKhoan tk,string mk)
        {
            try
            {
                return dal_tk.Doimk(tk, mk);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool XoaTk(TaiKhoan tk)
        {
            try
            {
                return dal_tk.XoaTK(tk);
            }

            catch (Exception ex)
            {
                throw ex;
            }
           
        }
        public DataTable Timkiemtk(string ma)
        {
            try
            {
                return dal_tk.TimKiemtk(ma);
            }

            catch (Exception ex)
            {
                throw ex;
            }
           
        }
        public TaiKhoan Checkquyen(string tk, string pw)
        {
            try
            {
                return tkacess.Checkquyen(tk, pw);
            }

            catch (Exception ex)
            {
                throw ex;
            }
           
        }
    }
}
