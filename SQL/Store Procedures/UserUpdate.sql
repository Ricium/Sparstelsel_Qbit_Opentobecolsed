USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_User]    Script Date: 26/09/2014 02:27:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

ALTER PROCEDURE [dbo].[f_Admin_Update_User] 
		@UserID int,
		@UserName varchar(50),
		@UserSurname varchar(50),
		@ID varchar(13),
		@UserCell varchar(50),
		@UserEmail varchar(50),
		@UserTypeID int,
		@Removed bit,
		@UpdatedDate datetime,
		@UpdatedBy int
	
   
AS
UPDATE [t_User] 
           SET
		UserID=@UserID,
		UserName=@UserName,
		UserSurname=@UserSurname,
		ID=@ID,
		UserCell=@UserCell,
		UserEmail=@UserEmail,
		UserTypeID=@UserTypeID,
		Removed=@Removed,
		UpdatedDate=@Updatedate,
		UpdatedBy=@UpdatedBy  
where UserID =@UserID 
          
	
SET NOCOUNT ON 
	RETURN