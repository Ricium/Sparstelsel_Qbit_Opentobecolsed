USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_KwikPay]    Script Date: 26/09/2014 02:27:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

ALTER PROCEDURE [dbo].[f_Admin_Update_KwikPay] 
		@KwikPayID int,
		@ActualDate datetime,
		@ModifiedDate datetime,
		@Amount decimal(18,2),
		@KwikPayTypeID int,
		@UserID int,
		@UserTypeID int,
		@Removed bit,
		@UpdatedDate datetime,
		@UpdatedBy int
	
   
AS
UPDATE [t_KwikPay] 
           SET
		ActualDate=@ActualDate,
		ModifiedDate=@ModifiedDate,
		Amount=@Amount,
		KwikPayTypeID=@KwikPayTypeID,
		UserID=@UserID,
		UserTypeID=@UserTypeID,
		Removed=@Removed ,
		UpdatedDate=@UpdatedDate ,
		UpdatedBy=@UpdatedBy  
where KwikPayID =@KwikPayID
          
	
SET NOCOUNT ON 
	RETURN