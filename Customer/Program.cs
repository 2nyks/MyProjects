using System;

namespace Customer
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Monica";
            customer1.Surname = "Geller";
            customer1.Age = 27;

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Chandler";
            customer2.Surname = "Bing";
            customer2.Age = 30;

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

            customerManager.List();
            customerManager.Delete(customer1);
            customerManager.List(); 
        }
    }
}
