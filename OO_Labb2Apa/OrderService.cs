using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OO_Labb2Apa;

namespace OO_Labb2Apa
{
    public class OrderService
    {
        private readonly IMessageSender _messageSender;
        private readonly ILogInterface _log;

        public OrderService(IMessageSender messageSender, ILogInterface log )
        {
            _messageSender = messageSender;
            _log = log;
        }

        public void Process(Order order)
        {
            _log.Log($"Started processing order {order.ID}");
            _messageSender.SendMessage(order.Email,
                "Your order has been shipped",
                $"Your order with ID {order.ID} is expected to arrive within {order.Priority.ProcessMessage()}", order.ID
                );  
        }
    }
}