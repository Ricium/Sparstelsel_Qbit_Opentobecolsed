USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_Budget]    Script Date: 26/09/2014 02:27:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Update_Budget] 
		@BudgetID int,
		@BudgetDate datetime,
		@Amount decimal,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int,
		@Removed bit
	
   
AS
UPDATE [l_Budget] 
           SET
		BudgetDate=@BudgetDate,
		Amount=@Amount,
		CompanyID=@CompanyID,
		ModifiedDate=@ModifiedDate,
		ModifiedBy=@ModifiedBy,
		Removed=@Removed
where BudgetID =@BudgetID
          
	
SET NOCOUNT ON 
	RETURN