using Domain.Model.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDomain
{
    [TestClass]
    public sealed class PhoneTest
    {
        [TestMethod]
        public void PhoneConstructor_EverythingsFine_ObjIsCreated()
        {
            Phone phone = new Phone("397654532291");
            Assert.AreEqual("397654532291", phone.Value);

        }

        [TestMethod]
        public void PhoneConstructor_ContainsLessThanSevenDigits_ThrowsException()
        {
            Phone phone;
            Assert.ThrowsException<ArgumentException>(() => phone = new Phone("39765432"));
        }

        [TestMethod]
        public void PhoneConstructor_ContainsLettersAndDigits_ThrowsException()
        {
            Phone phone;
            Assert.ThrowsException<ArgumentException>(() => phone = new Phone("3d9765a432"));
        }

        [TestMethod]
        public void PhoneConstructor_IsWhiteSpace_ThrowsException()
        {
            Phone phone;
            Assert.ThrowsException<ArgumentException>(() => phone = new Phone(" "));
        }
    }
}
