create database QLThuVien
drop database QLThuVien
use QLThuVien

create table Sach(
MaSach nchar(10) primary key not null,
TenSach nvarchar(255),
TacGia nvarchar(255),
TheLoai nvarchar(255),
NhaXuatBan nvarchar(255),
GiaSach int,
TinhTrang nvarchar(255))


create table DocGia(
MaDocGia nchar(10) primary key not null,
TenDangNhap nchar(10) unique,
HoTen nvarchar(255),
GioiTinh nvarchar(10),
NamSinh int,
DiaChi nvarchar(255),
SDT nvarchar(255))

create table TaiKhoan(
MaDocGia nchar(10) foreign key (MaDocGia) references DocGia(MaDocGia) on delete cascade,
TenDangNhap nchar(10) not null unique,
MatKhau nchar(10) not null unique,
VaiTro int)

create table PhieuMuon(
MaPhieu nchar(10) primary key not null,
MaDocGia nchar(10) foreign key (MaDocGia) references DocGia(MaDocGia) on delete cascade,
MaSach nchar(10) foreign key (MaSach) references Sach(MaSach) on delete cascade,
NgayMuon datetime,
NgayPhaiTra datetime)

create table PhieuTra(
MaPhieu nchar(10) primary key not null,
MaDocGia nchar(10) foreign key (MaDocGia) references DocGia(MaDocGia) on delete cascade,
MaSach nchar(10) foreign key (MaSach) references Sach(MaSach) on delete cascade,
NgayTra datetime)

insert into Sach(MaSach, TenSach, TacGia, TheLoai, NhaXuatBan, GiaSach, TinhTrang) values
('MS01', 'Cong Nghe Thong Tin I','Nguyen Van A', 'Khoa Học', 'GDDDT','70000','Còn'),
('MS02', 'Thong Tin II','Nguyen Van B', 'Giáo Dục', 'TPHCM','80000','Còn'),
('MS03', 'Cong Nghe ','Lam Vy A', 'Tự nhiên', 'DHSP','90000','Còn'),
('MS04', 'Cong Nghe Thong Tin VI','Tran Thanh T', 'Khoa Học', 'KT','50000','Hết');

insert into DocGia(MaDocGia, TenDangNhap, HoTen, GioiTinh, NamSinh, DiaChi, SDT) values
('DG1', '23van2', 'Nguyen Van A', 'Nam','2004', '280 An Duong Vuong', '0121012000'),
('DG2', 'uyen3van2', 'Uuyen Van', 'Nam','2004', 'Q5, TPHCM', '0121012666'),
('DG3', 'nguyen22', 'Nguyen A', 'Nữ','2006', 'Q11', '0121011457'),
('DG4', 'uyen23van2', 'Van Anh', 'Nữ','2005', 'KTX', '0121012250');


insert into TaiKhoan(MaDocGia, TenDangNhap, MatKhau, VaiTro) values
('DG1', '23van2','123', '1'),
('DG2', 'uyen3van2','456', '1'),
('DG3', 'nguyen22','789', '2'),
('DG4', 'uyen23van2','666', '2');

insert into PhieuMuon(MaPhieu, MaDocGia, MaSach, NgayMuon, NgayPhaiTra) values
('MP01', 'DG1', 'MS01', '2024-12-20', '2024-12-25'),
('MP011', 'DG2', 'MS01', '2024-12-10', '2024-12-20'),
('MP03', 'DG3', 'MS02', '2024-12-20', '2024-12-30'),
('MP033', 'DG1', 'MS03', '2024-12-20', '2024-12-30'),
('MP02', 'DG2', 'MS01', '2024-12-15', '2024-12-25');

insert into PhieuTra(MaPhieu, MaDocGia, MaSach,NgayTra) values
('MP01', 'DG1', 'MS01','2024-12-30'),
('MP011', 'DG2', 'MS01', '2024-12-20'),
('MP03', 'DG1', 'MS02', '2024-12-30'),
('MP033', 'DG1', 'MS03', '2024-12-30'),
('MP02', 'DG1', 'MS01', '2024-12-30');

select * from PhieuMuon;
SELECT * FROM DocGia WHERE MaDocGia = 'DG2';
delete from PhieuMuon where MaPhieu = 'MP033' 

select * from PhieuMuon where MaPhieu = 'MP02' 
SELECT * FROM Sach WHERE MaSach = 'MP02';
select * from PhieuTra;

