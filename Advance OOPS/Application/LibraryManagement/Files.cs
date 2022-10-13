using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Files
    {
        public static void Create(){
            if(!Directory.Exists("Details")){
                Console.WriteLine($"Folder Create Successfully");
                Directory.CreateDirectory("Details");                
            }
        }
    }
}