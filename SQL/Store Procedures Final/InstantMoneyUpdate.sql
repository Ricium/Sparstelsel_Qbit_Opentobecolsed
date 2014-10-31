USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_InstantMoney]    Script Date: 26/09/2014 02:27:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Update_InstantMoney] 
		@InstantMoneyID int,
		@ActualDate datetime,
		@Amount decimal(18,2),
		@CreatedDate datetime,
		@InstantMoneyTypeID int,
		@UserID int,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int
	
AS
UPDATE [t_InstantMoney] 
           SET
		ActualDate=@ActualDate,
		Amount=@Amount,
		CreatedDate=@CreatedDate,
		InstantMoneyTypeID=@InstantMoneyTypeID,
		UserID=@UserID,
		CompanyID=@CompanyID,
		ModifiedDate=@ModifiedDate,
		ModifiedBy=@ModifiedBy  
where InstantMoneyID =@InstantMoneyID
          
	
SET NOCOUNT ON 
	RETURN