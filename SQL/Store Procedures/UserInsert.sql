USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_User]    Script Date: 26/09/2014 02:26:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[f_Admin_Insert_User]
			@UserName varchar(50),
		@UserSurname varchar(50),
		@ID varchar(13),
		@UserCell varchar(50),
		@UserEmail varchar(50),
		@UserTypeID int,
		@Removed bit,
		@UpdatedDate datetime,
		@UpdatedBy int,
		@CreatedDate datetime
	
AS
INSERT INTO [dbo].[t_User] 
		([UserName]
      ,[UserSurname]
      ,[ID]
      ,[UserCell]
      ,[UserEmail]
      ,[UserTypeID]
      ,[Removed]
      ,[UpdatedDate]
      ,[UpdatedBy]
	  ,CreatedDate)

	VALUES
		(
		@UserName,
		@UserSurname,
		@ID,
		@UserCell,
		@UserEmail,
		@UserTypeID,
		@Removed,
		@UpdatedDate,
		@UpdatedBy,
		@CreatedDate )
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN
