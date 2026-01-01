using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Room_Booking_System
{
    public  class Bill
    {
        public int BillId { get; set; }
        public int BookingId { get; set; }
        public int TotalNights { get; set; }
        public decimal RoomCharges { get; set; }
        public decimal Discount {  get; set; }
        public decimal FinalAmount { get; set; }
        
  
        public static void Bills()
        {
            Bill bill = new Bill();

            Console.WriteLine("Enter Bill Id");
            bill.BillId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Booking Id");
            bill.BookingId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Hotel Nights");
            bill.TotalNights = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Room Charges");
            bill.RoomCharges = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter Discount");
            bill.Discount = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter Final Amount");
            bill.FinalAmount = Convert.ToDecimal(Console.ReadLine());

            Service.bills1.Add(bill);
            DisplayBill();

        }
        public static void DisplayBill()
        {
            Bill bill = new Bill();
            Console.WriteLine($"BillId:{bill.BillId},BookingId:{bill.BookingId},TotalNights:{bill.TotalNights},RoomCharges:{bill.RoomCharges},Discount:{bill.Discount},FinalAmount:{bill.FinalAmount}");
        }

    }
}
