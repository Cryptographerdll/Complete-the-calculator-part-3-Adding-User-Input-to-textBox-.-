using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculatorWindows
{
    /*
    <summary>
     A basic Calculator
    <summary>
    */
    public partial class Form1 : Form
    {
        #region "Constructor"
        
         /// <summary>
         /// dEFAULT constructor
        /// <summary>
 
        public Form1()
        {
            InitializeComponent();
            // this.CEbutton.Click += new System.EventHandler(this.CEbutton_Click);
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void CEbutton_Click(object sender, EventArgs e)
        {
            // Clears the user input .
            this.textBox1.Text = string.Empty;
            // Focus the user Input .
            FocusInputText(); 
        }
       

        private void RemoveButton_Click(object sender, EventArgs e)
        {

            DeleteTextValue();
            // Focusing the input on user selection .
            FocusInputText();
        }
        #region Operations
        private void PercentageButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("%");
            // Focusing the input on user selection .
            FocusInputText();
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("*");
            // Focusing the input on user selection .
            FocusInputText();
        }
        private void PlusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("+");
            // Focusing the input on user selection .
            FocusInputText();
        }
        private void MinusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("-");
            // Focusing the input on user selection .
            FocusInputText();
        }
        private void DevideButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("/");
            // Focusing the input on user selection .
            FocusInputText();
        }
        private void EqualButton_Click(object sender, EventArgs e)
        {
            CalculateResult();
            // Focusing the input on user selection .
            FocusInputText();
        }
        #endregion

        #region Buttons Numbers
        private void PointButton_Click(object sender, EventArgs e)
        {
            InsertTextValue(".");
            // Focusing the input on user selection .
            FocusInputText();
        }
        private void ZeroButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("0");
            // Focusing the input on user selection .
            FocusInputText();
        }
        private void OneButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("1");
            // Focusing the input on user selection .
            FocusInputText();
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("2");
            // Focusing the input on user selection .
            FocusInputText();
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("3");
            // Focusing the input on user selection .
            FocusInputText();
        }
        private void ForthButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("4");
            // Focusing the input on user selection .
            FocusInputText();
        }
        private void FiveButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("5");
            // Focusing the input on user selection .
            FocusInputText();
        }
        private void SixButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("6");
            // Focusing the input on user selection .
            FocusInputText();
        }
        private void SevenButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("7");
            // Focusing the input on user selection .
            FocusInputText();
        }
        private void EightButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("8");
            // Focusing the input on user selection .
            FocusInputText();
        }
        private void nineButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("9");
            // Focusing the input on user selection .
            FocusInputText();
        }
        #endregion
        // Equation Method 
        private void CalculateResult()
        {
            // Focusing the input on user selection .
            FocusInputText();
        }
        #region Private Helpers
        // Focus the user Input Text .
        private void FocusInputText()
        {
            this.textBox1.Focus();
        }
            // Insert the user text into the user Input text Box .
        private void InsertTextValue(string value)
        {
            // Remeber the Selection Start
            var selectionStart = this.textBox1.SelectionStart;

            // Set New Text
            this.textBox1.Text = this.textBox1.Text.Insert(this.textBox1.SelectionStart, value);

            // Restore the Selection start 
          /*$*/  this.textBox1.SelectionStart = selectionStart + value.Length; // $

            // Set the selection start to zero
            this.textBox1.SelectionLength = 0;
        }

        // Delete the user Text .
        private void DeleteTextValue()
        {
            // if we don't have a value to delete then we do nothing return null .
            if (this.textBox1.Text.Length < this.textBox1.SelectionStart + 1)
                return;

            // Remeber the Selection Start
            var selectionStart = this.textBox1.SelectionStart;

            // Delete the character to the right of selection .
            
                this.textBox1.Text = this.textBox1.Text.Remove(this.textBox1.SelectionStart, 1);

            // Set the selection start to zero
            this.textBox1.SelectionLength = 0;
        }
        #endregion
    }
}
