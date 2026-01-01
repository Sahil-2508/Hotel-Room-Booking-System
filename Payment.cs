using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Room_Booking_System
{
    public  class Payment
    {
        public int PaymentId { get; set; }
        public int BookingId { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMode { get; set; }
        public DateTime PaymentDate { get; set; }
        public bool IsPaymentSuccessful { get; set; }

       
        public static void CashPayment()
        {
            Payment payment = new Payment();

            
            Console.WriteLine("Enter Payment Id");
            payment.PaymentId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Booking Id");
            payment.BookingId= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Amount");
            payment.Amount= Convert.ToDecimal(Console.ReadLine());

            payment.IsPaymentSuccessful = true;

            Service.payments1.Add(payment);
            DisplayPayment();

        }

        public static void DisplayPayment()
        {
            foreach (var payment in Service.payments1)
            {
                Console.WriteLine(
                    $"PaymentId: {payment.PaymentId}, BookingId: {payment.BookingId}, Amount: {payment.Amount} ,PaymentMode: {payment.PaymentMode},PaymentDate:{payment.PaymentDate},IsPaymentSuccessful:{payment.IsPaymentSuccessful}"
                );
            }

        }


    }
}
