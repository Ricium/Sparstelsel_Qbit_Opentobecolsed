USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_KwikPay]    Script Date: 26/09/2014 02:27:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Update_KwikPay] 
		@KwikPayID int,
		@ActualDate datetime,
		@Amount decimal(18,2),
		@CreatedDate datetime,
		@KwikPayTypeID int,
		@UserID int,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int
	
   
AS
UPDATE [t_KwikPay] 
           SET
		ActualDate=@ActualDate,
		Amount=@Amount,
		CreatedDate=@CreatedDate,
		KwikPayTypeID=@KwikPayTypeID,
		UserID=@UserID,
		CompanyID=@CompanyID ,
		ModifiedDate=@ModifiedDate ,
		ModifiedBy=@ModifiedBy  
where KwikPayID =@KwikPayID
          
	
SET NOCOUNT ON 
	RETURN