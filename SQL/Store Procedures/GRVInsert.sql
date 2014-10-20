USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_GRVList]    Script Date: 26/09/2014 02:26:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[f_Admin_Insert_GRVList]
			@InvoiceNumber varchar(50),
		@StateDate datetime,
		@Number int,
		@PayDate datetime,
		@PinkSlipNumber varchar(50),
		@GRVDate datetime,
		@InvoiceDate datetime,
		@ExcludingVat decimal(18,2),
		@IncludingVat decimal(18,2),
		@GRVTypeID int,
		@SupplierID int,
		@SupplierTypeID int,
		@Removed bit,
		@UpdatedDate datetime,
		@UpdatedBy int,
		@CreatedDate datetime
	
AS
INSERT INTO [dbo].[t_GRVList] 
		([InvoiceNumber]
      ,[StateDate]
      ,[Number]
      ,[PayDate]
      ,[PinkSlipNumber]
      ,[GRVDate]
      ,[InvoiceDate]
      ,[ExcludingVat]
      ,[IncludingVat]
      ,[GRVTypeID]
      ,[SupplierID]
      ,[SupplierTypeID]
      ,[Removed]
      ,[UpdatedDate]
      ,[UpdatedBy]
	  ,CreatedDate)

	VALUES
		(
		@InvoiceNumber,
		@StateDate,
		@Number,
		@PayDate,
		@PinkSlipNumber,
		@GRVDate,
		@InvoiceDate,
		@ExcludingVat,
		@IncludingVat,
		@GRVTypeID,
		@SupplierID,
		@SupplierTypeID,
		@Removed,
		@UpdatedDate,
		@UpdatedBy,
		@CreatedDate )
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN
