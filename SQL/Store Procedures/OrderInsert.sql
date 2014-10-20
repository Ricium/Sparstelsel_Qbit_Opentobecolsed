USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_Order]    Script Date: 26/09/2014 02:26:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[f_Admin_Insert_Order]
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
		@UpdatedBy int,
		@CreatedDate datetime
	
AS
INSERT INTO [dbo].[t_Order] 
		([OrderDate]
      ,[ExpectedDeliveryDate]
      ,[Amount]
      ,[SupplierID]
      ,[SupplierTypeID]
      ,[UserID]
      ,[UserTypeID]
      ,[CommentID]
      ,[Removed]
      ,[UpdatedDate]
      ,[UpdatedBy]
	  ,CreatedDate)

	VALUES
		(
		@OrderDate,
		@ExpectedDeliveryDate,
		@Amount,
		@SupplierID,
		@SupplierTypeID,
		@UserID,
		@UserTypeID,
		@CommentID,
		@Removed,
		@UpdatedDate,
		@UpdatedBy,
		@CreatedDate )
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN
