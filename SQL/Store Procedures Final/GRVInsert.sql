USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_GRVList]    Script Date: 26/09/2014 02:26:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[f_Admin_Insert_GRVList]
			@InvoiceNumber varchar(50),
		@StateDate datetime,
		@Number varchar(50),
		@PayDate datetime,
		@PinkSlipNumber varchar(10),
		@GRVDate datetime,
		@InvoiceDate datetime,
		@ExcludingVat decimal,
		@IncludingVat decimal,
		@CreatedDate datetime,
		@GRVTypeID int,
		@SupplierID int,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int,
		@Removed bit
	
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
      ,[CreatedDate]
      ,[GRVTypeID]
      ,[SupplierID]
      ,[CompanyID]
      ,[ModifiedDate]
      ,[ModifiedBy]
	  ,[Removed])

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
		@CreatedDate,
		@GRVTypeID,
		@SupplierID,
		@CompanyID,
		@ModifiedDate,
		@ModifiedBy,
		@Removed
		)
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN
