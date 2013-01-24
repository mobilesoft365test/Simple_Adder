using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using NUnit.Framework;
using SAdder;

namespace GoodTest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    [TestFixture]
    class TestClass
    {
        [Test]
        public void MethodTest()
        {
            Assert.IsTrue(SAdder.MainForm.Add(2,3)==5);
        }
    }
}
