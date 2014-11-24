USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_Supplier]    Script Date: 26/09/2014 02:26:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[f_Admin_Insert_Supplier]
			@Supplier int,
		@StockCondition varchar(50),
		@Term varchar(50),
		@CreatedDate datetime,
		@SupplierTypeID int,
		@ProductID int,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int,
		@Removed bit
		
	
AS
INSERT INTO [dbo].[t_Supplier] 
		([Supplier]
      ,[StockCondition]
      ,[Term]
      ,[CreatedDate]
      ,[SupplierTypeID]
      ,[ProductID]
      ,[CompanyID]
      ,[ModifiedDate]
      ,[ModifiedBy]
	  ,[Removed])

	VALUES
		(
		@Supplier,
		@StockCondition,
		@Term,
		@CreatedDate,
		@SupplierTypeID,
		@ProductID,
		@CompanyID,
		@ModifiedDate,
		@ModifiedBy,
		@Removed
		 )
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN
