USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_Supplier]    Script Date: 26/09/2014 02:27:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Update_Supplier] 
		@SupplierID int,
		@Suppliers varchar(50),
		@StockCondition varchar(50),
		@Term varchar(50),
		@CreatedDate datetime,
		@SupplierTypeID int,
		@ProductID int,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int
	
   
AS
UPDATE [t_Supplier] 
           SET
		Suppliers=@Suppliers,
		StockCondition=@StockCondition,
		Term=@Term,
		CreatedDate=@CreatedDate,
		SupplierTypeID=@SupplierTypeID,
		ProductID=@ProductID,
		CompanyID=@CompanyID,
		ModifiedDate=@ModifiedDate,
		ModifiedBy=@ModifiedBy  
where SupplierID =@SupplierID
          
	
SET NOCOUNT ON 
	RETURN