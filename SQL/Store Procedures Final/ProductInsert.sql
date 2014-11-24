USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_Product]    Script Date: 26/09/2014 02:26:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[f_Admin_Insert_Product]
			@Products int,
		@ProductDescription varchar(50),
		@Price decimal(18,2),
		@Quantity int,
		@Total int,
		@BTW decimal(18,2),
		@CreatedDate datetime,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int,
		@Removed bit

	
AS
INSERT INTO [dbo].[t_Product] 
		([Product]
      ,[ProductDescription]
      ,[Price]
      ,[Quantity]
      ,[Total]
      ,[BTW]
      ,[CreatedDate]
      ,[CompanyID]
      ,[ModifiedDate]
      ,[ModifiedBy]
	  ,[Removed])

	VALUES
		(
		@Products,
		@ProductDescription,
		@Price,
		@Quantity,
		@Total,
		@BTW,
		@CreatedDate,
		@CompanyID,
		@ModifiedDate,
		@ModifiedBy,
		@Removed  
		)
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN
