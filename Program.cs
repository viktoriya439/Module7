namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание продуктов
            var product1 = new Product { Name = "Продукт 1", Price = 100m };
            var product2 = new Product { Name = "Продукт 2", Price = 200m };
            // Создание доставки
            var delivery = new HomeDelivery("Адрес 1", "Курьер 1");
            // Создание заказа
            var order = new Order<HomeDelivery>(delivery, 1, "Описание заказа");
            // Добавление продуктов в заказ
            order.AddProduct(product1);
            order.AddProduct(product2);
            // Вывод деталей заказа
            OrderHelper.PrintOrderDetails(order);
        }
    }
}