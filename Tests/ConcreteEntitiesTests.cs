using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensibleAdventureWorks.Business.Entities;
using Dapper;

namespace ExtensibleAdventureWorks.Tests
{
    /// <summary>
    /// Tests on Loading and Saving Concrete (Derived) Entities using Dapper and EF
    /// </summary>
    [TestFixture]
    public class ConcreteEntitiesTests
    {
        [Test]
        public void EFTest1()
        {
            var db = new AdventureWorksDB();
            var stores = db.Sales_Stores.ToList();
            Assert.That(stores.Count > 1);

            // Direct Load
            var store = stores.First();
            Assert.That(store.BusinessEntityId > 0);
            Assert.That(store.Test() == "Concrete Class");

            // Parent Lazy Load
            var person = store.Sales_SalesPerson;
            Assert.That(person != null);
            Assert.That(person.Test() == "Concrete Class");
            Assert.That(person.BusinessEntityId > 0);

            // Direct Load
            person = db.Sales_SalesPersons.Single(x=>x.BusinessEntityId == person.BusinessEntityId); // fetch again from db
            Assert.That(person.BusinessEntityId > 0);
            Assert.That(person.Test() == "Concrete Class");

            // Child Lazy Load
            var childs = person.Sales_Stores.ToList();
            Assert.That(childs.Count>0);
            Assert.That(childs.First().Test() == "Concrete Class");
        }

        [Test]
        public void DapperTest1()
        {
            using (var cn = AdventureWorksDB.CreateConnection())
            {
                var stores = cn.Query<Sales_Store>("SELECT * FROM [Sales].[Store]");
                Assert.That(stores.Count() > 1);

                // Direct Load
                var store = stores.First();
                Assert.That(store.BusinessEntityId > 0);

                // Dapper doesn't have Lazy Loading
                var person = store.Sales_SalesPerson;
                Assert.That(person == null);
            }
        }

        [Test]
        public void EFTest2()
        {
            var db = new ExtensibleAdventureWorks.Business.Entities.AdventureWorksDB();

            // Instantiate using Concrete Type
            Sales_Store store;
            store = new Sales_Store();
            store.Person_BusinessEntity = new Person_BusinessEntity() { };
            store.Name = "Concrete Child Test";
            store.SalesPersonId = 279;
            Assert.That(store.Test() == "Concrete Class");

            // Save and reload
            db.Sales_Stores.Add(store);
            var saved = db.SaveChanges();
            Assert.That(saved > 0); // will save 2 entities - Sales_Store and Person_BusinessEntity
            int id = store.BusinessEntityId;
            store = null;
            store = (Sales_Store)db.Sales_Stores.Single(x => x.BusinessEntityId == id);
            Assert.That(store.Test() == "Concrete Class");

            // Try to instantiate Abstract Class
            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(delegate {
                db.Sales_Stores.Create(); // we can't instantiate abstract classes
            });
            StringAssert.Contains("abstract classes cannot be created", ex.Message);

            // Instantiate Concrete Class automatically by DbSet<T>.Create
            var s1 = db.Sales_Stores.Create<Sales_Store>();
            Assert.That(s1.Test() == "Concrete Class");
        }

    }
}

