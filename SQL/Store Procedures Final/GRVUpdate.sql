USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_MemberSpouse]    Script Date: 26/09/2014 02:27:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Update_GRVList] 
		@GRVListID int,
		@InvoiceNumber varchar(50),
		@StateDate datetime,
		@Number varchar(50),
		@PayDate datetime,
		@PinkSlipNumber varchar(10),
		@GRVDate datetime,
		@InvoiceDate datetime,
		@ExcludingVat decimal,
		@IncludingVat decimal,
		@CreatedDate datetime,
		@GRVTypeID int,
		@SupplierID int,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int
	
   
AS
UPDATE [t_GRVList] 
           SET
		InvoiceNumber=@InvoiceNumber,
		StateDate=@StateDate,
		Number=@Number,
		PayDate=@PayDate,
		PinkSlipNumber=@PinkSlipNumber,
		GRVDate=@GRVDate,
		InvoiceDate=@InvoiceDate,
		ExcludingVat=@ExcludingVat,
		IncludingVat=@IncludingVat,
		CreatedDate=@CreatedDate,
		GRVTypeID=@GRVTypeID,
		SupplierID=@SupplierID,
		CompanyID=@CompanyID,
		ModifiedDate=@ModifiedDate,
		ModifiedBy=@ModifiedBy  
where GRVListID =@GRVListID
          
	
SET NOCOUNT ON 
	RETURN