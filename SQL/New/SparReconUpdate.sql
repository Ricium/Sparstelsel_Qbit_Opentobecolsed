USE [Spar_Database]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

CREATE PROCEDURE [dbo].[f_Admin_Update_SparRecon] 
		@SparReconId int
		,@GRVDate datetime
		,@SupplierId int
		,@InvoiceNumber varchar(100)
		,@Amount  decimal(18,2)
		,@ModifiedBy varchar(100)
		,@ModifiedDate datetime
		,@CompanyId int
		,@GRVTypeId int	
   
AS
UPDATE [t_SparRecon] 
           SET
		[GRVDate] = @GRVDate
      ,[SupplierId] = @SupplierId
      ,[InvoiceNumber] = @InvoiceNumber
      ,[Amount] = @Amount
      ,[ModifiedBy] = @ModifiedBy
      ,[ModifiedDate] = @ModifiedDate
      ,[CompanyId] = @CompanyId
      ,[GRVTypeId] =@GRVTypeId
where SparReconId = @SparReconId
          
	
SET NOCOUNT ON 
	RETURN


