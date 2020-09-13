using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("TEST");
            try
            {
                //Class to convert user input
                InputConverter inputConverter = new InputConverter();

                //Class to perform actual calculations
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                string operationText;
                operationText = "empty";
                if(operation == "+")
                {
                    operationText = "plus";
                }
                if(operation == "-")
                {
                    operationText = "minus";
                }
                if(operation == "*")
                {
                    operationText = "times";
                }
                if (operation == "/")
                {
                    operationText = "divides";
                }
                Console.WriteLine("The value"+" "+firstNumber+" "+operationText+" "+secondNumber+" "+"equals"+" "+Math.Round(result, 2));
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
