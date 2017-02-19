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
    public class Tests
    {
        [Test]
        public void EFTest1()
        {
            var db = new ExtensibleAdventureWorks.Business.Entities.AdventureWorksDB();
            var stores = db.Sales_Stores.ToList();
            Assert.That(stores.Count > 1);

            var store = stores.First();
            Assert.That(store.BusinessEntityId > 0);
            var person = store.Sales_SalesPerson;
            Assert.That(person != null);
            Assert.That(person.BusinessEntityId > 0);
        }

        [Test]
        public void DapperTest1()
        {
            using (var cn = Business.Entities.AdventureWorksDB.CreateConnection())
            {
                var stores = cn.Query<Sales_Store>("SELECT * FROM [Sales].[Store]");
                Assert.That(stores.Count() > 1);

                var store = stores.First();
                Assert.That(store.BusinessEntityId > 0);
                var person = store.Sales_SalesPerson;
                Assert.That(person == null);
            }
        }

    }
}
