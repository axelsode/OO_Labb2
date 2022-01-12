using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Labb2Apa
{
    public class Order
    {
        public int ID { get; set; }
        public IPriorityInterface Priority { get; set; }
        public string StreetAdress { get; set; }
        public string Email { get; set; }

    }
}