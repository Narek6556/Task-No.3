using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task_No._3
{
    class Program
    {
        static void Main(string[] args)
        {

            Write("Enter first number...  ");
            int firstNumber = int.Parse(ReadLine());
            Write("Enter second number...  ");
            int secondNumber = int.Parse(ReadLine());
            firstNumber = firstNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;
            WriteLine("First number: {0} ", firstNumber);
            WriteLine("Second number: {0}", secondNumber);


        }
    }
}
