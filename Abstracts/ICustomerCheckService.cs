using CoffeeProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeProject.Abstracts
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
