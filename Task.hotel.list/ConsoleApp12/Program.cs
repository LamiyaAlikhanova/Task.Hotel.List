namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel = new Hotel();
            bool exit = false;
            do
            {
                Console.WriteLine("sisteme giris");
                Console.WriteLine("1.Hotel yarat:");
                Console.WriteLine("2.Hoteli gosterin:");
                Console.WriteLine("3.Hoteli secin//1.Otaq yarat//2.Otaqlari goster//3.Rezerve et//4.Menyuya geri qayit");
                Console.WriteLine("0.exit");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Hotel yarat:");
                        Hotel hotel1=CreateHotel();
                        break;
                    case "2":
                        Console.WriteLine("Hotelin gosterin");
                        hotel.ShowHotel();
                        break;
                    case "3":
                        Console.WriteLine("Id daxil edin");
                        int id=Convert.ToInt32(Console.ReadLine());
                        var hotell=hotel.FindHotel(id);
                        bool exitt = false;
                        do
                        {
                            string input1=Console.ReadLine();
                            switch (input1)
                            {
                                case "1":
                                    Console.WriteLine("Otaq yarat:");
                                    Room room = CreateRoom();
                                    hotel.AddRoom(room);
                                    Console.WriteLine("yarandi");
                                    break;
                                case "2":
                                    Console.WriteLine("Otaqlari gosterin");
                                    Room room1 = new Room();
                                    room1.ShowInfo();
                                    break;
                                case "3":
                                    Console.WriteLine("Id daxil edin");
                                    id=Convert.ToInt32(Console.ReadLine());
                                    var roomm=hotel.FindAllRoom(id);
                                    break;
                                case "4":
                                    exitt=true;
                                    break;
                            }
                        }
                        while (exitt != true);
                        break;
                    case "0":
                        exit=true;
                        break;
                }
            }
            while (exit != true);
        }
        public static Hotel CreateHotel()
        {
            Hotel hotel1 = new Hotel();
            Console.WriteLine("Hotelin adini daxil edin:");
            hotel1.Name = Console.ReadLine();
            return hotel1;
        }
        public static Room CreateRoom()
        {
            Room room= new Room();
            Console.WriteLine("Otagin adini daxil edin:");
            room.Name = Console.ReadLine();
            Console.WriteLine("Otagin qiymetini daxil edin:");
            room.Price=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Otagin tutumunu daxil edin:");
            room.PersonCapacity=Convert.ToDouble(Console.ReadLine());

            string choose= Console.ReadLine();
            switch(choose)
            {
                case "1":room.IsAviable=true; 
                    break;
                case"2":room.IsAviable=false;
                    break;

            }
            return room;
        }

    }
}
