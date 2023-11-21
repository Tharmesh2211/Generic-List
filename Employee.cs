using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public long PhoneNumber { get; set; }
        public string DOB { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }

        public Employee()
        {

        }
        public Employee(int id, string name, int age, string gender, long phoneNumber, string dOB, double salary, string address)
        {
            Id = id;
            Name = name;
            Age = age;
            Gender = gender;
            PhoneNumber = phoneNumber;
            DOB = dOB;
            Salary = salary;
            Address = address;
        }
    }
}
