using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Quản_lý_thư_viện___DAO
{
    public class DataProvider
    {
        public static string ChuoiKetNoi
        {
            get
            {
                //return System.Configuration.ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
                return "Data Source = DESKTOP-DIEMHUO; Initial Catalog = QLThuVien; Integrated Security = True; TrustServerCertificate = True";
            }
        }

        public static bool TruyVan_XuLy(string sql)
        {
            try
            {
                SqlConnection connsql = new SqlConnection(ChuoiKetNoi);
                SqlCommand cmd = new SqlCommand(sql, connsql);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static DataTable TruyVan_LayDuLieu(string sql)
        {
            SqlConnection connsql = new SqlConnection(ChuoiKetNoi);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connsql);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public static void ExcuteNonQuery(string sql, CommandType type, SqlParameter[] paras)
        {
            SqlConnection connsql = new SqlConnection(ChuoiKetNoi);
            connsql.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connsql;
            cmd.CommandType = type;
            cmd.CommandText = sql;

            if (paras != null)  //Có tham số
                cmd.Parameters.AddRange(paras);

            cmd.ExecuteNonQuery();

            connsql.Close();
        }

        public static DataTable SelectData(string sql, CommandType type, SqlParameter[] paras)
        {
            DataTable dt = new DataTable();

            SqlConnection connsql = new SqlConnection(ChuoiKetNoi);
            connsql.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connsql;
            cmd.CommandType = type;
            cmd.CommandText = sql;

            if (paras != null)  //Có tham số
                cmd.Parameters.AddRange(paras);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            connsql.Close();

            return dt;
        }

        public static object ExecuteScalar(string query, CommandType commandType = CommandType.Text, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ChuoiKetNoi))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = commandType;

                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        return command.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thực hiện ExecuteScalar: " + ex.Message);
            }
        }

        //2 hàm này dùng riêng cho việc Đăng nhập
        public static bool KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau";
                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@TenDangNhap", tenDangNhap),
            new SqlParameter("@MatKhau", matKhau)
                };

                object result = ExecuteScalar(query, CommandType.Text, parameters);

                // Nếu COUNT > 0, tức là đăng nhập thành công
                return Convert.ToInt32(result) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra đăng nhập: " + ex.Message);
            }
        }

        public static DataRow LayThongTinTaiKhoan(string tenDangNhap, string matKhau)
        {
            try
            {
                string query = "SELECT * FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau";
                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@TenDangNhap", tenDangNhap),
            new SqlParameter("@MatKhau", matKhau)
                };

                DataTable dt = SelectData(query, CommandType.Text, parameters);

                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0]; // Trả về dòng đầu tiên nếu tồn tại
                }
                else
                {
                    return null; // Không tìm thấy tài khoản
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy thông tin tài khoản: " + ex.Message);
            }
        }
    }
}
