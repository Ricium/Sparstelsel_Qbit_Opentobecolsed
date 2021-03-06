USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Report_SparRecon]    Script Date: 2015/02/26 11:49:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

ALTER PROCEDURE [dbo].[f_Admin_Report_SparRecon]
  @SelectedDate datetime
AS
select COALESCE(g.InvoiceNumber,'No Recon') as GRVInvoiceNumber
, COALESCE(g.StateDate,'1900-01-01') as StateDate
, COALESCE(g.PayDate,'1900-01-01') as GRVPayDate
, COALESCE(g.IncludingVat,0) as GRVInVAT
, COALESCE(g.ExcludingVat,0) as GRVExVAT
, COALESCE(g.PinkSlipNumber,0) as GRVPinkSlipNumber
, COALESCE(g.GRVTypeID,0) as GRVType
, COALESCE(sr.InvoiceNumber,'No GRV') as ReconInvoiceNumber
, COALESCE(sr.StateDate,'1900-01-01') as ReconDate
, COALESCE(sr.Amount,0) as ReconAmount
, COALESCE(sr.GRVTypeId,0) as ReconType
, s.Supplier 
from t_GRVList g
full join t_SparRecon sr on g.InvoiceNumber = sr.InvoiceNumber and g.GRVTypeID = sr.GRVTypeId
inner join t_Supplier s on (g.SupplierID = s.SupplierID or sr.SupplierId = s.SupplierID)
where 
COALESCE(g.InvoiceDate,0) = @SelectedDate
or COALESCE(sr.StateDate,0) = @SelectedDate
and(g.Removed = 0
or sr.Removed = 0)   
	
SET NOCOUNT ON 
	RETURN


