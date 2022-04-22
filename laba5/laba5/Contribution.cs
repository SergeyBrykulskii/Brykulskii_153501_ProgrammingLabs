using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    public class Contribution
    {
        private double amount;
        private int type;
        private double percent;
        public Contribution(int type = 0, double percent = 0, double amount = 0)
        {
            this.amount = amount;   
            this.type = type;
            this.percent = percent;
        }

        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        public double Percent
        {
            get { return percent; }
            set { percent = value; }
        }
    }
}
