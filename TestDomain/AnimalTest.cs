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
    public sealed class AnimalTest
    {
        [TestMethod]
        public void AddVisit_WorksFine_VisitIsAddedToTheList()
        {
            Cat cat1 = new Cat("Mimi", new List<VeterinaryVisit>());
            DateTime date = new DateTime(2023, 6, 20, 14, 30, 0);
            FullName fullName = new FullName("Andrew", "Smith");
            Email email = new Email("andrewsmith@gmail.com");
            Phone phoneNumber = new Phone("393544532213");
            Veterinary drSmith = new Veterinary(fullName, email, phoneNumber, "veterinary");
            VeterinaryVisit visit1 = new VeterinaryVisit(cat1, drSmith, date , VisitResults.WAITING);
            cat1.AddVisit(visit1);
            Assert.AreEqual(1, cat1.VisitList.Count);
        }

        [TestMethod]
        public void AddVisit_WrongAnimal_ThrowsArgumentException()
        {
            Cat cat1 = new Cat("Mimi", new List<VeterinaryVisit>());
            Dog dog1 = new Dog("Mike", new List<VeterinaryVisit>());
            DateTime date = new DateTime(2023, 6, 20, 14, 30, 0);
            FullName fullName = new FullName("Andrew", "Smith");
            Email email = new Email("andrewsmith@gmail.com");
            Phone phoneNumber = new Phone("393544532213");
            Veterinary drSmith = new Veterinary(fullName, email, phoneNumber, "veterinary");
            VeterinaryVisit visit1 = new VeterinaryVisit(dog1, drSmith, date, VisitResults.WAITING);
            Assert.ThrowsException<ArgumentException>(() => cat1.AddVisit(visit1));
        }

        [TestMethod]
        public void Equals_AnimalsAreEquals_ReturnsTrue()
        {
            Cat cat1 = new Cat("Mimi", new List<VeterinaryVisit>());
            Cat cat2 = new Cat("Mimi", new List<VeterinaryVisit>());
            Assert.IsTrue(cat1.Equals(cat2));
        }

        [TestMethod]
        public void Equals_AnimalsArentEquals_ReturnsFalse()
        {
            Cat cat1 = new Cat("Mimi", new List<VeterinaryVisit>());
            Cat cat2 = new Cat("Mumu", new List<VeterinaryVisit>());
            Assert.IsFalse(cat1.Equals(cat2));
        }
    }
}
