using Domain.Model.Entities;
using Domain.Model.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDomain
{
    [TestClass]
    public sealed class CatTest
    {
        [TestMethod]
        public void CatConstructorWOnlyNameNdList_WorksFine_ObjIsCreated()
        {
            Cat cat1 = new Cat("Mimi", new List<VeterinaryVisit>());
            Assert.AreEqual("Mimi", cat1.Name);
            Assert.AreEqual(0, cat1.VisitList.Count);
        }

        [TestMethod]
        public void FullCatConstructor_WorksFine_ObjIsCreated()
        {
            DateOnly birthday = new DateOnly(2020, 5, 20);
            Birthdate birthdate = new Birthdate(birthday);
            Cat cat1 = new Cat("Mimi", birthdate, "Siamese", new List<VeterinaryVisit>());
            Assert.AreEqual("Mimi", cat1.Name);
            Assert.AreEqual(cat1.Birthday, birthdate);
            Assert.AreEqual("Siamese", cat1.Breed);
            Assert.AreEqual(0, cat1.VisitList.Count);
        }
    }
}
