using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class HomeDelivery : Delivery
    {
        public string Courier { get; private set; }
        public HomeDelivery(string address, string courier) : base(address)
        {
            Courier = courier;
        }
        public override void Deliver()
        {
            Console.WriteLine($"Доставка на дом по адресу: {Address} с помощью курьера: {Courier}");
        }
    }
}
