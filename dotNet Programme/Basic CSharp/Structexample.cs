using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsCSharp
{
    struct Employee
    {
        public int EmpId{ get; set; }
        public String EmpName { get; set; }
        public Double EmpSalary { get; set; }
    }
    public String GetDetails()
    {
        return $"name is{EmpName}  with salary is {EmpSalary}";


    }
    class Structexample
    {
        static void Main(string[] args)
      
        {
            Employee ep = new Employee { EmpId = 111, EmpName = "Eshwar", EmpSalary = 50000 };
           Console.WriteLine(ep.GetDetails());       
        }   
    }
}
