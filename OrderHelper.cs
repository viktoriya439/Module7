using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    static class OrderHelper
    {
        public static void PrintOrderDetails<TDelivery>(this Order<TDelivery> order) where TDelivery : Delivery
        {
            Console.WriteLine($"Order Number: {order.Number}");
            Console.WriteLine($"Description: {order.Description}");
            Console.WriteLine($"Total Price: {order.GetTotalPrice()}");
            order.DisplayAddress();
        }
    }
}
