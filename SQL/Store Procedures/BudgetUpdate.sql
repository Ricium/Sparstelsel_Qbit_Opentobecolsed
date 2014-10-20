USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_Budget]    Script Date: 26/09/2014 02:27:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

ALTER PROCEDURE [dbo].[f_Admin_Update_Budget] 
		@BudgetID int,
		@BudgetDate datetime,
		@Amount decimal(18,2),
		@Removed bit,
		@UpdatedDate datetime,
		@UpdatedBy int
	
   
AS
UPDATE [l_Budget] 
           SET
		BudgetDate=@BudgetDate,
		Amount=@Amount,
		Removed=@Removed ,
		UpdatedDate=@UpdatedDate ,
		UpdatedBy=@UpdatedBy  
where BudgetID =@BudgetID
          
	
SET NOCOUNT ON 
	RETURN