using ExtensibleAdventureWorks.Business.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensibleAdventureWorks.Business.Modules.TaxAuditor
{
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
}
