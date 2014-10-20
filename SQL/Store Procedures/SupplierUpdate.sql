USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_Supplier]    Script Date: 26/09/2014 02:27:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

ALTER PROCEDURE [dbo].[f_Admin_Update_Supplier] 
		@SupplierID int,
		@Suppliers varchar(50),
		@StockCondition varchar(50),
		@Term varchar(50),
		@SupplierTypeID int,
		@ProductID int,
		@Removed bit,
		@UpdatedDate datetime,
		@UpdatedBy int
	
   
AS
UPDATE [t_Supplier] 
           SET
		Suppliers=@Suppliers,
		StockCondition=@StockCondition,
		Term=@Term,
		SupplierTypeID=@SupplierTypeID,
		ProductID=@ProductID,
		Removed=@Removed ,
		UpdatedDate=@UpdatedDate ,
		UpdatedBy=@UpdatedBy  
where SupplierID =@SupplierID
          
	
SET NOCOUNT ON 
	RETURN