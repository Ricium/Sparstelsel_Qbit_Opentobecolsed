USE [Spar_Database]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

CREATE PROCEDURE [dbo].[f_Admin_Remove_SparRecon] 
	@SparReconId int,
	@ModifiedDate datetime,
	@ModifiedBy varchar (100),
	@Removed bit
   
AS
UPDATE [t_SparRecon] 
SET         
	ModifiedDate = @ModifiedDate,
	ModifiedBy = @ModifiedBy,
	Removed = @Removed
WHERE SparReconId = @SparReconId
          
	
SET NOCOUNT ON 
	RETURN


