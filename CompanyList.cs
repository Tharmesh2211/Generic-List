






                                              //Incomplete




//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace List
//{
//    public class CompanyList
//    {
//        List<Company> list = new List<Company>();
//        Company company = null;

//        public CompanyList()
//        {
//            Console.Write("Enter Number Of Company To Add   -  ");
//            int n = int.Parse(Console.ReadLine());

//            for(int i = 0; i < n; i++)
//            {
//                company = new Company();
//                Console.Write("Enter Company ID          :  ");
//                company.Id = int.Parse(Console.ReadLine());

//                Console.Write("Enter Company Name        :  ");
//                company.Company_Name = Console.ReadLine();

//                Console.Write("Enter Company WorkPlace   :  ");
//                company.WorkPlace = Console.ReadLine();

//                AddCompany(company);
                
//            }
            
//        }

//        public void AddCompany(Company company)
//        {
//            list.Add(company);
//        }
//    }
//}
