using System;
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

    class AccountManager
    {
        private Account[] _accounts = null;
        private int _size = 0;
        public AccountManager(int size)
        {
            _size = size;
            _accounts = new Account[_size];
        }

        public void AddNewAccount(Account acc)
        {
            for (int i = 0; i < _size; i++)
            {
                if (_accounts[i] == null)
                {
                    _accounts[i] = new Account { AccountId = acc.AccountId, Name = acc.Name };
                    _accounts[i].Credit((int)acc.Balance);
                    return;
                }
            }
        }

        public void UpdateAccountDetails(Account acc)
        {
            for (int i = 0; i < _size; i++)
            {
                if (_accounts[i] != null && _accounts[i].AccountId == acc.AccountId)
                {
                    _accounts[i].Name = acc.Name;
                    return;
                }
            }
            throw new Exception("Account not found to update");
        }

        public void DeleteAccount(int id)
        {
            for (int i = 0; i < _size; i++)
            {
                if (_accounts[i] != null && _accounts[i].AccountId == id)
                {
                    //.NET does not allow to delete an object. 
                    _accounts[i] = null; //
                    return;
                }
            }
            throw new Exception("No Account found to delete");

        }

        public Account FindAccount(int id)
        {
            foreach (Account acc in _accounts)
            {
                if (acc != null && acc.AccountId == id)
                    return acc;
            }
            throw new Exception("No Account found");
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
    class BankAccount
    {
        static void Main(string[] args)
        {
    
            int count = Utilities.GetNumber("Enter the Account Count U want to create");
            AccountManager mgr = new AccountManager(count);
            //AccountManager mgr = new AccountManager(count);
            try
            {
                mgr.FindAccount(123);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
