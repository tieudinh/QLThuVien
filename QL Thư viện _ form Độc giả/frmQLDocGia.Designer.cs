namespace QL_Thư_viện___form_Độc_giả
{
    partial class frmQLDocGia
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtHoTen = new TextBox();
            txtSDT = new TextBox();
            lblHoTen = new Label();
            lblNamSinh = new Label();
            lblSDT = new Label();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            dgvQLDocGia = new DataGridView();
            lblMaDocGia = new Label();
            txtMaDocGia = new TextBox();
            lblTenDangNhap = new Label();
            txtTenDangNhap = new TextBox();
            txtNamSinh = new TextBox();
            txtDiaChi = new TextBox();
            lblDiaChi = new Label();
            lblGioiTinh = new Label();
            rbtnNam = new RadioButton();
            rbtnNu = new RadioButton();
            grpbThongTinDG = new GroupBox();
            grpbTimKiem = new GroupBox();
            btnTimKiem = new Button();
            lblHT_TK = new Label();
            txtHT_TK = new TextBox();
            btnRefresh = new Button();
            grpbThongTinTK = new GroupBox();
            txtVaiTro = new TextBox();
            lblVaiTro = new Label();
            txtMDG_TK = new TextBox();
            lblMDG_TK = new Label();
            txtTDN_TK = new TextBox();
            lblTDN_TK = new Label();
            txtMatKhau = new TextBox();
            lblMatKhau = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvQLDocGia).BeginInit();
            grpbThongTinDG.SuspendLayout();
            grpbTimKiem.SuspendLayout();
            grpbThongTinTK.SuspendLayout();
            SuspendLayout();
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Times New Roman", 12F);
            txtHoTen.Location = new Point(116, 108);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(236, 26);
            txtHoTen.TabIndex = 0;
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Times New Roman", 12F);
            txtSDT.Location = new Point(116, 213);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(236, 26);
            txtSDT.TabIndex = 2;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Times New Roman", 12F);
            lblHoTen.Location = new Point(11, 111);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(68, 19);
            lblHoTen.TabIndex = 5;
            lblHoTen.Text = "Họ và tên";
            // 
            // lblNamSinh
            // 
            lblNamSinh.AutoSize = true;
            lblNamSinh.Font = new Font("Times New Roman", 12F);
            lblNamSinh.Location = new Point(11, 146);
            lblNamSinh.Name = "lblNamSinh";
            lblNamSinh.Size = new Size(66, 19);
            lblNamSinh.TabIndex = 6;
            lblNamSinh.Text = "Năm sinh";
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Font = new Font("Times New Roman", 12F);
            lblSDT.Location = new Point(11, 216);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(88, 19);
            lblSDT.TabIndex = 7;
            lblSDT.Text = "Số điện thoại";
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.ButtonFace;
            btnThem.Font = new Font("Times New Roman", 14.25F);
            btnThem.Location = new Point(12, 337);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 46);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = SystemColors.ButtonFace;
            btnXoa.Font = new Font("Times New Roman", 14.25F);
            btnXoa.Location = new Point(144, 336);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 46);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = SystemColors.ButtonFace;
            btnSua.Font = new Font("Times New Roman", 14.25F);
            btnSua.Location = new Point(283, 337);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 46);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // dgvQLDocGia
            // 
            dgvQLDocGia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLDocGia.Location = new Point(12, 404);
            dgvQLDocGia.Name = "dgvQLDocGia";
            dgvQLDocGia.Size = new Size(851, 284);
            dgvQLDocGia.TabIndex = 13;
            dgvQLDocGia.RowHeaderMouseClick += dgvQLDocGia_RowHeaderMouseClick;
            // 
            // lblMaDocGia
            // 
            lblMaDocGia.AutoSize = true;
            lblMaDocGia.Font = new Font("Times New Roman", 12F);
            lblMaDocGia.Location = new Point(11, 41);
            lblMaDocGia.Name = "lblMaDocGia";
            lblMaDocGia.Size = new Size(78, 19);
            lblMaDocGia.TabIndex = 16;
            lblMaDocGia.Text = "Mã độc giả";
            // 
            // txtMaDocGia
            // 
            txtMaDocGia.Enabled = false;
            txtMaDocGia.Font = new Font("Times New Roman", 12F);
            txtMaDocGia.Location = new Point(116, 38);
            txtMaDocGia.Name = "txtMaDocGia";
            txtMaDocGia.ReadOnly = true;
            txtMaDocGia.Size = new Size(175, 26);
            txtMaDocGia.TabIndex = 15;
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Font = new Font("Times New Roman", 12F);
            lblTenDangNhap.Location = new Point(11, 76);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(98, 19);
            lblTenDangNhap.TabIndex = 18;
            lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Times New Roman", 12F);
            txtTenDangNhap.Location = new Point(116, 73);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(175, 26);
            txtTenDangNhap.TabIndex = 17;
            // 
            // txtNamSinh
            // 
            txtNamSinh.Font = new Font("Times New Roman", 12F);
            txtNamSinh.Location = new Point(116, 143);
            txtNamSinh.Name = "txtNamSinh";
            txtNamSinh.Size = new Size(139, 26);
            txtNamSinh.TabIndex = 19;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Times New Roman", 12F);
            txtDiaChi.Location = new Point(116, 178);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(236, 26);
            txtDiaChi.TabIndex = 21;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Times New Roman", 12F);
            lblDiaChi.Location = new Point(11, 181);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(51, 19);
            lblDiaChi.TabIndex = 20;
            lblDiaChi.Text = "Địa chỉ";
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Font = new Font("Times New Roman", 12F);
            lblGioiTinh.Location = new Point(11, 247);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(59, 19);
            lblGioiTinh.TabIndex = 22;
            lblGioiTinh.Text = "Giới tính";
            // 
            // rbtnNam
            // 
            rbtnNam.AutoSize = true;
            rbtnNam.Font = new Font("Times New Roman", 12F);
            rbtnNam.Location = new Point(126, 245);
            rbtnNam.Name = "rbtnNam";
            rbtnNam.Size = new Size(57, 23);
            rbtnNam.TabIndex = 24;
            rbtnNam.TabStop = true;
            rbtnNam.Text = "Nam";
            rbtnNam.UseVisualStyleBackColor = true;
            // 
            // rbtnNu
            // 
            rbtnNu.AutoSize = true;
            rbtnNu.Font = new Font("Times New Roman", 12F);
            rbtnNu.Location = new Point(224, 245);
            rbtnNu.Name = "rbtnNu";
            rbtnNu.Size = new Size(48, 23);
            rbtnNu.TabIndex = 25;
            rbtnNu.TabStop = true;
            rbtnNu.Text = "Nữ";
            rbtnNu.UseVisualStyleBackColor = true;
            // 
            // grpbThongTinDG
            // 
            grpbThongTinDG.BackColor = Color.BurlyWood;
            grpbThongTinDG.Controls.Add(rbtnNu);
            grpbThongTinDG.Controls.Add(txtMaDocGia);
            grpbThongTinDG.Controls.Add(rbtnNam);
            grpbThongTinDG.Controls.Add(lblMaDocGia);
            grpbThongTinDG.Controls.Add(lblGioiTinh);
            grpbThongTinDG.Controls.Add(txtTenDangNhap);
            grpbThongTinDG.Controls.Add(txtDiaChi);
            grpbThongTinDG.Controls.Add(lblTenDangNhap);
            grpbThongTinDG.Controls.Add(lblDiaChi);
            grpbThongTinDG.Controls.Add(txtNamSinh);
            grpbThongTinDG.Controls.Add(lblSDT);
            grpbThongTinDG.Controls.Add(lblNamSinh);
            grpbThongTinDG.Controls.Add(lblHoTen);
            grpbThongTinDG.Controls.Add(txtSDT);
            grpbThongTinDG.Controls.Add(txtHoTen);
            grpbThongTinDG.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpbThongTinDG.Location = new Point(12, 12);
            grpbThongTinDG.Name = "grpbThongTinDG";
            grpbThongTinDG.Size = new Size(371, 304);
            grpbThongTinDG.TabIndex = 26;
            grpbThongTinDG.TabStop = false;
            grpbThongTinDG.Text = "Thông tin độc giả";
            grpbThongTinDG.Enter += grpbThongTinDG_Enter;
            // 
            // grpbTimKiem
            // 
            grpbTimKiem.BackColor = Color.BurlyWood;
            grpbTimKiem.Controls.Add(btnTimKiem);
            grpbTimKiem.Controls.Add(lblHT_TK);
            grpbTimKiem.Controls.Add(txtHT_TK);
            grpbTimKiem.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpbTimKiem.Location = new Point(402, 12);
            grpbTimKiem.Name = "grpbTimKiem";
            grpbTimKiem.Size = new Size(467, 99);
            grpbTimKiem.TabIndex = 27;
            grpbTimKiem.TabStop = false;
            grpbTimKiem.Text = "Tìm kiếm độc giả";
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = SystemColors.ButtonFace;
            btnTimKiem.Font = new Font("Times New Roman", 14.25F);
            btnTimKiem.Location = new Point(349, 27);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(112, 46);
            btnTimKiem.TabIndex = 28;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // lblHT_TK
            // 
            lblHT_TK.AutoSize = true;
            lblHT_TK.Font = new Font("Times New Roman", 12F);
            lblHT_TK.Location = new Point(21, 40);
            lblHT_TK.Name = "lblHT_TK";
            lblHT_TK.Size = new Size(68, 19);
            lblHT_TK.TabIndex = 5;
            lblHT_TK.Text = "Họ và tên";
            // 
            // txtHT_TK
            // 
            txtHT_TK.Font = new Font("Times New Roman", 12F);
            txtHT_TK.Location = new Point(105, 37);
            txtHT_TK.Name = "txtHT_TK";
            txtHT_TK.Size = new Size(221, 26);
            txtHT_TK.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.ButtonFace;
            btnRefresh.Font = new Font("Times New Roman", 14.25F);
            btnRefresh.Location = new Point(419, 339);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(112, 44);
            btnRefresh.TabIndex = 28;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // grpbThongTinTK
            // 
            grpbThongTinTK.BackColor = Color.BurlyWood;
            grpbThongTinTK.Controls.Add(txtMatKhau);
            grpbThongTinTK.Controls.Add(lblMatKhau);
            grpbThongTinTK.Controls.Add(txtMDG_TK);
            grpbThongTinTK.Controls.Add(lblMDG_TK);
            grpbThongTinTK.Controls.Add(txtVaiTro);
            grpbThongTinTK.Controls.Add(txtTDN_TK);
            grpbThongTinTK.Controls.Add(lblVaiTro);
            grpbThongTinTK.Controls.Add(lblTDN_TK);
            grpbThongTinTK.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpbThongTinTK.Location = new Point(402, 139);
            grpbThongTinTK.Name = "grpbThongTinTK";
            grpbThongTinTK.Size = new Size(467, 177);
            grpbThongTinTK.TabIndex = 27;
            grpbThongTinTK.TabStop = false;
            grpbThongTinTK.Text = "Thông tin tài khoản";
            // 
            // txtVaiTro
            // 
            txtVaiTro.Enabled = false;
            txtVaiTro.Font = new Font("Times New Roman", 12F);
            txtVaiTro.Location = new Point(124, 130);
            txtVaiTro.Name = "txtVaiTro";
            txtVaiTro.ReadOnly = true;
            txtVaiTro.Size = new Size(126, 26);
            txtVaiTro.TabIndex = 19;
            // 
            // lblVaiTro
            // 
            lblVaiTro.AutoSize = true;
            lblVaiTro.Font = new Font("Times New Roman", 12F);
            lblVaiTro.Location = new Point(19, 133);
            lblVaiTro.Name = "lblVaiTro";
            lblVaiTro.Size = new Size(49, 19);
            lblVaiTro.TabIndex = 20;
            lblVaiTro.Text = "Vai trò";
            // 
            // txtMDG_TK
            // 
            txtMDG_TK.Enabled = false;
            txtMDG_TK.Font = new Font("Times New Roman", 12F);
            txtMDG_TK.Location = new Point(124, 31);
            txtMDG_TK.Name = "txtMDG_TK";
            txtMDG_TK.ReadOnly = true;
            txtMDG_TK.Size = new Size(175, 26);
            txtMDG_TK.TabIndex = 26;
            // 
            // lblMDG_TK
            // 
            lblMDG_TK.AutoSize = true;
            lblMDG_TK.Font = new Font("Times New Roman", 12F);
            lblMDG_TK.Location = new Point(19, 34);
            lblMDG_TK.Name = "lblMDG_TK";
            lblMDG_TK.Size = new Size(78, 19);
            lblMDG_TK.TabIndex = 27;
            lblMDG_TK.Text = "Mã độc giả";
            // 
            // txtTDN_TK
            // 
            txtTDN_TK.Font = new Font("Times New Roman", 12F);
            txtTDN_TK.Location = new Point(124, 62);
            txtTDN_TK.Name = "txtTDN_TK";
            txtTDN_TK.Size = new Size(175, 26);
            txtTDN_TK.TabIndex = 28;
            // 
            // lblTDN_TK
            // 
            lblTDN_TK.AutoSize = true;
            lblTDN_TK.Font = new Font("Times New Roman", 12F);
            lblTDN_TK.Location = new Point(19, 65);
            lblTDN_TK.Name = "lblTDN_TK";
            lblTDN_TK.Size = new Size(98, 19);
            lblTDN_TK.TabIndex = 29;
            lblTDN_TK.Text = "Tên đăng nhập";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Enabled = false;
            txtMatKhau.Font = new Font("Times New Roman", 12F);
            txtMatKhau.Location = new Point(124, 95);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.ReadOnly = true;
            txtMatKhau.Size = new Size(126, 26);
            txtMatKhau.TabIndex = 30;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Times New Roman", 12F);
            lblMatKhau.Location = new Point(19, 98);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(67, 19);
            lblMatKhau.TabIndex = 31;
            lblMatKhau.Text = "Mật khẩu";
            // 
            // frmQLDocGia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(885, 700);
            Controls.Add(grpbThongTinTK);
            Controls.Add(btnRefresh);
            Controls.Add(grpbTimKiem);
            Controls.Add(grpbThongTinDG);
            Controls.Add(dgvQLDocGia);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Name = "frmQLDocGia";
            Text = "Quản lý độc giả";
            Load += frmQLDocGia_Load;
            ((System.ComponentModel.ISupportInitialize)dgvQLDocGia).EndInit();
            grpbThongTinDG.ResumeLayout(false);
            grpbThongTinDG.PerformLayout();
            grpbTimKiem.ResumeLayout(false);
            grpbTimKiem.PerformLayout();
            grpbThongTinTK.ResumeLayout(false);
            grpbThongTinTK.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtHoTen;
        private TextBox txtSDT;
        private TextBox txtNoiSinh;
        private TextBox txtEmail;
        private Label lblHoTen;
        private Label lblNamSinh;
        private Label lblSDT;
        private Label lblEmail;
        private Label lblNoiSinh;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private DataGridView dgvQLDocGia;
        private DateTimePicker dtpDoB;
        private Label lblMaDocGia;
        private TextBox txtMaDocGia;
        private Label lblTenDangNhap;
        private TextBox txtTenDangNhap;
        private TextBox txtNamSinh;
        private TextBox txtDiaChi;
        private Label lblDiaChi;
        private Label lblGioiTinh;
        private RadioButton rbtnNam;
        private RadioButton rbtnNu;
        private GroupBox grpbThongTinDG;
        private GroupBox grpbTimKiem;
        private Label lblHT_TK;
        private TextBox txtHT_TK;
        private Button btnTimKiem;
        private Button btnRefresh;
        private GroupBox grpbThongTinTK;
        private TextBox txtVaiTro;
        private Label lblVaiTro;
        private TextBox txtMatKhau;
        private Label lblMatKhau;
        private TextBox txtMDG_TK;
        private Label lblMDG_TK;
        private TextBox txtTDN_TK;
        private Label lblTDN_TK;
    }
}
