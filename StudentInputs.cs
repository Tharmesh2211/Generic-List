using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class StudentInputs 
    {
        List<Student> students = new List<Student>();
        Student student = null;
        public StudentInputs() 
        {
            Console.Write("Enter Number Student Detail to Add  -  ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Clear();
                student = new Student();

                Console.WriteLine("Append Student Detail  "+i);

                Console.Write("Enter Student ID           :  ");
                student.Id = int.Parse(Console.ReadLine());

                Console.Write("Enter Student Name         :  ");
                student.Name = Console.ReadLine();

                Console.Write("Enter Student Age          :  ");
                student.Age = int.Parse(Console.ReadLine());

                Console.Write("Enter Student DOB          :  ");
                student.Dob = Console.ReadLine();

                Console.Write("Enter Student PhoneNumber  :  ");
                student.PhoneNumber = long.Parse(Console.ReadLine());

                Console.Write("Enter Student Gender       :  ");
                student.Gender = Console.ReadLine();

                Console.Write("Enter Student Address      :  ");
                student.Address = Console.ReadLine();

                Console.Write("Enter Student City         :  ");
                student.City = Console.ReadLine();

                Console.Write("Enter Student Total Mark   :  ");
                student.TotalMark = double.Parse(Console.ReadLine());

                Calculate(student.TotalMark);
                AddStudentObject(student);
            }
        }

        public void AddStudentObject(Student student)
        {
            if(student == null)
            {
                student = new Student();
            }
            students.Add(student);
        }

        public void Calculate(double TotalMark)
        {
            if (TotalMark < 175)
                student.Grade = 'E';
            else if (TotalMark < 250)
                student.Grade = 'D';
            else if (TotalMark < 350)
                student.Grade = 'C';
            else if (TotalMark < 450)
                student.Grade = 'B';
            else
                student.Grade = 'A';
        }
        public void DisplayDetail()
        {
            for(int j = 0; j < students.Count; j++)
            {
                Console.Clear();
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("       STUDENT DETAIL {0}  " , (j+1));
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("Enter Student ID          :  " + students[j].Id);
                Console.WriteLine("Enter Student Name        :  " + students[j].Name);
                Console.WriteLine("Enter Student Age         :  " + students[j].Age);
                Console.WriteLine("Enter Student DOB         :  " + students[j].Dob);
                Console.WriteLine("Enter Student PhoneNumber :  " + students[j].PhoneNumber);
                Console.WriteLine("Enter Student Gender      :  " + students[j].Gender);
                Console.WriteLine("Enter Student Address     :  " + students[j].Address);
                Console.WriteLine("Enter Student City        :  " + students[j].City);
                Console.WriteLine("Enter Student Total Mark  :  " + students[j].TotalMark);
                Console.WriteLine("Enter Student Grade       :  " + students[j].Grade);
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.ReadKey();
            }
            
        }
    }
}
