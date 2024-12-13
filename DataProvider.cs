using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace QL_Học_Sinh___DAO
{
    public class DataProvider
    {
        public static string ChuoiKetNoi
        {
            get
            {
                return "Data Source = DESKTOP-DIEMHUO; Initial Catalog = QLHocSinh; Integrated Security = True; TrustServerCertificate = True";
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

        public static DataTable SelectData (string sql, CommandType type, SqlParameter[] paras)
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
    }
}
