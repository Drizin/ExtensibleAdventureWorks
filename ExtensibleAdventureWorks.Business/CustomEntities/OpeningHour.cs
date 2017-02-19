using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensibleAdventureWorks.Business.Entities
{
    #region Module Setup
    public class OpeningHourModule : IModelExtension
    {
        public void Extend(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new custom_OpeningHourConfiguration());
        }
    }
    #endregion

    #region New POCO - OpeningHour
    // OpeningHour
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.28.0.0")]
    public partial class custom_OpeningHour
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key)
        public int DayOfWeek { get; set; } // DayOfWeek (Primary key)
        public System.TimeSpan OpeningTime { get; set; } // OpeningTime
        public System.TimeSpan ClosingTime { get; set; } // ClosingTime

        // Foreign keys

        /// <summary>
        /// Parent Sales_Store pointed by [OpeningHour].([BusinessEntityId]) (FK_OpeningHour_Store_BusinessEntityID)
        /// </summary>
        public virtual Sales_Store Sales_Store { get; set; } // FK_OpeningHour_Store_BusinessEntityID
    }
    #endregion

    #region OpeningHour Configuration
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.28.0.0")]
    public partial class custom_OpeningHourConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<custom_OpeningHour>
    {
        public custom_OpeningHourConfiguration()
            : this("custom")
        {
        }

        public custom_OpeningHourConfiguration(string schema)
        {
            ToTable("OpeningHour", schema);
            HasKey(x => new { x.BusinessEntityId, x.DayOfWeek });

            Property(x => x.BusinessEntityId).HasColumnName(@"BusinessEntityID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DayOfWeek).HasColumnName(@"DayOfWeek").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.OpeningTime).HasColumnName(@"OpeningTime").HasColumnType("time").IsRequired();
            Property(x => x.ClosingTime).HasColumnName(@"ClosingTime").HasColumnType("time").IsRequired();

            // Foreign keys
            HasRequired(a => a.Sales_Store).WithMany(b => b.custom_OpeningHours).HasForeignKey(c => c.BusinessEntityId).WillCascadeOnDelete(false); // FK_OpeningHour_Store_BusinessEntityID
            this.ConfigureExtensions();
            InitializePartial();
        }
        partial void InitializePartial();
    }
    #endregion

    #region Partial Classes
    partial class AdventureWorksDB
    {
        public System.Data.Entity.DbSet<custom_OpeningHour> custom_OpeningHours { get; set; } // OpeningHour
    }
    #endregion

}
