using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace _9September
{
    internal class EX4
    {
         static Object obj = new object();

        public static void callmethod()
        {
            string ThreadName = Thread.CurrentThread.Name;
            Console.WriteLine(ThreadName);
            fwrite(ThreadName);
        }

        public static void fwrite(string A)
        {
            try
            {
                Monitor.Enter(obj);
                string path = @"C:\Users\M NILOFAR\source\repos\9September\9September\bin\Debug\newfile.txt";
                FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(A);
                Console.WriteLine("File Written Sucessfully");
                sw.Close();
                fs.Close();
                sw.Dispose();
                fs.Dispose();
               


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Monitor.Exit(obj);
                Console.WriteLine("Releasing the thread " + A);


            }
            
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Thread thread = new Thread(callmethod);
                thread.Name = string.Concat("thread ", i);
                thread.Start();

            }
            Console.Read();


        }




    }
}
