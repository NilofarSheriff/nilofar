using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace _12September
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\M NILOFAR\source\repos\12September\MathLibrary\bin\Debug\MathLibrary.dll";

            Assembly asm = Assembly.LoadFrom(path);
            Type[] types = asm.GetTypes();
            
            foreach(var item in types)
            {
                Console.WriteLine("name= " + item.Name);//classname
                Console.WriteLine("Full Name= " + item.FullName);//assemblyname/namespacename and class

                Console.WriteLine("IS Class=" + item.IsClass);
                Console.WriteLine("IS Absatract=" + item.IsAbstract);
                Console.WriteLine("Whether public " + item.IsPublic);


                //Console.WriteLine("-----------------");
                //MemberInfo[] minfo = item.GetMembers();

                //foreach (var minfoitem in minfo)
                //{

                //    Console.WriteLine("Member Info Name= " + minfoitem.Name);

                //    Console.WriteLine("Declaring type=" + minfoitem.DeclaringType);
                //}
                //Console.WriteLine("---------------------");
                //MethodInfo[] methodInfos = item.GetMethods();
                //foreach (var methodInfosItem in methodInfos)
                //{

                //    Console.WriteLine("name=" + methodInfosItem.Name);
                //    Console.WriteLine("IS PUBLIC=" + methodInfosItem.IsPublic);
                //    Console.WriteLine("IS STATIC =" + methodInfosItem.IsStatic);

                //    ParameterInfo[] pinfo = methodInfosItem.GetParameters();
                //    Console.WriteLine("---Add method Parameters----");


                //    foreach (var par in pinfo)
                //    {
                //        Console.WriteLine(par.Name);
                //        Console.WriteLine(par.Position);
                //        Console.WriteLine(par.ParameterType);


                //    }



                //}


                Type t = asm.GetType(item.FullName);
                object obj = Activator.CreateInstance(t);

                //item.InvokeMember("AcceptData", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null
                //    , obj, null);

                //item.InvokeMember("DisplayData", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null
                //    , obj, null);

                //if(item.Name == "Employee")
                //{
                //    item.InvokeMember("AcceptEmp", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null
                //    , obj, new Object[2] { 101, "Nilo" });

                //    item.InvokeMember("DisplayEmp", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null
                //        , obj, null);
                //    break;
                //}

                if(item.Name == "Calculator")
                {
                    item.InvokeMember("Cube", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null
                    , obj, new Object[1] {154});

                    item.InvokeMember("Sqrt", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null
                    , obj, new Object[1] { 25864 });

                    break;


                }

                
               
            }
            Console.ReadLine();
        }
    }
}
