USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Remove_InstantMoney]    Script Date: 26/09/2014 02:27:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

ALTER PROCEDURE [dbo].[f_Admin_Remove_InstantMoney] 
	@InstantMoneyID int,
	@Removed bit,
	@UpdatedBy int,
	@UpdatedDate datetime
   
AS
UPDATE [t_InstantMoney] 
SET         
	Removed = @Removed,
	UpdatedBy = @UpdatedBy,
	UpdatedDate = @UpdatedDate
WHERE InstantMoneyID = @InstantMoneyID
          
	
SET NOCOUNT ON 
	RETURN