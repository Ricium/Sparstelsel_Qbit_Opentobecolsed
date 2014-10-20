USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_FNB]    Script Date: 26/09/2014 02:26:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[f_Admin_Insert_FNB]
			@ActualDate int,
		@ModifiedDate varchar(50),
		@Amount varchar(50),
		@FNBTypeID varchar(50),
		@UserID int,
		@UserTypeID varchar(50),
		@Removed bit,
		@UpdatedDate datetime,
		@UpdatedBy int,
		@CreatedDate datetime
	
AS
INSERT INTO [dbo].[t_FNB] 
		([ActualDate]
      ,[ModifiedDate]
      ,[Amount]
      ,[FNBTypeID]
      ,[UserID]
      ,[UserTypeID]
      ,[Removed]
      ,[UpdatedDate]
      ,[UpdatedBy]
	  ,CreatedDate)

	VALUES
		(
		@ActualDate,
		@ModifiedDate,
		@Amount,
		@FNBTypeID,
		@UserID,
		@UserTypeID,
		@Removed ,
		@UpdatedDate ,
		@UpdatedBy ,
		@CreatedDate  )
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN
