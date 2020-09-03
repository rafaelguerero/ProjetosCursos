using Exproposto.Entities;
using Exproposto.Entities.Enuns;
using System;
using System.Globalization;
using System.Text;

namespace Exproposto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the client data:");

            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("E-mail: ");
            string email = Console.ReadLine();
            Console.Write("Birth(DD/MM/YYYY): ");
            DateTime birth = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, birth);

            Console.WriteLine();

            Console.WriteLine("Enter the order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many itens to this order? ");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter #{0} item data:",i);
                Console.Write("Product name: ");
                string pName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Product product = new Product(pName, price);

                Console.Write("Quantity: ");
                int qnt = int.Parse(Console.ReadLine());                
                OrderItem item = new OrderItem(qnt, product);
                order.AddItem(item);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMARY");
            Console.WriteLine(order);

        }
    }
}
