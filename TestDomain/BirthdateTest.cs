using Domain.Model.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDomain
{
    [TestClass]
    public sealed class BirthdateTest
    {
        [TestMethod]
        public void BirthdateConstructor_EverythingsFine_ObjIsCreated()
        {
            DateOnly date = new DateOnly(1990, 1, 1);
            Birthdate birthdate = new Birthdate(date);
        }

        [TestMethod]
        public void BirthdateConstructor_FutureDate_ThrowsException()
        {
            DateOnly date = new DateOnly(2026, 1, 1);
            Birthdate birthdate;
            Assert.ThrowsException<ArgumentException>(() => birthdate = new Birthdate(date));
        }
    }
}
