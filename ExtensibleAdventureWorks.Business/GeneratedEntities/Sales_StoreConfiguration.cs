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

    // Store
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.28.0.0")]
    public partial class Sales_StoreConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Sales_Store>
    {
        public Sales_StoreConfiguration()
            : this("Sales")
        {
        }

        public Sales_StoreConfiguration(string schema)
        {
            ToTable("Store", schema);
            HasKey(x => x.BusinessEntityId);

            Property(x => x.BusinessEntityId).HasColumnName(@"BusinessEntityID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.SalesPersonId).HasColumnName(@"SalesPersonID").HasColumnType("int").IsOptional();
            Property(x => x.Demographics).HasColumnName(@"Demographics").HasColumnType("xml").IsOptional();
            Property(x => x.Rowguid).HasColumnName(@"rowguid").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            // Foreign keys
            HasOptional(a => a.Sales_SalesPerson).WithMany(b => b.Sales_Stores).HasForeignKey(c => c.SalesPersonId).WillCascadeOnDelete(false); // FK_Store_SalesPerson_SalesPersonID
            HasRequired(a => a.Person_BusinessEntity).WithOptional(b => b.Sales_Store).WillCascadeOnDelete(false); // FK_Store_BusinessEntity_BusinessEntityID
            this.ConfigureExtensions();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>