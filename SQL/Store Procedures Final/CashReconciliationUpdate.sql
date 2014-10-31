USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_CashReconciliation]    Script Date: 26/09/2014 02:27:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Update_CashReconciliation] 
		@CashReconciliationID int,
		@ActualDate datetime,
		@CreatedDate datetime,
		@ReconciliationTypeID int,
		@UserID int,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int
   
AS
UPDATE [t_CashReconciliation] 
           SET
		ActualDate=@ActualDate,
		CreatedDate=@CreatedDate,
		ReconciliationTypeID=@ReconciliationTypeID,
		UserID=@UserID,
		CompanyID=@CompanyID,
		ModifiedDate=@ModifiedDate,
		ModifiedBy=@ModifiedBy  
where CashReconciliationID =@CashReconciliationID
          
	
SET NOCOUNT ON 
	RETURN