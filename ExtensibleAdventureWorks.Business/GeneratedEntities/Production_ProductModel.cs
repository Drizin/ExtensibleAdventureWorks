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

    // ProductModel
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.28.0.0")]
    public partial class Production_ProductModel
    {

        ///<summary>
        /// Primary key for ProductModel records.
        ///</summary>
        public int ProductModelId { get; set; } // ProductModelID (Primary key)

        ///<summary>
        /// Product model description.
        ///</summary>
        public string Name { get; set; } // Name (length: 50)

        ///<summary>
        /// Detailed product catalog information in xml format.
        ///</summary>
        public string CatalogDescription { get; set; } // CatalogDescription

        ///<summary>
        /// Manufacturing instructions in xml format.
        ///</summary>
        public string Instructions { get; set; } // Instructions

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
        /// Child Production_Products where [Product].[ProductModelID] point to this entity (FK_Product_ProductModel_ProductModelID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Production_Product> Production_Products { get; set; } = new System.Collections.Generic.List<Production_Product>(); // Product.FK_Product_ProductModel_ProductModelID
        /// <summary>
        /// Child Production_ProductModelIllustrations where [ProductModelIllustration].[ProductModelID] point to this entity (FK_ProductModelIllustration_ProductModel_ProductModelID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Production_ProductModelIllustration> Production_ProductModelIllustrations { get; set; } = new System.Collections.Generic.List<Production_ProductModelIllustration>(); // ProductModelIllustration.FK_ProductModelIllustration_ProductModel_ProductModelID
        /// <summary>
        /// Child Production_ProductModelProductDescriptionCultures where [ProductModelProductDescriptionCulture].[ProductModelID] point to this entity (FK_ProductModelProductDescriptionCulture_ProductModel_ProductModelID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Production_ProductModelProductDescriptionCulture> Production_ProductModelProductDescriptionCultures { get; set; } = new System.Collections.Generic.List<Production_ProductModelProductDescriptionCulture>(); // ProductModelProductDescriptionCulture.FK_ProductModelProductDescriptionCulture_ProductModel_ProductModelID
    }

}
// </auto-generated>
