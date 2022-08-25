using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace _25August
{
    internal class _25AugustEx4
    {
        static void Main(string[] args)
        {
            DriveInfo driveInfos = new DriveInfo("D");
            Console.WriteLine(driveInfos.Name);
            Console.WriteLine(driveInfos.TotalSize);
            Console.WriteLine(driveInfos.VolumeLabel);
            Console.WriteLine(driveInfos.TotalFreeSpace);
            Console.WriteLine(driveInfos.AvailableFreeSpace);
            Console.WriteLine(driveInfos.DriveFormat);
            Console.WriteLine(driveInfos.DriveType);
            Console.WriteLine(driveInfos.IsReady);
            Console.WriteLine(driveInfos.Name);
            Console.WriteLine(driveInfos.RootDirectory);
            Console.WriteLine("----------------------------");

            Console.WriteLine("_________________________________");

            DriveInfo[] dinfo = DriveInfo.GetDrives();
            Console.WriteLine(dinfo.Length);

            foreach (DriveInfo d in dinfo)
            {
                Console.WriteLine(d);
            }
            Console.ReadLine();
            Console.Read();

        }
    }
}
