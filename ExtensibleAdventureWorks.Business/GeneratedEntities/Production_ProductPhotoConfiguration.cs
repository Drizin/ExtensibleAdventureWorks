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

    // ProductPhoto
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.28.0.0")]
    public partial class Production_ProductPhotoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Production_ProductPhoto>
    {
        public Production_ProductPhotoConfiguration()
            : this("Production")
        {
        }

        public Production_ProductPhotoConfiguration(string schema)
        {
            ToTable("ProductPhoto", schema);
            HasKey(x => x.ProductPhotoId);

            Property(x => x.ProductPhotoId).HasColumnName(@"ProductPhotoID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ThumbNailPhoto).HasColumnName(@"ThumbNailPhoto").HasColumnType("varbinary").IsOptional();
            Property(x => x.ThumbnailPhotoFileName).HasColumnName(@"ThumbnailPhotoFileName").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.LargePhoto).HasColumnName(@"LargePhoto").HasColumnType("varbinary").IsOptional();
            Property(x => x.LargePhotoFileName).HasColumnName(@"LargePhotoFileName").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();
            this.ConfigureExtensions();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>