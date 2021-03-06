USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_CashType]    Script Date: 2014-12-19 03:33:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[f_Admin_Insert_CashType]
			@CashType varchar(50),
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy varchar (100),
		@Removed bit
	
AS
INSERT INTO [dbo].[l_CashType] 
		([CashType]
		,[CompanyID]
		,[ModifiedDate]
		,[ModifiedBy]
		,[Removed])

	VALUES
		(
		@CashType, 
		@CompanyID,
		@ModifiedDate,
		@ModifiedBy,
		@Removed
		)
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN


