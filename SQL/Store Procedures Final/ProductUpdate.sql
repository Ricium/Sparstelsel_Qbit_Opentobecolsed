USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_Product]    Script Date: 26/09/2014 02:27:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Update_Product] 
		@ProductID int,
		@Products varchar(50),
		@ProductDescription varchar(50),
		@Price decimal(18,2),
		@Quantity varchar(50),
		@Total int,
		@BTW decimal(18,2),
		@CreatedDate datetime,
		@CamponyID int,
		@ModifiedDate datetime,
		@ModifiedBy int,
		@Removed bit
	
   
AS
UPDATE [t_Product] 
           SET
		Products=@Products,
		ProductDescription=@ProductDescription,
		Price=@Price,
		Quantity=@Quantity,
		Total=@Total,
		BTW=@BTW,
		Removed=@Removed ,
		ModifiedDate=@ModifiedDate,
		ModifiedBy=@ModifiedBy  
where ProductID =@ProductID
          
	
SET NOCOUNT ON 
	RETURN