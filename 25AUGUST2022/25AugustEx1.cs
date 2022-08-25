using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace _25August
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE FILE NAME");
            String fname = Console.ReadLine();
            
            Console.WriteLine("Enter the number to perform the file action\n" +
                " 1.ADD  \n 2.EDIT  \n 3.TRUNCATE \n");
            int Userchoice = Convert.ToInt32(Console.ReadLine());
            

            switch (Userchoice)
            {
                case 1:
                    {
                        FileStream fn = new FileStream(fname, FileMode.Append, FileAccess.Write);
                        StreamWriter s = new StreamWriter(fn);
                        s.WriteLine("These contents are added to the text file using append");
                        Console.WriteLine("Content added sucessfully");
                        s.Flush();
                        fn.Flush();
                        s.Close();
                        fn.Close();
                        s.Dispose();
                        fn.Dispose();
                        break;

                    }
                case 2:
                    {
                        
                        string[] accounts = File.ReadAllLines(fname);
                        foreach (string account in accounts) { Console.WriteLine(account); }
                        Console.WriteLine("Select to change");
                        string change = Console.ReadLine();
                        Console.WriteLine("WHAT TO REPLACE?");
                        string dest = Console.ReadLine();
                        string[] items2 = accounts.Select(x => x.Replace(change, dest)).ToArray();
                        foreach (string account in items2) { Console.WriteLine(account); }
                        File.WriteAllLines(fname, items2);
                        Console.WriteLine("Content edited sucessfully");
                        break;
                    }
                case 3:
                    {
                        FileStream fn = new FileStream(fname, FileMode.Truncate, FileAccess.Write);
                        Console.WriteLine("Content deleted sucessfully");
                        fn.Close();
                        fn.Dispose();
                        break;
                    }

                    
            }

            Console.ReadLine();




        }

       
    }
}
