using System;
namespace OO_Labb2Apa
{
    public class LowPriority : IPriorityInterface
    {
        public string ProcessMessage()
        {
            return "low";
        }
        public int ProcessPriority()
        {
            return 6;
        }
    }
    public class MediumPriority : IPriorityInterface
    {
        public string ProcessMessage()
        {
            return "medium";
        }
        public int ProcessPriority()
        {
            return 3;
        }
    }
    public class HighPriority : IPriorityInterface
    {
        public string ProcessMessage()
        {
            return "high";
        }
        public int ProcessPriority()
        {
            return 1;
        }
    }
    public class SuperHighPriority : IPriorityInterface
    {
        public string ProcessMessage()
        {
            return "superhigh";
        }
        public int ProcessPriority()
        {
            return 0;
        }
    }
}
