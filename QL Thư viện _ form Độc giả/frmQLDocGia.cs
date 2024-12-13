using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
//using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections;
using System.Net.Http.Headers;
using Quản_lý_thư_viện___BUS;
using Quản_lý_thư_viện___DAO;
using Quản_lý_thư_viện___DTO;

namespace QL_Thư_viện___form_Độc_giả
{
    public partial class frmQLDocGia : Form
    {
        private SqlConnection connsql;

        public frmQLDocGia()
        {
            InitializeComponent();

            //string cs = "Data Source = DESKTOP-DIEMHUO; Initial Catalog = QLThuVien; Integrated Security = True; TrustServerCertificate = True";

            //connsql = new SqlConnection(cs);
        }

        private void displayList()
        {
            /*
            try
            {
                if (connsql.State == ConnectionState.Closed)
                {
                    connsql.Open();
                }

                string query = "select * from Readers";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connsql);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvQLDocGia.DataSource = table;

                if (connsql.State == ConnectionState.Open)
                {
                    connsql.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed " + ex.ToString());
            }
            */

            dgvQLDocGia.DataSource = DocGia_BUS.LayDSDocGia();
        }

        private void clearFields()
        {
            txtMaDocGia.Clear();
            txtTenDangNhap.Clear();
            txtHoTen.Clear();
            txtNamSinh.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            rbtnNam.Checked = false;
            rbtnNu.Checked = false;
        }

        private void frmQLDocGia_Load(object sender, EventArgs e)
        {
            displayList();

            dgvQLDocGia.AutoResizeColumns();
        }

        private void dgvQLDocGia_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //load thông tin độc giả
            txtMaDocGia.Text = dgvQLDocGia.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenDangNhap.Text = dgvQLDocGia.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtHoTen.Text = dgvQLDocGia.Rows[e.RowIndex].Cells[2].Value.ToString();

            //txtMaDocGia.Text = dgvQLDocGia.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (dgvQLDocGia.Rows[e.RowIndex].Cells[3].Value.ToString() == "Nam")
            {
                rbtnNam.Checked = true;
            }
            else if (dgvQLDocGia.Rows[e.RowIndex].Cells[3].Value.ToString() == "Nu" || dgvQLDocGia.Rows[e.RowIndex].Cells[3].Value.ToString() == "Nữ")
            {
                rbtnNu.Checked = true;
            }

            txtNamSinh.Text = dgvQLDocGia.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtDiaChi.Text = dgvQLDocGia.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtSDT.Text = dgvQLDocGia.Rows[e.RowIndex].Cells[6].Value.ToString();

            //load thông tin tài khoản
        }

        private string getNewMaDocGia()
        {
            string query = "SELECT MAX(CAST(SUBSTRING(MaDocGia, 5, LEN(MaDocGia) - 4) AS INT)) FROM DocGia WHERE MaDocGia LIKE 'user%'";

            object result = DataProvider.ExecuteScalar(query);

            if (result == DBNull.Value || result == null)
            {
                return "user0";
            }
            else
            {
                int maxNumber = int.Parse(result.ToString());
                maxNumber++;
                return "user" + maxNumber;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                if (connsql == null)
                {
                    MessageBox.Show("Connection is not initialized.");
                    return;
                }

                if (connsql.State == ConnectionState.Closed)
                {
                    connsql.Open();
                }

                //string id = getNewReaderID();
                string insert_str = "INSERT INTO Readers (FullName, DOB, PhoneNumber, Email, Address) VALUES (@Fullname, @DOB, @PhoneNumber, @Email, @Address)";

                using (SqlCommand cmd = new SqlCommand(insert_str, connsql))
                {
                    //cmd.Parameters.AddWithValue("@ReaderID", id);
                    cmd.Parameters.AddWithValue("@Fullname", txtHoTen.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", txtSDT.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Address", txtNoiSinh.Text);
                    //cmd.Parameters.AddWithValue("@DOB", dtpDoB.Text);
                    cmd.Parameters.Add("@DOB", SqlDbType.Date).Value = DateTime.Parse(dtpDoB.Value.ToString("yyyy-MM-dd"));

                    //cmd.Parameters.Add("@ReaderID", SqlDbType.Int).Value = id;
                    //cmd.Parameters.Add("@Fullname", SqlDbType.NVarChar).Value = txtHoTen.Text;
                    //cmd.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar).Value = txtSDT.Text;
                    //cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = txtEmail.Text;
                    //cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = txtNoiSinh.Text;
                    //cmd.Parameters.Add("@DOB", SqlDbType.Date).Value = DateTime.Parse(dtpDoB.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Success!");
                displayList();

                txtMaDocGia.Clear();
                txtHoTen.Clear();
                txtSDT.Clear();
                txtEmail.Clear();
                txtNoiSinh.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed " + ex.ToString());
            }
            */

            try
            {
                Class_DocGia dg = new Class_DocGia();

                dg.MaDocGia = getNewMaDocGia();
                dg.TenDangNhap = txtTenDangNhap.Text.Trim();
                dg.HoTen = txtHoTen.Text.Trim();
                dg.DiaChi = txtDiaChi.Text.Trim();

                //dg.GioiTinh = txtGioiTinh.Text.Trim();
                if (rbtnNam.Checked == true)
                {
                    dg.GioiTinh = "Nam";
                }
                else if (rbtnNu.Checked == true)
                {
                    dg.GioiTinh = "Nữ";
                }

                dg.NamSinh = int.Parse(txtNamSinh.Text.Trim());
                dg.SDT = txtSDT.Text.Trim();

                DocGia_BUS.themDG(dg);

                MessageBox.Show("Thêm độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                displayList();

                clearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            /*
            string query = "delete from Readers where ReaderID = @ReaderID";

            SqlCommand cmd = new SqlCommand(query, connsql);
            cmd.Parameters.AddWithValue("@ReaderID", txtMaDocGia.Text);

            try
            {
                if (connsql.State == ConnectionState.Closed)
                {
                    connsql.Open();
                }

                DialogResult dr = MessageBox.Show("Bạn thật sự muốn xoá?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã xoá thành công.", "Thông báo", MessageBoxButtons.OK);
                    displayList();
                }

                txtMaDocGia.Clear();
                txtHoTen.Clear();
                txtSDT.Clear();
                txtEmail.Clear();
                txtNoiSinh.Clear();

                if (connsql.State == ConnectionState.Open)
                {
                    connsql.Close();
                }
            }
            catch
            {
                MessageBox.Show("Khoá ngoại");
            }
            */

            if (dgvQLDocGia.SelectedRows.Count > 0)
            {
                string madg = dgvQLDocGia.SelectedRows[0].Cells[0].Value.ToString();

                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa độc giả có mã [" + madg + "] ?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        DocGia_BUS.xoaDG(madg);

                        MessageBox.Show("Xóa độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        displayList();

                        clearFields();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn độc giả để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            /*
            string query = "update Readers " +
                "set FullName = @FullName, DOB = @DOB, PhoneNumber = @PhoneNumber, Email = @Email, Address = @Address " +
                "where ReaderID = @ReaderID";

            try
            {
                if (connsql.State == ConnectionState.Closed)
                {
                    connsql.Open();
                }

                using (SqlCommand cmd = new SqlCommand(query, connsql))
                {
                    cmd.Parameters.AddWithValue("@ReaderID", txtMaDocGia.Text);
                    cmd.Parameters.AddWithValue("@Fullname", txtHoTen.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", txtSDT.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Address", txtNoiSinh.Text); 
                    cmd.Parameters.Add("@DOB", SqlDbType.Date).Value = DateTime.Parse(dtpDoB.Value.ToString("yyyy-MM-dd"));

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Sửa thành công!", "Thông báo");
                displayList();

                txtMaDocGia.Clear();
                txtHoTen.Clear();
                txtSDT.Clear();
                txtEmail.Clear();
                txtNoiSinh.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed " + ex.ToString());
            }
            finally
            {
                if (connsql.State == ConnectionState.Open)
                {
                    connsql.Close();
                }
            }
            */

            try
            {
                Class_DocGia dg = new Class_DocGia();

                dg.MaDocGia = txtMaDocGia.Text;
                dg.TenDangNhap = txtTenDangNhap.Text.Trim();
                dg.HoTen = txtHoTen.Text.Trim();
                dg.DiaChi = txtDiaChi.Text.Trim();

                //dg.GioiTinh = txtGioiTinh.Text.Trim();
                if (rbtnNam.Checked == true)
                {
                    dg.GioiTinh = "Nam";
                }
                else if (rbtnNu.Checked == true)
                {
                    dg.GioiTinh = "Nữ";
                }

                dg.NamSinh = int.Parse(txtNamSinh.Text.Trim());
                dg.SDT = txtSDT.Text.Trim();

                DocGia_BUS.suaDG(dg);

                MessageBox.Show("Sửa thông tin độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                displayList();

                clearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvQLDocGia.DataSource = DocGia_BUS.timKiemDG(txtHT_TK.Text.Trim());

            dgvQLDocGia.AutoResizeColumns();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            displayList();
            clearFields();

            dgvQLDocGia.AutoResizeColumns();
        }

        private void grpbThongTinDG_Enter(object sender, EventArgs e)
        {

        }
    }
}
