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

    // CountryRegionCurrency
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.28.0.0")]
    public partial class Sales_CountryRegionCurrencyConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Sales_CountryRegionCurrency>
    {
        public Sales_CountryRegionCurrencyConfiguration()
            : this("Sales")
        {
        }

        public Sales_CountryRegionCurrencyConfiguration(string schema)
        {
            ToTable("CountryRegionCurrency", schema);
            HasKey(x => new { x.CountryRegionCode, x.CurrencyCode });

            Property(x => x.CountryRegionCode).HasColumnName(@"CountryRegionCode").HasColumnType("nvarchar").IsRequired().HasMaxLength(3).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CurrencyCode).HasColumnName(@"CurrencyCode").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(3).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            // Foreign keys
            HasRequired(a => a.Person_CountryRegion).WithMany(b => b.Sales_CountryRegionCurrencies).HasForeignKey(c => c.CountryRegionCode).WillCascadeOnDelete(false); // FK_CountryRegionCurrency_CountryRegion_CountryRegionCode
            HasRequired(a => a.Sales_Currency).WithMany(b => b.Sales_CountryRegionCurrencies).HasForeignKey(c => c.CurrencyCode).WillCascadeOnDelete(false); // FK_CountryRegionCurrency_Currency_CurrencyCode
            this.ConfigureExtensions();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>