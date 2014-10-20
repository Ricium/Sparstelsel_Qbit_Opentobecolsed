USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_FNB]    Script Date: 26/09/2014 02:27:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

ALTER PROCEDURE [dbo].[f_Admin_Update_FNB] 
		@FNBID int,
		@ActualDate int,
		@ModifiedDate varchar(50),
		@Amount varchar(50),
		@FNBTypeID varchar(50),
		@UserID int,
		@UserTypeID varchar(50),
		@Removed bit,
		@UpdatedDate datetime,
		@UpdatedBy int
	
   
AS
UPDATE [t_FNB] 
           SET
		ActualDate=@ActualDate,
		ModifiedDate=@ModifiedDate,
		Amount=@Amount,
		FNBTypeID=@FNBTypeID,
		UserID=@UserID,
		UserTypeID=@UserTypeID,
		Removed=@Removed ,
		UpdatedDate=@UpdatedDate ,
		UpdatedBy=@UpdatedBy  
where FNBID =@FNBID
          
	
SET NOCOUNT ON 
	RETURN