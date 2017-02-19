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

    // Document
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.28.0.0")]
    public partial class Production_DocumentConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Production_Document>
    {
        public Production_DocumentConfiguration()
            : this("Production")
        {
        }

        public Production_DocumentConfiguration(string schema)
        {
            ToTable("Document", schema);
            HasKey(x => x.DocumentNode);

            Property(x => x.DocumentNode).HasColumnName(@"DocumentNode").HasColumnType("hierarchyid").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DocumentLevel).HasColumnName(@"DocumentLevel").HasColumnType("smallint").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Title).HasColumnName(@"Title").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.Owner).HasColumnName(@"Owner").HasColumnType("int").IsRequired();
            Property(x => x.FolderFlag).HasColumnName(@"FolderFlag").HasColumnType("bit").IsRequired();
            Property(x => x.FileName).HasColumnName(@"FileName").HasColumnType("nvarchar").IsRequired().HasMaxLength(400);
            Property(x => x.FileExtension).HasColumnName(@"FileExtension").HasColumnType("nvarchar").IsRequired().HasMaxLength(8);
            Property(x => x.Revision).HasColumnName(@"Revision").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(5);
            Property(x => x.ChangeNumber).HasColumnName(@"ChangeNumber").HasColumnType("int").IsRequired();
            Property(x => x.Status).HasColumnName(@"Status").HasColumnType("tinyint").IsRequired();
            Property(x => x.DocumentSummary).HasColumnName(@"DocumentSummary").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Document).HasColumnName(@"Document").HasColumnType("varbinary").IsOptional();
            Property(x => x.Rowguid).HasColumnName(@"rowguid").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            // Foreign keys
            HasRequired(a => a.HumanResources_Employee).WithMany(b => b.Production_Documents).HasForeignKey(c => c.Owner).WillCascadeOnDelete(false); // FK_Document_Employee_Owner
            this.ConfigureExtensions();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>