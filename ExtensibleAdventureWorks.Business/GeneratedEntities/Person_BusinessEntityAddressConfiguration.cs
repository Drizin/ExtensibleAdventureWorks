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

    // BusinessEntityAddress
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.28.0.0")]
    public partial class Person_BusinessEntityAddressConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Person_BusinessEntityAddress>
    {
        public Person_BusinessEntityAddressConfiguration()
            : this("Person")
        {
        }

        public Person_BusinessEntityAddressConfiguration(string schema)
        {
            ToTable("BusinessEntityAddress", schema);
            HasKey(x => new { x.BusinessEntityId, x.AddressId, x.AddressTypeId });

            Property(x => x.BusinessEntityId).HasColumnName(@"BusinessEntityID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.AddressId).HasColumnName(@"AddressID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.AddressTypeId).HasColumnName(@"AddressTypeID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Rowguid).HasColumnName(@"rowguid").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            // Foreign keys
            HasRequired(a => a.Person_Address).WithMany(b => b.Person_BusinessEntityAddresses).HasForeignKey(c => c.AddressId).WillCascadeOnDelete(false); // FK_BusinessEntityAddress_Address_AddressID
            HasRequired(a => a.Person_AddressType).WithMany(b => b.Person_BusinessEntityAddresses).HasForeignKey(c => c.AddressTypeId).WillCascadeOnDelete(false); // FK_BusinessEntityAddress_AddressType_AddressTypeID
            HasRequired(a => a.Person_BusinessEntity).WithMany(b => b.Person_BusinessEntityAddresses).HasForeignKey(c => c.BusinessEntityId).WillCascadeOnDelete(false); // FK_BusinessEntityAddress_BusinessEntity_BusinessEntityID
            this.ConfigureExtensions();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
