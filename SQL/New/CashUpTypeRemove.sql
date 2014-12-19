USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Remove_CashBox]    Script Date: 2014-12-19 03:31:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Remove_CashType] 
	@CashTypeID int,
	@ModifiedDate datetime,
	@ModifiedBy varchar (100),
	@Removed bit
   
AS
UPDATE [l_CashType] 
SET         
	ModifiedDate = @ModifiedDate,
	ModifiedBy = @ModifiedBy,
	Removed = @Removed
WHERE CashTypeID = @CashTypeID 
          
	
SET NOCOUNT ON 
	RETURN
