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
    public sealed class VeterinaryTest
    {
        [TestMethod]
        public void VeterinaryConstructor_WorksFine_ObjIsCreated()
        {
            FullName fullName = new FullName("Andrew", "Smith");
            Email email = new Email("andrewsmith@gmail.com");
            Phone phoneNumber = new Phone("393544532213");
            Veterinary drSmith = new Veterinary(fullName, email, phoneNumber, "veterinary");
            Assert.AreEqual("Andrew Smith", drSmith.Name.ToString());
            Assert.AreEqual(email, drSmith.Email);
            Assert.AreEqual(phoneNumber, drSmith.Phone);
            Assert.AreEqual("veterinary", drSmith.Specialization);
        }

        [TestMethod]
        public void VeterinaryEquals_2VetsAreEqual_ReturnsTrue()
        {
            FullName fullName = new FullName("Andrew", "Smith");
            Email email = new Email("andrewsmith@gmail.com");
            Phone phoneNumber = new Phone("393544532213");
            Veterinary drSmith = new Veterinary(fullName, email, phoneNumber, "veterinary");
            FullName fullName2 = new FullName("Andrew", "Kiwi");
            Email email2 = new Email("andrewkiwi@gmail.com");
            Phone phoneNumber2 = new Phone("393544532213");
            Veterinary drKiwi = new Veterinary(fullName2, email2, phoneNumber2, "veterinary");
            Assert.IsTrue(drSmith.Equals(drKiwi));
        }
        [TestMethod]
        public void VeterinaryEquals_2VetsAreNotEqual_ReturnsFalse()
        {
            FullName fullName = new FullName("Andrew", "Smith");
            Email email = new Email("andrewsmith@gmail.com");
            Phone phoneNumber = new Phone("393544532213");
            Veterinary drSmith = new Veterinary(fullName, email, phoneNumber, "veterinary");
            FullName fullName2 = new FullName("Rick", "Kiwi");
            Email email2 = new Email("rickkiwi@gmail.com");
            Phone phoneNumber2 = new Phone("393654332213");
            Veterinary drKiwi = new Veterinary(fullName2, email2, phoneNumber2, "veterinary");
            Assert.IsFalse(drSmith.Equals(drKiwi));
        }
    }
}
