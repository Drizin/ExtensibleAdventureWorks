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

    // WorkOrder
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.28.0.0")]
    public partial class Production_WorkOrderConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Production_WorkOrder>
    {
        public Production_WorkOrderConfiguration()
            : this("Production")
        {
        }

        public Production_WorkOrderConfiguration(string schema)
        {
            ToTable("WorkOrder", schema);
            HasKey(x => x.WorkOrderId);

            Property(x => x.WorkOrderId).HasColumnName(@"WorkOrderID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ProductId).HasColumnName(@"ProductID").HasColumnType("int").IsRequired();
            Property(x => x.OrderQty).HasColumnName(@"OrderQty").HasColumnType("int").IsRequired();
            Property(x => x.StockedQty).HasColumnName(@"StockedQty").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.ScrappedQty).HasColumnName(@"ScrappedQty").HasColumnType("smallint").IsRequired();
            Property(x => x.StartDate).HasColumnName(@"StartDate").HasColumnType("datetime").IsRequired();
            Property(x => x.EndDate).HasColumnName(@"EndDate").HasColumnType("datetime").IsOptional();
            Property(x => x.DueDate).HasColumnName(@"DueDate").HasColumnType("datetime").IsRequired();
            Property(x => x.ScrapReasonId).HasColumnName(@"ScrapReasonID").HasColumnType("smallint").IsOptional();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            // Foreign keys
            HasOptional(a => a.Production_ScrapReason).WithMany(b => b.Production_WorkOrders).HasForeignKey(c => c.ScrapReasonId).WillCascadeOnDelete(false); // FK_WorkOrder_ScrapReason_ScrapReasonID
            HasRequired(a => a.Production_Product).WithMany(b => b.Production_WorkOrders).HasForeignKey(c => c.ProductId).WillCascadeOnDelete(false); // FK_WorkOrder_Product_ProductID
            this.ConfigureExtensions();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
