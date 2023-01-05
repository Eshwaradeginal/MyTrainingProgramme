using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsCSharp
{
    class Employee1
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpSalary { get; set; }

        public static Employee1 operator + (Employee1 emp, int amount)
        {
            emp.EmpSalary += amount;
            return emp;
        }
        public static Employee1 operator -(Employee1 emp, int amount)
        {
            emp.EmpSalary -= amount;
            return emp;
        }
        public static Employee1 operator *(Employee1 emp, int amount)
        {
            emp.EmpSalary *= amount;
            return emp;
        }
        public static Employee1 operator /(Employee1 emp, int amount)
        {
            emp.EmpSalary /= amount;
            return emp;
        }
        public static Employee1 operator % (Employee1 emp, int amount)
        {
        
            emp.EmpSalary %= amount;
            return emp;
        }
        public static bool  operator > (Employee1 emp, int amount)
        {

           return  emp.EmpSalary  > amount;
           
        }
        public static bool operator <(Employee1 emp, int amount)
        {

            return emp.EmpSalary < amount;

        }
        public static Employee1  operator &(Employee1 emp, int amount)
        {

            return emp.EmpSalary  &  amount;

        }
    }
    class OperatorOverloading
    {
        static void Main(string[] args)
        {
            Employee1 emp = new Employee1
            {
                EmpId = 111,
                EmpName = "eshwar",
                EmpSalary = 27000
            };

            emp += 3000;
            Console.WriteLine("The Current salary is " + emp.EmpSalary);
            emp -= 3000;
            Console.WriteLine("The Current salary is " + emp.EmpSalary);
            emp *= 30;
            Console.WriteLine("The Current salary is " + emp.EmpSalary);
            emp /= 10;
            Console.WriteLine("The Current salary is " + emp.EmpSalary);
            emp %= 3;
            Console.WriteLine("The Current salary is " + emp.EmpSalary);
            Console.WriteLine(emp > 2000); 
            Console.WriteLine(emp < 2000); 
            Console.WriteLine(emp & 2000); 

            
        }
    }

}
