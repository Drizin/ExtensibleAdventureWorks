using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensibleAdventureWorks.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var db = new ExtensibleAdventureWorks.Business.Entities.AdventureWorksDB();
            var stores = db.Sales_Stores.ToList();
            Assert.That(stores.Count > 1);
        }
    }
}
