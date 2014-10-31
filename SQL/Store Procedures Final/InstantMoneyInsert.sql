USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_InstantMoney]    Script Date: 26/09/2014 02:26:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[f_Admin_Insert_InstantMoney]
			@ActualDate datetime,
		@Amount decimal(18,2),
		@CreatedDate datetime,
		@InstantMoneyTypeID int,
		@UserID int,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int,
		@Removed bit
	
AS
INSERT INTO [dbo].[t_InstantMoney] 
		([ActualDate]
      ,[Amount]
      ,[CreatedDate]
      ,[InstantMoneyTypeID]
      ,[UserID]
      ,[CompanyID]
      ,[ModifiedDate]
      ,[ModifiedBy]
	  ,[Removed])

	VALUES
		(
		@ActualDate,
		@Amount,
		@CreatedDate,
		@InstantMoneyTypeID,
		@UserID,
		@CompanyID,
		@ModifiedDate ,
		@ModifiedBy ,
		@Removed
		)
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN
