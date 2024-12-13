using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quản_lý_thư_viện___BUS;
using Quản_lý_thư_viện___DAO;
using Quản_lý_thư_viện___DTO;
using Microsoft.Data.SqlClient;
using Quản_lý_độc_giả___DTO;

namespace QL_Thư_viện___form_Độc_giả
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tdn = txtTenDangNhap.Text;
            string mk = txtMatKhau.Text;

            if (string.IsNullOrEmpty(tdn) || string.IsNullOrEmpty(mk))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Class_TaiKhoan taiKhoan = TaiKhoan_BUS.DangNhap(tdn, mk);

                if (taiKhoan != null)
                {
                    MessageBox.Show($"Đăng nhập thành công! Vai trò: {taiKhoan.VaiTro}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (taiKhoan.VaiTro == 1)
                    {
                        // Chuyển sang giao diện chính
                        this.Hide();
                        frmQLDocGia formMain = new frmQLDocGia();
                        formMain.Show();
                    }
                    else if (taiKhoan.VaiTro == 0)
                    {
                        MessageBox.Show("Xin chào độc giả. Test form");
                    }
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
