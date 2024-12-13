using Quản_lý_độc_giả___DTO;
using Quản_lý_thư_viện___DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Quản_lý_thư_viện___BUS
{
    public class TaiKhoan_BUS
    {
        public static List<Class_TaiKhoan> layDSTaiKhoan()
        {
            return TaiKhoan_DAO.layDSTaiKhoan();
        }

        public static Class_TaiKhoan DangNhap(string tenDangNhap, string matKhau)
        {
            Class_TaiKhoan taiKhoan = TaiKhoan_DAO.DangNhap(tenDangNhap, matKhau);

            if (taiKhoan != null)
            {
                return taiKhoan;
            }

            return null;
        }
    }
}
