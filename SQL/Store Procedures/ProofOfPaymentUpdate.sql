USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_ProofOfPayment]    Script Date: 26/09/2014 02:27:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

ALTER PROCEDURE [dbo].[f_Admin_Update_ProofOfPayment] 
		@ProofOfPaymentID int,
		@ActualDate datetime,
		@ModifiedDate datetime,
		@PaymentDescription varchar(50),
		@SupplierID int,
		@SupplierTypeID int,
		@Removed bit,
		@UpdatedDate datetime,
		@UpdatedBy int
	
   
AS
UPDATE [t_ProofOfPayment] 
           SET
		ProofOfPaymentID=@ProofOfPaymentID,
		ActualDate=@ActualDate,
		ModifiedDate=@ModifiedDate,
		PaymentDescription=@PaymentDescription,
		SupplierID=@SupplierID,
		SupplierTypeID=@SupplierTypeID,
		Removed=@Removed,
		UpdatedDate=@UpdatedDate,
		UpdatedBy=@UpdatedBy  
where ProofOfPaymentID =@ProofOfPaymentID 
          
	
SET NOCOUNT ON 
	RETURN