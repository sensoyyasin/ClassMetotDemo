using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to banking");
            Console.WriteLine("**");
            Console.WriteLine("**");
            Console.WriteLine("**");
            Console.WriteLine("**");

            Customer customer1 = new Customer();
            customer1.Id = "Apexs";
            customer1.Name = "Yasin";
            customer1.Surname = "Sensoy";
            customer1.Age = "19";

            Customer customer2 = new Customer();
            customer2.Id = "xax";
            customer2.Name = "yay";
            customer2.Surname =  "zaz";
            customer2.Age = "91";



            List<Customer> customers = new List<Customer>();
            customers.Add(customer1);
            customers.Add(customer2);

            Console.WriteLine("customers.Count");
            CustomerManager customerManager = new CustomerManager();
            Console.WriteLine(customers.Count);

            foreach(var customer in customers)
            {
                Console.WriteLine(customer.Id + " * " + customer.Name + " * " + customer.Surname + " * " + customer.Age);
            }

            customerManager.AddCustomer(customers);
            customerManager.ListCustomer(customers);
            Console.WriteLine(customers.Count);
            foreach(var customer in customers)
            {
                Console.WriteLine(customer.Id + " * " + customer.Name + " * " + customer.Surname + " * " + customer.Age);

            }
        }
    }
}
