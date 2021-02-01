using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Customer
{
    class CustomerManager
    {
        ArrayList customerList = new ArrayList(); 
        public void Add (Customer customer)
        {
            customerList.Add(customer);
            Console.WriteLine(customer.Name + " " +customer.Surname + "müşterisi listeye eklendi.");
        }

        public void List()
        {
            foreach (Customer customer in customerList)
            {
                Console.WriteLine(customer.Name + " " + customer.Surname);

            }
        }

        public void Delete(Customer customer)
        {
            customerList.Remove(customer);
            Console.WriteLine(customer.Name + " " + customer.Surname + "müşterisi listeden çıkarıldı.");
        }
    }
}
