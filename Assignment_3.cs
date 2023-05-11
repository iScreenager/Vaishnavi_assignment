using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssignments
{
    class Assignment3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First Number:-");

            double num1 =double.Parse( Console.ReadLine());

            Console.WriteLine("Enter the Second Number:-");

            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the operation (+,-,*,/) :-");

            string operation = Console.ReadLine();

            bool check = checkForOperation(operation);

            if(check != true)
            {
                double result = Calculator(num1, num2, operation);



                Console.WriteLine("Your result: ");
                Console.WriteLine(num1 + " " + operation + " " + num2 + " " + " = " + result);


            }
            else
            {
                Console.WriteLine("Invalid Operation!!! Please check and enter the correct Operation.");
            }


        }

        public static double Calculator(double num1,double num2,string operation)
        {
            double result =0.0;
           

            switch (operation)
            {
                case "+":  result = num1 + num2; break;
                case "-": result = num1 - num2; break;
                case "*":result = num1 * num2; break;
                case "/":result = num1 / num2; break;
                default:   break;
            }
           
            return result;
           
           
        }
        
        public static bool checkForOperation(string operation)
        {
            bool check = true;

            if(operation == "+" || operation=="-" || operation =="*" || operation == "/")
            {
                check = false;
            }
            return check;
        }


    }
}
