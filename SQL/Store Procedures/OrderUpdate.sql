USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_Order]    Script Date: 26/09/2014 02:27:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

ALTER PROCEDURE [dbo].[f_Admin_Update_Order] 
		@OrderID int,
		@OrderDate datetime,
		@ExpectedDeliveryDate datetime,
		@Amount decimal(18,2),
		@SupplierID int,
		@SupplierTypeID int,
		@UserID int,
		@UserTypeID int,
		@CommentID int,
		@Removed bit,
		@UpdatedDate datetime,
		@UpdatedBy int
	
   
AS
UPDATE [t_Order] 
           SET
		OrderDate=@OrderDate,
		ExpectedDeliveryDate=@ExpectedDeliveryDate,
		Amount=@Amount,
		SupplierID=@SupplierID,
		SupplierTypeID=@SupplierTypeID,
		UserID=@UserID,
		UserTypeID=@UserTypeID,
		CommentID=@CommentID,
		Removed=@Removed,
		UpdatedDate=@UpdatedDate,
		UpdatedBy=@UpdatedBy  
where OrderID =@OrderID 
          
	
SET NOCOUNT ON 
	RETURN