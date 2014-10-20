USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_ElectronicType]    Script Date: 26/09/2014 02:26:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[f_Admin_Insert_ElectronicType]
			@ElectronicTypes varchar(50)
	
AS
INSERT INTO [dbo].[t_ElectronicType] 
		([ElectronicTypes])

	VALUES
		(
		@ElectronicTypes )
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN
