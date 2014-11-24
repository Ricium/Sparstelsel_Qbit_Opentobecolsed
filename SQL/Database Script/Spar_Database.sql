use master
go
create database Spar_Database
go

use Spar_Database
GO

Create table l_Budget
(
BudgetID int identity(1,1) primary key not null,
BudgetDate datetime,
Amount decimal(18,2),
CompanyID int,
ModifiedDate datetime,
ModifiedBy int,
Removed bit
)
go

Create table l_Permission
(
PermissionID int identity(1,1) primary key not null,
Permission varchar(50),
CompanyID int

)

Create table t_UserTypePermission
(
UserTypePermissionID int identity(1,1) primary key not null,
PermissionID int,
UserTypeID int,
CompanyID int
)

Create table l_UserType
(
UserTypeID int identity(1,1) primary key not null,
UserType varchar(50),
CompanyID int
)

Create table t_User
(
UserID int identity(1,1) primary key not null,
UserName varchar(50),
UserSurname varchar(50),
ID varchar(50),
UserCell varchar(20),
UserEmail varchar(50),
UserTypeID int,
CompanyID int
)

Create table l_SupplierType
(
SupplierTypeID int identity(1,1) primary key not null,
SupplierType varchar(50),
CompanyID int,
ModifiedDate datetime,
ModifiedBy int,
Removed bit
)

Create table t_Supplier
(
SupplierID int identity(1,1) primary key not null,
Supplier varchar(50),
StockCondition varchar(50),
Term varchar(50),
CreatedDate datetime,
SupplierTypeID int,
ProductID int,
CompanyID int,
ModifiedDate datetime,
ModifiedBy int,
Removed bit
)

Create table t_Product
(
ProductID int identity(1,1) primary key not null,
Product varchar(50),
ProductDescription varchar(50),
Price decimal(18,2),
Quantity int,
Total int,
BTW decimal(18,2),
CreatedDate datetime,
CompanyID int,
ModifiedDate datetime,
ModifiedBy int,
Removed bit
)

Create table l_CommentType
(
CommentTypeID int identity(1,1) primary key not null,
CommentType varchar(50),
CompanyID int,
ModifiedDate datetime,
ModifiedBy int,
Removed bit
)

Create table t_Comment
(
CommentID int identity(1,1) primary key not null,
Comment varchar(100),
CreatedDate datetime,
CommentTypeID int,
CompanyID int,
ModifiedDate datetime,
ModifiedBy int,
Removed bit
)

Create table t_Order
(
OrderID int identity(1,1) primary key not null,
OrderDate datetime,
ExpectedDeliveryDate datetime,
Amount decimal(18,2),
CreatedDate datetime,
SupplierID int,
UserID int,
CommentID int,
CompanyID int,
ModifiedDate datetime,
ModifiedBy int,
Removed bit
)

Create table t_ProofOfPayment
(
ProofOfPaymentID int identity(1,1) primary key not null,
ActualDate datetime,
PaymentDescription varchar(50),
CreatedDate datetime,
SupplierID int,
CompanyID int,
ModifiedDate datetime,
ModifiedBy int,
Removed bit
)

Create table t_CashReconciliation
(
CashReconcilationID int identity(1,1) primary key not null,
ActualDate datetime,
CreatedDate datetime,
ReconciliationTypeID int,
UserID int,
CompanyID int,
ModifiedDate datetime,
ModifiedBy int,
Removed bit
)


Create table l_ReconciliationType
(
ReconciliationTypeID int identity(1,1) primary key not null,
ActualDate datetime,
UserID int,
CompanyID int,
ModifiedDate datetime,
ModifiedBy int,
Removed bit
)

Create table t_KwikPay
(
KwikPayID int identity(1,1) primary key not null,
ActualDate datetime,
Amount decimal(18,2),
CreatedDate datetime,
KwikPayTypeID int,
UserID int,
CompanyID int,
ModifiedDate datetime,
ModifiedBy int,
Removed bit
)

Create table l_KwikPayType
(
KwikPayTypeID int identity(1,1) primary key not null,
KwikPayType varchar(50),
CompanyID int,
ModifiedDate datetime,
ModifiedBy int,
Removed bit
)

Create table t_InstantMoney
(
InstantMoneyID int identity(1,1) primary key not null,
ActualDate datetime,
Amount decimal(18,2),
CreatedDate datetime,
InstantMoneyTypeID int,
UserID int,
CompanyID int,
ModifiedDate datetime,
ModifiedBy int,
Removed bit
)

