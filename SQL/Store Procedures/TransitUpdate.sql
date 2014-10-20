USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_Transit]    Script Date: 26/09/2014 02:27:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

ALTER PROCEDURE [dbo].[f_Admin_Update_Transit] 
		@ActualDate datetime,
		@ModifiedDate datetime,
		@Amount decimal(18,2),
		@Removed bit,
		@UpdatedDate datetime,
		@UpdatedBy int
	
   
AS
UPDATE [l_Transit] 
           SET
		ActualDate=@ActualDate,
		ModifiedDate=@ModifiedDate,
		Amount=@Amount,
		Removed=@Removed,
		UpdatedDate=@UpdatedDate,
		UpdatedBy=@UpdatedBy  
where TransitID =@TransitID 
          
	
SET NOCOUNT ON 
	RETURN