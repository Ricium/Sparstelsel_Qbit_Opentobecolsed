USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_Order]    Script Date: 26/09/2014 02:26:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[f_Admin_Insert_Order]
			@OrderDate datetime,
		@ExpectedDeliveryDate datetime,
		@Amount decimal(18,2),
		@CreatedDate datetime,
		@SupplierID int,
		@UserID int,
		@CommentID int,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int,
		@Removed bit
	
AS
INSERT INTO [dbo].[t_Order] 
		([OrderDate]
      ,[ExpectedDeliveryDate]
      ,[Amount]
      ,[CreatedDate]
      ,[SupplierID]
      ,[UserID]
      ,[CommentID]
      ,[CompanyID]
      ,[ModifiedDate]
      ,[ModifiedBy]
	  ,Removed)

	VALUES
		(
		@OrderDate,
		@ExpectedDeliveryDate,
		@Amount,
		@CreatedDate,
		@SupplierID,
		@UserID,
		@CommentID,
		@CompanyID,
		@ModifiedDate,
		@ModifiedBy,
		@Removed
		)
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN
