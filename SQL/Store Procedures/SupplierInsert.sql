USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_Supplier]    Script Date: 26/09/2014 02:26:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[f_Admin_Insert_Supplier]
			@Suppliers int,
		@StockCondition varchar(50),
		@Term varchar(50),
		@SupplierTypeID int,
		@ProductID int,
		@Removed bit,
		@UpdatedDate datetime,
		@UpdatedBy int,
		@CreatedDate datetime
	
AS
INSERT INTO [dbo].[t_Supplier] 
		([Suppliers]
      ,[StockCondition]
      ,[Term]
      ,[SupplierTypeID]
      ,[ProductID]
      ,[Removed]
      ,[UpdatedDate]
      ,[UpdatedBy]
	  ,CreatedDate)

	VALUES
		(
		@Suppliers,
		@StockCondition,
		@Term,
		@SupplierTypeID,
		@ProductID,
		@Removed,
		@UpdatedDate,
		@UpdatedBy,
		@CreatedDate )
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN
