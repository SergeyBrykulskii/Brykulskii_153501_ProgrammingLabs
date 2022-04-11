using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    public class Hotel
    {
        private static Hotel obj;
        private string name;
        private int numberOfRooms;
        private int numberOfBusyRooms;
        private Rate rate = new Rate(0);
        private static int days = 100;
        private Hotel(string name, int numberOfRooms, int rate)
        {
            this.name = name;
            this.numberOfRooms = numberOfRooms;
            this.rate.Price = rate;
        }

        public static Hotel GetHotel(string name, int numberOfRooms, int rate)
        {
            if (obj == null)
            {
                obj = new Hotel(name, numberOfRooms, rate);
            }
            return obj;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int NumberOfRooms
        {
            get { return numberOfRooms; }
            set { numberOfRooms = value; }
        }

        public int NumberOfBusyRooms
        {
            get { return numberOfBusyRooms; }
            set { numberOfBusyRooms = value; }
        }
        
        public int EditPrice
        {
            get { return rate.Price; }
            set { rate.Price = value; }
        }

        public int calculate()
        {
            return rate.Price * days;
        }
    }
}
