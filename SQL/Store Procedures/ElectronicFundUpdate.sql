USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_ElectronicFund]    Script Date: 26/09/2014 02:27:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

ALTER PROCEDURE [dbo].[f_Admin_Update_ElectronicFund] 
		@ElectronicFundID int,
		@ElectronicFunds int,
		@Total varchar(50),
		@ElectronicTypeID varchar(50),
		@UserID varchar(50),
		@UserTypeID int,
		@Removed bit,
		@UpdatedDate datetime,
		@UpdatedBy int
	
   
AS
UPDATE [t_ElectronicFund] 
           SET
		ElectronicFunds=@ElectronicFunds,
		Total=@Total,
		ElectronicTypeID=@ElectronicTypeID,
		UserID=@UserID,
		UserTypeID=@UserTypeID,
		Removed=@Removed,
		UpdatedDate=@UpdatedDate,
		UpdatedBy=@UpdatedBy  
where ElectronicFundID =@ElectronicFundID
          
	
SET NOCOUNT ON 
	RETURN