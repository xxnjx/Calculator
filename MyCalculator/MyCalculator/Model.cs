using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    class Model
    {
        string currentText;
        
        public Model()
        {
            currentText = "";
        }

        public void Clear()
        {
            currentText = "";
        }

        public string AppendToInput(string currentInput, string newValue)
        {
            if(isZero(currentInput) || isOperator(currentInput))
            {
                return newValue;
            }
            else
            {
                return currentInput + newValue;
            }
        }

        public bool isZero(string currentInput)
        {
            return currentInput == "0";
        }

        public bool isOperator(string currentInput)
        {
            if (currentInput == "+" 
                || currentInput == "-" 
                || currentInput == "*" 
                || currentInput == "/")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal double getButtonEqual(string expression)
        {
            DataTable dt = new DataTable();
            return Convert.ToDouble(dt.Compute(expression, ""));
        }

    }
}
