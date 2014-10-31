USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_ProofOfPayment]    Script Date: 26/09/2014 02:27:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Update_ProofOfPayment] 
		@ProofOfPaymentID int,
		@ActualDate datetime,
		@PaymentDescription varchar(50),
		@CreatedDate datetime,
		@SupplierID int,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int
	
AS
UPDATE [t_ProofOfPayment] 
           SET
		ActualDate=@ActualDate,
		PaymentDescription=@PaymentDescription,
		CreatedDate=@CreatedDate,
		SupplierID=@SupplierID,
		CompanyID=@CompanyID,
		ModifiedDate=@ModifiedDate,
		ModifiedBy=@ModifiedBy  
where ProofOfPaymentID =@ProofOfPaymentID 
          
	
SET NOCOUNT ON 
	RETURN