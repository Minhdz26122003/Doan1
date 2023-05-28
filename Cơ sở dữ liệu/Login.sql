USE [QLQTS]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[Login]
	@Taikhoan varchar(20),
	@Matkhau varchar(50)
AS
BEGIN	
	Select * from Taikhoan where Taikhoan=@Taikhoan and Matkhau=@Matkhau
END