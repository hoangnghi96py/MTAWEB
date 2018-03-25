USE MtaWeb
CREATE TABLE ADMIN  (
id INT IDENTITY(1,1) PRIMARY KEY,
name NVARCHAR(50),
username NCHAR(15),
deparment NVARCHAR(50),
password NCHAR(15),
active BIT   --kich hoat tai khoan hay khong
)
GO 
CREATE TABLE CATEGOTY(
id INT IDENTITY(1,1) PRIMARY KEY,
name NVARCHAR(250),
lever INT,-- phan cap nhom tin

)
GO

CREATE TABLE SUBCATEGOTY(
id INT IDENTITY(1,1) PRIMARY KEY,
name NVARCHAR(250),
lever INT,-- phan cap nhom tin
idCategory INT FOREIGN KEY REFERENCES dbo.CATEGOTY(id)
)
GO

CREATE TABLE UNITCATEGOTY(
id INT IDENTITY(1,1) PRIMARY KEY,
name NVARCHAR(250),
lever INT,-- phan cap nhom tin
idSubCategory INT FOREIGN KEY REFERENCES dbo.SUBCATEGOTY(id)
)

CREATE TABLE NEWS(
id INT IDENTITY(1,1) PRIMARY KEY,
name NVARCHAR(250),  -- tieu de
picture NVARCHAR(250), -- anh dai dien
content NTEXT,-- mo ta ben ngoai
detail NTEXT, -- noi dung chi tie
avtive BIT, -- kich hoat khong
dateup date, -- ngay dang
tacgia NVARCHAR(250),
nguoidang INT FOREIGN KEY REFERENCES dbo.ADMIN(id), -- nguoi dang
idSubCategory INT FOREIGN KEY REFERENCES  dbo.SUBCATEGOTY(id),
idUnitCategory INT FOREIGN KEY REFERENCES dbo.UNITCATEGOTY(id)
)
GO 

GO
CREATE TABLE PICTURE(
idPicture INT IDENTITY(1,1) PRIMARY KEY,
linkPicture NCHAR(250),
idNews INT FOREIGN KEY REFERENCES dbo.NEWS(id)
)

GO

INSERT dbo.NEWS
        ( 
          name ,
          picture ,
          content ,
          detail ,
          avtive ,
          dateup ,
          tacgia ,
          nguoidang ,
          idSubCategory ,
          idUnitCategory
        )
VALUES  ( 
          N'Thong bao 1' , -- name - nvarchar(250)
          N'' , -- picture - nvarchar(250)
          'Day la thong bao 1' , -- content - ntext
          'Day la chi tiet thong bao 1' , -- detail - ntext
          NULL , -- avtive - bit
          GETDATE() , -- dateup - date
          N'' , -- tacgia - nvarchar(250)
          0 , -- nguoidang - int
          0 , -- idSubCategory - int
          0  -- idUnitCategory - int
        )
		( 
          N'Thong bao 2' , -- name - nvarchar(250)
          N'' , -- picture - nvarchar(250)
          'Day la thong bao 2' , -- content - ntext
          'Day la chi tiet thong bao 2' , -- detail - ntext
          NULL , -- avtive - bit
          GETDATE() , -- dateup - date
          N'' , -- tacgia - nvarchar(250)
          0 , -- nguoidang - int
          0 , -- idSubCategory - int
          0  -- idUnitCategory - int
        )
		( 
          N'Thong bao 3' , -- name - nvarchar(250)
          N'' , -- picture - nvarchar(250)
          'Day la thong bao 3' , -- content - ntext
          'Day la chi tiet thong bao 3' , -- detail - ntext
          NULL , -- avtive - bit
          GETDATE() , -- dateup - date
          N'' , -- tacgia - nvarchar(250)
          0 , -- nguoidang - int
          0 , -- idSubCategory - int
          0  -- idUnitCategory - int
        )