Create table l_InstantMoneyType
(
InstantMoneyTypeID int identity(1,1) primary key not null,
InstantMoneyType varchar(50),
CompanyID int,
ModifiedDate datetime,
ModifiedBy int,
Removed bit
)

Create table t_FNB
(
FNBID int identity(1,1) primary key not null,
ActualDate datetime,
Amount decimal(18,2),
CreatedDate datetime,
FNBTypeID int,
UserID int,
CompanyID int,
ModifiedDate datetime,
ModifiedBy int,
Removed bit
)

Create table l_FNBType
(
FNBTypeID int identity(1,1) primary key not null,
FNBType varchar(50),
CompanyID int,
ModifiedDate datetime,
ModifiedBy int,
Removed bit
)

Create table t_ElectronicFund
(
ElectronicFundID int identity(1,1) primary key not null,
ElectronicFund varchar(50),
Total decimal(18,2),
CreatedDate datetime,
ElectronicTypeID int,
UserID int,
CompanyID int,
ModifiedDate datetime,
ModifiedBy int,
Removed bit
)

Create table l_ElectronicType 
(
ElectronicTypeID int identity(1,1) primary key not null,
ElectronicType varchar(50),
ElectronicTypeDescription varchar(50),
CompanyID int,
ModifiedDate datetime,
ModifiedBy int,
Removed bit
)

Create table l_MoneyUnit
(
MoneyUnitID int identity(1,1) primary key not null,
MoneyUnit varchar(50),
CompanyID int,
ModifiedDate datetime,
ModifiedBy int,
Removed bit
)

Create table l_MovementType
(
MovementTypeID int identity(1,1) primary key not null,
MovementType varchar(50),
CompanyID int,
ModifiedDate datetime,
ModifiedBy int,
Removed bit
)

Create table t_CoinMovement
(
CoinMovementID int identity(1,1) primary key not null,
ActualDate datetime,
Amount decimal(18,2),
CreatedDate datetime,
MovementTypeID int,
MoneyUnitID int,
UserID int,
CompanyID int,
ModifiedDate datetime,
ModifiedBy int,
Removed bit
)

Create table t_CashBox
(
CashBoxID int identity(1,1) primary key not null,
ActualDate datetime,
Amount decimal(18,2),
CreatedDate datetime,
MovementTypeID int,
CompanyID int,
ModifiedDate datetime,
ModifiedBy int,
Removed bit
)

Create table l_CashType
(
CashTypeID int identity(1,1) primary key not null,
CashType varchar(50),
CompanyID int,
ModifiedDate datetime,
ModifiedBy int,
Removed bit
)

Create table t_PickUp
(
PickUpID int identity(1,1) primary key not null,
ActualDate datetime,
Amount decimal(18,2),
CreatedDate datetime,
CashTypeID int,
UserID int,
CompanyID int,
ModifiedDate datetime,
ModifiedBy int,
Removed bit
)

Create table t_CashMovement  
(
CashMovementID int identity(1,1) primary key not null,
ActualDate datetime,
Amount decimal(18,2),
CreatedDate datetime,
CashTypeID int,
MoneyUnitID int,
UserID int,
CompanyID int,
ModifiedDate datetime,
ModifiedBy int,
Removed bit
)

Create table t_Transit
(
TransitID int identity(1,1) primary key not null,
ActualDate datetime,
Amount decimal(18,2),
CreatedDate datetime,
CompanyID int,
ModifiedDate datetime,
ModifiedBy int,
Removed bit
)

Create table l_GRVType
(
GRVTypeID int identity(1,1) primary key not null,
GRVType varchar(50),
CompanyID int,
ModifiedDate datetime,
ModifiedBy int,
Removed bit
)
go

Create table t_GRVList 
(
GRVListID int identity(1,1) primary key not null,
InvoiceNumber varchar(50),
StateDate datetime,
Number varchar(50),
PayDate datetime,
PinkSlipNumber varchar(10),
GRVDate datetime,
InvoiceDate datetime,
ExcludingVat decimal(18,2),
IncludingVat decimal(18,2),
CreatedDate datetime,
GRVTypeID int,
SupplierID int,
CompanyID int,
ModifiedDate datetime,
ModifiedBy int,
Removed bit
)

