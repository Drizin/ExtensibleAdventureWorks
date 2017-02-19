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

    // PurchaseOrderDetail
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.28.0.0")]
    public partial class Purchasing_PurchaseOrderDetailConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Purchasing_PurchaseOrderDetail>
    {
        public Purchasing_PurchaseOrderDetailConfiguration()
            : this("Purchasing")
        {
        }

        public Purchasing_PurchaseOrderDetailConfiguration(string schema)
        {
            ToTable("PurchaseOrderDetail", schema);
            HasKey(x => new { x.PurchaseOrderId, x.PurchaseOrderDetailId });

            Property(x => x.PurchaseOrderId).HasColumnName(@"PurchaseOrderID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.PurchaseOrderDetailId).HasColumnName(@"PurchaseOrderDetailID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.DueDate).HasColumnName(@"DueDate").HasColumnType("datetime").IsRequired();
            Property(x => x.OrderQty).HasColumnName(@"OrderQty").HasColumnType("smallint").IsRequired();
            Property(x => x.ProductId).HasColumnName(@"ProductID").HasColumnType("int").IsRequired();
            Property(x => x.UnitPrice).HasColumnName(@"UnitPrice").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.LineTotal).HasColumnName(@"LineTotal").HasColumnType("money").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.ReceivedQty).HasColumnName(@"ReceivedQty").HasColumnType("decimal").IsRequired().HasPrecision(8,2);
            Property(x => x.RejectedQty).HasColumnName(@"RejectedQty").HasColumnType("decimal").IsRequired().HasPrecision(8,2);
            Property(x => x.StockedQty).HasColumnName(@"StockedQty").HasColumnType("decimal").IsRequired().HasPrecision(9,2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            // Foreign keys
            HasRequired(a => a.Production_Product).WithMany(b => b.Purchasing_PurchaseOrderDetails).HasForeignKey(c => c.ProductId).WillCascadeOnDelete(false); // FK_PurchaseOrderDetail_Product_ProductID
            HasRequired(a => a.Purchasing_PurchaseOrderHeader).WithMany(b => b.Purchasing_PurchaseOrderDetails).HasForeignKey(c => c.PurchaseOrderId).WillCascadeOnDelete(false); // FK_PurchaseOrderDetail_PurchaseOrderHeader_PurchaseOrderID
            this.ConfigureExtensions();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
