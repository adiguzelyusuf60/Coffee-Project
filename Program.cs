using CoffeeProject.Abstracts;
using CoffeeProject.Concretes;
using CoffeeProject.Entities;
using CoffeeProject.Adapters;
using System;

namespace CoffeeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
            //Altta verilen bilgi kısımlarını doğru bilgilerini yazarsanız save işlemi sorunsuz çalışacaktır.
            customerManager.Save(new Customer { DateOfBirth = new DateTime(2000,3,4), FirstName = "Yusuf", LastName = "Adıgüzel", NationallyId = "12345678910"} );

            
        }
    }
}