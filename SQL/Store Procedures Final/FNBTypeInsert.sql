USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_FNBType]    Script Date: 26/09/2014 02:26:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[f_Admin_Insert_FNBType]
			@FNBType int,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int,
		@Removed bit	
	
AS
INSERT INTO [dbo].[l_FNBType] 
		([FNBType]
		,[CompanyID]
		,[ModifiedDate]
		,[ModifiedBy]
		,[Removed])

	VALUES
		(
		@FNBType,
		@CompanyID,
		@ModifiedDate,
		@ModifiedBy,
		@Removed 
		)
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN
