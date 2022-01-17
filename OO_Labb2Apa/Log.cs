using System;
namespace OO_Labb2Apa
{
    public class Log : ILogInterface
    {
        void ILogInterface.Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
