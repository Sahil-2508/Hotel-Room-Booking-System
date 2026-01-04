using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization.Metadata;

namespace Hotel_Room_Booking_System
{ 
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Welcome To Hotel Mangement System------");
            Console.WriteLine("****------plz select Options---------****");
            Console.WriteLine(" 1.Booking \n 2.DisplayAllBooking \n 3.Customer \n 4.Payment \n 5.Bill");
            
            int choice1 = Convert.ToInt32(Console.ReadLine());

            switch (choice1)
            {
                case 1:
                    Console.WriteLine("Booking selected ");
                    Booking.BookingCust();
                    break;
                    case 2:
                    Booking.DisplayAllBooking();
                    break;
                case 3:
                    Console.WriteLine("Customer selected");
                    Customer.AddCustomer();
                    break;
                case 4:
                    Console.WriteLine("Payment selected");
                    Payment.DisplayPayment();
                    break;

                case 5:
                    Console.WriteLine("Bill is Selected");
                    Bill.Bills();
                    break;
            }
            //Console.WriteLine("\n");
            Console.WriteLine("********** Please select Rooms ***********\n");
            Console.WriteLine(" 1.StandardRoom \n 2.DelaxRoom \n 3.SuperDelax");
            int meanu = Convert.ToInt32(Console.ReadLine());
            Booking booking = new Booking();
            switch (meanu)
            {
                case 1:
                    Console.WriteLine("----Standard Room Selected-----");
                    Room.StandardRoom();
                break;
                case 2:
                    Console.WriteLine("-----Delax Room Selected-----");
                    Room.DelaxRoom();
                break;
                case 3:
                    Console.WriteLine("------Super DelaxRoom Selected-----");
                    Room.SuperDelaxRoom();
                    break;
                case 4:
                    Room.DisplayAllrooms();
                break;

            }

            Console.WriteLine("******* Plz select Optons *******\n");
            Console.WriteLine("1.AddCustomer \n 2.DeleteCust \n 3.DisplayAllCustomer");
            int Cust = Convert.ToInt32(Console.ReadLine());
            Customer customer = new Customer();
            switch (Cust)
            {
                case 1:
                    Customer.AddCustomer();
                break;
                    case 2: 
                    Customer.DeleteCust(Cust);
                    break;
            }
            Console.WriteLine("******** Plz Select Options *********");
            Console.WriteLine("1.CashPayment \n 2.OnlinePaymnent \n 3.MobileBanking");
            Payment payment = new Payment();
            int Paymentchoice = Convert.ToInt32(Console.ReadLine());
            switch (Paymentchoice)
            {
                case 1:
                    Payment.CashPayment();
                    break;
                case 2:
                    Payment.OnlinePayment();
                    break;
                case 3:
                    Payment.DisplayPayment();
                    break;
            }
           
            for (; ; )
            {
                                            
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Room.DisplayAllrooms();
                        break;

                    case 1:
                        Payment.DisplayPayment();
                        break;
                    case 2:
                          Customer.AddCustomer();
                        break;
                    case 3:
                        Customer.DisplayAllCustomer();
                    break;
                    case 4:
                        Bill.Bills();
                   break;
                        case 6:
                        Bill.DisplayAllBills();
                        break;


                }
            }
           

        }
    }
}
