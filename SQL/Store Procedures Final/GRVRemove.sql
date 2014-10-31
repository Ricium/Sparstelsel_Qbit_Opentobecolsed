USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Remove_GRVList]    Script Date: 26/09/2014 02:27:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Remove_GRVList] 
	@GRVListID int,
	@ModifiedDate datetime,
	@ModifiedBy int,
	@Remove bit
   
AS
UPDATE [t_GRVList] 
SET         
	@ModifiedDate = @ModifiedDate,
	@ModifiedBy = @ModifiedBy,
	@Remove = @Remove
WHERE GRVListID = @GRVListID
          
	
SET NOCOUNT ON 
	RETURN