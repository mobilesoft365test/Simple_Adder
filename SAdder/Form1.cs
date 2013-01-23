using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SAdder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        
        private void ClearA(object sender, EventArgs e)
        {
            BoxA.Text = string.Empty;
        }

        private void ClearB(object sender, EventArgs e)
        {
            BoxB.Text = string.Empty;
        }

        private void CalculateBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(BoxA.Text);
                int b = Convert.ToInt32(BoxB.Text);
                BoxC.Text = Add(a, b).ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show("Incorrect input data","Input data error");
            }

        }

    }
}
