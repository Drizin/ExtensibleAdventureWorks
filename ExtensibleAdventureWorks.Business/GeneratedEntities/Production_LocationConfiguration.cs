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

    // Location
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.28.0.0")]
    public partial class Production_LocationConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Production_Location>
    {
        public Production_LocationConfiguration()
            : this("Production")
        {
        }

        public Production_LocationConfiguration(string schema)
        {
            ToTable("Location", schema);
            HasKey(x => x.LocationId);

            Property(x => x.LocationId).HasColumnName(@"LocationID").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.CostRate).HasColumnName(@"CostRate").HasColumnType("smallmoney").IsRequired().HasPrecision(10,4);
            Property(x => x.Availability).HasColumnName(@"Availability").HasColumnType("decimal").IsRequired().HasPrecision(8,2);
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();
            this.ConfigureExtensions();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
