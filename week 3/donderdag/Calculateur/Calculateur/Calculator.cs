using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Calculateur
{
    class Calculator
    {
        public double result;
        public int focus = 0;
        public bool gotResult = false;
        public bool selectingOperator = false;

        public String textA;
        public String textB;
        public String operatorText;
        public String output;

        List<OperatorBase> operatorsList = new List<OperatorBase>();
        operatorAdd operatorAdd = new operatorAdd();
        operatorMinus operatorMinus = new operatorMinus();
        operatorTimes operatorTimes = new operatorTimes();
        operatorDivision operatorDivision = new operatorDivision();

        //testing purposes
        String formula = "10+15*2";

        public Calculator()
        {
            operatorsList.Add(operatorAdd);
            operatorsList.Add(operatorMinus);
            operatorsList.Add(operatorTimes);
            operatorsList.Add(operatorDivision);
        }


        public void calculate()
        {
            Console.WriteLine(stringCalculate(formula));

            if(!String.IsNullOrEmpty(textA)&&!String.IsNullOrEmpty(textB))
            {
                //list extension?
                foreach (OperatorBase operat in operatorsList)
                {
                    if (operatorText == operat.symbol)
                    {
                        result = operat.calculate(textA, textB);
                    }
                }

                output = Convert.ToString(result);
                selectingOperator = false;
                gotResult = true;
            }

        }

        public String stringCalculate(String formula)
        {
            return new DataTable().Compute(formula, null).ToString();
        }


        public int getFocus()
        {
            return focus;
        }

        public List<String> getUpdatedText()
        {
            List<String> updatedText = new List<String> { textA, textB, operatorText, output };
            return updatedText;
        }

        public void reset()
        {
            focus = 0;
            textA = "";
            textB = "";
            operatorText = "";
            output = "";
            gotResult = false;
            selectingOperator = false;
        }

        public void continueCalculations()
        {
            
            textA = output;
            textB = "";
            output = "";
            focus = 1;
            selectingOperator = true;
        }
        public void switchFocus()
        {
            if(focus ==0)
            {
                focus = 1;
            }
            else if(focus == 1)
            {
                focus = 0;
            }
        }
        public void pressButon(String operation) {
            operatorText = operation;
            if (!selectingOperator)
            {
                if (!gotResult)
                {
                    switchFocus();
                }
                else
                {
                    continueCalculations();
                }
            }
        }

        public void pressNumber(String number)
        {
            if (focus == 0)
            {
                textA += number;
            }
            else
            {
                textB += number;
            }
        }
    }
}
