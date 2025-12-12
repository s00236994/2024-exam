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

        public EventType TypeOfEvent { get; set; }


        //constructors

        public Event()
        {

        }

        public Event(string name, DateTime eventDate, List<Ticket> tickets, EventType typeOfEvent)
        {
            Name = name;
            EventDate = eventDate;
            Tickets = tickets;
            TypeOfEvent = typeOfEvent;
        }

        //methods
        public int CompareTo(Event other)
        {
            return this.EventDate.CompareTo(other.EventDate);
        }
    }
}
