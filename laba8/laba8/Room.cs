using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba8
{
    class Room
    {
        private int Number { get; set; }

        private IPrice Ip { get; set; }

        public Room(int number, IPrice ip)
        {
            Number = number;
            Ip = ip;
        }

        public double GetPrice()
        {
            return Ip.GetPrice();
        }
    }
}
