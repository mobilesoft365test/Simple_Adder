using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NUnit.Framework;
using NUnit.Extensions.Forms;
using SAdder;


namespace AdderTest
{
    [TestFixture]
    public class AdderTest : NUnitFormTest
    {
        SAdder.MainForm f;
        public override void Setup()
        {
            base.Setup();
            f = new MainForm();
            f.Show();
        }

        [Test]
        public void MethodTest()
        {
            Assert.Equals(SAdder.MainForm.Add(112,333),445);
            Assert.Equals(SAdder.MainForm.Add(-100, 100), 0);
            Assert.Equals(SAdder.MainForm.Add(50, -65), 15);            
        }

        [Test]
        public void AddTest()
        {
            TextBoxTester textbox1 = new TextBoxTester("BoxA");
            TextBoxTester textbox2 = new TextBoxTester("BoxB");
            TextBoxTester textbox3 = new TextBoxTester("BoxC");
            ButtonTester btn1 = new ButtonTester("CalculateBtn");
            string expected = "-1";
            
            textbox1.Enter("-7");
            textbox2.Enter("6");
            btn1.Click();

            Assert.AreEqual(expected, textbox3.Text);
      
        }

        [Test]
        public void NoDataTest()
        {
            string ErrorDialogCaption = "Input data error";
            string ErrorDialogText = "Incorrect input data";
            ExpectModal(ErrorDialogCaption, "TestErrorDialogHandler");
            var tb1 = new TextBoxTester("BoxA");
            var tb2 = new TextBoxTester("BoxB");
            var CalcBtn = new ButtonTester("CalculateBtn");

            tb1["Text"] = string.Empty;
            tb2["Text"] = string.Empty;
            CalcBtn.Click();
            Assert.IsFalse(f.DialogResult == DialogResult.OK);
        }

        [Test]
        public void IncorrectDataTest()
        {
            string ErrorDialogCaption = "Input data error";
            ExpectModal(ErrorDialogCaption, "TestErrorDialogHandler");

            var tb1 = new TextBoxTester("BoxA");
            var tb2 = new TextBoxTester("BoxB");
            var CalcBtn = new ButtonTester("CalculateBtn");

            tb1["Text"] = "@$%^%$";
            tb2["Text"] = "...";
            CalcBtn.Click();

            Assert.IsFalse(f.DialogResult == DialogResult.OK);
        }

      private void TestErrorDialogHandler()
        {
            string ErrorDialogCaption = "Input data error";
            var messageBoxTester = new MessageBoxTester(ErrorDialogCaption);
            if (messageBoxTester != null)
            {
                messageBoxTester.ClickOk();
            }
        }

      [Test]
      public void ErrorDialogTest()
      {
          string ErrorDialogCaption = "Input data error";
          string ErrorDialogText = "Incorrect input data";
          ExpectModal(ErrorDialogCaption, "ErrorDialogHandler");
          MessageBox.Show(ErrorDialogText, ErrorDialogCaption);
          
      }

      public void ErrorDialogHandler()
      {
          string ErrorDialogCaption = "Input data error";
          string ErrorDialogText = "Incorrect input data";
          var messageBoxTester = new MessageBoxTester(ErrorDialogCaption);
          //Assert.Equals(messageBoxTester.Text, ErrorDialogText);
          messageBoxTester.ClickOk();
         
     }
      [Test]
      public void TestMessageBoxOK()
      {
          ExpectModal("caption", "MessageBoxOkHandler");
          MessageBox.Show("test string", "caption");
      }

      public void MessageBoxOkHandler()
      {
          MessageBoxTester messageBox = new MessageBoxTester("caption");
          //MessageBox.Show("test string", "caption");
          //Assert.Equals("te string", messageBox.Text);
          //Assert.Equals("caion", messageBox.Title);
          messageBox.ClickOk();
      }
    }
}
