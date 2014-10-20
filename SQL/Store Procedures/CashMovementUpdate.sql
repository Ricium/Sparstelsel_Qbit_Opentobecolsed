USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_CashMovement]    Script Date: 26/09/2014 02:27:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

ALTER PROCEDURE [dbo].[f_Admin_Update_CashMovement] 
		@CashMovementID int,
		@ActualDate datetime,
		@ModifiedDate datetime,
		@Amount decimal(18,2),
		@CashTypeID int,
		@MoneyUnitID int,
		@UserID int,
		@UserTypeID int,
		@Removed bit,
		@UpdatedDate datetime,
		@UpdatedBy int
	
   
AS
UPDATE [t_CashMovement] 
           SET
		ActualDate=@ActualDate,
		ModifiedDate=@ModifiedDate,
		Amount=@Amount,
		CashTypeID=@CashTypeID,
		MoneyUnitID=@MoneyUnitID,
		UserID=@UserID,
		UserTypeID=@UserTypeID,
		Removed=@Removed,
		UpdatedDate=@UpdatedDate,
		UpdatedBy=@UpdatedBy  
where CashMovementID =@CashMovementID
          
	
SET NOCOUNT ON 
	RETURN