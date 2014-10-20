USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Remove_Supplier]    Script Date: 26/09/2014 02:27:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

ALTER PROCEDURE [dbo].[f_Admin_Remove_Supplier] 
	@SupplierID int,
	@Removed bit,
	@UpdatedBy int,
	@UpdatedDate datetime
   
AS
UPDATE [t_Supplier] 
SET         
	Removed = @Removed,
	UpdatedBy = @UpdatedBy,
	UpdatedDate = @UpdatedDate
WHERE SupplierID = @SupplierID 
          
	
SET NOCOUNT ON 
	RETURN