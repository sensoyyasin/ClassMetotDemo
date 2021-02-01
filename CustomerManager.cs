using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        Customer NewCustomer = new Customer();
        public void AddCustomer(List<Customer> customers)
        {
            Console.WriteLine("Please enter your Id ");
            NewCustomer.Id = Console.ReadLine();

            Console.WriteLine("Please enter your name ");
            NewCustomer.Name = Console.ReadLine();

            Console.WriteLine("Please enter your surname ");
            NewCustomer.Surname = Console.ReadLine();

            Console.WriteLine("Please enter your age ");
            NewCustomer.Age = Console.ReadLine();
            customers.Add(NewCustomer);

        }

        public void ListCustomer(List<Customer> customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("Customers are listed ");
                Console.WriteLine("Customers Id " + customer.Id);
                Console.WriteLine("Customers Name " + customer.Name);
                Console.WriteLine("Customers Surname " + customer.Surname);
                Console.WriteLine("Customers Age " + customer.Age);
                Console.WriteLine("*********");
            }
        }

        public void RemoveCustomer(Customer customer)
        {
            Console.WriteLine("Customers removed " + customer.Id + " / " + customer.Name);
        }
    }
}
