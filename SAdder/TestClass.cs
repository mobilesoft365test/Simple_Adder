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
            Assert.That(SAdder.MainForm.Add(2, 4), Is.EqualTo(6));
            Assert.That(SAdder.MainForm.Add(4,8),Is.EqualTo(12));
        }
    }
}
