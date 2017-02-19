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

    // ProductModelProductDescriptionCulture
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.28.0.0")]
    public partial class Production_ProductModelProductDescriptionCulture
    {

        ///<summary>
        /// Primary key. Foreign key to ProductModel.ProductModelID.
        ///</summary>
        public int ProductModelId { get; set; } // ProductModelID (Primary key)

        ///<summary>
        /// Primary key. Foreign key to ProductDescription.ProductDescriptionID.
        ///</summary>
        public int ProductDescriptionId { get; set; } // ProductDescriptionID (Primary key)

        ///<summary>
        /// Culture identification number. Foreign key to Culture.CultureID.
        ///</summary>
        public string CultureId { get; set; } // CultureID (Primary key) (length: 6)

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        public System.DateTime ModifiedDate { get; set; } = System.DateTime.Now; // ModifiedDate

        // Foreign keys

        /// <summary>
        /// Parent Production_Culture pointed by [ProductModelProductDescriptionCulture].([CultureId]) (FK_ProductModelProductDescriptionCulture_Culture_CultureID)
        /// </summary>
        public virtual Production_Culture Production_Culture { get; set; } // FK_ProductModelProductDescriptionCulture_Culture_CultureID
        /// <summary>
        /// Parent Production_ProductDescription pointed by [ProductModelProductDescriptionCulture].([ProductDescriptionId]) (FK_ProductModelProductDescriptionCulture_ProductDescription_ProductDescriptionID)
        /// </summary>
        public virtual Production_ProductDescription Production_ProductDescription { get; set; } // FK_ProductModelProductDescriptionCulture_ProductDescription_ProductDescriptionID
        /// <summary>
        /// Parent Production_ProductModel pointed by [ProductModelProductDescriptionCulture].([ProductModelId]) (FK_ProductModelProductDescriptionCulture_ProductModel_ProductModelID)
        /// </summary>
        public virtual Production_ProductModel Production_ProductModel { get; set; } // FK_ProductModelProductDescriptionCulture_ProductModel_ProductModelID
    }

}
// </auto-generated>