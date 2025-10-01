using Domain.Model.Entities;
using Domain.Model.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TestDomain
{
    [TestClass]
    public sealed class AddressTest
    {
        [TestMethod]
        public void AddressConstructor_EverythingsFine_ObjIsCreated()
        {
            string street = "Main St";
            string city = "Springfield";
            string zipCode = "12345";
            Address address = new Address(street, city, zipCode);
            Assert.AreEqual(street, address.Street);
            Assert.AreEqual(city, address.City);
            Assert.AreEqual(zipCode, address.ZipCode);
        }

        [TestMethod]
        public void AddressConstructor_StreetIsWhiteSpace_ThrowsException()
        {
            string street = " ";
            string city = "Springfield";
            string zipCode = "12345";
            Address address;
            Assert.ThrowsException<ArgumentException>(() => address = new Address(street, city, zipCode));
        }

        [TestMethod]
        public void AddressConstructor_CityIsWhiteSpace_ThrowsException()
        {
            string street = "Main St";
            string city = " ";
            string zipCode = "12345";
            Address address;
            Assert.ThrowsException<ArgumentException>(() => address = new Address(street, city, zipCode));
        }
    }
}
