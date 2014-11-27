USE [Spar_Database]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Update_Status] 
		(
		@StatusID int,
		@StatusName varchar(50),
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int

	)
   
AS
UPDATE l_Status 
           SET
		StatusName =@StatusName,
		CompanyID=@CompanyID,
		ModifiedDate=@ModifiedDate,
		ModifiedBy=@ModifiedBy  
where StatusID =@StatusID
          
	
SET NOCOUNT ON 
	RETURN