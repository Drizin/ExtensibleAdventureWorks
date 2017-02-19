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

    // ShoppingCartItem
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.28.0.0")]
    public partial class Sales_ShoppingCartItemConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Sales_ShoppingCartItem>
    {
        public Sales_ShoppingCartItemConfiguration()
            : this("Sales")
        {
        }

        public Sales_ShoppingCartItemConfiguration(string schema)
        {
            ToTable("ShoppingCartItem", schema);
            HasKey(x => x.ShoppingCartItemId);

            Property(x => x.ShoppingCartItemId).HasColumnName(@"ShoppingCartItemID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ShoppingCartId).HasColumnName(@"ShoppingCartID").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.Quantity).HasColumnName(@"Quantity").HasColumnType("int").IsRequired();
            Property(x => x.ProductId).HasColumnName(@"ProductID").HasColumnType("int").IsRequired();
            Property(x => x.DateCreated).HasColumnName(@"DateCreated").HasColumnType("datetime").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            // Foreign keys
            HasRequired(a => a.Production_Product).WithMany(b => b.Sales_ShoppingCartItems).HasForeignKey(c => c.ProductId).WillCascadeOnDelete(false); // FK_ShoppingCartItem_Product_ProductID
            this.ConfigureExtensions();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>