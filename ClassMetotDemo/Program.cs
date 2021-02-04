using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Ömer Faruk";
            customer1.LastName = "Bozlak";
            customer1.Company = "Öğrenci";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Delete(customer1);
            customerManager.Update(customer1);


        }
    }
}
