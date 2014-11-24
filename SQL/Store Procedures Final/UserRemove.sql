USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Remove_User]    Script Date: 26/09/2014 02:27:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

CREATE PROCEDURE [dbo].[f_Admin_Remove_User] 
	@UserID int,
	@Removed bit,
	@UpdatedBy int,
	@UpdatedDate datetime
   
AS
UPDATE [t_User] 
SET         
	Removed = @Removed,
	UpdatedBy = @UpdatedBy,
	UpdatedDate = @UpdatedDate
WHERE UserID = @UserID 
          
	
SET NOCOUNT ON 
	RETURN