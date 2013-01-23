using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace SAdder
{
    [TestFixture]
    class TestClass
    {
        [Test]
        public static void Test1()
        {
            Assert.That(SAdder.MainForm.Add(2, 3), Is.EqualTo(5));
            Assert.That(SAdder.MainForm.Add(4,8),Is.EqualTo(12));
        }
    }
}
