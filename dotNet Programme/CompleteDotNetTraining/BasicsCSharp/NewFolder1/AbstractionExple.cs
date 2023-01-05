using BasicsCSharp;
using System;


namespace BasicsCSharp
{

    abstract class Account1
    {
        public int AccNo { get; set; }
        public string Name { get; set; }
        public int Balance { get; private set; } = 5000;
        public void Credit(int amount) => Balance += amount;
        public void Debit(int amount)
        {
            if (amount > Balance)
                throw new Exception("Insufficient Funds");
            Balance -= amount;
        }

        public abstract void CalculateInterest();
    }

    class SBAccount : Account1
    {
        //override is used to implement the abstract method. 
        public override void CalculateInterest()
        {
            var pricipal = Balance;
            var time = 0.25;
            var rate = 0.05;
           
            var interest = pricipal * time * rate;
            Credit((int)interest);
        }
    }
    class RDAccount : Account1
    {
        public override void CalculateInterest()
        {
            var pricipal = Balance;
            var time = 0.25;
            var rate = 0.05;
            var tenure = 3;
            var interest = pricipal * ((1+rate)/tenure);
            Credit((int)interest);
        }
    }
    class FDAccount : Account1
    {
        //override is used to implement the abstract method. 
        public override void CalculateInterest()
        {
            var pricipal = Balance;
            var time = 0.25;
            var rate = 0.05;
            var tenure = 3;
            var interest = pricipal * rate* tenure;
            Credit((int)interest);
        }
    }

     enum typeOfAccounts { SB=1,RD=2,FD =3 };
    class AccountFactory
    {
        public static Account1 CreateAccount(typeOfAccounts acc)
        {
            switch (acc)
            {
                case typeOfAccounts.SB:
                    return new SBAccount();
                case typeOfAccounts.RD:
                    return new RDAccount();
                case typeOfAccounts.FD:
                    return new FDAccount();
            }
            throw new Exception("Not a valid account type");
        }
    }
}



    class AbstractClasses
    {
        static void Main(string[] args)
        {
            string inp = Console.ReadLine();
            var type = (typeOfAccounts)Enum.Parse(typeof(typeOfAccounts), inp);
            Account1 acc = AccountFactory.CreateAccount(type);//Create this class 
            acc.AccNo = 123;
            acc.Name = "Eshwar";
            acc.Credit(30000);
            acc.CalculateInterest();
            Console.WriteLine("The current balance is " + acc.Balance);
        }
    }

