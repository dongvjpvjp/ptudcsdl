
CREATE DATABASE CSKH_OTO
ON   
( NAME = CSKH_OTO_dat,  
    FILENAME = 'D:\Workspace\Visual Studio\CSKH_SALONOTO\SQL\CSKH_OTO.mdf'
     )  
LOG ON  
( 
	NAME = CSKH_OTO_log,  
    FILENAME = 'D:\Workspace\Visual Studio\CSKH_SALONOTO\SQL\CSKH_OTO.ldf' 
     ) ;  
GO  
use CSKH_OTO;
/*use schema dbo;
không cần thiết tạo và phân quyền schema mới*/

create table NCC(
Ma_NCC char(10) primary key not null,
Ten_NCC NVARCHAR(50) not null,
Dc_NCC NVARCHAR(100),
Sdt_NCC char(11),
Mota_NCC Nvarchar(100)
);

create table XE(
Ma_Xe char(10) primary key not null,
Ten_XE NVARCHAR(50) not null,
Giatri_XE MONEY, 
Mota_XE NVARCHAR(100),
Ma_NCC char(10)
constraint FK_XE_NCC foreign key (MA_NCC) References NCC(Ma_NCC)
);

create table KH(
Ma_KH char(10) Primary key not null,
Ten_KH NVARCHAR(50) not null,
Dt_KH char(13),
Dc_KH NVARCHAR(100),
Cmnd_KH char(13),
Ma_XE char(10) not null
constraint FK_KH_XE
foreign key (Ma_XE) REFERENCEs XE(Ma_XE)
);

create table FCSKH(
Ma_FCSKH char(10) primary key not null,
Ma_KH char(10) not null
constraint FK_FCSKH_KH foreign key (Ma_KH) References KH(Ma_KH),
Ma_XE char(10) not null
constraint FK_FCSKH_XE foreign key (Ma_XE) References XE(Ma_XE),
Nd_FCSKH NVARCHAR(100),
Ngaylap_FCSKH date,
Tinhtrang_FCSKH Nvarchar(50),
);
create table NV
(
Ma_NV char(10) primary key not null,
Ten_NV NVARCHAR(50) not null,
Sdt_NV char(13),
Dc_NV NVARCHAR(100),
Cmnd_NV char(13)
)


create table Hinhthuc_CSKH
(
Ma_HT char(10) primary key not null,
Ten_HT NVARCHAR(50) not null,
Mota_HT NVARCHAR(100)
)
create table FCSKHCT
(
Ma_FCSKHCT char(10) primary key not null,
Ma_FCSKH char(10) not null constraint FK_FCSKHCT_FCSKH foreign key (MA_FCSKH) References FCSKH(MA_FCSKH),
Nd_FCSKHCT NVARCHAR(100),
Ngayhen_FCSKHT date,
Ma_HT char(10) constraint FK_FCSKHCT_Hinhthuc foreign key (Ma_HT) References Hinhthuc_CSKH(Ma_HT),
Ma_NV char(10) constraint FK_NV_FCSKHCT foreign key (Ma_NV) References NV(Ma_NV),
StartTime_FCSKHCT datetime,
FinishTime_FCSKHCT datetime
)
GO
create view View_FCSKH AS
SELECT        dbo.FCSKH.Ma_FCSKH, dbo.KH.Ten_KH, dbo.XE.Ten_XE, dbo.FCSKH.Nd_FCSKH, dbo.FCSKH.Ngaylap_FCSKH, dbo.FCSKH.Tinhtrang_FCSKH
FROM            dbo.FCSKH INNER JOIN
                         dbo.KH ON dbo.FCSKH.Ma_KH = dbo.KH.Ma_KH INNER JOIN
                         dbo.XE ON dbo.FCSKH.Ma_XE = dbo.XE.Ma_Xe AND dbo.KH.Ma_XE = dbo.XE.Ma_Xe;
GO						
create view View_FCSKHCT AS
SELECT        dbo.FCSKHCT.Ma_FCSKHCT, dbo.NV.Ten_NV, dbo.Hinhthuc_CSKH.Ten_HT, dbo.FCSKHCT.Nd_FCSKHCT, dbo.FCSKHCT.Ngayhen_FCSKHT, dbo.FCSKHCT.StartTime_FCSKHCT, dbo.FCSKHCT.FinishTime_FCSKHCT, 
                         dbo.FCSKHCT.Ma_FCSKH
FROM            dbo.FCSKHCT INNER JOIN
                         dbo.Hinhthuc_CSKH ON dbo.FCSKHCT.Ma_HT = dbo.Hinhthuc_CSKH.Ma_HT INNER JOIN
                         dbo.NV ON dbo.FCSKHCT.Ma_NV = dbo.NV.Ma_NV
