USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_CashReconciliation]    Script Date: 26/09/2014 02:26:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[f_Admin_Insert_CashReconciliation]
			@ActualDate int,
		@ModifiedDate varchar(50),
		@ReconcilationTypeID varchar(50),
		@UserID varchar(50),
		@UserTypeID int,
		@Removed bit,
		@UpdatedDate datetime,
		@UpdatedBy int,
		@CreatedDate datetime
	
AS
INSERT INTO [dbo].[t_CashReconciliation] 
		([ActualDate]
      ,[ModifiedDate]
      ,[ReconciliationTypeID]
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
		@ReconcilationTypeID,
		@UserID,
		@UserTypeID,
		@Removed,
		@UpdatedDate,
		@UpdatedBy,
		@CreatedDate  )
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN
