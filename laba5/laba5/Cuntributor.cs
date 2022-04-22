using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    public class Contributor
    {
        private string name;
        private Contribution cont;
        public Contributor(string name = "Ivan")
        {
            this.name = name;
            cont = new();
        }
        public string Name 
        { 
            get => name;  
            set => name = value;
        }

        public Contribution Cont
        {
            get => cont; 
            set => cont = value; 
        }
    }
}
