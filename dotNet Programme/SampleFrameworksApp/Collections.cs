using SampleFrameworksApp.Practical;
using System;
using System.Collections;
namespace DataLayer
{
    interface IDataComponent
    {
        void AddNewCustomer(Customer cst);
        void UpdateCustomer(Customer cst);
        Array GetAllCustomers();
        void DeleteCustomer(int id);
    }

    class CustomerDatabase : IDataComponent
    {
        private ArrayList _listOfCustomers = new ArrayList();//UR Array is replaced by ArrayList. 
        public void AddNewCustomer(Customer cst)
        {
            _listOfCustomers.Add(cst);
            //throw new NotImplementedException();
        }

        public void DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public Array GetAllCustomers()
        {

            return _listOfCustomers.ToArray();
        }

        public void UpdateCustomer(Customer cst)
        {
            foreach (var item in cst)
            {
                if(cst is Customer)
                {
                    var unBoxed = cst as Customer;
                    if(unBoxed.CustomerId == cst.CustomerId)
                    {
                        unBoxed.CustomerId = cst.CustomerId;
                        unBoxed.CustomerName = cst.CustomerName;
                        unBoxed.CustomerAddress = cst.CustomerAddress;
                        return;
                    }
                }

            }
            throw new NotImplementedException();
        }
    }


}