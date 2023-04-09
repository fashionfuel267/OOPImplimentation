using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_13_OOPImplimentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee= new Employee();  
            Console.WriteLine("Enter your ID");
            employee.Id =int.Parse( Console.ReadLine());
            Console.WriteLine("Enter name");
            employee.Name=Console.ReadLine();
            Console.WriteLine("Enter your Date of Birth");
            employee.DOB=DateTime.Parse( Console.ReadLine().Trim());
            Console.WriteLine("Enter your JoiningDate");
            employee.JOiningDate= DateTime.Parse( Console.ReadLine().Trim());
            Console.WriteLine("Enter Your Designation[ Faculty=1,ManagingDirector=2,Accountant=3,Peion=4]");
            employee.Designation=(Designation)int.Parse( Console.ReadLine());
            string role = "";
            while(role.ToLower() != "x")
            {
                Console.WriteLine("enter your role[x to stop]");
                role = Console.ReadLine();
                if (role.ToLower() != "x")
                    employee.AddRole(role);

            }
            Console.WriteLine("Id\t Name \t Designation \t Roles");
            Console.WriteLine("====================================");
                Console.WriteLine(employee.Id+"\t"+ employee.Name+"\t"+ employee.Designation+"\t"+ employee.RolePlays());
            Console.ReadKey();
        }
    }
}
