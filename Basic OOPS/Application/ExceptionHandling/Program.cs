using System;
namespace ExceptionHandling
{
    class Program
    {
        public static void Main(string[] args)
        {

            try
            {
                Console.WriteLine($"Enter the 1st Number");
                int number1 = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter the 2st Number");
                int number2 = int.Parse(Console.ReadLine());

                Console.WriteLine(number1 / number2);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"The Error is : {e.Message}");
                Console.WriteLine(e.StackTrace);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"The Error is : {e.Message}");
                Console.WriteLine(e.StackTrace);
            }
            catch (Exception e)
            {
                Console.WriteLine($"The Error is : {e.Message}");
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Console.WriteLine("All Exceptions handled properly");
            }

        }
    }
}