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

    // ProductCategory
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.28.0.0")]
    public partial class Production_ProductCategoryConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Production_ProductCategory>
    {
        public Production_ProductCategoryConfiguration()
            : this("Production")
        {
        }

        public Production_ProductCategoryConfiguration(string schema)
        {
            ToTable("ProductCategory", schema);
            HasKey(x => x.ProductCategoryId);

            Property(x => x.ProductCategoryId).HasColumnName(@"ProductCategoryID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.Rowguid).HasColumnName(@"rowguid").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
