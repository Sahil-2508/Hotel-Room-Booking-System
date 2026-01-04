using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Room_Booking_System
{
    public  class Customer
    {
        public int CustId {  get; set; }
        public string  CustomerName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }


        public static void AddCustomer()
        {
           Customer customer = new Customer();

            Console.WriteLine("Enter CustId");
            customer.CustId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter CustomerName");
            customer.CustomerName = Console.ReadLine();

            Console.WriteLine("Enter EmailAddress");
            customer.EmailAddress = Console.ReadLine();

            Console.WriteLine("Enter Number");
            customer.PhoneNumber = Console.ReadLine();

            Service.customers.Add(customer);    

            DisplayAllCustomer();
        }
        public static void DeleteCust(int CustId)
        {
            Customer customer = new Customer();

            Console.WriteLine("Enter CustId");
            customer.CustId = Convert.ToInt32(Console.ReadLine());
        }

        public static void DisplayCustomer(Customer customer)
        {
            Console.WriteLine($"CustId:{customer.CustId},CustomerName:{customer.CustomerName},EmailAddress:{customer.EmailAddress},PhoneNumber:{customer.PhoneNumber}");  
        }
        public static void DisplayAllCustomer()
        {
            foreach(var Customer1 in Service.customers)
            {
                Console.WriteLine($"CustId:{Customer1.CustId},CustomerName:{Customer1.CustomerName},EmailAddress:{Customer1.EmailAddress},PhoneNumber:{Customer1.PhoneNumber}");

            }
        }

    }

}
