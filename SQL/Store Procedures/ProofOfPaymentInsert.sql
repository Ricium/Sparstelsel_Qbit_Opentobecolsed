USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_ProofOfPayment]    Script Date: 26/09/2014 02:26:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[f_Admin_Insert_ProofOfPayment]
			@ActualDate datetime,
		@ModifiedDate datetime,
		@PaymentDescription varchar(50),
		@SupplierID int,
		@SupplierTypeID int,
		@Removed bit,
		@UpdatedDate datetime,
		@UpdatedBy int,
		@CreatedDate datetime
	
AS
INSERT INTO [dbo].[t_ProofOfPayment] 
		([ActualDate]
      ,[ModifiedDate]
      ,[PaymentDescription]
      ,[SupplierID]
      ,[SupplierTypeID]
      ,[Removed]
      ,[UpdatedDate]
      ,[UpdatedBy]
	  ,CreatedDate)

	VALUES
		(
		@ActualDate,
		@ModifiedDate,
		@PaymentDescription,
		@SupplierID,
		@SupplierTypeID,
		@Removed,
		@UpdatedDate,
		@UpdatedBy,
		@CreatedDate  )
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN
