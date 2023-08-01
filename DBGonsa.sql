USE master
CREATE DATABASE GONSA
GO

USE GONSA
GO

-- Table
CREATE TABLE User_Middleware(
	Username varchar(50) NOT NULL PRIMARY KEY,
	Passwd varchar(100) NOT NULL,
	Ma_Nhan_Vien varchar(20),
	User_Privilege varchar(50),
	Note nvarchar(1000),
);
GO

CREATE TABLE CBNV_Gonsa(
	Ma_Nhan_Vien varchar(20) NOT NULL PRIMARY KEY,
	Ten_Nhan_Vien nvarchar(200),
	Phong_Ban nvarchar(500),
	Chuc_Vu nvarchar(500),
	Email varchar(200),
	So_DT varchar(20)
);
GO

-- Constraint
ALTER TABLE User_Middleware
ADD CONSTRAINT FK_MaNhanVien
FOREIGN KEY (Ma_Nhan_Vien) REFERENCES CBNV_Gonsa(Ma_Nhan_Vien)
GO

-- Insert CBNV_Gonsa
INSERT INTO CBNV_Gonsa(Ma_Nhan_Vien,Ten_Nhan_Vien,Phong_Ban,Chuc_Vu,Email,So_DT)
VALUES ('001',N'Ngô Trịnh Hoàng Khánh',N'Middleware',N'Thực tập sinh','khanh@gmail.com','0982266104')
INSERT INTO CBNV_Gonsa(Ma_Nhan_Vien,Ten_Nhan_Vien,Phong_Ban,Chuc_Vu,Email,So_DT)
VALUES ('002',N'Ngô Trịnh Hoàng Khánh2',N'Middleware',N'Thực tập sinh','khanh@gmail.com','0982266104')
INSERT INTO CBNV_Gonsa(Ma_Nhan_Vien,Ten_Nhan_Vien,Phong_Ban,Chuc_Vu,Email,So_DT)
VALUES ('003',N'Ngô Trịnh Hoàng Khánh3',N'Middleware',N'Thực tập sinh','khanh@gmail.com','0982266104')
INSERT INTO CBNV_Gonsa(Ma_Nhan_Vien,Ten_Nhan_Vien,Phong_Ban,Chuc_Vu,Email,So_DT)
VALUES ('004',N'Ngô Trịnh Hoàng Khánh4',N'Middleware',N'Thực tập sinh','khanh@gmail.com','0982266104')
INSERT INTO CBNV_Gonsa(Ma_Nhan_Vien,Ten_Nhan_Vien,Phong_Ban,Chuc_Vu,Email,So_DT)
VALUES ('005',N'Ngô Trịnh Hoàng Khánh5',N'Middleware',N'Thực tập sinh','khanh@gmail.com','0982266104')
INSERT INTO CBNV_Gonsa(Ma_Nhan_Vien,Ten_Nhan_Vien,Phong_Ban,Chuc_Vu,Email,So_DT)
VALUES ('006',N'Ngô Trịnh Hoàng Khánh6',N'Middleware',N'Thực tập sinh','khanh@gmail.com','0982266104')
INSERT INTO CBNV_Gonsa(Ma_Nhan_Vien,Ten_Nhan_Vien,Phong_Ban,Chuc_Vu,Email,So_DT)
VALUES ('007',N'Ngô Trịnh Hoàng Khánh7',N'Middleware',N'Thực tập sinh','khanh@gmail.com','0982266104')
INSERT INTO CBNV_Gonsa(Ma_Nhan_Vien,Ten_Nhan_Vien,Phong_Ban,Chuc_Vu,Email,So_DT)
VALUES ('008',N'Ngô Trịnh Hoàng Khánh8',N'Middleware',N'Thực tập sinh','khanh@gmail.com','0982266104')
INSERT INTO CBNV_Gonsa(Ma_Nhan_Vien,Ten_Nhan_Vien,Phong_Ban,Chuc_Vu,Email,So_DT)
VALUES ('009',N'Ngô Trịnh Hoàng Khánh9',N'Middleware',N'Thực tập sinh','khanh@gmail.com','0982266104')
INSERT INTO CBNV_Gonsa(Ma_Nhan_Vien,Ten_Nhan_Vien,Phong_Ban,Chuc_Vu,Email,So_DT)
VALUES ('010',N'Ngô Trịnh Hoàng Khánh10',N'Middleware',N'Thực tập sinh','khanh@gmail.com','0982266104')
GO

-- Insert User_Middleware
INSERT INTO User_Middleware(Username,Passwd,Ma_Nhan_Vien,User_Privilege,Note)
VALUES ('khanh001','1','001','admin',N'')
INSERT INTO User_Middleware(Username,Passwd,Ma_Nhan_Vien,User_Privilege,Note)
VALUES ('khanh002','1','002','user',N'')
INSERT INTO User_Middleware(Username,Passwd,Ma_Nhan_Vien,User_Privilege,Note)
VALUES ('khanh003','1','003','user',N'')
INSERT INTO User_Middleware(Username,Passwd,Ma_Nhan_Vien,User_Privilege,Note)
VALUES ('khanh004','1','004','user',N'')
INSERT INTO User_Middleware(Username,Passwd,Ma_Nhan_Vien,User_Privilege,Note)
VALUES ('khanh005','1','005','user',N'')
INSERT INTO User_Middleware(Username,Passwd,Ma_Nhan_Vien,User_Privilege,Note)
VALUES ('khanh006','1','006','user',N'')
INSERT INTO User_Middleware(Username,Passwd,Ma_Nhan_Vien,User_Privilege,Note)
VALUES ('khanh007','1','007','user',N'')
INSERT INTO User_Middleware(Username,Passwd,Ma_Nhan_Vien,User_Privilege,Note)
VALUES ('khanh008','1','008','user',N'')
INSERT INTO User_Middleware(Username,Passwd,Ma_Nhan_Vien,User_Privilege,Note)
VALUES ('khanh009','1','009','user',N'')
INSERT INTO User_Middleware(Username,Passwd,Ma_Nhan_Vien,User_Privilege,Note)
VALUES ('khanh010','1','010','user',N'')
GO

