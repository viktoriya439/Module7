using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class PickPointDelivery : Delivery
    {
        public string Company { get; private set; }
        public string PickPoint { get; private set; }
        public PickPointDelivery(string address, string company, string pickPoint) : base(address)
        {
            Company = company;
            PickPoint = pickPoint;
        }
        public override void Deliver()
        {
            Console.WriteLine($"Доставка в пункт выдачи по адресу: {Address} компании: {Company} в точку выдачи: {PickPoint}");
        }
    }
}
