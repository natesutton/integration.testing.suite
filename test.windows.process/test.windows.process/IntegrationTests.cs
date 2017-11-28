using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace test.windows.process
{
    [TestFixture]
    class IntegrationTests
    {
        [TestCase]
        public void NumberOfCortlandApplesFor7Cups()
        {
            Assert.AreEqual("Your apple pie requires 4.2 Cortland apples", RunApplePieApplication.Execute("7", "Cortland"));
        }

    }
}
