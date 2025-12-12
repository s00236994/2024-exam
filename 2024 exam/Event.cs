using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_exam
{
    public enum EventType
    {
        Music, Comedy, Theatre
    }
    public class Event : IComparable<Event>
    {
        //properties
        public string Name { get; set; }
        public DateTime EventDate { get; set; }

        public List <Ticket> Tickets { get; set; } 

        public Event TypeOfEvent { get; set; }



        //constructors

        //methods
        public int CompareTo(Event other)
        {
            return this.EventDate.CompareTo(other.EventDate);
        }
    }
}
