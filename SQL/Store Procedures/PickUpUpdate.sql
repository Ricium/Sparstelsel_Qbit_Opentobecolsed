USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_PickUp]    Script Date: 26/09/2014 02:27:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

ALTER PROCEDURE [dbo].[f_Admin_Update_PickUp] 
		@PickUpID int,
		@ActualDate datetime,
		@ModifiedDate datetime,
		@Amount decimal(18,2),
		@CashTypeID int,
		@UserID int,
		@UserTypeID int,
		@Removed bit,
		@UpdatedDate datetime,
		@UpdatedBy int
	
   
AS
UPDATE [t_PickUp] 
           SET
		ActualDate=@ActualDate,
		ModifiedDate=@ModifiedDate,
		Amount=@Amount,
		CashTypeID=@CashTypeID,
		UserID=@UserID,
		UserTypeID=@UserTypeID,
		Removed=@Removed ,
		UpdatedDate=@UpdatedDate ,
		UpdatedBy=@UpdatedBy  
where PickUpID =@PickUpID 
          
	
SET NOCOUNT ON 
	RETURN