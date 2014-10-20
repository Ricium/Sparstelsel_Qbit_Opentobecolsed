USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_InstantMoney]    Script Date: 26/09/2014 02:27:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

ALTER PROCEDURE [dbo].[f_Admin_Update_InstantMoney] 
		@InstantMoneyID int,
		@ActualDate datetime,
		@ModifiedDate datetime,
		@Amount decimal(18,2),
		@InstantMoneyTypeID int,
		@UserID int,
		@UserTypeID int,
		@Removed bit,
		@UpdatedDate datetime,
		@UpdatedBy int
	
   
AS
UPDATE [t_InstantMoney] 
           SET
		ActualDate=@ActualDate,
		ModifiedDate=@ModifiedDate,
		Amount=@Amount,
		InstantMoneyTypeID=@InstantMoneyTypeID,
		UserID=@UserID,
		UserTypeID=@UserTypeID,
		Removed=@Removed ,
		UpdatedDate=@UpdatedDate ,
		UpdatedBy=@UpdatedBy  
where InstantMoneyID =@InstantMoneyID
          
	
SET NOCOUNT ON 
	RETURN