USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_ElectronicFund]    Script Date: 26/09/2014 02:27:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Update_ElectronicFund] 
		@ElectronicFundID int,
		@ElectronicFunds varchar(50),
		@Total decimal(18,2),
		@CreatedDate datetime,
		@ElectronicTypeID int,
		@UserID int,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int
	
   
AS
UPDATE [t_ElectronicFund] 
           SET
		ElectronicFunds=@ElectronicFunds,
		Total=@Total,
		CreatedDate=@CreatedDate,
		ElectronicTypeID=@ElectronicTypeID,
		UserID=@UserID,
		CompanyID=@CompanyID,
		ModifiedDate=@ModifiedDate,
		ModifiedBy=@ModifiedBy  
where ElectronicFundID =@ElectronicFundID
          
	
SET NOCOUNT ON 
	RETURN