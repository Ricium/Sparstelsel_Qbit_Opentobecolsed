USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_ProofOfPayment]    Script Date: 26/09/2014 02:26:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[f_Admin_Insert_ProofOfPayment]
			@ActualDate datetime,
		@PaymentDescription varchar(50),
		@CreatedDate datetime,
		@SupplierID int,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int,
		@Removed bit
	
AS
INSERT INTO [dbo].[t_ProofOfPayment] 
		([ActualDate]
      ,[PaymentDescription]
      ,[CreatedDate]
      ,[SupplierID]
      ,[CompanyID] 
      ,[ModifiedDate]
      ,[ModifiedBy]
	  ,Removed)

	VALUES
		(
		@ActualDate,
		@PaymentDescription,
		@CreatedDate,
		@SupplierID,
		@CompanyID,
		@ModifiedDate,
		@ModifiedBy,
		@Removed
		)
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN
