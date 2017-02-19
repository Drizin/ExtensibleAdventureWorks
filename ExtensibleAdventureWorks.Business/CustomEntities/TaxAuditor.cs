using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensibleAdventureWorks.Business.Entities
{
    #region Module Setup
    public class TaxAuditorModule : IModelExtension, IModelExtension<Sales_Store>
    {
        public void Extend(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new custom_TaxAuditorConfiguration());
        }
        public void Extend(EntityTypeConfiguration<Sales_Store> config)
        {
            config.Property(x => x.TaxAuditorId).HasColumnName(@"TaxAuditorID").HasColumnType("int").IsOptional();
            config.HasOptional(a => a.custom_TaxAuditor).WithMany(b => b.Sales_Stores).HasForeignKey(c => c.TaxAuditorId).WillCascadeOnDelete(false); // FK_Store_TaxAuditor_TaxAuditorID
        }
    }
    #endregion

    #region New POCO - TaxAuditor
    // TaxAuditor
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.28.0.0")]
    public partial class custom_TaxAuditor
    {
        public int TaxAuditorId { get; set; } // TaxAuditorID (Primary key)
        public string FirstName { get; set; } // FirstName (length: 200)
        public string LastName { get; set; } // LastName (length: 200)

        // Reverse navigation

        /// <summary>
        /// Child Sales_Stores where [Store].[TaxAuditorID] point to this entity (FK_Store_TaxAuditor_TaxAuditorID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Sales_Store> Sales_Stores { get; set; } = new System.Collections.Generic.List<Sales_Store>(); // Store.FK_Store_TaxAuditor_TaxAuditorID
    }
    #endregion

    #region TaxAuditor Configuration
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.28.0.0")]
    public partial class custom_TaxAuditorConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<custom_TaxAuditor>
    {
        public custom_TaxAuditorConfiguration()
            : this("custom")
        {
        }

        public custom_TaxAuditorConfiguration(string schema)
        {
            ToTable("TaxAuditor", schema);
            HasKey(x => x.TaxAuditorId);

            Property(x => x.TaxAuditorId).HasColumnName(@"TaxAuditorID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.FirstName).HasColumnName(@"FirstName").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.LastName).HasColumnName(@"LastName").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            this.ConfigureExtensions();
            InitializePartial();
        }
        partial void InitializePartial();
    }
    #endregion

    #region Partial Classes
    partial class AdventureWorksDB
    {
        public System.Data.Entity.DbSet<custom_TaxAuditor> custom_TaxAuditors { get; set; } // TaxAuditor
    }
    partial class Sales_Store
    {
        public int? TaxAuditorId { get; set; } // TaxAuditorID

        /// <summary>
        /// Child custom_OpeningHours where [OpeningHour].[BusinessEntityID] point to this entity (FK_OpeningHour_Store_BusinessEntityID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<custom_OpeningHour> custom_OpeningHours { get; set; } = new System.Collections.Generic.List<custom_OpeningHour>(); // OpeningHour.FK_OpeningHour_Store_BusinessEntityID

        /// <summary>
        /// Parent custom_TaxAuditor pointed by [Store].([TaxAuditorId]) (FK_Store_TaxAuditor_TaxAuditorID)
        /// </summary>
        public virtual custom_TaxAuditor custom_TaxAuditor { get; set; } // FK_Store_TaxAuditor_TaxAuditorID

    }
    #endregion
}