using Dapper;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensibleAdventureWorks.Business.Entities;

namespace ExtensibleAdventureWorks.Tests
{
    [TestFixture]
    public class EFExtensionTests
    {
        [Test]
        public void ReadTest()
        {
            var db = new ExtensibleAdventureWorks.Business.Entities.AdventureWorksDB();
            var store = db.Sales_Stores.First();
            var monday = store.custom_OpeningHours.Single(x => x.DayOfWeek == (int)DayOfWeek.Monday);
            Assert.That(monday.OpeningTime.Hours == 8 && monday.OpeningTime.Minutes == 30);
            Assert.That(monday.ClosingTime.Hours == 17 && monday.ClosingTime.Minutes == 30);

            var auditor = store.custom_TaxAuditor;
            Assert.That(auditor != null);
            Assert.That(auditor.FirstName == "Mike" || auditor.FirstName == "James");
        }


        [Test]
        public void WriteCustomChildTest()
        {
            using (var cn = Business.Entities.AdventureWorksDB.CreateConnection())
            {
                var db = new ExtensibleAdventureWorks.Business.Entities.AdventureWorksDB();
                var store = db.Sales_Stores.OrderByDescending(x=>x.BusinessEntityId).First();

                int found;
                found = cn.Query<int>("SELECT COUNT(*) FROM [custom].[OpeningHour] WHERE [BusinessEntityID]=@ID AND [DayOfWeek]=@Day", new { ID = store.BusinessEntityId, Day = 1 }).Single();
                Assert.That(found == 1);

                var monday = store.custom_OpeningHours.Single(x => x.DayOfWeek == (int)DayOfWeek.Monday);
                db.custom_OpeningHours.Remove(monday);
                db.SaveChanges();

                found = cn.Query<int>("SELECT COUNT(*) FROM [custom].[OpeningHour] WHERE [BusinessEntityID]=@ID AND [DayOfWeek]=@Day", new { ID = store.BusinessEntityId, Day = 1 }).Single();
                Assert.That(found == 0);

                db.custom_OpeningHours.Add(monday);
                db.SaveChanges();

                found = cn.Query<int>("SELECT COUNT(*) FROM [custom].[OpeningHour] WHERE [BusinessEntityID]=@ID AND [DayOfWeek]=@Day", new { ID = store.BusinessEntityId, Day = 1 }).Single();
                Assert.That(found == 1);
            }
        }


        [Test]
        public void WriteCustomParentTest()
        {
            using (var cn = Business.Entities.AdventureWorksDB.CreateConnection())
            {
                var db = new ExtensibleAdventureWorks.Business.Entities.AdventureWorksDB();
                var store = db.Sales_Stores.Include("custom_TaxAuditor").First(); // eager load

                int ?auditorId;
                auditorId = cn.Query<int?>("SELECT [TaxAuditorID] FROM [Sales].[Store] WHERE [BusinessEntityID]=@ID", new { ID = store.BusinessEntityId }).Single();
                Assert.That(auditorId!=null);

                store.custom_TaxAuditor = null;
                db.SaveChanges();

                auditorId = cn.Query<int?>("SELECT [TaxAuditorID] FROM [Sales].[Store] WHERE [BusinessEntityID]=@ID", new { ID = store.BusinessEntityId }).Single();
                Assert.That(auditorId == null);

                var auditor = db.custom_TaxAuditors.First();
                store.custom_TaxAuditor = auditor;
                db.SaveChanges();

                auditorId = cn.Query<int?>("SELECT [TaxAuditorID] FROM [Sales].[Store] WHERE [BusinessEntityID]=@ID", new { ID = store.BusinessEntityId }).Single();
                Assert.That(auditorId != null);
            }
        }



    }
}
