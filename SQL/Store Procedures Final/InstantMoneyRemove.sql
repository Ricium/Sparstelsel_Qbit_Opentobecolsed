USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Remove_InstantMoney]    Script Date: 26/09/2014 02:27:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

alter PROCEDURE [dbo].[f_Admin_Remove_InstantMoney] 
	@InstantMoneyID int,
	@ModifiedDate datetime,
	@ModifiedBy int,
	@Removed bit
   
AS
UPDATE [t_InstantMoney] 
SET         
	ModifiedDate = @ModifiedDate,
	ModifiedBy = @ModifiedBy,
	Removed = @Removed
WHERE InstantMoneyID = @InstantMoneyID
          
	
SET NOCOUNT ON 
	RETURN