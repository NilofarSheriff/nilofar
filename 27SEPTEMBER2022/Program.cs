using HELPER_IMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL_IMS;
using Microsoft.VisualBasic;

namespace _27SeptemberDisconnected_Network
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Institue Management System");
            Console.WriteLine("--------------------------------");
            HELPER_IMSS helper = new HELPER_IMSS(); 
            Console.WriteLine("Menu");
            Console.WriteLine("-----");
            Console.WriteLine("1. Add \n 2. Update \n 3. Find \n 4. Show All \n 5.Delete \n  6. Course count \n 7. Exit ");
            int userchoice = Convert.ToInt32(Console.ReadLine());
            

            switch (userchoice)
            {
                case 1:

                    BLL_Course COURSE = new BLL_Course();
                    Console.WriteLine("Enter Course Id");
                    COURSE.CourseID= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Course Name");
                    COURSE.COURSENAME= Console.ReadLine();
                    Console.WriteLine("Enter DEPTID");
                    COURSE.DEPTID= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ENTER DURATION");
                    COURSE.DURATION= Convert.ToInt32(Console.ReadLine());

                    bool queryStatus = helper.AddNew(COURSE);
                    if (queryStatus)
                    {
                        Console.WriteLine("Course added successfully.....");
                    }
                    else
                    {
                        Console.WriteLine("Some error occured...");
                    }
                    break;
                case 2:
                    COURSE = new BLL_Course();
                    Console.WriteLine("Enter Course Id");
                    COURSE.CourseID = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Course Name");
                    COURSE.COURSENAME = Console.ReadLine();
                    Console.WriteLine("Enter DEPTID");
                    COURSE.DEPTID = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ENTER DURATION");
                    COURSE.DURATION = Convert.ToInt32(Console.ReadLine());
                    

                    queryStatus = helper.Edit(COURSE);
                    if (queryStatus)
                    {
                        Console.WriteLine("Employee updated successfully.....");
                    }
                    else
                    {
                        Console.WriteLine("Some error occured...");
                    }

                    break;
                case 3:
                    COURSE = new BLL_Course();
                    Console.WriteLine("enter Course id");
                    COURSE.CourseID = Convert.ToInt32(Console.ReadLine());
                    BLL_Course data = helper.Locate(COURSE);
                    if (data != null)
                    {
                        Console.WriteLine("Following are the details");
                        Console.WriteLine(data.CourseID);
                        Console.WriteLine(data.COURSENAME);
                        Console.WriteLine(data.DEPTID);
                        Console.WriteLine(data.DURATION);
                        
                    }
                    else
                    {
                        Console.WriteLine("Invalid COURSE id");
                    }
                    break;
                case 4:
                    List<BLL_Course> courselist = new List<BLL_Course>();
                    courselist = helper.EmployeeList();
                   
                    foreach (var item in courselist)
                    {
                        Console.WriteLine(item.CourseID);
                        Console.WriteLine(item.COURSENAME);
                        Console.WriteLine(item.DEPTID);
                        Console.WriteLine(item.DURATION);
                        Console.WriteLine();
                    }break;
                case 5:
                    COURSE = new BLL_Course();
                    Console.WriteLine("enter Course id");
                    COURSE.CourseID = Convert.ToInt32(Console.ReadLine());

                    queryStatus = helper.Remove(COURSE);
                    if (queryStatus)
                    {
                        Console.WriteLine("Course Deleted successfully.....");
                    }
                    else
                    {
                        Console.WriteLine("Some error occured...");
                    }
                    break;
                default:
                    break;
            }
            Console.ReadLine();



        }
    
    }
}
