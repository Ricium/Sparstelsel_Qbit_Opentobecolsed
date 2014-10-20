USE [Spar_Database]
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_MemberSpouse]    Script Date: 26/09/2014 02:27:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

ALTER PROCEDURE [dbo].[f_Admin_Update_GRVList] 
		@GRVListID int,
		@InvoiceNumber int,
		@StateDate datetime,
		@Number varchar(50),
		@PayDate datetime,
		@PinkSlipNumber varchar(50),
		@GRVDate datetime,
		@InvoiceDate datetime,
		@ExcludingVat decimal(18,2),
		@IncludingVat decimal(18,2),
		@GRVTypeID int,
		@SupplierID int,
		@SupplierTypeID int,
		@Removed bit,
		@UpdatedDate datetime,
		@UpdatedBy int
	
   
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
		GRVTypeID=@GRVTypeID,
		SupplierID=@SupplierID,
		SupplierTypeID=@SupplierTypeID,
		Removed=@Removed ,
		UpdatedDate=@UpdatedDate ,
		UpdatedBy=@UpdatedBy  
where GRVListID =@GRVListID
          
	
SET NOCOUNT ON 
	RETURN