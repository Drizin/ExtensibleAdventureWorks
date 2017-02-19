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

    // SalesOrderDetail
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.28.0.0")]
    public partial class Sales_SalesOrderDetailConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Sales_SalesOrderDetail>
    {
        public Sales_SalesOrderDetailConfiguration()
            : this("Sales")
        {
        }

        public Sales_SalesOrderDetailConfiguration(string schema)
        {
            ToTable("SalesOrderDetail", schema);
            HasKey(x => new { x.SalesOrderId, x.SalesOrderDetailId });

            Property(x => x.SalesOrderId).HasColumnName(@"SalesOrderID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SalesOrderDetailId).HasColumnName(@"SalesOrderDetailID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CarrierTrackingNumber).HasColumnName(@"CarrierTrackingNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(25);
            Property(x => x.OrderQty).HasColumnName(@"OrderQty").HasColumnType("smallint").IsRequired();
            Property(x => x.ProductId).HasColumnName(@"ProductID").HasColumnType("int").IsRequired();
            Property(x => x.SpecialOfferId).HasColumnName(@"SpecialOfferID").HasColumnType("int").IsRequired();
            Property(x => x.UnitPrice).HasColumnName(@"UnitPrice").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.UnitPriceDiscount).HasColumnName(@"UnitPriceDiscount").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.LineTotal).HasColumnName(@"LineTotal").HasColumnType("numeric").IsRequired().HasPrecision(38,6).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Rowguid).HasColumnName(@"rowguid").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            // Foreign keys
            HasRequired(a => a.Sales_SalesOrderHeader).WithMany(b => b.Sales_SalesOrderDetails).HasForeignKey(c => c.SalesOrderId); // FK_SalesOrderDetail_SalesOrderHeader_SalesOrderID
            HasRequired(a => a.Sales_SpecialOfferProduct).WithMany(b => b.Sales_SalesOrderDetails).HasForeignKey(c => new { c.SpecialOfferId, c.ProductId }).WillCascadeOnDelete(false); // FK_SalesOrderDetail_SpecialOfferProduct_SpecialOfferIDProductID
            this.ConfigureExtensions();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
