using System;
using OO_Labb2Apa;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogInterface log = new Log();

            EmailSender emailSender = new EmailSender(log);
            
            OrderService orderService = new OrderService(emailSender, log);

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