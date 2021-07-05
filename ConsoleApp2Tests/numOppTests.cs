using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Tests
{
    [TestClass()]
    public class numOppTests
    {
        [TestMethod()]
        public void addTTest()
        {

            var tt = new numOpp() { };
            var test = tt.addT(1, 2);

            Assert.AreEqual(3, test);
        }
    }
}

namespace ConsoleApp2Tests
{
    class numOppTests
    {
    }
}
