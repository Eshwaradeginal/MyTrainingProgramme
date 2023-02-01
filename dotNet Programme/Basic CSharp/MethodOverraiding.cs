using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsCSharp.NewFolder1
{
    class Business
    {
        public virtual void MakePayment(string payMode, double amount)
        {
            if (payMode == "CreditCard")
            {
                Console.WriteLine("Payment not accepted");
            }
            else
                Console.WriteLine("Payment accepted by {1} for Rs.{0}", amount, payMode);
        }
    }

    class TechBusiness : Business
    {
        public override void MakePayment(string payMode, double amount)
        {
            if (payMode == "Cheque")
            {
                Console.WriteLine("Payment is no longer accepted");
            }
            else
                Console.WriteLine("Payment accepted by {1} for Rs.{0}", amount, payMode);
        }
    }

    class BusinessFactory
    {
        public static Business GetObject(string arg)
        {
            if (arg.ToUpper() == "BUSINESS")
                return new Business();
            else if (arg.ToUpper() == "TECHBUSINESS")
                return new TechBusiness();
            else
                throw new Exception("This type of Business is not availabe with Us!!!");

        }
    }

    class MethodOverraiding
    {
        static void Main(string[] args)
        {
            string busstype = Utilities.Prompt("enter type of business");
            Business comp = BusinessFactory.GetObject(busstype);
            comp.MakePayment("creditcard",  10000);

        }
    }
}
