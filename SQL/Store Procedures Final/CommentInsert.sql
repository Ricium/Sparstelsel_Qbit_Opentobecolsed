USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_Comment]    Script Date: 26/09/2014 02:26:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[f_Admin_Insert_Comment]
			@Comment varchar(50),
		@CreatedDate datetime,	
		@CommentTypeID int,
        @CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int,
		@Removed bit
	
AS
INSERT INTO [dbo].[t_Comment] 
		([Comment]
	  ,[CreatedDate]
      ,[CommentTypeID]
      ,[CompanyID]
      ,[ModifiedDate]
      ,[ModifiedBy]
	  ,[Removed])

	VALUES
		(
		@Comment,
		@CreatedDate,
		@CommentTypeID,
		@CompanyID,
		@ModifiedDate ,
		@ModifiedBy ,
		@Removed 
		)
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN
