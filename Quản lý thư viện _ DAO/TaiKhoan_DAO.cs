using Quản_lý_độc_giả___DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Quản_lý_thư_viện___DAO
{
    public class TaiKhoan_DAO
    {
        public static List<Class_TaiKhoan> layDSTaiKhoan()
        {
            List<Class_TaiKhoan> dsTK = new List<Class_TaiKhoan>();
            DataTable dt = DataProvider.TruyVan_LayDuLieu("select * from TaiKhoan");
            //DataTable dt = DataProvider.TruyVan_LayDuLieu("SELECT HoTen FROM DocGia WHERE MaDocGia IN (SELECT MaDocGia FROM TaiKhoan)");

            foreach (DataRow dr in dt.Rows)
            {
                Class_TaiKhoan tk = new Class_TaiKhoan();

                tk.MaDocGia = dr["MaDocGia"].ToString();
                tk.TenDangNhap = dr["TenDangNhap"].ToString();
                tk.MatKhau = dr["MatKhau"].ToString();
                tk.VaiTro = int.Parse(dr["VaiTro"].ToString());

                dsTK.Add(tk);
            }

            return dsTK;
        }

        public static Class_TaiKhoan DangNhap(string tendn, string mk)
        {
            if (DataProvider.KiemTraDangNhap(tendn, mk))
            {
                DataRow taiKhoanRow = DataProvider.LayThongTinTaiKhoan(tendn, mk);
                if (taiKhoanRow != null)
                {
                    return new Class_TaiKhoan
                    {
                        TenDangNhap = taiKhoanRow["TenDangNhap"].ToString(),
                        MatKhau = taiKhoanRow["MatKhau"].ToString(),
                        VaiTro = Convert.ToInt32(taiKhoanRow["VaiTro"])
                    };
                }
            }

            return null;
        }
    }
}
