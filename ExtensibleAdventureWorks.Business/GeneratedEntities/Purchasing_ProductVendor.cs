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

    // ProductVendor
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.28.0.0")]
    public partial class Purchasing_ProductVendor
    {

        ///<summary>
        /// Primary key. Foreign key to Product.ProductID.
        ///</summary>
        public int ProductId { get; set; } // ProductID (Primary key)

        ///<summary>
        /// Primary key. Foreign key to Vendor.BusinessEntityID.
        ///</summary>
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key)

        ///<summary>
        /// The average span of time (in days) between placing an order with the vendor and receiving the purchased product.
        ///</summary>
        public int AverageLeadTime { get; set; } // AverageLeadTime

        ///<summary>
        /// The vendor&apos;s usual selling price.
        ///</summary>
        public decimal StandardPrice { get; set; } // StandardPrice

        ///<summary>
        /// The selling price when last purchased.
        ///</summary>
        public decimal? LastReceiptCost { get; set; } // LastReceiptCost

        ///<summary>
        /// Date the product was last received by the vendor.
        ///</summary>
        public System.DateTime? LastReceiptDate { get; set; } // LastReceiptDate

        ///<summary>
        /// The maximum quantity that should be ordered.
        ///</summary>
        public int MinOrderQty { get; set; } // MinOrderQty

        ///<summary>
        /// The minimum quantity that should be ordered.
        ///</summary>
        public int MaxOrderQty { get; set; } // MaxOrderQty

        ///<summary>
        /// The quantity currently on order.
        ///</summary>
        public int? OnOrderQty { get; set; } // OnOrderQty

        ///<summary>
        /// The product&apos;s unit of measure.
        ///</summary>
        public string UnitMeasureCode { get; set; } // UnitMeasureCode (length: 3)

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        public System.DateTime ModifiedDate { get; set; } = System.DateTime.Now; // ModifiedDate

        // Foreign keys

        /// <summary>
        /// Parent Production_Product pointed by [ProductVendor].([ProductId]) (FK_ProductVendor_Product_ProductID)
        /// </summary>
        public virtual Production_Product Production_Product { get; set; } // FK_ProductVendor_Product_ProductID
        /// <summary>
        /// Parent Production_UnitMeasure pointed by [ProductVendor].([UnitMeasureCode]) (FK_ProductVendor_UnitMeasure_UnitMeasureCode)
        /// </summary>
        public virtual Production_UnitMeasure Production_UnitMeasure { get; set; } // FK_ProductVendor_UnitMeasure_UnitMeasureCode
        /// <summary>
        /// Parent Purchasing_Vendor pointed by [ProductVendor].([BusinessEntityId]) (FK_ProductVendor_Vendor_BusinessEntityID)
        /// </summary>
        public virtual Purchasing_Vendor Purchasing_Vendor { get; set; } // FK_ProductVendor_Vendor_BusinessEntityID
    }

}
// </auto-generated>