USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_Order]    Script Date: 26/09/2014 02:27:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Update_Order] 
		@OrderID int,
		@OrderDate datetime,
		@ExpectedDeliveryDate datetime,
		@Amount decimal(18,2),
		@CreatedDate datetime,
		@SupplierID int,
		@UserID int,
		@CommentID int,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int
	
   
AS
UPDATE [t_Order] 
           SET
		OrderDate=@OrderDate,
		ExpectedDeliveryDate=@ExpectedDeliveryDate,
		Amount=@Amount,
		CreatedDate=@CreatedDate,
		SupplierID=@SupplierID,
		UserID=@UserID,
		CommentID=@CommentID,
		CompanyID=@CompanyID,
		ModifiedDate=@ModifiedDate,
		ModifiedBy=@ModifiedBy  
where OrderID =@OrderID 
          
	
SET NOCOUNT ON 
	RETURN