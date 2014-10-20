USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_MoneyUnit]    Script Date: 26/09/2014 02:26:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[f_Admin_Insert_MoneyUnit]
			@MoneyUnits varchar
	
AS
INSERT INTO [dbo].[l_MoneyUnit] 
		([MoneyUnits])

	VALUES
		(
		@MoneyUnits )
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN
