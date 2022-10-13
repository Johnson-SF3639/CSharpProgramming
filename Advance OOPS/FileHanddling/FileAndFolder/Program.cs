using System;
using System.IO;
namespace FileAndFolder
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"\n*** Creating Folder And Files ***\n");

            string path = @"C:\Users\JohnsonSoundararajan\OneDrive - Syncfusion\Desktop\MyFolder";

            string folderPath = path + "/John";
            string filePath = path + "/newFile.txt";

            if (!Directory.Exists(folderPath))
            {
                Console.WriteLine($"Create your folder Successfully ");
                Directory.CreateDirectory(folderPath);
            }
            else
            {
                Console.WriteLine($"Already Folder is Here");
            }

            if (!File.Exists(filePath))
            {
                Console.WriteLine($"File Not Found so you can create you File ");
                File.Create(filePath);
            }
            else
            {
                Console.WriteLine($"Already File is Here");
            }

            Console.WriteLine($"\nSelect your Option \n1. Create Folder\n2. Create File\n3. Delete Folder\n4. Delete File\n5. Exit\n");
            Console.Write($"Enter Your Option : ");

            int action = int.Parse(Console.ReadLine());

            switch (action)
            {
                case 1:
                    {
                        Console.WriteLine($"Enter the Folder Name : ");
                        string name1 = Console.ReadLine();
                        string newPath = path + "\\" + name1;

                        if (!Directory.Exists(newPath))
                        {
                            Console.WriteLine($"Create your folder Successfully");
                            Directory.CreateDirectory(newPath);
                        }
                        else
                        {
                            Console.WriteLine($"Already Folder Name is Here");
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine($"Enter the File Name : ");
                        string fileName = Console.ReadLine();
                        Console.WriteLine($"Enter the File Extention : ");
                        string extention = Console.ReadLine();
                        string newPath = path + "\\" + fileName + "." + extention;

                        if (!File.Exists(newPath))
                        {
                            Console.WriteLine($"File Not Found so you can create you File ");
                            File.Create(newPath);
                        }
                        else
                        {
                            Console.WriteLine($"Already File Name is Here");
                        }
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine($"\nYour Folder Details : ");
                        
                        foreach (string name in Directory.GetDirectories(path))
                        {
                            Console.WriteLine($"{name}");
                        }
                        Console.Write($"\nSelcet Folder Name, you want to Delete : ");
                        string name1 = Console.ReadLine();
                        string newPath = path + "\\" + name1;
                        foreach (string name in Directory.GetDirectories(path))
                        {
                            try
                            {
                                if (name == newPath)
                                {
                                    Directory.Delete(newPath);
                                    Console.WriteLine($"Folder Deleted");
                                }
                            }
                            catch (DirectoryNotFoundException e)
                            {
                                Console.WriteLine($"Error : {e}");
                            }
                        }
                        break;
                    }
                case 4:
                    {
                        foreach (string name in Directory.GetFiles(path))
                        {
                            Console.WriteLine($"{name}");
                        }
                        Console.WriteLine($"Selcet file you want to Delete");
                        string name1 = Console.ReadLine();
                        Console.WriteLine($"Selcet file extention you want to Delete");
                        string extention = Console.ReadLine();
                        string newPath = path + "\\" + name1+ "." + extention;
                        foreach (string name in Directory.GetFiles(path))
                        {
                            try
                            {
                                if (name == newPath)
                                {
                                    File.Delete(newPath);
                                    Console.WriteLine($"File Deleted");
                                }
                            }
                            catch (DirectoryNotFoundException e)
                            {
                                Console.WriteLine($"Error : {e}");
                            }
                        }

                        break;
                    }
                case 5:
                    {
                        Console.WriteLine($"\nExit Successfully");
                        
                        break;
                    }
            }



            Console.WriteLine($"\n");
        }
    }
}