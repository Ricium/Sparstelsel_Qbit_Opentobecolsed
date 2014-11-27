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

        public static readonly string KwikPayInsert = "f_Admin_Insert_Kwikpay";
        public static readonly string KwikPayUpdate = "f_Admin_Update_Kwikpay";
        public static readonly string KwikPayRemove = "f_Admin_Remove_Kwikpay";

        public static readonly string BudgetInsert = "f_Admin_Insert_Budget";
        public static readonly string BudgetRemove = "f_Admin_Remove_Budget";
        public static readonly string BudgetUpdate = "f_Admin_Update_Budget";

        public static readonly string CashBoxInsert = "f_Admin_Insert_CashBox";
        public static readonly string CashBoxRemove = "f_Admin_Remove_CashBox";
        public static readonly string CashBoxUpdate = "f_Admin_Update_CashBox";

        public static readonly string CashMovementInsert = "f_Admin_Insert_CashMovement";
        public static readonly string CashMovementRemove = "f_Admin_Remove_CashMovement";
        public static readonly string CashMovementUpdate = "f_Admin_Update_CashMovement";

        public static readonly string CashReconcilationInsert = "f_Admin_Insert_CashReconcilation";
        public static readonly string CashReconcilationRemove = "f_Admin_Remove_CashReconcilation";
        public static readonly string CashReconcilationUpdate = "f_Admin_Update_CashReconcilation";

        public static readonly string CashTypeInsert = "f_Admin_Insert_CashType";
        public static readonly string CashTypeRemove = "f_Admin_Remove_CashType";
        public static readonly string CashTypeUpdate = "f_Admin_Update_CashType";

        public static readonly string CoinMovementInsert = "f_Admin_Insert_CoinMovement";
        public static readonly string CoinMovementRemove = "f_Admin_Remove_CoinMovement";
        public static readonly string CoinMovementUpdate = "f_Admin_Update_CoinMovement";

        public static readonly string CommentInsert = "f_Admin_Insert_Comment";
        public static readonly string CommentRemove = "f_Admin_Remove_Comment";
        public static readonly string CommentUpdate = "f_Admin_Update_Comment";

        public static readonly string ElectronicFundInsert = "f_Admin_Insert_ElectronicFund";
        public static readonly string ElectronicFundRemove = "f_Admin_Remove_ElectronicFund";
        public static readonly string ElectronicFundUpdate = "f_Admin_Update_ElectronicFund";

        public static readonly string FNBInsert = "f_Admin_Insert_FNB";
        public static readonly string FNBRemove = "f_Admin_Remove_FNB";
        public static readonly string FNBUpdate = "f_Admin_Update_FNB";

        public static readonly string GRVListInsert = "f_Admin_Insert_GRVList";
        public static readonly string GRVListRemove = "f_Admin_Remove_GRVList";
        public static readonly string GRVListUpdate = "f_Admin_Update_GRVList";

        public static readonly string GRVTypeInsert = "f_Admin_Insert_GRVType";
        public static readonly string GRVTypeRemove = "f_Admin_Remove_GRVType";
        public static readonly string GRVTypeUpdate = "f_Admin_Update_GRVType";

        public static readonly string InstantMoneyInsert = "f_Admin_Insert_InstantMoney";
        public static readonly string InstantMoneyRemove = "f_Admin_Remove_InstantMoney";
        public static readonly string InstantMoneyUpdate = "f_Admin_Update_InstantMoney";

        public static readonly string InstantMoneyTypeInsert = "f_Admin_Insert_InstantMoneyType";
        public static readonly string InstantMoneyTypeRemove = "f_Admin_Remove_InstantMoneyType";
        public static readonly string InstantMoneyTypeUpdate = "f_Admin_Update_InstantMoneyType";

        public static readonly string KwikPayTypeInsert = "f_Admin_Insert_KwikPayType";
        public static readonly string KwikPayTypeRemove = "f_Admin_Remove_KwikPayType";
        public static readonly string KwikPayTypeUpdate = "f_Admin_Update_KwikPayType";

        public static readonly string MoneyUnitInsert = "f_Admin_Insert_MoneyUnit";
        public static readonly string MoneyUnitRemove = "f_Admin_Remove_MoneyUnit";
        public static readonly string MoneyUnitUpdate = "f_Admin_Update_MoneyUnit";

        public static readonly string MovementTypeInsert = "f_Admin_Insert_MovementType";
        public static readonly string MovementTypeRemove = "f_Admin_Remove_MovementType";
        public static readonly string MovementTypeUpdate = "f_Admin_Update_MovementType";

        public static readonly string OrderInsert = "f_Admin_Insert_Order";
        public static readonly string OrderRemove = "f_Admin_Remove_Order";
        public static readonly string OrderUpdate = "f_Admin_Update_Order";

        public static readonly string ProductInsert = "f_Admin_Insert_Product";
        public static readonly string ProductUpdate = "f_Admin_Update_Product";
        public static readonly string ProductRemove = "f_Admin_Remove_Product";

        public static readonly string PickUpUpdate = "f_Admin_Update_PickUp";
        public static readonly string PickUpInsert = "f_Admin_Insert_PickUp";
        public static readonly string PickUpRemove = "f_Admin_Remove_PickUp";

        public static readonly string ProofOfPaymentInsert = "f_Admin_Insert_ProofOfPayment";
        public static readonly string ProofOfPaymentRemove = "ProofOfPaymentRemove";

        public static readonly string SupplierInsert = "f_Admin_Insert_Supplier";
        public static readonly string SupplierRemove = "f_Admin_Remove_Supplier";
        public static readonly string SupplierUpdate = "f_Admin_Update_Supplier";

        public static readonly string SupplierTypeRemove = "f_Admin_Remove_SupplierType";
        public static readonly string SupplierTypeUpdate = "f_Admin_Update_SupplierType";
        public static readonly string SupplierTypeInsert = "f_Admin_Insert_SupplierType";

        public static readonly string TransitInsert = "f_Admin_Insert_Transit";
        public static readonly string TransitRemove = "f_Admin_Remove_Transit";
        public static readonly string TransitUpdate = "f_Admin_Update_Transit";

        public static readonly string UserInsert = "f_Admin_Insert_User";
        public static readonly string UserRemove = "f_Admin_Remove_User";
        public static readonly string UserUpdate = "f_Admin_Update_User";

        public static readonly string UserTypeInsert = "f_Admin_Insert_UserType";
        public static readonly string UserTypeRemove = "f_Admin_Remove_UserType";
        public static readonly string UserTypeUpdate = "f_Admin_Update_UserType";

        public static readonly string UserTypePermissionInsert = "f_Admin_Insert_UserTypePermission";
        public static readonly string UserTypePermissionRemove = "f_Admin_Remove_UserTypePermission";
        public static readonly string UserTypePermissionUpdate = "f_Admin_Update_UserTypePermission";

        public static readonly string CommentTypeInsert = "f_Admin_Insert_CommentType";
        public static readonly string CommentTypeRemove = "f_Admin_Remove_CommentType";
        public static readonly string CommentTypeUpdate = "f_Admin_Update_CommentType";

        public static readonly string PermissionInsert = "f_Admin_Insert_Permission";
        public static readonly string PermissionRemove = "f_Admin_Remove_Permission";
        public static readonly string PermissionUpdate = "f_Admin_Update_Permission";

        public static readonly string ElectronicTypeInsert = "f_Admin_Insert_ElectronicType";
        public static readonly string ElectronicTypeRemove = "f_Admin_Remove_ElectronicType";
        public static readonly string ElectronicTypeUpdate = "f_Admin_Update_ElectronicType";

        public static readonly string FNBTypeInsert = "f_Admin_Insert_FNBType";
        public static readonly string FNBTypeUpdate = "f_Admin_Update_FNBType";


        public static readonly string StatusInsert = "f_Admin_Insert_Status";
        public static readonly string StatusRemove = "f_Admin_Remove_Status";
        public static readonly string StatusUpdate = "f_Admin_Update_Status";
        
    }
}