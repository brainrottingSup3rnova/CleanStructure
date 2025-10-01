using Domain.Model.Entities;
using Domain.Model.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TestDomain
{
    [TestClass]
    public sealed class VeterinaryVisitTest
    {
        [TestMethod]
        public void VeterinaryVisitConstructor_WorksFine_ObjIsCreated()
        {
            DateOnly birthday = new DateOnly(2020, 5, 20);
            Birthdate birthdate = new Birthdate(birthday);
            DateTime date = new DateTime(2023, 6, 20, 14, 30, 0);
            Dog dog1 = new Dog("Mike", birthdate, "Bulldog", "Bone", new List<VeterinaryVisit>());
            FullName fullName = new FullName("Andrew", "Smith");
            Email email = new Email("andrewsmith@gmail.com");
            Phone phoneNumber = new Phone("393544532213");
            Veterinary drSmith = new Veterinary(fullName, email, phoneNumber, "veterinary");
            VeterinaryVisit visit1 = new VeterinaryVisit(dog1, drSmith, date, VisitResults.WAITING);
            Assert.AreEqual(dog1, visit1.Animal);
            Assert.AreEqual(drSmith, visit1.Veterinary);
            Assert.AreEqual(date, visit1.Date);
            Assert.AreEqual(VisitResults.WAITING, visit1.Results);
        }

        [TestMethod]
        public void VeterinaryVisitConstructor2_WorksFine_ObjIsCreated()
        {
            DateOnly birthday = new DateOnly(2020, 5, 20);
            Birthdate birthdate = new Birthdate(birthday);
            DateTime date = new DateTime(2023, 6, 20, 14, 30, 0);
            Dog dog1 = new Dog("Mike", birthdate, "Bulldog", "Bone", new List<VeterinaryVisit>());
            FullName fullName = new FullName("Andrew", "Smith");
            Email email = new Email("andrewsmith@gmail.com");
            Phone phoneNumber = new Phone("393544532213");
            Veterinary drSmith = new Veterinary(fullName, email, phoneNumber, "veterinary");
            VeterinaryVisit visit1 = new VeterinaryVisit(dog1, drSmith, date, VisitResults.WAITING, "Idk");
            Assert.AreEqual(dog1, visit1.Animal);
            Assert.AreEqual(drSmith, visit1.Veterinary);
            Assert.AreEqual(date, visit1.Date);
            Assert.AreEqual(VisitResults.WAITING, visit1.Results);
            Assert.AreEqual("Idk", visit1.Notes);
        }
    }
}
