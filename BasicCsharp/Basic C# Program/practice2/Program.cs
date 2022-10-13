using System;
namespace Pratice2{
    class Program{
        public static void Main(string[] args)
        {
            double firstNumber, secondNumber, addition, subtraction, multiplication, dividing, modulo ;
            Console.WriteLine("Enter The First No");
            firstNumber= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Second No");
            secondNumber= Convert.ToInt32(Console.ReadLine());
            
            addition=(firstNumber + secondNumber);
            subtraction=(firstNumber - secondNumber);
            multiplication=(firstNumber * secondNumber);
            dividing=(firstNumber / secondNumber);
            modulo =(firstNumber % secondNumber);

            Console.WriteLine($"{firstNumber} + {secondNumber} = {addition}");
            Console.WriteLine($"{firstNumber} - {secondNumber} = {subtraction}");
            Console.WriteLine($"{firstNumber} * {secondNumber} = {multiplication}");
            Console.WriteLine($"{firstNumber} / {secondNumber} = {dividing}");
            Console.WriteLine($"{firstNumber} % {secondNumber} = {modulo}");

        }
    }
}