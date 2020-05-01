using System;
using HomeWork4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PersonTests
{
    [TestClass]
    public class UnitTest1
    {
        Person person = new Person("John", new DateTime(2010, 5, 5));

        [TestMethod]
        public void AgeCounterChecking()
        {
            int expected = 10;
            int actual = person.AgeCounter();
        }
    }
}
