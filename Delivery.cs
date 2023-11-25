using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    abstract class Delivery
    {
        public string Address { get; private set; }

        public Delivery(string address)
        {
            Address = address;
        }

        public abstract void Deliver();
    }
}
