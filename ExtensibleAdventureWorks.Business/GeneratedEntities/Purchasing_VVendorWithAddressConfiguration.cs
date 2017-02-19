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

    // vVendorWithAddresses
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.28.0.0")]
    public partial class Purchasing_VVendorWithAddressConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Purchasing_VVendorWithAddress>
    {
        public Purchasing_VVendorWithAddressConfiguration()
            : this("Purchasing")
        {
        }

        public Purchasing_VVendorWithAddressConfiguration(string schema)
        {
            ToTable("vVendorWithAddresses", schema);
            HasKey(x => new { x.BusinessEntityId, x.Name, x.AddressType, x.AddressLine1, x.City, x.StateProvinceName, x.PostalCode, x.CountryRegionName });

            Property(x => x.BusinessEntityId).HasColumnName(@"BusinessEntityID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.AddressType).HasColumnName(@"AddressType").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.AddressLine1).HasColumnName(@"AddressLine1").HasColumnType("nvarchar").IsRequired().HasMaxLength(60).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.AddressLine2).HasColumnName(@"AddressLine2").HasColumnType("nvarchar").IsOptional().HasMaxLength(60);
            Property(x => x.City).HasColumnName(@"City").HasColumnType("nvarchar").IsRequired().HasMaxLength(30).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.StateProvinceName).HasColumnName(@"StateProvinceName").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.PostalCode).HasColumnName(@"PostalCode").HasColumnType("nvarchar").IsRequired().HasMaxLength(15).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CountryRegionName).HasColumnName(@"CountryRegionName").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            this.ConfigureExtensions();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
