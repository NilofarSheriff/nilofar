using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace _8September
{
    
   
    public class Program:EventArgs
    {
        public static event EmployeeOperations AddEmployeeEvent;
        public static event EmployeeOperations EditEmployeeEvent;
        public static event EmployeeOperations UpdateEmployeeEvent;
        public static event EmployeeOperations DeleteEmployeeEvent;
        public static event EmployeeOperations DisplayEmployeeEvent;
        public static List<Employee> emplist = new List<Employee>();


        static void Main(string[] args)
        {
            AddEmployeeEvent += AddEmployeeEvent_EmployeeOperations;
            EditEmployeeEvent += EditEmployeeEvent_EmployeeOperations;
            UpdateEmployeeEvent += UpdateEmployeeEvent_EmployeeOperations;
            DeleteEmployeeEvent += DeleteEmployeeEvent_EmployeeOperations;
            DisplayEmployeeEvent += DisplayEmployeeEvent_EmployeeOperations;



            List<Employee> emplist = new List<Employee>();
            List<Employee> emplist1 = new List<Employee>();
            Employee emp = new Employee();
            emp.EmpId = 101;
            emp.EmpName = "Nilofar";
            emp.DeptNo = 1;
            emp.Salary = 1200000;
            emp.Manager = "Zamruth";
            Employee emp1 = new Employee();
            emp1.EmpId = 102;
            emp1.EmpName = "Mehar";
            emp1.DeptNo = 1;
            emp1.Salary = 1200000;
            emp.Manager = "Zamruth";
            emplist.Add(emp);
            emplist.Add(emp1);
            emplist1.Add(emp);
            emplist1.Add(emp1);
            LoginPage(emplist1);


            
            void LoginPage(List<Employee> emplistt)
            {
                Action<string,string> fun = (string Username,string Password) =>
                {

                    

                        Employee Fin = emplist1.Find(x => x.EmpName == Username);
                        if (Fin == null)
                        {
                            Console.WriteLine("Invalid Username");


                        }

                        else if ((Username == Fin.EmpName) && (Password == "password"))
                        {
                            Console.WriteLine("Logged in Successfully");
                            Console.WriteLine("Select the option to perform\n 1.ADD \n 2.EDIT \n 3.UPDATE \n 4.DELETE \n 5.DISPLAY EMPLOYEE DETAILS");
                            int userchoice = int.Parse(Console.ReadLine());



                            switch (userchoice)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("Before Adding");
                                        foreach (var item1 in emplist)
                                        {
                                            Console.WriteLine("Employee ID : " + item1.EmpId);
                                            Console.WriteLine("Employee Name : " + item1.EmpName);
                                            Console.WriteLine("Employee Dept No : " + item1.DeptNo);
                                            Console.WriteLine("Employee Salary : " + item1.Salary);
                                            Console.WriteLine("Employee Reporting Manager : " + item1.Manager);
                                            Console.WriteLine("********************************************");
                                        }
                                        AddEmployeeEvent(emplist);
                                        Console.WriteLine("Added Sucessfully");
                                        Console.WriteLine();
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("After Adding");
                                        Dept dept1 = new Dept();
                                        EmployeeOperations del = new EmployeeOperations(dept1.displaydetails);
                                        del(emplist);
                                        break;

                                    }
                                case 2:
                                    {
                                        Console.WriteLine("Before Editing");
                                        foreach (var item1 in emplist)
                                        {
                                            Console.WriteLine("Employee ID : " + item1.EmpId);
                                            Console.WriteLine("Employee Name : " + item1.EmpName);
                                            Console.WriteLine("Employee Dept No : " + item1.DeptNo);
                                            Console.WriteLine("Employee Salary : " + item1.Salary);
                                            Console.WriteLine("Employee Reporting Manager : " + item1.Manager);
                                            Console.WriteLine("********************************************");
                                        }
                                        Console.WriteLine();
                                        EditEmployeeEvent(emplist);
                                        Console.WriteLine("Edited Sucessfully");
                                        Console.WriteLine();
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("After Editing");
                                        Dept dept1 = new Dept();
                                        EmployeeOperations del = new EmployeeOperations(dept1.displaydetails);
                                        del(emplist);
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.WriteLine("Before Updating");
                                        foreach (var item1 in emplist)
                                        {
                                            Console.WriteLine("Employee ID : " + item1.EmpId);
                                            Console.WriteLine("Employee Name : " + item1.EmpName);
                                            Console.WriteLine("Employee Dept No : " + item1.DeptNo);
                                            Console.WriteLine("Employee Salary : " + item1.Salary);
                                            Console.WriteLine("Employee Reporting Manager : " + item1.Manager);
                                            Console.WriteLine("********************************************");
                                        }
                                        Console.WriteLine();
                                        UpdateEmployeeEvent(emplist);
                                        Console.WriteLine("Updated Sucessfully");
                                        Console.WriteLine();
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("After Updating");
                                        Dept dept1 = new Dept();
                                        EmployeeOperations del = new EmployeeOperations(dept1.displaydetails);
                                        del(emplist);
                                        break;
                                    }
                                case 4:
                                    {
                                        Console.WriteLine("Before Deleting");
                                        foreach (var item1 in emplist)
                                        {
                                            Console.WriteLine("Employee ID : " + item1.EmpId);
                                            Console.WriteLine("Employee Name : " + item1.EmpName);
                                            Console.WriteLine("Employee Dept No : " + item1.DeptNo);
                                            Console.WriteLine("Employee Salary : " + item1.Salary);
                                            Console.WriteLine("Employee Reporting Manager : " + item1.Manager);
                                            Console.WriteLine("********************************************");
                                        }
                                        DeleteEmployeeEvent(emplist);
                                        Console.WriteLine("Deleted Sucessfully");
                                        Console.WriteLine();
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("After Deleting");
                                        Dept dept1 = new Dept();
                                        EmployeeOperations del = new EmployeeOperations(dept1.displaydetails);
                                        del(emplist);
                                        break;
                                    }
                            case 5:
                                {
                                    DisplayEmployeeEvent(emplist);
                                    break;
                                }

                                default:
                                    Environment.Exit(1);
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("password is wrong");
                        }


                    


                };
                fun("Mehar", "password");


            }






            
            Console.ReadLine();

        }

        private void AddEmployee(List<Employee> emplist)
        {
            Employee employee = new Employee();
            Console.WriteLine("Write the Employee ID to Add");
            employee.EmpId = int.Parse(Console.ReadLine());
            Console.WriteLine("Write the Employee Name to Add");
            employee.EmpName = Console.ReadLine();
            Console.WriteLine("Write the Dept No to Add");
            employee.DeptNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Write the Employee Salary to Add");
            employee.Salary = int.Parse(Console.ReadLine());
            Console.WriteLine("Write the reporting Manager to Add");
            employee.Manager = Console.ReadLine();
            emplist.Add(employee);

        }

        private void EditEmployee(List<Employee> emplist)
        {

            Console.WriteLine("Enter the Emp Id to delete the employee details");
            int emi = int.Parse(Console.ReadLine());
            Employee found = emplist.Find(x => x.EmpId == emi);
            Console.WriteLine("Write the Employee ID to edit");
            found.EmpId = int.Parse(Console.ReadLine());
            Console.WriteLine("Write the Employee Name to edit");
            found.EmpName = Console.ReadLine();
            Console.WriteLine("Write the Dept No to edit");
            found.DeptNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Write the Employee Salary to edit");
            found.Salary = int.Parse(Console.ReadLine());
            Console.WriteLine("Write the reporting Manager to edit");
            found.Manager = Console.ReadLine();


            Console.WriteLine("Employee Details Updated Successfully");


        }

        private void UpdateEmployee(List<Employee> emplist)
        {
            Employee found = new Employee();
            Console.WriteLine("Write the Employee ID to update");
            found.EmpId = int.Parse(Console.ReadLine());
            Console.WriteLine("Write the Employee Name to update");
            found.EmpName = Console.ReadLine();
            Console.WriteLine("Write the Dept No to update");
            found.DeptNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Write the Employee Salary to update");
            found.Salary = int.Parse(Console.ReadLine());
            Console.WriteLine("Write the reporting Manager to update");
            found.Manager = Console.ReadLine();
            emplist.Add(found);

        }

        private void DeleteEmployee(List<Employee> emplist)
        {
            Console.WriteLine("Enter the Emp Id to delete the employee details");
            int emi = int.Parse(Console.ReadLine());
            Employee found = emplist.Find(x => x.EmpId == emi);
            emplist.Remove(found);

        }
        private static void EditEmployeeEvent_EmployeeOperations(List<Employee> emplist)
        {
            
            Program p1 = new Program();
            EmployeeOperations del = new EmployeeOperations(p1.EditEmployee);
            del(emplist);
        }
       private static void UpdateEmployeeEvent_EmployeeOperations(List<Employee> emplist)
        {
            Program p1 = new Program();
            EmployeeOperations del = new EmployeeOperations(p1.UpdateEmployee);
            del(emplist);
        }
       private static void DeleteEmployeeEvent_EmployeeOperations(List<Employee> emplist)
        {
            Program p1 = new Program();
            EmployeeOperations del = new EmployeeOperations(p1.DeleteEmployee);
            del(emplist);

        }
       private static void AddEmployeeEvent_EmployeeOperations(List<Employee> emplist)
        {
            Program p1 = new Program();
            EmployeeOperations del = new EmployeeOperations(p1.AddEmployee);
            del(emplist);

        }

        private static void DisplayEmployeeEvent_EmployeeOperations(List<Employee> emplist)
        {
           
            Dept dep = new Dept();
            EmployeeOperations del = new EmployeeOperations(dep.displaydetails);
            del(emplist);

        }


    }
}
