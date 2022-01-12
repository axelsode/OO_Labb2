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
        public void Process(Order order)
        {
            Log($"Started processing order {order.ID}");
            SendEmail(
                order.Email,
                "Your order has been shipped",
                $"Your order with ID {order.ID} is expected to arrive within {order.Priority.ProcessMessage()}", order.ID
                );
        }
        private void Log(string message)
        {
            // Some logging logic. 
            // We output it now to the console just to see what is happening. In reality we could choose multiple ways to log, like
            // text file, event log, database or external framework.
            Console.WriteLine(message);
        }
        private void SendEmail(string recipient, string subject, string message, int orderID)
        {
            // Some email sending logic we don't care about
            Log($"Email sent to {recipient} about order {orderID}");
        }

    }
}