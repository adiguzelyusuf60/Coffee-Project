using CoffeeProject.Abstracts;
using System;

namespace CoffeeProject.Entities
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationallyId { get; set; }
    }
}