using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Hotel
    {
        public string Name;
        private static int _id;
        public int Id;
        List <Room>rooms = new List <Room> ();
        List<Hotel>hotels= new List <Hotel> ();
        public Hotel()
        {
            Id=++_id;
        }
        public void ShowHotel()
        {
            Console.WriteLine($"name:{Name},id:{Id}");
        }
        public void AddHotel(Hotel hotel)
        {
            hotels.Add(hotel);
        }
        public Hotel FindHotel(int id)
        {
            return hotels.Find(x => x.Id == id);
        }

        public void AddRoom(Room room)
        {
            rooms.Add(room);
        }
        public List<Room>FindAllRoom(int id)
        {
            return rooms.FindAll(x=> x.Id == id);
        }

        public void MakeReservation(int? roomid)
        {
            if (roomid == null) throw new NullReferenceException("Id yoxdu");
            foreach (Room room in rooms)
            {
                if(room.Id == roomid)
                {
                    if (room.IsAviable)
                    {
                        Console.WriteLine("Rezerv olundu");
                        room.IsAviable = false;
                        Console.WriteLine(room);
                    }
                    else
                    {
                        throw new NotAvaibleExpecition("Otaq rezerv olunub");
                    }
                }
            }
        }


    }
}
