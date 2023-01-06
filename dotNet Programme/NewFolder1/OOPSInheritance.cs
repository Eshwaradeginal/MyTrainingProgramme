using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsCSharp.NewFolder1
{
    class Account
    {
        public int AccountNo { get; set; }
        public string AccountName { get; set; }
        public int Balance { get; protected set; } = 5000;
    }

    class SBAccount : Account
    {
        public void Credit(int amount) => Balance += amount;

        public void Debit(int amount) => Balance -= amount;

    }

    class RDAccount : Account
    {
        int amount = 9000;
        public void MakePayment()
        {
            Console.WriteLine($"Payment of Rs. {amount} is done");
            Balance += amount;
        }
    }


    class OOPSInheritance
    {
        static void Main(string[] args)
        {
            SBAccount acc = new SBAccount { AccountName = "testName", AccountNo = 123 };
            acc.Credit(60000);
            Console.WriteLine("The Balance : " + acc.Balance);
            acc.Debit(5000);

            Console.WriteLine("The Balance : " + acc.Balance);

         
        }
    }
}
