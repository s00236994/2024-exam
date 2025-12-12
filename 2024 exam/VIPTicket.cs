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
        public VIPTicket()
        {

        }

        public VIPTicket(string name, decimal price, int availableTickets, string additionalExtras, decimal additionalCost)
            : base(name, price, availableTickets)

        {
            AdditionalCost = additionalCost;
            AdditionalExtras = additionalExtras;
        }


        //methods
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
