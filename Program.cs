using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================================");
            Console.WriteLine("             LIST                   ");
            Console.WriteLine("====================================");
            Console.WriteLine("   1. STUDENT LIST");
            Console.WriteLine("   2. EMPLOYEE LIST");
            //Console.WriteLine("   3. Company LIST");
            Console.WriteLine("====================================");

            Console.Write("Enter Your Option  -  ");
            int n = int.Parse(Console.ReadLine());
            switch(n)
            {
                case 1:
                    EmployeeInputs inputs = new EmployeeInputs();
                    inputs.AddEmploy();
                    inputs.Display();
                    break;
                case 2:
                    StudentInputs studentInputs = new StudentInputs();
                    studentInputs.DisplayDetail();
                    break;
                default: Console.WriteLine("Invalid Option");
                    break;
            }

        }
    }
    
   
}
