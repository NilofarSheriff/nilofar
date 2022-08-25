using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _25August
{
    internal class _25AugustEx3
    {
        static void Main(string[] args)
        {
            string path = @"D:\NewRepo\Results";
            //Directory.CreateDirectory(path);
            //Console.WriteLine("Directory created sucesfully");
            //Directory.CreateDirectory(Path.Combine(path, "Results_17-18"));
            //Directory.CreateDirectory(Path.Combine(path, "Results_18-19"));
            //Directory.CreateDirectory(Path.Combine(path, "Results_20-21"));
            //File.Create(@"D:\NewRepo\Results\Results_17-18\file1.txt");
            //File.Create(@"D:\NewRepo\Results\Results_18-19\file1.txt");
            //File.Create(@"D:\NewRepo\Results\Results_20-21\file1.txt");
            //File.Create(@"D:\NewRepo\Results\Results_17-18\file2.txt");
            //File.Create(@"D:\NewRepo\Results\Results_18-19\file2.txt");
            //File.Create(@"D:\NewRepo\Results\Results_20-21\file2.txt");
            //Console.WriteLine("Subdirectories created");
            //Console.WriteLine("Files Created sucessfully");
            

            Directory.CreateDirectory(@"D:\NewRepo\Results\Results_17-18\Jan");
            Directory.CreateDirectory(@"D:\NewRepo\Results\Results_17-18\Feb");
            Directory.CreateDirectory(@"D:\NewRepo\Results\Results_17-18\Mar");
            Directory.CreateDirectory(@"D:\NewRepo\Results\Results_17-18\Apr");
            Directory.CreateDirectory(@"D:\NewRepo\Results\Results_17-18\May");
            Directory.CreateDirectory(@"D:\NewRepo\Results\Results_17-18\Jun");
            Directory.CreateDirectory(@"D:\NewRepo\Results\Results_17-18\Jul");
            Directory.CreateDirectory(@"D:\NewRepo\Results\Results_17-18\Aug");
            Directory.CreateDirectory(@"D:\NewRepo\Results\Results_17-18\Sep");
            Directory.CreateDirectory(@"D:\NewRepo\Results\Results_17-18\OCT");
            Directory.CreateDirectory(@"D:\NewRepo\Results\Results_17-18\Nov");
            Directory.CreateDirectory(@"D:\NewRepo\Results\Results_17-18\Dec");
           
            Console.WriteLine("Dir created");

            Console.WriteLine("**************************************************************************");

            Console.WriteLine("The files are shown");

            //string[] fname = Directory.GetFiles(path);
            //foreach (string fname11 in fname) { Console.WriteLine(fname11); }
            //Console.WriteLine("______________________________________");
            //string path1 = @"D:\NewRepo\Results\Results_18-19";
            //string[] fname1 = Directory.GetFiles(path1);
            //foreach (string fname21 in fname) { Console.WriteLine(fname21); }
            //Console.WriteLine("______________________________________");

            //string path2 = @"D:\NewRepo\Results\Results_20-21";
            //string[] fname2 = Directory.GetFiles(path2);
            //foreach (string fname22 in fname) { Console.WriteLine(fname22); }
            //Console.WriteLine("______________________________________");

            string[] dir = Directory.GetDirectories(path);
            foreach (string dir2 in dir)
            {
               
                Console.WriteLine("files");
                string[] files = Directory.GetFiles(dir2);
                foreach (string file2 in files)
                {
                    Console.WriteLine(file2);
                }
                Console.WriteLine("----------------------------------------------------");
            }

            Console.WriteLine("***************************************************************************");
            string[] fold= Directory.GetDirectories(@"D:\NewRepo\Results\Results_17-18");
            foreach (string fold2 in fold) { Console.WriteLine(fold2); }

            
               

            Console.ReadLine();
            }











        
    }
}
