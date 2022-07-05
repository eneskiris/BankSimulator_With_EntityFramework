using Business.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    internal class Program
    {

        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            //customerManager.Add(new Customer
            //{
            //    CustomerName = "Enes",
            //    CustomerSurname = "Demiroğ",
            //    NationalityId = "12344612334",
            //    Password = "33351212",
            //    Age = 32,
            //    Money = 120000
            //});


            foreach (var customer in customerManager.GetAll())
            {
                Console.WriteLine(customer.CustomerName.PadRight(10)+" ---- ".PadRight(7)+customer.Money+" TL");
            }


        }
    }
}
