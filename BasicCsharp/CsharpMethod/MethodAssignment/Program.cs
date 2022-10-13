using System;
namespace MethodAssignment{
    class Program{
        public static void Main(string[] args)
        {
            int check, value1, value2, multiplication;
            double division;
            string again;
            do{
                Console.WriteLine("The basic mathematical operations \n1. Addition \n2. Subtraction \n3. Multiplication \n4. Division\n\nEntre Your Choice :");
                check = Convert.ToInt32(Console.ReadLine());

                if(check < 5 && check > 0){
                Console.Write("Enter the 1st Number : ");
                value1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nEnter the 2st Number : ");
                value2 = Convert.ToInt32(Console.ReadLine());

                switch(check){
                    case 1:{
                        Addition();
                        break;
                    }
                    case 2:{
                        Subtraction(value1, value2);
                        break;
                    }
                    case 3:{
                        multiplication = Multiplication(value1, value2);
                        Console.Write($"Multiplication of {value1} and {value2} is : {multiplication}");
                        break;
                    }
                    case 4:{
                        division = Division();
                        Console.Write($"Multiplication of {value1} and {value2} is : {division}");
                        break;
                    }
                }

                Console.WriteLine("\nDo you want to try again (Yes/No) : ");
                again =Console.ReadLine();
                if(again !="Yes"){
                    break;
                }
                }else{
                    Console.WriteLine("Enter the Valid Number (1 to 4)");
                }
            }while(true);

            void Addition(){
                Console.WriteLine($"Addition of {value1} and {value2} is : "+(value1+value2));
            }
            void Subtraction(int value1, int value2){
                Console.WriteLine($"Subtraction of {value1} and {value2} is : "+(value1-value2));
            }
            int Multiplication(int value1, int value2){
                return (value1*value2);
            }
            double Division(){
                return (value1/value2);
            }
        }
    }
}