GO
create view View_KH AS
SELECT        dbo.KH.Ma_KH, dbo.KH.Ten_KH, dbo.XE.Ten_XE, dbo.KH.Dt_KH, dbo.KH.Dc_KH, dbo.KH.Cmnd_KH
FROM            dbo.KH INNER JOIN
                         dbo.XE ON dbo.KH.Ma_XE = dbo.XE.Ma_Xe
GO
create view View_XE AS 
SELECT        dbo.XE.Ma_Xe, dbo.XE.Ten_XE, dbo.NCC.Ten_NCC, dbo.XE.Giatri_XE, dbo.XE.Mota_XE
FROM            dbo.NCC INNER JOIN
                         dbo.XE ON dbo.NCC.Ma_NCC = dbo.XE.Ma_NCC;
GO
create view View_XEKH AS
SELECT        dbo.XE.Ma_Xe, dbo.XE.Ten_XE, dbo.KH.Ma_KH
FROM            dbo.KH INNER JOIN
                         dbo.XE ON dbo.KH.Ma_XE = dbo.XE.Ma_Xe
GO
;
insert into NCC(Ma_NCC,Ten_NCC,Dc_NCC,Sdt_NCC,Mota_NCC) values ('NCC01',N'HonDaFast',N'Số 155 Phố Hạnh Phúc','0123456789',N'Nhà cung cấp chuyên cung cấp xe ô tô honda chất lượng cao cho phái mạnh');
insert into NCC(Ma_NCC,Ten_NCC,Dc_NCC,Sdt_NCC,Mota_NCC) values ('NCC02',N'MisubishiFast',N'Số 156 Phố Hạnh Phúc','0133456789',N'Nhà cung cấp chuyên cung cấp xe ô tô Mitsubishi chuyên nghiệp đẳng cấp cho các dân chơi');
insert into NCC(Ma_NCC,Ten_NCC,Dc_NCC,Sdt_NCC,Mota_NCC) values ('NCC03',N'VinFast',N'Số 158 Phố Hạnh Phúc','0123455789',N'Nhà cung cấp chuyên cung cấp xe ô tô vinfast 7 màu cho những người đặc biệt');

insert into XE(Ma_Xe,Ten_XE,Giatri_XE,Mota_XE,Ma_NCC) values ('HD01',N'Honda3099',800000000,N'Xe honda mẫu 3099 đẳng cấp thế giới, yên xe được bọc da thú, động cơ hơn 1 tỷ mã lực','NCC01');
insert into XE(Ma_Xe,Ten_XE,Giatri_XE,Mota_XE,Ma_NCC) values ('MSBS01',N'Mishubishi9599',888888,N'Xe mishubishi mẫu 3099 với khung xe được gia cố bằng kim cương, chứng tỏ đẳng cấp của các dân chơi','NCC02');
insert into XE(Ma_Xe,Ten_XE,Giatri_XE,Mota_XE,Ma_NCC) values ('VF01',N'Vinfast953099',909090999,N'Xe vinfast mẫu 953099 mẫu xe đầu tiên được người việt xuất khẩu, với hệ thống auto drive tân tiến','NCC03');

insert into KH(Ma_KH,Ten_KH,Ma_XE,Dt_KH,Dc_KH,Cmnd_KH) values ('KH01',N'Đông','HD01','0528455877',N'Số 3/5/45 Kiều Sơn','000111222333');
insert into KH(Ma_KH,Ten_KH,Ma_XE,Dt_KH,Dc_KH,Cmnd_KH) values ('KH02',N'Đức','MSBS01','1234567890',N'Số 33333 Hải Phòng','111000222333');
insert into KH(Ma_KH,Ten_KH,Ma_XE,Dt_KH,Dc_KH,Cmnd_KH) values ('KH03',N'Huy','VF01','0987654321',N'Số 44444 Hải Phòng','000111000333');

insert into NV(Ma_NV,Ten_NV,Dc_NV,Sdt_NV,Cmnd_NV) values ('NV01',N'NVĐông',N'Số 3/5/45 Kiều Sơn','0373664313','111000999111');
insert into NV(Ma_NV,Ten_NV,Dc_NV,Sdt_NV,Cmnd_NV) values ('NV02',N'NVMĐức',N'Số 3343453 Hải Phòng','1231231234','000999111222');
insert into NV(Ma_NV,Ten_NV,Dc_NV,Sdt_NV,Cmnd_NV) values ('NV03',N'NVQHuy',N'Số 394839 Hải Phòng','2323323321','555444333222');

insert into Hinhthuc_CSKH(Ma_HT,Ten_HT,Mota_HT) values ('HT01',N'Email',N'Chăm sóc khách hàng bằng email qua hệ thống thư tín');
insert into Hinhthuc_CSKH(Ma_HT,Ten_HT,Mota_HT) values ('HT02',N'Trực tiếp',N'Chăm sóc khách hàng bằng hệ thống trò chuyền trực quan qua di động');
insert into Hinhthuc_CSKH(Ma_HT,Ten_HT,Mota_HT) values ('HT03',N'Phone',N'Chăm sóc khách hàng trực tiếp tại salon');

