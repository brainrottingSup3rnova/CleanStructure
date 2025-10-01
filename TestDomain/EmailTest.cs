using Domain.Model.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDomain
{
    [TestClass]
    public sealed class EmailTest
    {
        [TestMethod]
        public void EmailConstructor_EverythingsFine_ObjIsCreated()
        {
            Email email = new Email("yoyoyo@gmail.com");
            Assert.AreEqual("yoyoyo@gmail.com", email.Value);
        }

        [TestMethod]
        public void EmailConstructor_DoesntContainSpir_ThrowsException()
        {
            Email email;
            Assert.ThrowsException<ArgumentException>(() => email = new Email("yoyoyogmail.com"));
        }

        [TestMethod]
        public void EmailConstructor_DoesntContaintwoCharsAfterTheSpir_ThrowsException()
        {
            Email email;
            Assert.ThrowsException<ArgumentException>(() => email = new Email("yoyoyogmail@gmail.a"));
        }

        [TestMethod]
        public void EmailConstructor_DoesntContainThePeriod_ThrowsException()
        {
            Email email;
            Assert.ThrowsException<ArgumentException>(() => email = new Email("yoyoyogmail@gmaila"));
        }
    }
}
