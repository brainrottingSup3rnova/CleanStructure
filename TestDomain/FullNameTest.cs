using Domain.Model.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDomain
{
    [TestClass]
    public sealed class FullNameTest
    {
        [TestMethod]
        public void FullNameConstructor_EverythingsFine_ObjIsCreated()
        {
            FullName fullName = new FullName("John", "Doe");
            Assert.AreEqual("John", fullName.First);
            Assert.AreEqual("Doe", fullName.Last);
        }

        [TestMethod]
        public void FullNameConstructor_FirstNameIsWhiteSpace_ThrowsException()
        {
            FullName fullName;
            Assert.ThrowsException<ArgumentException>(() => fullName = new FullName(" ", "Doe"));
        }

        [TestMethod]
        public void FullNameConstructor_LastNameIsWhiteSpace_ThrowsException()
        {
            FullName fullName;
            Assert.ThrowsException<ArgumentException>(() => fullName = new FullName("John", " "));
        }
    }
}
