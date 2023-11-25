using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class ShopDelivery : Delivery
    {
        public ShopDelivery(string address) : base(address) { }
        public override void Deliver()
        {
            Console.WriteLine($"Доставка в магазин по адресу: {Address} с помощью внутренних средств компании");
        }
    }
}
