using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model.Entities;
using Domain.Model.ValueObjects;

namespace TestDomain
{
    [TestClass]
    public sealed class DogTest
    {
        [TestMethod]
        public void DogConstructorWOnlyNameNdList_WorksFine_ObjIsCreated()
        {
            Dog dog1 = new Dog("Mike", new List<VeterinaryVisit>());
            Assert.AreEqual("Mike", dog1.Name);
            Assert.AreEqual(0, dog1.VisitList.Count);
        }

        [TestMethod]
        public void FullDogConstructor_WorksFine_ObjIsCreated()
        {
            DateOnly birthday = new DateOnly(2020, 5, 20);
            Birthdate birthdate = new Birthdate(birthday);
            Dog dog1 = new Dog("Mike", birthdate, "Bulldog", "Bone", new List<VeterinaryVisit>());
            Assert.AreEqual("Mike", dog1.Name);
            Assert.AreEqual(dog1.Birthday, birthdate);
            Assert.AreEqual("Bulldog", dog1.Breed);
            Assert.AreEqual("Bone", dog1.FavouriteChewing);
            Assert.AreEqual(0, dog1.VisitList.Count);
        }

        [TestMethod]
        public void FavouriteChewing_SetEmptyString_ThrowsArgumentException()
        {
            Dog dog1 = new Dog("Mike", new List<VeterinaryVisit>());
            Assert.ThrowsException<ArgumentException>(() => dog1.FavouriteChewing = "");
        }
    }
}
