using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_exam
{
    public class VIPTicket : Ticket
    {
        //properties
        public string AdditionalExtras { get; set; }

        public decimal AdditionalCost { get; set; }

        //constructors


        //methods
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
