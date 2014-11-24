USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_UserTypePermission]    Script Date: 26/09/2014 02:26:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[f_Admin_Insert_UserTypePermission]
			@PermissionID int,
		@UserTypeID varchar(50)
	
AS
INSERT INTO [dbo].[t_UserTypePermission] 
		([PermissionID]
      ,[UserTypeID])

	VALUES
		(
		@PermissionID,
		@UserTypeID )
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN
