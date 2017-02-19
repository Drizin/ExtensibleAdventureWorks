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

    // ProductSubcategory
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.28.0.0")]
    public partial class Production_ProductSubcategoryConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Production_ProductSubcategory>
    {
        public Production_ProductSubcategoryConfiguration()
            : this("Production")
        {
        }

        public Production_ProductSubcategoryConfiguration(string schema)
        {
            ToTable("ProductSubcategory", schema);
            HasKey(x => x.ProductSubcategoryId);

            Property(x => x.ProductSubcategoryId).HasColumnName(@"ProductSubcategoryID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ProductCategoryId).HasColumnName(@"ProductCategoryID").HasColumnType("int").IsRequired();
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.Rowguid).HasColumnName(@"rowguid").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            // Foreign keys
            HasRequired(a => a.Production_ProductCategory).WithMany(b => b.Production_ProductSubcategories).HasForeignKey(c => c.ProductCategoryId).WillCascadeOnDelete(false); // FK_ProductSubcategory_ProductCategory_ProductCategoryID
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
