using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NUnit.Framework;
using NUnit.Extensions.Forms;
using SAdder;

namespace ClassLibrary1
{
    [TestFixture]
    public class Class1
    {


        [Test]
        public void MethodTest()
        {
            Assert.IsTrue(SAdder.MainForm.Add(112, 333)==445);
        }
    }
}
