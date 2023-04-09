using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_13_OOPImplimentation
{
    enum Designation
    {
        Faculty=1,ManagingDirector,Accountant,Peion
    }
    
    internal sealed class Employee:Person,IRole
    {
        public int Id { get;set; }
        public DateTime JOiningDate { get;set; }
        public Designation Designation { get; set; }
        public List<string> Roles=new List<string>();

        public void AddRole(string item)
        {
            Roles.Add(item);
        }

        public string RolePlays()
        {
            return String.Join(",", Roles);
        }
    }
   
}
