using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_exam
{
    public class Ticket
    {
        //properties
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int AvailableTickets { get; set; }

        //constructors
        public Ticket()
        {

        }

        public Ticket(string name, decimal price, int availableTickets)
        {
            Name = name;
            Price = price;
            AvailableTickets = availableTickets;
        }



        //methods
        public override string ToString()
        {
            return $"{Name} - {Price:C} [AVAILABLE - {AvailableTickets}]";
        }


    }//end of class
}
