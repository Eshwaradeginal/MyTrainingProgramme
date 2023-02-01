using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsCSharp
{
    class Account
    {
        public int AccountId { get; set; }
        public string Name { get; set; }
        public double Balance { get; private set; } = 5000;

        public void Credit(int amount) => Balance += amount;

        public void Debit(int amount)
        {
            if (amount > Balance)
                throw new Exception("Insufficient Funds");
            Balance -= amount;
        }
    }
    class Employee
    {
        int id;
        string name, address;
        double salary;

        public int EmpID
        {
            get { return id; }
            set { id = value; }
        }

        public string EmpName
        {
            get => name;
            set => name = value;
        }

        public string EmpAddress
        {
            get => address;
            set => address = value;
        }

        public double EmpSalary
        {
            get => salary;
            set => salary = value;
        }


    }
    class Ex07ClassesDemo
    {
        static void Main(string[] args)
        {
            Employee empObj = new Employee { EmpAddress = "Bangalore", EmpID = 111, EmpName = "Eshwara", EmpSalary =80000 };
            Console.WriteLine("The name is " + empObj.EmpName);

            Account acc = new Account { AccountId = 111, Name = "Phaniraj" };
            Console.WriteLine("The Balance: " + acc.Balance);
            acc.Credit(10000);
            Console.WriteLine("The Balance: " + acc.Balance);
            try
            {
                acc.Debit(50000);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
