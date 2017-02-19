using ExtensibleAdventureWorks.Business.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensibleAdventureWorks.Business.Modules.OpeningHours
{
    public class OpeningHoursModule : IModelExtension
    {
        public void Extend(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new custom_OpeningHourConfiguration());
        }
    }
}
