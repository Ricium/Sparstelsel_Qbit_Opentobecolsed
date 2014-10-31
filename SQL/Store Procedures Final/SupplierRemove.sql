USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Remove_Supplier]    Script Date: 26/09/2014 02:27:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Remove_Supplier] 
	@SupplierID int,
	@ModifiedDate datetime,
	@ModifiedBy int,
	@Removed bit
   
AS
UPDATE [t_Supplier] 
SET         
	
	ModifiedBy = @ModifiedBy,
	ModifiedDate = @ModifiedDate,
	Removed = @Removed
WHERE SupplierID = @SupplierID 
          
	
SET NOCOUNT ON 
	RETURN