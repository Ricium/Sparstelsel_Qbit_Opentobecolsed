USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_ElectronicFund]    Script Date: 26/09/2014 02:26:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[f_Admin_Insert_ElectronicFund]
			@ElectronicFunds varchar(50),
		@Total decimal(18,2),
		@ElectronicTypeID int,
		@UserID int,
		@UserTypeID int,
		@Removed bit,
		@UpdatedDate datetime,
		@UpdatedBy int,
		@CreatedDate datetime
	
AS
INSERT INTO [dbo].[t_ElectronicFund] 
		([ElectronicFunds]
      ,[Total]
      ,[ElectronicTypeID]
      ,[UserID]
      ,[UserTypeID]
      ,[Removed]
      ,[UpdatedDate]
      ,[UpdatedBy]
	  ,CreatedDate)

	VALUES
		(
		@ElectronicFunds,
		@Total,
		@ElectronicTypeID,
		@UserID,
		@UserTypeID,
		@Removed ,
		@UpdatedDate ,
		@UpdatedBy ,
		@CreatedDate )
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN
