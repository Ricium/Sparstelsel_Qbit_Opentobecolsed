USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_CashBox]    Script Date: 26/09/2014 02:27:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Update_CashBox] 
		@CashBoxID int,
		@ActualDate datetime,
		@Amount decimal(18,2),
		@CreatedDate datetime,
		@MovementTypeID int,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int
   
AS
UPDATE [t_CashBox] 
           SET
		ActualDate=@ActualDate,
		Amount=@Amount,
		CreatedDate=@CreatedDate,
		MovementTypeID=@MovementTypeID,
		CompanyID=@CompanyID,
		ModifiedDate=@ModifiedDate,
		ModifiedBy=@ModifiedBy  
where CashBoxID =@CashBoxID 
          
	
SET NOCOUNT ON 
	RETURN