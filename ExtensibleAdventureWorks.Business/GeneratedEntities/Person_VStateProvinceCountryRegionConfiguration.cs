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

    // vStateProvinceCountryRegion
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.28.0.0")]
    public partial class Person_VStateProvinceCountryRegionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Person_VStateProvinceCountryRegion>
    {
        public Person_VStateProvinceCountryRegionConfiguration()
            : this("Person")
        {
        }

        public Person_VStateProvinceCountryRegionConfiguration(string schema)
        {
            ToTable("vStateProvinceCountryRegion", schema);
            HasKey(x => new { x.StateProvinceId, x.StateProvinceCode, x.IsOnlyStateProvinceFlag, x.StateProvinceName, x.TerritoryId, x.CountryRegionCode, x.CountryRegionName });

            Property(x => x.StateProvinceId).HasColumnName(@"StateProvinceID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.StateProvinceCode).HasColumnName(@"StateProvinceCode").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(3).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IsOnlyStateProvinceFlag).HasColumnName(@"IsOnlyStateProvinceFlag").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.StateProvinceName).HasColumnName(@"StateProvinceName").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.TerritoryId).HasColumnName(@"TerritoryID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CountryRegionCode).HasColumnName(@"CountryRegionCode").HasColumnType("nvarchar").IsRequired().HasMaxLength(3).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CountryRegionName).HasColumnName(@"CountryRegionName").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            this.ConfigureExtensions();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>