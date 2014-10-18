using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SparStelsel
{
    /// <summary>
    /// Stored Procedures is a collection of static readonly strings assosiated with the Stored Procedures in the Database.
    /// This is to allow the developers to only change a single member to propagate across the project. 
    /// </summary>
    public class StoredProcedures
    {       
        public static readonly string InsertUser = "Insert_User";

        public static readonly string KwikPayInsert = "Insert_Kwikpay";
        public static readonly string KwikPayUpdate = "Update_Kwikpay";
        public static readonly string KwikPayRemove = "Remove_Kwikpay";

        public static readonly string BudgetInsert = "BudgetInsert";
        public static readonly string BudgetRemove = "BudgetRemove";
        public static readonly string BudgetUpdate = "BudgetUpdate";

        public static readonly string CashBoxInsert = "CashBoxInsert";
        public static readonly string CashBoxRemove = "CashBoxRemove";
        public static readonly string CashBoxUpdate = "CashBoxUpdate";

        public static readonly string CashMovementInsert = "CashMovementInsert";
        public static readonly string CashMovementRemove = "CashMovementRemove";
        public static readonly string CashMovementUpdate = "CashMovementUpdate";

        public static readonly string CashReconcilationInsert = "CashReconcilationInsert";
        public static readonly string CashReconcilationRemove = "CashReconcilationRemove";
        public static readonly string CashReconcilationUpdate = "CashReconcilationUpdate";

        public static readonly string CashTypeInsert = "CashTypeInsert";
        public static readonly string CashTypeRemove = "CashTypeRemove";
        public static readonly string CashTypeUpdate = "CashTypeUpdate";

        public static readonly string CoinMovementInsert = "CoinMovementInsert";
        public static readonly string CoinMovementRemove = "CoinMovementRemove";
        public static readonly string CoinMovementUpdate = "CoinMovementUpdate";

        public static readonly string CommentInsert = "CommentInsert";
        public static readonly string CommentRemove = "CommentRemove";
        public static readonly string CommentUpdate = "CommentUpdate";

        public static readonly string ElectronicFundInsert = "ElectronicFundInsert";
        public static readonly string ElectronicFundRemove = "ElectronicFundRemove";
        public static readonly string ElectronicFundUpdate = "ElectronicFundUpdate";

        public static readonly string FNBInsert = "FNBInsert";
        public static readonly string FNBRemove = "FNBRemove";
        public static readonly string FNBUpdate = "FNBUpdate";

        public static readonly string GRVListInsert = "GRVListInsert";
        public static readonly string GRVListRemove = "GRVListRemove";
        public static readonly string GRVListUpdate = "GRVListUpdate";

        public static readonly string GRVTypeInsert = "GRVTypeInsert";
        public static readonly string GRVTypeRemove = "GRVTypeRemove";
        public static readonly string GRVTypeUpdate = "GRVTypeUpdate";

        public static readonly string InstantMoneyInsert = "InstantMoneyInsert";
        public static readonly string InstantMoneyRemove = "InstantMoneyRemove";
        public static readonly string InstantMoneyUpdate = "InstantMoneyUpdate";

        public static readonly string InstantMoneyTypeInsert = "InstantMoneyTypeInsert";
        public static readonly string InstantMoneyTypeRemove = "InstantMoneyTypeRemove";
        public static readonly string InstantMoneyTypeUpdate = "InstantMoneyTypeUpdate";

        public static readonly string KwikPayTypeInsert = "KwikPayTypeInsert";
        public static readonly string KwikPayTypeRemove = "KwikPayTypeRemove";
        public static readonly string KwikPayTypeUpdate = "KwikPayTypeUpdate";

        public static readonly string MoneyUnitInsert = "MoneyUnitInsert";
        public static readonly string MoneyUnitRemove = "MoneyUnitRemove";
        public static readonly string MoneyUnitUpdate = "MoneyUnitUpdate";

        public static readonly string MovementTypeInsert = "MovementTypeInsert";
        public static readonly string MovementTypeRemove = "MovementTypeRemove";
        public static readonly string MovementTypeUpdate = "MovementTypeUpdate";

        public static readonly string OrderInsert = "OrderInsert";
        public static readonly string OrderRemove = "OrderRemove";
        public static readonly string OrderUpdate = "OrderUpdate";

        public static readonly string ProductInsert = "ProductInsert";
        public static readonly string ProductUpdate = "ProductUpdate";
        public static readonly string ProductRemove = "ProductRemove";

        public static readonly string PickUpUpdate = "PickUpUpdate";
        public static readonly string PickUpInsert = "PickUpInsert";
        public static readonly string PickUpRemove = "PickUpRemove";
     
        public static readonly string ProofOfPaymentInsert = "ProofOfPaymentInsert";
        public static readonly string ProofOfPaymentRemove = "ProofOfPaymentRemove";

        public static readonly string SupplierInsert = "SupplierInsert";
        public static readonly string SupplierRemove = "SupplierRemove";
        public static readonly string SupplierUpdate = "SupplierUpdate";

        public static readonly string SupplierTypeRemove = "SupplierTypeRemove";
        public static readonly string SupplierTypeUpdate = "SupplierTypeUpdate";
        public static readonly string SupplierTypeInsert = "SupplierTypeInsert";

        public static readonly string TransitInsert = "TransitInsert";
        public static readonly string TransitRemove = "TransitRemove";
        public static readonly string TransitUpdate = "TransitUpdate";

        public static readonly string UserInsert = "UserInsert";
        public static readonly string UserRemove = "UserRemove";
        public static readonly string UserUpdate = "UserUpdate";

        public static readonly string UserTypeInsert = "UserTypeInsert";
        public static readonly string UserTypeRemove = "UserTypeRemove";
        public static readonly string UserTypeUpdate = "UserTypeUpdate";

        public static readonly string UserTypePermissionInsert = "UserTypePermissionInsert";
        public static readonly string UserTypePermissionRemove = "UserTypePermissionRemove";
        public static readonly string UserTypePermissionUpdate = "UserTypePermissionUpdate";

        public static readonly string CommentTypeInsert = "CommentTypeInsert";
        public static readonly string CommentTypeRemove = "CommentTypeRemove";
        public static readonly string CommentTypeUpdate = "CommentTypeUpdate";

        public static readonly string PermissionInsert = "PermissionInsert";
        public static readonly string PermissionRemove = "PermissionRemove";
        public static readonly string PermissionUpdate = "PermissionUpdate";
        
    }
}