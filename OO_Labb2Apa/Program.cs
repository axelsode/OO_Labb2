using System;
using OO_Labb2Apa;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService orderService = new OrderService();

            orderService.Process(new Order
            {
                Email = "example@example.com",
                ID = 12321,
                Priority = new HighPriority(),
                StreetAdress = "Some adress"
            });
        }
    }
}