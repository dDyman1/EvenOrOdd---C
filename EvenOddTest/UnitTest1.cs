using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text;
using FluentAssertions;
using EvenOrOdd;

namespace EvenOddTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IOTest()
        {
            TextWriter tmp = Console.Out;
            String readIn = "5\n7\n4\n31\n96\n-1\nFish";
            StringBuilder writeOut = new StringBuilder();
            Console.SetIn(new StringReader(readIn));
            Console.SetOut(new StringWriter(writeOut));
            Program.Main(null);
            String expected = "The number five is odd."
                + Environment.NewLine + "The number seven is odd."
                + Environment.NewLine + "The number four is even."
                + Environment.NewLine + "The number thirty-one is odd."
                + Environment.NewLine + "The number ninety-six is even."
                + Environment.NewLine + "The number minus one is odd.";
            Console.SetOut(tmp);
            expected.Should().Be(writeOut.ToString().Trim());
        }

        [TestMethod]
        public void TestIsEven()
        {
            Assert.IsTrue(Program.isEven(4));
            Assert.IsFalse(Program.isEven(1));
            Assert.IsFalse(Program.isEven(7));
            Assert.IsTrue(Program.isEven(-2));
            Assert.IsFalse(Program.isEven(-1));
        }
    }
}
