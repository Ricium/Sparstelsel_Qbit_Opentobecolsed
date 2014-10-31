USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_PickUp]    Script Date: 26/09/2014 02:27:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Update_PickUp] 
		@PickUpID int,
		@ActualDate datetime,
		@Amount decimal,
		@CreatedDate datetime,
		@CashTypeID int,
		@UserID int,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int
	
   
AS
UPDATE [t_PickUp] 
           SET
		ActualDate=@ActualDate,
		Amount=@Amount,
		CreatedDate=@CreatedDate,
		CashTypeID=@CashTypeID,
		UserID=@UserID,
		CompanyID=@CompanyID,
		ModifiedDate=@ModifiedDate,
		ModifiedBy=@ModifiedBy  
where PickUpID =@PickUpID 
          
	
SET NOCOUNT ON 
	RETURN