using PjEnum.Entities;
using PjEnum.Entities.Enuns;
using System;

namespace PjEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order { Id = 1080, Moment = DateTime.Now, Status = OrderStatus.PendingPayment};

            //Converte enum para string
            string txt = OrderStatus.Delivered.ToString();

            //Converte string para enum
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(order);
            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}
