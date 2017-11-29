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

        [TestCase]
        public void NumberOfMcIntonshApplesFor5Cups()
        {
            Assert.AreEqual("Your apple pie requires 6.25 McIntosh apples", RunApplePieApplication.Execute("5", "McIntosh"));
        }

        [TestCase]
        public void ThisTestWillFail()
        {
            Assert.AreEqual("Output Text will not match", RunApplePieApplication.Execute("5", "McIntonsh"));
        }
    }
}
