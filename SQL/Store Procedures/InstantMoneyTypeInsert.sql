USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_InstantMoneyType]    Script Date: 26/09/2014 02:26:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[f_Admin_Insert_MemberSpouse]
			@InstantMoneyTypes varchar(50)
	
AS
INSERT INTO [dbo].[l_InstantMoneyType] 
		([InstantMoneyTypes])

	VALUES
		(
		@InstantMoneyTypes )
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN
