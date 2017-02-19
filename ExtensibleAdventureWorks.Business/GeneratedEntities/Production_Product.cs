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

    // Product
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.28.0.0")]
    public partial class Production_Product
    {

        ///<summary>
        /// Primary key for Product records.
        ///</summary>
        public int ProductId { get; set; } // ProductID (Primary key)

        ///<summary>
        /// Name of the product.
        ///</summary>
        public string Name { get; set; } // Name (length: 50)

        ///<summary>
        /// Unique product identification number.
        ///</summary>
        public string ProductNumber { get; set; } // ProductNumber (length: 25)

        ///<summary>
        /// 0 = Product is purchased, 1 = Product is manufactured in-house.
        ///</summary>
        public bool MakeFlag { get; set; } = true; // MakeFlag

        ///<summary>
        /// 0 = Product is not a salable item. 1 = Product is salable.
        ///</summary>
        public bool FinishedGoodsFlag { get; set; } = true; // FinishedGoodsFlag

        ///<summary>
        /// Product color.
        ///</summary>
        public string Color { get; set; } // Color (length: 15)

        ///<summary>
        /// Minimum inventory quantity.
        ///</summary>
        public short SafetyStockLevel { get; set; } // SafetyStockLevel

        ///<summary>
        /// Inventory level that triggers a purchase order or work order.
        ///</summary>
        public short ReorderPoint { get; set; } // ReorderPoint

        ///<summary>
        /// Standard cost of the product.
        ///</summary>
        public decimal StandardCost { get; set; } // StandardCost

        ///<summary>
        /// Selling price.
        ///</summary>
        public decimal ListPrice { get; set; } // ListPrice

        ///<summary>
        /// Product size.
        ///</summary>
        public string Size { get; set; } // Size (length: 5)

        ///<summary>
        /// Unit of measure for Size column.
        ///</summary>
        public string SizeUnitMeasureCode { get; set; } // SizeUnitMeasureCode (length: 3)

        ///<summary>
        /// Unit of measure for Weight column.
        ///</summary>
        public string WeightUnitMeasureCode { get; set; } // WeightUnitMeasureCode (length: 3)

        ///<summary>
        /// Product weight.
        ///</summary>
        public decimal? Weight { get; set; } // Weight

        ///<summary>
        /// Number of days required to manufacture the product.
        ///</summary>
        public int DaysToManufacture { get; set; } // DaysToManufacture

        ///<summary>
        /// R = Road, M = Mountain, T = Touring, S = Standard
        ///</summary>
        public string ProductLine { get; set; } // ProductLine (length: 2)

        ///<summary>
        /// H = High, M = Medium, L = Low
        ///</summary>
        public string Class { get; set; } // Class (length: 2)

        ///<summary>
        /// W = Womens, M = Mens, U = Universal
        ///</summary>
        public string Style { get; set; } // Style (length: 2)

        ///<summary>
        /// Product is a member of this product subcategory. Foreign key to ProductSubCategory.ProductSubCategoryID.
        ///</summary>
        public int? ProductSubcategoryId { get; set; } // ProductSubcategoryID

        ///<summary>
        /// Product is a member of this product model. Foreign key to ProductModel.ProductModelID.
        ///</summary>
        public int? ProductModelId { get; set; } // ProductModelID

        ///<summary>
        /// Date the product was available for sale.
        ///</summary>
        public System.DateTime SellStartDate { get; set; } // SellStartDate

        ///<summary>
        /// Date the product was no longer available for sale.
        ///</summary>
        public System.DateTime? SellEndDate { get; set; } // SellEndDate

        ///<summary>
        /// Date the product was discontinued.
        ///</summary>
        public System.DateTime? DiscontinuedDate { get; set; } // DiscontinuedDate

        ///<summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        ///</summary>
        public System.Guid Rowguid { get; set; } = System.Guid.NewGuid(); // rowguid

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        public System.DateTime ModifiedDate { get; set; } = System.DateTime.Now; // ModifiedDate

        // Reverse navigation

        /// <summary>
        /// Child Production_BillOfMaterials where [BillOfMaterials].[ComponentID] point to this entity (FK_BillOfMaterials_Product_ComponentID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Production_BillOfMaterial> Component { get; set; } = new System.Collections.Generic.List<Production_BillOfMaterial>(); // BillOfMaterials.FK_BillOfMaterials_Product_ComponentID
        /// <summary>
        /// Child Production_BillOfMaterials where [BillOfMaterials].[ProductAssemblyID] point to this entity (FK_BillOfMaterials_Product_ProductAssemblyID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Production_BillOfMaterial> ProductAssembly { get; set; } = new System.Collections.Generic.List<Production_BillOfMaterial>(); // BillOfMaterials.FK_BillOfMaterials_Product_ProductAssemblyID
        /// <summary>
        /// Child Production_ProductCostHistories where [ProductCostHistory].[ProductID] point to this entity (FK_ProductCostHistory_Product_ProductID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Production_ProductCostHistory> Production_ProductCostHistories { get; set; } = new System.Collections.Generic.List<Production_ProductCostHistory>(); // ProductCostHistory.FK_ProductCostHistory_Product_ProductID
        /// <summary>
        /// Child Production_ProductDocuments where [ProductDocument].[ProductID] point to this entity (FK_ProductDocument_Product_ProductID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Production_ProductDocument> Production_ProductDocuments { get; set; } = new System.Collections.Generic.List<Production_ProductDocument>(); // ProductDocument.FK_ProductDocument_Product_ProductID
        /// <summary>
        /// Child Production_ProductInventories where [ProductInventory].[ProductID] point to this entity (FK_ProductInventory_Product_ProductID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Production_ProductInventory> Production_ProductInventories { get; set; } = new System.Collections.Generic.List<Production_ProductInventory>(); // ProductInventory.FK_ProductInventory_Product_ProductID
        /// <summary>
        /// Child Production_ProductListPriceHistories where [ProductListPriceHistory].[ProductID] point to this entity (FK_ProductListPriceHistory_Product_ProductID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Production_ProductListPriceHistory> Production_ProductListPriceHistories { get; set; } = new System.Collections.Generic.List<Production_ProductListPriceHistory>(); // ProductListPriceHistory.FK_ProductListPriceHistory_Product_ProductID
        /// <summary>
        /// Child Production_ProductProductPhotoes where [ProductProductPhoto].[ProductID] point to this entity (FK_ProductProductPhoto_Product_ProductID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Production_ProductProductPhoto> Production_ProductProductPhotoes { get; set; } = new System.Collections.Generic.List<Production_ProductProductPhoto>(); // ProductProductPhoto.FK_ProductProductPhoto_Product_ProductID
        /// <summary>
        /// Child Production_ProductReviews where [ProductReview].[ProductID] point to this entity (FK_ProductReview_Product_ProductID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Production_ProductReview> Production_ProductReviews { get; set; } = new System.Collections.Generic.List<Production_ProductReview>(); // ProductReview.FK_ProductReview_Product_ProductID
        /// <summary>
        /// Child Production_TransactionHistories where [TransactionHistory].[ProductID] point to this entity (FK_TransactionHistory_Product_ProductID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Production_TransactionHistory> Production_TransactionHistories { get; set; } = new System.Collections.Generic.List<Production_TransactionHistory>(); // TransactionHistory.FK_TransactionHistory_Product_ProductID
        /// <summary>
        /// Child Production_WorkOrders where [WorkOrder].[ProductID] point to this entity (FK_WorkOrder_Product_ProductID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Production_WorkOrder> Production_WorkOrders { get; set; } = new System.Collections.Generic.List<Production_WorkOrder>(); // WorkOrder.FK_WorkOrder_Product_ProductID
        /// <summary>
        /// Child Purchasing_ProductVendors where [ProductVendor].[ProductID] point to this entity (FK_ProductVendor_Product_ProductID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Purchasing_ProductVendor> Purchasing_ProductVendors { get; set; } = new System.Collections.Generic.List<Purchasing_ProductVendor>(); // ProductVendor.FK_ProductVendor_Product_ProductID
        /// <summary>
        /// Child Purchasing_PurchaseOrderDetails where [PurchaseOrderDetail].[ProductID] point to this entity (FK_PurchaseOrderDetail_Product_ProductID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Purchasing_PurchaseOrderDetail> Purchasing_PurchaseOrderDetails { get; set; } = new System.Collections.Generic.List<Purchasing_PurchaseOrderDetail>(); // PurchaseOrderDetail.FK_PurchaseOrderDetail_Product_ProductID
        /// <summary>
        /// Child Sales_ShoppingCartItems where [ShoppingCartItem].[ProductID] point to this entity (FK_ShoppingCartItem_Product_ProductID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Sales_ShoppingCartItem> Sales_ShoppingCartItems { get; set; } = new System.Collections.Generic.List<Sales_ShoppingCartItem>(); // ShoppingCartItem.FK_ShoppingCartItem_Product_ProductID
        /// <summary>
        /// Child Sales_SpecialOfferProducts where [SpecialOfferProduct].[ProductID] point to this entity (FK_SpecialOfferProduct_Product_ProductID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Sales_SpecialOfferProduct> Sales_SpecialOfferProducts { get; set; } = new System.Collections.Generic.List<Sales_SpecialOfferProduct>(); // SpecialOfferProduct.FK_SpecialOfferProduct_Product_ProductID

        // Foreign keys

        /// <summary>
        /// Parent Production_ProductModel pointed by [Product].([ProductModelId]) (FK_Product_ProductModel_ProductModelID)
        /// </summary>
        public virtual Production_ProductModel Production_ProductModel { get; set; } // FK_Product_ProductModel_ProductModelID
        /// <summary>
        /// Parent Production_ProductSubcategory pointed by [Product].([ProductSubcategoryId]) (FK_Product_ProductSubcategory_ProductSubcategoryID)
        /// </summary>
        public virtual Production_ProductSubcategory Production_ProductSubcategory { get; set; } // FK_Product_ProductSubcategory_ProductSubcategoryID
        /// <summary>
        /// Parent Production_UnitMeasure pointed by [Product].([SizeUnitMeasureCode]) (FK_Product_UnitMeasure_SizeUnitMeasureCode)
        /// </summary>
        public virtual Production_UnitMeasure Production_UnitMeasure_SizeUnitMeasureCode { get; set; } // FK_Product_UnitMeasure_SizeUnitMeasureCode
        /// <summary>
        /// Parent Production_UnitMeasure pointed by [Product].([WeightUnitMeasureCode]) (FK_Product_UnitMeasure_WeightUnitMeasureCode)
        /// </summary>
        public virtual Production_UnitMeasure Production_UnitMeasure_WeightUnitMeasureCode { get; set; } // FK_Product_UnitMeasure_WeightUnitMeasureCode
    }

}
// </auto-generated>