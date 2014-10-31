USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_Comment]    Script Date: 26/09/2014 02:27:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Update_Comment] 
		@CommentID int,
		@Comments varchar(50),
		@CreatedDate datetime,
		@CommentTypeID int,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int
	
   
AS
UPDATE [t_Comment] 
           SET
		Comments=@Comments,
		CreatedDate=@CreatedDate,
		CommentTypeID=@CommentTypeID,
		@CompanyID=@CompanyID,
		ModifiedDate=@ModifiedDate ,
		ModifiedBy=@ModifiedBy  
where CommentID =@CommentID 
          
	
SET NOCOUNT ON 
	RETURN