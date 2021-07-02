using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_App
{
    public partial class Form1 : Form
    {

        bool HasAns = false;

        //Where we store all the data
        private decimal First = 0.0m;
        private decimal Second = 0.0m;
        private decimal Ans = 0.0m;
        private int OperationType = 0;

        //Operations
        public enum Operations
        {
            addition = 1,
            subraction = 2,
            multiplication = 3,
            division = 4,
        }


        public Form1()
        {
            InitializeComponent();
        }

        //Button Click Events
        private void NumClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (DisplayBox.Text == "0")
            {
                DisplayBox.Clear();
            }
            if (HasAns == true)
            {
                DisplayBox.Clear();
                HasAns = false;
            }
            DisplayBox.Text = DisplayBox.Text + btn.Text;
        }

        //Decimal Point Click Event
        private void DecimalPoint_Click(object sender, EventArgs e)
        {
            if (!DisplayBox.Text.Contains("."))
            {
                DisplayBox.Text += ".";
            }
        }

        // Get previous answer
        private void Answer_Click(object sender, EventArgs e)
        {
            DisplayBox.Text = Ans.ToString();
        }

        //Negative and Positive CLick Event
        private void Sign_Click(object sender, EventArgs e)
        {
            if (!DisplayBox.Text.Contains("-"))
            {
                DisplayBox.Text = "-" + DisplayBox.Text;
            }
            else
            {
                DisplayBox.Text = DisplayBox.Text.Trim('-');
            }
        }

        //Save the 1st and continue with the operation
        private void Save(int operation)
        {
            OperationType = operation;
            First = Convert.ToDecimal(DisplayBox.Text);
            DisplayBox.Text = "0";
        }

        //Operation Click Event
        private void OperationClick(object sender, EventArgs e)
        {
            Button op = (Button)sender;
            if (op.Text == "+")
            {
                Save((int)Operations.addition);
            }

            if (op.Text == "-")
            {
                Save((int)Operations.subraction);
            }

            if (op.Text == "*")
            {
                Save((int)Operations.multiplication);
            }

            if (op.Text == "/")
            {
                Save((int)Operations.division);
            }
        }

        //Does the operation when = is clicked
        private void Equals_Click(object sender, EventArgs e)
        {
            HasAns = true;
            Second = Convert.ToDecimal(DisplayBox.Text);
            switch(OperationType)
            {
                case 1:
                    Ans = First + Second;
                    break;
                case 2:
                    Ans = First - Second;
                    break;
                case 3:
                    Ans = First * Second;
                    break;
                case 4:
                    Ans = First / Second;
                    break;
            }
            DisplayBox.Text = Ans.ToString();
        }

        //Remove 1 char from the string
        private void delete_Click(object sender, EventArgs e)
        {
            int index = DisplayBox.Text.Length;
            index--;
            DisplayBox.Text = DisplayBox.Text.Remove(index);
            if (DisplayBox.Text == "")
            {
                DisplayBox.Text = "0";
            }
        }

        //Clear DisplayBox
        private void Clear_Click(object sender, EventArgs e)
        {
            DisplayBox.Text = "0";
        }

        //Clear all Entries
        private void ClearEntry_Click(object sender, EventArgs e)
        {
            DisplayBox.Text = "0";
            First = 0.0m;
            Second = 0.0m;
            Ans = 0.0m;
            OperationType = 0;
        }
    }
}
