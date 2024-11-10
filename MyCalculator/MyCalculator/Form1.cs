using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class CalculatorForm : Form
    {
        Model model;
        public CalculatorForm()
        {
            InitializeComponent();
            model = new Model();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button inputButton = (Button)sender;

            if (resultTextBox.Text != "")
            {
                inputTextBox.Clear();
                resultTextBox.Clear();
            }

            inputTextBox.Text = model.AppendToInput(inputTextBox.Text, inputButton.Text);
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            double result = model.getButtonEqual(inputTextBox.Text);
            resultTextBox.Text = "= " + result.ToString();
        }

        private void buttonSetClear_Click(object sender, EventArgs e)
        {
            model.Clear();
            inputTextBox.Clear();
            resultTextBox.Clear();
        }
    }
}
