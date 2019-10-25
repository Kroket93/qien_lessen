using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculateur
{
    public partial class Form1 : Form
    {
        Calculator calculator = new Calculator();
        public Form1()
        {
            InitializeComponent();
            foreach (var button in this.Controls.OfType<Button>())
            {
                int newSize = 16;
                button.Font = new Font(button.Font.FontFamily, newSize);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textUpdater()
        {
            List<String> updatedText = calculator.getUpdatedText();
            inputBoxA.Text = updatedText[0];
            inputBoxB.Text = updatedText[1];
            operatorBox.Text = updatedText[2];
            outputBox.Text = updatedText[3];
        }


        private void numberButtonClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
            calculator.pressNumber(button.Text);
            textUpdater();
            //calculator.update(ref inputBoxA.Text, inputBoxB, operatorBox, outputBox);
            //property or indexer may not be passed as an out or ref parameter
        }


        private void buttonEquals_Click(object sender, EventArgs e)
        {
            calculator.calculate();
            textUpdater();
        }


        private void buttonReset_Click(object sender, EventArgs e)
        {
            calculator.reset();
            textUpdater();
        }


        private void operatorButtonClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
            calculator.pressButon(button.Text);
            textUpdater();
        }

        private void formulaCalculateButton_Click(object sender, EventArgs e)
        {
            formulaOutputBox.Text =  calculator.stringCalculate(formulaInputBox.Text);
        }
    }
}
