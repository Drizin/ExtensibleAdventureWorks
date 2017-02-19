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

    // Person
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.28.0.0")]
    public partial class Person_PersonConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Person_Person>
    {
        public Person_PersonConfiguration()
            : this("Person")
        {
        }

        public Person_PersonConfiguration(string schema)
        {
            ToTable("Person", schema);
            HasKey(x => x.BusinessEntityId);

            Property(x => x.BusinessEntityId).HasColumnName(@"BusinessEntityID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.PersonType).HasColumnName(@"PersonType").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(2);
            Property(x => x.NameStyle).HasColumnName(@"NameStyle").HasColumnType("bit").IsRequired();
            Property(x => x.Title).HasColumnName(@"Title").HasColumnType("nvarchar").IsOptional().HasMaxLength(8);
            Property(x => x.FirstName).HasColumnName(@"FirstName").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.MiddleName).HasColumnName(@"MiddleName").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.LastName).HasColumnName(@"LastName").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.Suffix).HasColumnName(@"Suffix").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.EmailPromotion).HasColumnName(@"EmailPromotion").HasColumnType("int").IsRequired();
            Property(x => x.AdditionalContactInfo).HasColumnName(@"AdditionalContactInfo").HasColumnType("xml").IsOptional();
            Property(x => x.Demographics).HasColumnName(@"Demographics").HasColumnType("xml").IsOptional();
            Property(x => x.Rowguid).HasColumnName(@"rowguid").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            // Foreign keys
            HasRequired(a => a.Person_BusinessEntity).WithOptional(b => b.Person_Person).WillCascadeOnDelete(false); // FK_Person_BusinessEntity_BusinessEntityID
            this.ConfigureExtensions();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
