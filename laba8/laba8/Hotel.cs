using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba8
{
    class Hotel
    {
        private Room[] listOfRooms;
        private int countOfRooms;

        public Hotel()
        {
            listOfRooms = new Room[100];
            countOfRooms = 0;
        }
        public void AddAbsDiscountRoom(int num, double price, double discount)
        {
            listOfRooms[countOfRooms++] = new Room(num, new AbsDiscount(price, discount));
        }
        public void AddNoDiscountRoom(int num, double price)
        {
            listOfRooms[countOfRooms++] = new Room(num, new NoDiscount(price));
        }

        public double GetTotalPrice()
        {
            double sum = 0;
            for (int i = 0; i < countOfRooms; i++)
            {
                sum += listOfRooms[i].GetPrice();
            }
            return sum;
        }
    }
}
