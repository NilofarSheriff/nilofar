using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace _25August
{
    internal class _25AugustEx2
    {
        static void Main(string[] args)
        {
            //string path = @"D:\NewRepo\secondfile.txt";
            //aFile.Create(path);
            //Console.WriteLine("File created sucessfully");
            //File.Copy("new.txt", "copiedfile.txt");
            //Console.WriteLine("File Copied to the bin sucessfully");
            //string dest = @"D:\NewRepo\Copied.txt";
            //File.Copy(path, dest);
            //Console.WriteLine("File Copied to the different location sucessfully");
            //string path = @"D:\NewRepo\firstFile.txt";
            //File.Move(path, "moved file");
            //Console.WriteLine("First file moved sucessfully");
            //File.Delete("copiedfile.txt");
            //Console.WriteLine("second file deleted sucessfully");
            FileInfo fileInfo = new FileInfo("new.txt");
            string ext = fileInfo.Extension;
            Console.WriteLine("The extension of the secondfile is : " + ext);
            string creationtime = fileInfo.CreationTime.ToString();
            Console.WriteLine("The creation time of the secondfile is : " + creationtime);
            string directory = fileInfo.DirectoryName;
            Console.WriteLine("The directory name of the second file is : " + directory);
            Console.ReadLine();
        }
    }
}
