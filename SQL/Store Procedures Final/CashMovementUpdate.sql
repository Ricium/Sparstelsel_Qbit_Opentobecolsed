USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_CashMovement]    Script Date: 26/09/2014 02:27:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Update_CashMovement] 
		@CashMovementID int,
		@ActualDate datetime,
		@Amount decimal,
		@CreatedDate datetime,
		@CashTypeID int,
		@MoneyUnitID int,
		@UserID int,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int
	
   
AS
UPDATE [t_CashMovement] 
           SET
		ActualDate=@ActualDate,
		Amount=@Amount,
		CreatedDate=@CreatedDate,
		CashTypeID=@CashTypeID,
		MoneyUnitID=@MoneyUnitID,
		UserID=@UserID,
		CompanyID=@CompanyID,
		ModifiedDate=@ModifiedDate,
		ModifiedBy=@ModifiedBy  
where CashMovementID =@CashMovementID
          
	
SET NOCOUNT ON 
	RETURN