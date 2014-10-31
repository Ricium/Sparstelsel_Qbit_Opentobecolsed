USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Remove_Product]    Script Date: 26/09/2014 02:27:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Remove_Product] 
	@ProductID int,
	@ModifiedDate datetime,
	@ModifiedBy int,
	@Removed bit
   
AS
UPDATE [t_Product] 
SET         
	ModifiedDate = @ModifiedDate,
	ModifiedBy = @ModifiedBy,
	Removed = @Removed
WHERE ProductID = @ProductID
          
	
SET NOCOUNT ON 
	RETURN