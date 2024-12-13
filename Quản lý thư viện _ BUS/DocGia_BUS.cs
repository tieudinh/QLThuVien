using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Quản_lý_thư_viện___DAO;
using Quản_lý_thư_viện___DTO;

namespace Quản_lý_thư_viện___BUS
{
    public class DocGia_BUS
    {
        public static List<Class_DocGia> LayDSDocGia()
        {
            return DocGia_DAO.layDSDocGia();
        }

        public static List<Class_DocGia> timKiemDG(string lok)
        {
            return DocGia_DAO.timKiemDocGia(lok);
        }

        public static bool themDG(Class_DocGia dg)
        {
            try
            {
                DocGia_DAO.themDG(dg);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool xoaDG(string dg)
        {
            try
            {
                DocGia_DAO.xoaDG(dg);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool suaDG(Class_DocGia dg)
        {
            try
            {
                DocGia_DAO.suaDG(dg);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
