using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Quản_lý_thư_viện___DTO;

namespace Quản_lý_thư_viện___DAO
{
    public class DocGia_DAO
    {
        public static List<Class_DocGia> layDSDocGia()
        {
            List<Class_DocGia> dsDG = new List<Class_DocGia>();
            DataTable dtDG = DataProvider.TruyVan_LayDuLieu("select * from DocGia");

            foreach (DataRow dr in dtDG.Rows)
            {
                Class_DocGia dg = new Class_DocGia();

                dg.MaDocGia = dr["MaDocGia"].ToString();
                dg.TenDangNhap = dr["TenDangNhap"].ToString();
                dg.HoTen = dr["HoTen"].ToString();
                dg.GioiTinh = dr["GioiTinh"].ToString();
                dg.DiaChi = dr["DiaChi"].ToString();
                dg.SDT = dr["SDT"].ToString();

                if (dr["NamSinh"].ToString() != "")
                    dg.NamSinh = int.Parse(dr["NamSinh"].ToString());

                dsDG.Add(dg);
            }

            return dsDG;
        }

        public static void themDG(Class_DocGia dg)
        {
            string query = "insert into DocGia(MaDocGia, TenDangNhap, HoTen, GioiTinh, NamSinh, DiaChi, SDT) values (@MaDocGia, @TenDangNhap, @HoTen, @GioiTinh, @NamSinh, @DiaChi, @SDT)";
            SqlParameter[] sp = new SqlParameter[7];

            sp[0] = new SqlParameter("MaDocGia", dg.MaDocGia);
            sp[1] = new SqlParameter("TenDangNhap", dg.TenDangNhap);
            sp[2] = new SqlParameter("HoTen", dg.HoTen); 
            sp[3] = new SqlParameter("GioiTinh", dg.GioiTinh);
            sp[4] = new SqlParameter("NamSinh", dg.NamSinh);
            sp[5] = new SqlParameter("DiaChi", dg.DiaChi);
            sp[6] = new SqlParameter("SDT", dg.SDT);

            DataProvider.ExcuteNonQuery(query, CommandType.Text, sp);
        }

        public static void xoaDG(string madg)
        {
            string query = "delete from DocGia where MaDocGia = @MaDocGia";

            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@MaDocGia", madg);

            DataProvider.ExcuteNonQuery(query, CommandType.Text, sp);
        }

        public static void suaDG(Class_DocGia dg)
        {
            string query = "update DocGia set TenDangNhap = @TenDangNhap, HoTen = @HoTen, GioiTinh = @GioiTinh, NamSinh = @NamSinh, DiaChi = @DiaChi, SDT = @SDT where MaDocGia = @MaDocGia";

            SqlParameter[] sp = new SqlParameter[7];

            sp[0] = new SqlParameter("MaDocGia", dg.MaDocGia);
            sp[1] = new SqlParameter("TenDangNhap", dg.TenDangNhap);
            sp[2] = new SqlParameter("HoTen", dg.HoTen);
            sp[3] = new SqlParameter("GioiTinh", dg.GioiTinh);
            sp[4] = new SqlParameter("NamSinh", dg.NamSinh);
            sp[5] = new SqlParameter("DiaChi", dg.DiaChi);
            sp[6] = new SqlParameter("SDT", dg.SDT);

            DataProvider.ExcuteNonQuery(query, CommandType.Text, sp);
        }

        public static List<Class_DocGia> timKiemDocGia(string lok)
        {
            List<Class_DocGia> dsDG = new List<Class_DocGia>();
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("Ten", lok);

            DataTable dt = DataProvider.SelectData("SELECT * FROM DocGia WHERE HoTen LIKE N'%' + @Ten + '%'", CommandType.Text, sp);
            foreach (DataRow dr in dt.Rows)
            {
                Class_DocGia dg = new Class_DocGia();

                dg.MaDocGia = dr["MaDocGia"].ToString();
                dg.TenDangNhap = dr["TenDangNhap"].ToString();
                dg.HoTen = dr["HoTen"].ToString();
                dg.GioiTinh = dr["GioiTinh"].ToString();
                dg.DiaChi = dr["DiaChi"].ToString();
                dg.SDT = dr["SDT"].ToString();

                if (dr["NamSinh"].ToString() != "")
                    dg.NamSinh = int.Parse(dr["NamSinh"].ToString());

                dsDG.Add(dg);
            }

            return dsDG;
        }
    }
}
