USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_CoinMovement]    Script Date: 26/09/2014 02:26:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[f_Admin_Insert_CoinMovement]
			@ActualDate datetime,
		@ModifiedDate datetime,
		@Amount decimal(18,2),
		@MovementTypeID int,
		@MoneyUnitID int,
		@UserID int,
		@UserTypeID int,
		@Removed bit,
		@UpdatedDate datetime,
		@UpdatedBy int,
		@CreatedDate datetime
	
AS
INSERT INTO [dbo].[t_CoinMovement] 
		([ActualDate]
      ,[ModifiedDate]
      ,[Amount]
      ,[MovementTypeID]
      ,[MoneyUnitID]
      ,[UserID]
      ,[UserTypeID]
      ,[Removed]
      ,[UpdatedDate]
      ,[UpdatedBy]
	  ,CreatedDate)

	VALUES
		(
		@ActualDate,
		@ModifiedDate,
		@Amount,
		@MovementTypeID,
		@MoneyUnitID,
		@UserID,
		@UserTypeID ,
		@Removed ,
		@UpdatedDate ,
		@UpdatedBy ,
		@CreatedDate  )
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN
