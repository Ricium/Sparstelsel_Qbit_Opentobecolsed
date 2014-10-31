USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_CoinMovement]    Script Date: 26/09/2014 02:27:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Update_CoinMovement] 
		@CoinMovementID int,
		@ActualDate datetime,
		@Amount decimal(18,2),
		@CreatedDate datetime,
		@MovementTypeID int,
		@MoneyUnitID int,
		@UserID int,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int
	
   
AS
UPDATE [t_CoinMovement] 
           SET
		ActualDate=@ActualDate,
		Amount=@Amount,
		CreatedDate=@CreatedDate,
		MovementTypeID=@MovementTypeID,
		MoneyUnitID=@MoneyUnitID,
		UserID=@UserID,
		CompanyID=@CompanyID,
		ModifiedDate=@ModifiedDate,
		ModifiedBy=@ModifiedBy  
where CoinMovementID =@CoinMovementID
          
	
SET NOCOUNT ON 
	RETURN