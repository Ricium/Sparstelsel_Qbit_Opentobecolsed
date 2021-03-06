USE [Spar_Database]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[f_Admin_Insert_SparRecon]
		@GRVDate datetime
		,@SupplierId int
		,@InvoiceNumber varchar(100)
		,@Amount  decimal(18,2)
		,@ModifiedBy varchar(100)
		,@ModifiedDate datetime
		,@CompanyId int
		,@GRVTypeId int	
	
AS
INSERT INTO [dbo].[t_SparRecon] 
		([GRVDate]
      ,[SupplierId]
      ,[InvoiceNumber]
      ,[Amount]
      ,[ModifiedBy]
      ,[ModifiedDate]
      ,[CompanyId]
      ,[Removed]
      ,[GRVTypeId])

	VALUES
		(
		@GRVDate,
		@SupplierId,
		@InvoiceNumber,
		@Amount,
		@ModifiedBy,
		@ModifiedDate,
		@CompanyId,
		0,
		@GRVTypeId
		 )
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN



