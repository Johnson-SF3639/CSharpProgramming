using System;
using System.IO;
namespace ReadWriteTxtFile{
    class Program{
        public static void Main(string[] args)
        {
            if(!Directory.Exists("TestFolder")){
                Directory.CreateDirectory("TestFolder");
                Console.WriteLine($"Folder created");
            }
            else{
                Console.WriteLine($"Folder Exists");
            }

            if(!File.Exists("TestFolder/Test.txt")){
                File.Create("TestFolder/Test.txt");
                Console.WriteLine($"File Created");
            }else{
                Console.WriteLine($"File Found");
            }

            Console.WriteLine($"\nSelect option \n1. Read File\n2. Write File\n3. Exit");
            Console.Write($"\nEnter your Choice : ");

            int action = int.Parse(Console.ReadLine());

            switch(action){
                case 1:{
                    string line;
                    StreamReader sr = null;
                    try{
                        sr = new StreamReader("TestFolder/Test.txt");
                        line = sr.ReadLine();
                        while(line != null)
                        {
                            Console.WriteLine($"{line}");
                            line = sr.ReadLine();                            
                        }
                    }catch(Exception e){
                        Console.WriteLine($"Exception : {e.Message}");
                    }
                    finally{
                        if(sr != null){
                            Console.WriteLine($"Executing Finally Block.");
                            sr.Close();                            
                        }
                    }
                    break;
                }
                case 2:{
                    StreamWriter sw = null;
                    try{
                    string[] old = File.ReadAllLines("TestFolder/Test.txt");
                    sw = new StreamWriter("TestFolder/Test.txt");

                    Console.WriteLine($"Enter the New Content to be Placed in file");
                    string info = Console.ReadLine();
                    string old1="";

                    foreach(string text in old){
                        old1 = old1+ "\n" + text;
                    }

                    old1=old1+ "\n" + info;
                    sw.WriteLine(old1);

                    }
                    catch(Exception e){
                        Console.WriteLine($"Exception : {e.Message}");
                    }
                    finally{
                        Console.WriteLine($"Executing Finally Block.");
                        sw.Close();
                    }
                    break;
                }
                case 3:{
                    System.Console.WriteLine("Exit Successfully");
                    break;
                }
            }
            Console.WriteLine($"\n");
            
        }
    }
}