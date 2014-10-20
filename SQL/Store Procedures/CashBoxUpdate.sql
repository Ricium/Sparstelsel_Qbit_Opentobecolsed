USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_CashBox]    Script Date: 26/09/2014 02:27:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

ALTER PROCEDURE [dbo].[f_Admin_Update_CashBox] 
		@CashBoxID int,
		@ActualDate datetime,
		@ModifiedDate datetime,
		@Amount decimal(18,2),
		@MovementTypeID int,
		@Removed bit,
		@UpdatedDate datetime,
		@UpdatedBy int
	
   
AS
UPDATE [t_CashBox] 
           SET
		ActualDate=@ActualDate,
		ModifiedDate=@ModifiedDate,
		Amount=@Amount,
		MovementTypeID=@MovementTypeID,

		Removed=@Removed ,
		UpdatedDate=@UpdatedDate ,
		UpdatedBy=@UpdatedBy  
where CashBoxID =@CashBoxID 
          
	
SET NOCOUNT ON 
	RETURN