USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_Product]    Script Date: 26/09/2014 02:26:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[f_Admin_Insert_Product]
			@Products int,
		@ProductDescription varchar(50),
		@Price decimal(18,2),
		@Quantity int,
		@Total int,
		@BTW decimal(18,2),
		@Removed bit,
		@UpdatedDate datetime,
		@UpdatedBy int,
		@CreatedDate datetime
	
AS
INSERT INTO [dbo].[t_Product] 
		([Products]
      ,[ProductDescription]
      ,[Price]
      ,[Quantity]
      ,[Total]
      ,[BTW]
      ,[Removed]
      ,[UpdatedDate]
      ,[UpdatedBy]
	  ,CreatedDate)

	VALUES
		(
		@Products,
		@ProductDescription,
		@Price,
		@Quantity,
		@Total,
		@BTW,
		@Removed ,
		@UpdatedDate ,
		@UpdatedBy ,
		@CreatedDate  )
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN
