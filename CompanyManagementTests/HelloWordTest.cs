using CompanyManagement.Database;
using CompanyManagement.Database.Entities;
using NUnit.Framework;
using System;
using System.Linq;

namespace CompanyManagementTests
{
    [TestFixture]
    public class HelloWordTest
    {
        [Test]
        public void FirstTest()
        {
            Assert.IsTrue(1 == 1);
        }

        [Test]
        public void FirstDbContextTest()
        {
            using(var context = new Context("Context"))
            {
                context.Companies.Add(new Company {Id = Guid.NewGuid(), Name = "Hello" });
                context.SaveChanges();
            }
        }

        [Test]
        public void GetCompanyTest()
        {
            using (var context = new Context("Context"))
            {
                var result = context.Companies.First(company => company.Name == "Hello");

                Assert.AreEqual("Hello", result.Name);
                Assert.IsTrue(result.Id != Guid.Empty);
            }
        }
    }
}
