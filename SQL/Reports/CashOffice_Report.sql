USE [Spar_Database]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

CREATE PROCEDURE [dbo].[f_Admin_Report_CashOffice]
  @SelectedDate datetime
AS
   select SUM(cm.Amount) as CashierTotal, MoneyUnitID
into #cashiertotals
from t_CashMovement cm
where 
	cm.ActualDate = @SelectedDate
and cm.Removed = 0
group by  MoneyUnitID

select SUM(Amount) as OfficeTotal, co.MoneyUnitTypeID, co.CashOfficeTypeID, co.CashStatus 
into #cashoffice
from t_CashOffice co
where 
	co.ActualDate = @SelectedDate
and co.Removed = 0
group by co.MoneyUnitTypeID, co.CashOfficeTypeID, co.CashStatus

select	
	mu.MoneyUnit
	,(select COALESCE(SUM(co.OfficeTotal),0) 
	from #cashoffice co
	where co.MoneyUnitTypeID = mu.MoneyUnitID
	and co.CashStatus = 1
	and co.CashOfficeTypeID = 1)	as Sealed
	, (select COALESCE(SUM(co.OfficeTotal),0)  
	from #cashoffice co
	where co.MoneyUnitTypeID = mu.MoneyUnitID
	and co.CashStatus = 2
	and co.CashOfficeTypeID = 1)	as Opened
	,(select COALESCE(SUM(co.OfficeTotal),0)  
	from #cashoffice co
	where co.MoneyUnitTypeID = mu.MoneyUnitID
	and co.CashStatus = 3
	and co.CashOfficeTypeID = 1)	as Notes
	,(select COALESCE(SUM(ct.CashierTotal),0)  
	from #cashiertotals ct
	where ct.MoneyUnitID = mu.MoneyUnitID)	as Cashiers
	,(select COALESCE(SUM(co.OfficeTotal),0)  
	from #cashoffice co
	where co.MoneyUnitTypeID = mu.MoneyUnitID
	and co.CashOfficeTypeID = 2)	as Drops
from 
	l_MoneyUnit mu

drop table #cashiertotals
drop table #cashoffice     
	
SET NOCOUNT ON 
	RETURN


