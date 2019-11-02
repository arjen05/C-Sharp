using System;

namespace ArithmeticOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = 10;
            var secondNumber = 5;

            //addition
            int addition = firstNumber + secondNumber;
            Console.WriteLine("{0} + {1} = " + addition, firstNumber, secondNumber);

            //subtraction
            int subtraction = firstNumber - secondNumber;
            Console.WriteLine("{0} - {1} = " + subtraction, firstNumber, secondNumber);

            //multiplication
            int multiplication = firstNumber * secondNumber;
            Console.WriteLine("{0} * {1} = " + multiplication, firstNumber, secondNumber);

            //division
            int division = firstNumber / secondNumber;
            Console.WriteLine("{0} / {1} = " + division, firstNumber, secondNumber);

        }
    }
}
