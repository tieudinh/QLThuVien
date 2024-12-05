create database QLTV;
use QLTV;

CREATE TABLE Books (
    BookID INT PRIMARY KEY IDENTITY(1,1),
    Title NVARCHAR(255) NOT NULL,
    Author NVARCHAR(255),
    Publisher NVARCHAR(255),
    Year INT,
    CategoryID INT FOREIGN KEY REFERENCES Categories(CategoryID) on delete cascade,
    Quantity INT NOT NULL
);
select * from Books
CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY IDENTITY(1,1),
    CategoryName NVARCHAR(255) NOT NULL
);

select * from Categories

CREATE TABLE Readers (
    ReaderID INT PRIMARY KEY IDENTITY(1,1),
    UserName NVARCHAR(100) NOT NULL UNIQUE,
    PassWord NVARCHAR(10) NOT NULL UNIQUE,
    --FullName NVARCHAR(255) NOT NULL,
    DOB DATE,
    PhoneNumber NVARCHAR(15),
    Email NVARCHAR(255),
    Address NVARCHAR(255)
);

CREATE TABLE BorrowRecords (
    BorrowID INT PRIMARY KEY IDENTITY(1,1),
    ReaderID INT FOREIGN KEY REFERENCES Readers(ReaderID) on delete cascade,
    BookID INT FOREIGN KEY REFERENCES Books(BookID) on delete cascade ,
    BorrowDate DATE NOT NULL,
    ReturnDate DATE,
    Status NVARCHAR(50) NOT NULL
);
CREATE TABLE Staff (
    StaffID INT PRIMARY KEY IDENTITY(1,1),
    FullName NVARCHAR(255) NOT NULL,
    Username NVARCHAR(100) NOT NULL UNIQUE,
    Password NVARCHAR(255) NOT NULL,
    Role NVARCHAR(50) NOT NULL
);
select * from Categories
INSERT INTO Categories (CategoryName)VALUES 
('Khoa hoc vien tuong'),
('Kinh te hoc'),
('Y hoc'),
('Tam Ly hoc'),
('Nghe Thuat');

INSERT INTO Books (Title, Author, Publisher, Year, CategoryID, Quantity)VALUES
('Dune', 'Frank Herbert', 'Chilton Books', 1965, 6, 7),
('Principles of Economics', 'N. Gregory Mankiw', 'Cengage', 2020, 7, 5),
('Gray''s Anatomy', 'Henry Gray', 'Elsevier', 2019, 8, 10),
('Thinking, Fast and Slow', 'Daniel Kahneman', 'Farrar, Straus and Giroux', 2011, 9, 8),
('The Art of War', 'Sun Tzu', 'Oxford University Press', 2005, 10, 12);


INSERT INTO Readers (FullName, DOB, PhoneNumber, Email, Address)VALUES
('Phạm Văn E', '1992-07-10', '0934567890', 'phamvane@gmail.com', 'Đà Nẵng'),
('Trần Thị F', '1988-11-25', '0945678901', 'tranthif@gmail.com', 'Hà Nội'),
('Hoàng Minh G', '2001-05-15', '0956789012', 'hoangminhg@gmail.com', 'Hồ Chí Minh'),
('Ngô Thị H', '1990-02-20', '0967890123', 'ngothih@gmail.com', 'Huế'),
('Lý Văn K', '1997-09-30', '0978901234', 'lyvank@gmail.com', 'Cần Thơ');

INSERT INTO BorrowRecords (ReaderID, BookID, BorrowDate, ReturnDate, Status)VALUES
(1, 1, '2024-11-01', '2024-11-10', 'Đã trả'),
(2, 2, '2024-11-05', NULL, 'Chưa trả'),
(3, 3, '2024-11-07', '2024-11-15', 'Đã trả'),
(4, 4, '2024-11-10', NULL, 'Chưa trả'),
(5, 5, '2024-11-12', NULL, 'Chưa trả');

INSERT INTO Staff (FullName, Username, Password, Role)VALUES
('Nguyễn Văn M', 'nvmanh', 'password123', 'User'),
('Lê Thị N', 'lthinh', 'lethi@123', 'User'),
('Phạm Quốc P', 'pqphat', 'passphat', 'User'),
('Đặng Thị Q', 'dtquyen', 'quyen!pass', 'User'),
('Trương Văn R', 'tvrang', 'rang@2024', 'Admin');

select * from Books

update Books  set Quantity = Quantity - 1
where Title = 'Dune';
