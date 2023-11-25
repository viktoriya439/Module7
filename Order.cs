using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Order<TDelivery> where TDelivery : Delivery
    {
        private List<Product> products;
        public TDelivery Delivery { get; private set; }
        public int Number { get; private set; }
        public string Description { get; private set; }

        public Product this[int index]
        {
            get { return products[index]; }
            set { products[index] = value; }
        }

        public Order(TDelivery delivery, int number, string description)
        {
            Delivery = delivery;
            Number = number;
            Description = description;
            products = new List<Product>();
        }

        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }

        public decimal GetTotalPrice()
        {
            decimal total = 0;
            foreach (var product in products)
            {
                total += product.Price;
            }
            return total;
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }
    }
}
