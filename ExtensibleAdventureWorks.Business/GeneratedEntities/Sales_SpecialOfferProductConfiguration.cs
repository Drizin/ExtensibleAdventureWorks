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

    // SpecialOfferProduct
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.28.0.0")]
    public partial class Sales_SpecialOfferProductConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Sales_SpecialOfferProduct>
    {
        public Sales_SpecialOfferProductConfiguration()
            : this("Sales")
        {
        }

        public Sales_SpecialOfferProductConfiguration(string schema)
        {
            ToTable("SpecialOfferProduct", schema);
            HasKey(x => new { x.SpecialOfferId, x.ProductId });

            Property(x => x.SpecialOfferId).HasColumnName(@"SpecialOfferID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ProductId).HasColumnName(@"ProductID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Rowguid).HasColumnName(@"rowguid").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            // Foreign keys
            HasRequired(a => a.Production_Product).WithMany(b => b.Sales_SpecialOfferProducts).HasForeignKey(c => c.ProductId).WillCascadeOnDelete(false); // FK_SpecialOfferProduct_Product_ProductID
            HasRequired(a => a.Sales_SpecialOffer).WithMany(b => b.Sales_SpecialOfferProducts).HasForeignKey(c => c.SpecialOfferId).WillCascadeOnDelete(false); // FK_SpecialOfferProduct_SpecialOffer_SpecialOfferID
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
