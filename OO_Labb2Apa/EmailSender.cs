using System;
namespace OO_Labb2Apa
{
    public class EmailSender : IMessageSender
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }

        public void SendMessage(string recipient, string subject, string message, int orderID)
        {
            // Some email sending logic we don't care about
            Log($"Email sent to {recipient} about order {orderID}");
        }
    }
}
