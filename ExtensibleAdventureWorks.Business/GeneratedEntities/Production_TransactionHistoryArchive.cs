// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.5
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace ExtensibleAdventureWorks.Business.Entities
{

    // TransactionHistoryArchive
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.28.0.0")]
    public partial class Production_TransactionHistoryArchive
    {

        ///<summary>
        /// Primary key for TransactionHistoryArchive records.
        ///</summary>
        public int TransactionId { get; set; } // TransactionID (Primary key)

        ///<summary>
        /// Product identification number. Foreign key to Product.ProductID.
        ///</summary>
        public int ProductId { get; set; } // ProductID

        ///<summary>
        /// Purchase order, sales order, or work order identification number.
        ///</summary>
        public int ReferenceOrderId { get; set; } // ReferenceOrderID

        ///<summary>
        /// Line number associated with the purchase order, sales order, or work order.
        ///</summary>
        public int ReferenceOrderLineId { get; set; } = 0; // ReferenceOrderLineID

        ///<summary>
        /// Date and time of the transaction.
        ///</summary>
        public System.DateTime TransactionDate { get; set; } = System.DateTime.Now; // TransactionDate

        ///<summary>
        /// W = Work Order, S = Sales Order, P = Purchase Order
        ///</summary>
        public string TransactionType { get; set; } // TransactionType (length: 1)

        ///<summary>
        /// Product quantity.
        ///</summary>
        public int Quantity { get; set; } // Quantity

        ///<summary>
        /// Product cost.
        ///</summary>
        public decimal ActualCost { get; set; } // ActualCost

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        public System.DateTime ModifiedDate { get; set; } = System.DateTime.Now; // ModifiedDate
    }

}
// </auto-generated>