insert into FCSKH(Ma_FCSKH,Ma_KH,Ma_XE,Nd_FCSKH,Ngaylap_FCSKH,Tinhtrang_FCSKH) values ('FCS01','KH01','HD01',N'Xe có vấn đề về nội thất và ngoại thất','1999-5-9',N'Đang xử lý');
insert into FCSKH(Ma_FCSKH,Ma_KH,Ma_XE,Nd_FCSKH,Ngaylap_FCSKH,Tinhtrang_FCSKH) values ('FCS02','KH02','MSBS01',N'Xe có vấn đề về ngoại thất','2000-5-9',N'Đang xử lý');
insert into FCSKH(Ma_FCSKH,Ma_KH,Ma_XE,Nd_FCSKH,Ngaylap_FCSKH,Tinhtrang_FCSKH) values ('FCS03','KH03','VF01',N'Xe có vấn đề về nội thất ','2001-5-9',N'Đang xử lý');

insert into FCSKHCT(Ma_FCSKHCT,Ma_FCSKH,Nd_FCSKHCT,Ngayhen_FCSKHT,Ma_HT,Ma_NV,StartTime_FCSKHCT,FinishTime_FCSKHCT) values ('FCT01','FCS01',N'Sửa và hoàn thiện nội thất','2000-05-09','HT01','NV01','2000-05-09 08:00:00','2000-05-09 09:00:00');
insert into FCSKHCT(Ma_FCSKHCT,Ma_FCSKH,Nd_FCSKHCT,Ngayhen_FCSKHT,Ma_HT,Ma_NV,StartTime_FCSKHCT,FinishTime_FCSKHCT) values ('FCT02','FCS01',N'Sửa và hoàn thiện ngoại thất','2001-05-09','HT02','NV02','2001-05-09 08:00:00','2001-05-09 09:00:00');
insert into FCSKHCT(Ma_FCSKHCT,Ma_FCSKH,Nd_FCSKHCT,Ngayhen_FCSKHT,Ma_HT,Ma_NV,StartTime_FCSKHCT,FinishTime_FCSKHCT) values ('FCT03','FCS01',N'Hoàn thiện những phần còn sót lại','2002-05-09','HT03','NV03','2002-05-09 08:00:00','2002-05-09 09:00:00');

insert into FCSKHCT(Ma_FCSKHCT,Ma_FCSKH,Nd_FCSKHCT,Ngayhen_FCSKHT,Ma_HT,Ma_NV,StartTime_FCSKHCT,FinishTime_FCSKHCT) values ('FCT04','FCS02',N'Sửa và hoàn thiện nội thất','2001-05-09','HT01','NV01','2001-05-09 08:00:00','2001-05-09 09:00:00');
insert into FCSKHCT(Ma_FCSKHCT,Ma_FCSKH,Nd_FCSKHCT,Ngayhen_FCSKHT,Ma_HT,Ma_NV,StartTime_FCSKHCT,FinishTime_FCSKHCT) values ('FCT05','FCS02',N'Sửa và hoàn thiện ngoại thất','2002-05-09','HT02','NV02','2002-05-09 08:00:00','2002-05-09 09:00:00');
insert into FCSKHCT(Ma_FCSKHCT,Ma_FCSKH,Nd_FCSKHCT,Ngayhen_FCSKHT,Ma_HT,Ma_NV,StartTime_FCSKHCT,FinishTime_FCSKHCT) values ('FCT06','FCS02',N'Hoàn thiện những phần còn sót lại','2003-05-09','HT03','NV03','2003-05-09 08:00:00','2003-05-09 09:00:00');

insert into FCSKHCT(Ma_FCSKHCT,Ma_FCSKH,Nd_FCSKHCT,Ngayhen_FCSKHT,Ma_HT,Ma_NV,StartTime_FCSKHCT,FinishTime_FCSKHCT) values ('FCT07','FCS03',N'Sửa và hoàn thiện nội thất','2002-05-09','HT01','NV01','2002-05-09 08:00:00','2002-05-09 09:00:00');
insert into FCSKHCT(Ma_FCSKHCT,Ma_FCSKH,Nd_FCSKHCT,Ngayhen_FCSKHT,Ma_HT,Ma_NV,StartTime_FCSKHCT,FinishTime_FCSKHCT) values ('FCT08','FCS03',N'Sửa và hoàn thiện ngoại thất','2003-05-09','HT02','NV02','2003-05-09 08:00:00','2003-05-09 09:00:00');
insert into FCSKHCT(Ma_FCSKHCT,Ma_FCSKH,Nd_FCSKHCT,Ngayhen_FCSKHT,Ma_HT,Ma_NV,StartTime_FCSKHCT,FinishTime_FCSKHCT) values ('FCT09','FCS03',N'Hoàn thiện những phần còn sót lại','2004-05-09','HT03','NV03','2004-05-09 08:00:00','2004-05-09 09:00:00');

