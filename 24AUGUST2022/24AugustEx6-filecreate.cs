using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ReusableCodeLibrary
{
    public class Filecreate
    {
        public static void Fileecre()
        {
            string path = @"D:\NewRepo\firstFile.txt";
            File.Create(path);
            Console.ReadLine();

        }
        
    }
}
