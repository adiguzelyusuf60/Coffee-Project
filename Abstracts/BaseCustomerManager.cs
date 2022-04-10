using CoffeeProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeProject.Abstracts
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to database : " + customer.FirstName);
        }
    }
}
