using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFrameworksApp.Practical
{
    class MainUI
    {
        static IDataComponent component = new CustomerDatabase();
        static void Main(string[] args)
        {
            component.AddNewCustomer(new Customer { CustomerId = 111, CustomerName = "Ramesh Adiga", CustomerAddress ="Kundapur", BillAmount = 5600 });
            //component.AddNewCustomer(new Customer { CustomerId = 111, CustomerName = "Ramesh Adiga", CustomerAddress = "Kundapur", BillAmount = 5600 });
            //component.AddNewCustomer(new Customer { CustomerId = 111, CustomerName = "Ramesh Adiga", CustomerAddress = "Kundapur", BillAmount = 5600 });
            //component.DeleteCustomer(111);

            var data = component.GetAllCustomers();
            foreach (var customer in data)
            {

                Console.WriteLine(customer);
            }
        }

    }
}
