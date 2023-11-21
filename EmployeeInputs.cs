using List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace List
{

    public class EmployeeInputs 
    {
        List<Employee> employees = new List<Employee>();
        //Employee employee = null;

        public  void AddEmploy()
        {
            try
            {
                Console.Write("Enter Number Employ Detail to Add  -  ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine("Enter Employ Detail {0} ", i);
                    Console.Write("\nEnter Employ ID           :  ");
                    int Id = int.Parse(Console.ReadLine());

                    Console.Write("Enter Employ Name         :  ");
                    string Name = Console.ReadLine();

                    Console.Write("Enter Employ Age          :  ");
                    int Age = int.Parse(Console.ReadLine());

                    Console.Write("Enter Employ Gender       :  ");
                    string Gender = Console.ReadLine();

                    Console.Write("Enter Employ PhoneNumber  :  ");
                    long PhoneNumber = long.Parse(Console.ReadLine());

                    Console.Write("Enter Employ DOB          :  ");
                    string DOB = Console.ReadLine();

                    Console.Write("Enter Employ Salary       :  ");
                    double Salary = double.Parse(Console.ReadLine());

                    Console.Write("Enter Employ Address      :  ");
                    string Address = Console.ReadLine();

                    //    employee = new Employee(Id, Name, Age, Gender, PhoneNumber, DOB, Salary, Address);

                    AddEmpObject(new Employee(Id, Name, Age, Gender, PhoneNumber, DOB, Salary, Address));
                    Console.Clear();
                }
            
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        public void AddEmpObject(Employee emp)
        {
            employees.Add(emp);
        }
        public void Display()
        {
            int x = 1;
            foreach (Employee employee in employees)
            {
                Console.WriteLine("===========================================================");
                Console.WriteLine("                EMPLOY DETAIL  {0}",x++);
                Console.WriteLine("===========================================================\n");
                Console.WriteLine("Employ ID           :  "+employee.Id);
                Console.WriteLine("Employ Name         :  "+employee.Name);
                Console.WriteLine("Employ Age          :  "+employee.Age);
                Console.WriteLine("Employ Gender       :  "+employee.Gender);
                Console.WriteLine("Employ PhoneNumber  :  "+employee.PhoneNumber);
                Console.WriteLine("Employ DOB          :  "+employee.DOB);
                Console.WriteLine("Employ Salary       :  "+employee.Salary);
                Console.WriteLine("Employ Address      :  "+employee.Address);
                Console.WriteLine("===========================================================\n");
                Console.ReadKey();
                Console.Clear();

            }
        }
    }
}
