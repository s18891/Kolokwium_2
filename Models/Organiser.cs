﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium_2.Models
{
    public class Organiser
    {
        public int IdOrganiser { get; set; }
        public String Name { get; set; }

        public ICollection<Event_Organiser> Event_Organisers { get; set; }
    }
}
