using System;
namespace OO_Labb2Apa
{
    public interface IMessageSender : ILogInterface
    {
        void SendMessage(string recipient, string subject, string message, int orderID);
        
    }
}
