using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Buket Karaçaylı
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1234;
            customer1.CustomerNumber = "5555";
            customer1.TC = "11122233344";
            customer1.Name = "Buket";
            customer1.Surname = "Karaçaylı";

            //İş Bankası
            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 4567;
            customer2.CustomerNumber = "6666";
            customer2.CompanyName = "İş Bankası";
            customer2.TaxNumber = "44556699";


            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

        }
    }
}
