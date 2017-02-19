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

    // PersonPhone
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.28.0.0")]
    public partial class Person_PersonPhoneConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Person_PersonPhone>
    {
        public Person_PersonPhoneConfiguration()
            : this("Person")
        {
        }

        public Person_PersonPhoneConfiguration(string schema)
        {
            ToTable("PersonPhone", schema);
            HasKey(x => new { x.BusinessEntityId, x.PhoneNumber, x.PhoneNumberTypeId });

            Property(x => x.BusinessEntityId).HasColumnName(@"BusinessEntityID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.PhoneNumber).HasColumnName(@"PhoneNumber").HasColumnType("nvarchar").IsRequired().HasMaxLength(25).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.PhoneNumberTypeId).HasColumnName(@"PhoneNumberTypeID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            // Foreign keys
            HasRequired(a => a.Person_Person).WithMany(b => b.Person_PersonPhones).HasForeignKey(c => c.BusinessEntityId).WillCascadeOnDelete(false); // FK_PersonPhone_Person_BusinessEntityID
            HasRequired(a => a.Person_PhoneNumberType).WithMany(b => b.Person_PersonPhones).HasForeignKey(c => c.PhoneNumberTypeId).WillCascadeOnDelete(false); // FK_PersonPhone_PhoneNumberType_PhoneNumberTypeID
            this.ConfigureExtensions();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
