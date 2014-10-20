USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_CashReconciliation]    Script Date: 26/09/2014 02:27:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

ALTER PROCEDURE [dbo].[f_Admin_Update_CashReconciliation] 
		@CashReconciliationID int,
		@ActualDate int,
		@ModifiedDate varchar(50),
		@ReconciliationTypeID varchar(50),
		@UserID varchar(50),
		@UserTypeID int,
		@Removed bit,
		@UpdatedDate datetime,
		@UpdatedBy int
	
   
AS
UPDATE [t_CashReconciliation] 
           SET
		ActualDate=@ActualDate,
		ModifiedDate=@ModifiedDate,
		ReconciliationTypeID=@ReconciliationTypeID,
		UserID=@UserID,
		UserTypeID=@UserTypeID,
		Removed=@Removed,
		UpdatedDate=@UpdatedDate,
		UpdatedBy=@UpdatedBy  
where CashReconciliationID =@CashReconciliationID
          
	
SET NOCOUNT ON 
	RETURN