USE [Spar_Database]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE f_Admin_Update_SupplierType 
		(
		@SupplierTypeID int,
		@SupplierType varchar(50),
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int

	)
   
AS
UPDATE l_SupplierType 
           SET
		SupplierType =@SupplierType,
		CompanyID=@CompanyID,
		ModifiedDate=@ModifiedDate,
		ModifiedBy=@ModifiedBy  
where SupplierTypeID =@SupplierTypeID
          
	
SET NOCOUNT ON 
	RETURN