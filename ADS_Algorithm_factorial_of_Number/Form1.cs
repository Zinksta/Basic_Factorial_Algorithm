using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ADS_Algorithm_factorial_of_Number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Enter an integer to calculate the factorial", "Enter factorial");
            int n = Convert.ToInt32(input);
            int value = Factorial(n); // initial call to the recursive function
            txtOutput.Text = "The factorial of " + n + " is: " + value;
        }

        private int Factorial(int n)
        {
            if (n <= 0) // base case
                return 1;
            else
                return Factorial(n - 1) * n; // recursive call
        }
    }
}

