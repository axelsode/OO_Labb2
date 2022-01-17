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
        IMessageSender emailSender = new EmailSender();

        public void Process(Order order)
        {
            emailSender.Log($"Started processing order {order.ID}");
            emailSender.SendMessage(order.Email,
                "Your order has been shipped",
                $"Your order with ID {order.ID} is expected to arrive within {order.Priority.ProcessMessage()}", order.ID
                );  
        }
    }
}