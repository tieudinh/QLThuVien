create database QLTV;
use QLPhieu

create table TheLoai(
MaTheLoai varchar(6) primary key, --Ma The Loai bat dau bang chu "TL" 
TenTheLoai nvarchar(100)
);
select * from TheLoai
insert into TheLoai(MaTheLoai, TenTheLoai) values
('TL1','Tình cảm'),
('TL2','Trinh thám'),
('TL3','Kinh dị'),
('TL4','Viễn tưởng'),
('TL5','Giáo dục');

create table Sach(
MaSach varchar(6) primary key, -- Ma Sach bat dau bang ki tu "S"
TenSach nvarchar(255),
MaTheLoai varchar(6) foreign key (MaTheLoai) references TheLoai(MaTheLoai) on delete cascade,
TacGia nvarchar(255), 
NhaXuatBan nvarchar(255),
NamXuatBan int
);

create table DocGia(
MaDocGia varchar(6) primary key, --Ma Doc gia bat dau bang DG
HoTen nvarchar(255),
Username nvarchar(10) unique,
Password nvarchar(10) unique,
NgaySinh date, 
SoDienThoai nvarchar(255),
Email nvarchar(255),
DiaChi nvarchar(255)
)

select * from DocGia
insert into DocGia(MaDocGia, HoTen, NgaySinh, SoDienThoai, Email, DiaChi, Username, Password) values
('DG1', 'Nguyen Van A', '01-01-2000', '01111111111', 'anguyenvan@gmail.com','280 An Duong Vuong, P4, Q5, TPHCM','anv123', '01012000')

create table NhanVien(
MaNhanVien varchar(6) primary key, --Ma Nhan vien bat dau bang chu NV
HoTen nvarchar(255),
NgaySinh date,
Username nvarchar(10) unique,
Password nvarchar(10) unique,
SoDienThoai nvarchar(255),
Email nvarchar(255),
DiaChi nvarchar(255)
)

insert into NhanVien(MaNhanVien, HoTen, NgaySinh, Username, Password, Email, SoDienThoai, DiaChi)values
('NV1', 'Tran Van B', '01-01-1999', 'btranvan12', '123456', 'tranvanb123@gmail.com', '0222222222', '222 Le Van Sy, Q3')


create table GiaoDichMuonSach(
MaTheMuon varchar(6) primary key, --Ma the muon bat dau bang chu TM
MaDocGia varchar(6) foreign key (MaDocGia) references DocGia(MaDocGia) on delete cascade,
MaSach varchar(6) foreign key (MaSach) references Sach(MaSach) on delete cascade,
NgayMuon date,
NgayTraDuKien date,
NgayTraThucTe date,
TrangThai nvarchar(255)
)

select * from GiaoDichMuonSach
insert into GiaoDichMuonSach(MaTheMuon, MaDocGia, MaSach, NgayMuon, NgayTraDuKien, NgayTraThucTe, TrangThai)values
('TM1', 'DG1', 'S1', '2024-12-20', '2024-12-27', '2024-12-30', 'Chua Tra')



create table TienPhat( -- Khong co Khoa chinh
MaTheMuon varchar(6) foreign key (MaTheMuon) references GiaoDichMuonSach(MaTheMuon),
SoTienPhat real,
TrangThaiThanhToan nvarchar(255)
);
select * from TienPhat
insert into TienPhat(MaTheMuon, SoTienPhat, TrangThaiThanhToan)values
('TM1', 3*10000, 'Chua Thanh Toan')

