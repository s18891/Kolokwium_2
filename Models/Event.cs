using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium_2.Models
{
    public class Event
    {
        public int IdEvent { get; set; }
        public String Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ICollection<Event_Organiser> Event_Organisers { get; set; }
        public ICollection<Artist_Event> Artist_Events { get; set; }
    }
}
