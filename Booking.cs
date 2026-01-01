using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Room_Booking_System
{
    public class Booking
    {
        public int BookingId { get; set; }
        public string Customer { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public string BookingStatus { get; set; }


        public static void BookingCust()
        {
            Booking booking1 = new Booking();

            Console.WriteLine("Enter BookingId");
            booking1.BookingId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Customer");
            booking1.Customer = Console.ReadLine();

            Console.WriteLine("Enter CheckInData");
            booking1.CheckInDate = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Enter CheckOutData");
            booking1.CheckOutDate = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Enter BookingStatus");
            booking1.BookingStatus = Console.ReadLine();

            Service.bookings.Add(booking1);
           
        }
        public static void DisplayBookingCust(Booking booking1)
        {
            Console.WriteLine($"BookingId:{booking1.BookingId},Customer:{booking1.Customer},CheckInDate:{booking1.CheckInDate},CheckOutDate:{booking1.CheckOutDate},BookingStatus:{booking1.BookingStatus}");
        }


    }
}