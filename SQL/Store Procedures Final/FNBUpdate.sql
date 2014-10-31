USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_FNB]    Script Date: 26/09/2014 02:27:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Update_FNB] 
		@FNBID int,
		@ActualDate datetime,
		@Amount decimal(18,2),
		@CreatedDate datetime,
		@FNBTypeID int,
		@UserID int,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int	
   
AS
UPDATE [t_FNB] 
           SET
		ActualDate=@ActualDate,
		Amount=@Amount,
		CreatedDate=@CreatedDate,
		FNBTypeID=@FNBTypeID,
		UserID=@UserID,
		CompanyID=@CompanyID ,
		ModifiedDate=@ModifiedDate ,
		ModifiedBy=@ModifiedBy  
where FNBID =@FNBID
          
	
SET NOCOUNT ON 
	RETURN