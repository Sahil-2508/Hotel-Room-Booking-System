using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Room_Booking_System
{
    public class Room
    {
        public int RoomId { get; set; }
        public int PricePerDay { get; set; }
        public bool IsAvailable { get; set; }



        public static void StandardRoom()
        {
            Room obj = new Room();

            Console.WriteLine("Enter RoomId");
            obj.RoomId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Price per day");
            obj.PricePerDay = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Available or not");
            obj.IsAvailable = Console.ReadLine() == "1";

            Service.rooms.Add(obj);
            DisplayAllrooms();
        }

        public static void DelaxRoom()
        {
            Room obj = new Room();

            Console.WriteLine("Enter RoomId");
            obj.RoomId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Price per day");
            obj.PricePerDay = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Available or not");
            obj.IsAvailable = Console.ReadLine() == "1";

            Service.rooms.Add(obj);
            DisplayAllrooms();
        }

        public static void SuperDelaxRoom()
        {
            Room obj = new Room();

            Console.WriteLine("Enter RoomId");
            obj.RoomId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Price per day");
            obj.PricePerDay = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Available or not");
            obj.IsAvailable = Console.ReadLine() == "1";

            Service.rooms.Add(obj);
            DisplayAllrooms();
        }

        
        public static void DisplayRoom(Room room)
        {
            Console.WriteLine($"RoomId: {room.RoomId}, PricePerDay: {room.PricePerDay}, IsAvailable: {room.IsAvailable}");

        }
        public static void DisplayAllrooms()
        {
            foreach (var room in Service.rooms)
            {
                Console.WriteLine(
                    $"RoomId: {room.RoomId}, PricePerDay: {room.PricePerDay}, IsAvailable: {room.IsAvailable}"
                );
            }



        }
    }


}
