using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Room
    {
        private static int _id;
        public int Id;
        public string Name;
        public double Price;
        public double PersonCapacity;
        public bool IsAviable = true;

        public Room()
        {
            Id = ++_id;
        }
        public string ShowInfo()
        {
            return $"name:{Name},price:{Price},id:{Id},personcapacity:{PersonCapacity},Rezerved:{!IsAviable}";
        }
    }
}
