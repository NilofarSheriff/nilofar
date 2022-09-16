using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using ClassLib;

namespace _14September
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CustomerUser User = new CustomerUser();
            //User.PhoneNumber = "9344290177";
            //User.datecre =  DateTime.Now;
            //User.ValidateUser(User);
            //FileStream fs = new FileStream(@"user2.bin",FileMode.Create,FileAccess.Write);
            //BinaryFormatter formatter = new BinaryFormatter();
            //formatter.Serialize(fs, User);

            FileStream fs = new FileStream(@"user.bin", FileMode.Open, FileAccess.Read);
            BinaryFormatter formatter = new BinaryFormatter();
            CustomerUser user = (CustomerUser)formatter.Deserialize(fs);
            Console.WriteLine(user.LoginStatus);
            Console.WriteLine(user.datecre);

            fs.Flush();
            fs.Close();
            fs.Dispose();
            Console.ReadLine();

        }
    }
}
