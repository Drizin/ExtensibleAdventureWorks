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

    // PurchaseOrderDetail
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.28.0.0")]
    public partial class Purchasing_PurchaseOrderDetail
    {

        ///<summary>
        /// Primary key. Foreign key to PurchaseOrderHeader.PurchaseOrderID.
        ///</summary>
        public int PurchaseOrderId { get; set; } // PurchaseOrderID (Primary key)

        ///<summary>
        /// Primary key. One line number per purchased product.
        ///</summary>
        public int PurchaseOrderDetailId { get; set; } // PurchaseOrderDetailID (Primary key)

        ///<summary>
        /// Date the product is expected to be received.
        ///</summary>
        public System.DateTime DueDate { get; set; } // DueDate

        ///<summary>
        /// Quantity ordered.
        ///</summary>
        public short OrderQty { get; set; } // OrderQty

        ///<summary>
        /// Product identification number. Foreign key to Product.ProductID.
        ///</summary>
        public int ProductId { get; set; } // ProductID

        ///<summary>
        /// Vendor&apos;s selling price of a single product.
        ///</summary>
        public decimal UnitPrice { get; set; } // UnitPrice

        ///<summary>
        /// Per product subtotal. Computed as OrderQty * UnitPrice.
        ///</summary>
        public decimal LineTotal { get; private set; } // LineTotal

        ///<summary>
        /// Quantity actually received from the vendor.
        ///</summary>
        public decimal ReceivedQty { get; set; } // ReceivedQty

        ///<summary>
        /// Quantity rejected during inspection.
        ///</summary>
        public decimal RejectedQty { get; set; } // RejectedQty

        ///<summary>
        /// Quantity accepted into inventory. Computed as ReceivedQty - RejectedQty.
        ///</summary>
        public decimal StockedQty { get; private set; } // StockedQty

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        public System.DateTime ModifiedDate { get; set; } = System.DateTime.Now; // ModifiedDate

        // Foreign keys

        /// <summary>
        /// Parent Production_Product pointed by [PurchaseOrderDetail].([ProductId]) (FK_PurchaseOrderDetail_Product_ProductID)
        /// </summary>
        public virtual Production_Product Production_Product { get; set; } // FK_PurchaseOrderDetail_Product_ProductID
        /// <summary>
        /// Parent Purchasing_PurchaseOrderHeader pointed by [PurchaseOrderDetail].([PurchaseOrderId]) (FK_PurchaseOrderDetail_PurchaseOrderHeader_PurchaseOrderID)
        /// </summary>
        public virtual Purchasing_PurchaseOrderHeader Purchasing_PurchaseOrderHeader { get; set; } // FK_PurchaseOrderDetail_PurchaseOrderHeader_PurchaseOrderID
    }

}
// </auto-generated>