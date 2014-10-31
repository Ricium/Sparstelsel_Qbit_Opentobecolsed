USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_KwikPayType]    Script Date: 26/09/2014 02:26:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[f_Admin_Insert_KwikPayType]
			@KwikPayTypes varchar(50),
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int,
		@Removed bit
	
AS
INSERT INTO [dbo].[l_KwikPayType] 
		([KwikPayTypes]
		,[CompanyID]
		,[ModifiedDate] 
		,[ModifiedBy]  
		,[Removed]) 

	VALUES
		(
		@KwikPayTypes,
		@CompanyID,
		@ModifiedDate,
		@ModifiedBy,
		@Removed 
		)
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN
