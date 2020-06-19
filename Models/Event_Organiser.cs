﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium_2.Models
{
    public class Event_Organiser
    {
        public int IdEvent { get; set; }
        public int IdOrganiser { get; set; }
        public virtual Organiser Organiser { get; set; }
        public virtual Event Event { get; set; }

    }
}
