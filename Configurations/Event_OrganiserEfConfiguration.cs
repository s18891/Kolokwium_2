using Kolokwium_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium_2.Configurations
{
    public class Event_OrganiserEfConfiguration : IEntityTypeConfiguration<Event_Organiser>
    {
        public void Configure(EntityTypeBuilder<Event_Organiser> builder)
        {
            builder.HasKey(evor => new { evor.IdEvent, evor.IdOrganiser });

            builder.HasOne(evor => evor.Event)
            .WithMany(e => e.Event_Organisers)
            .HasForeignKey(evor => evor.IdEvent);
            
            
            builder.HasOne(evor => evor.Organiser)
            .WithMany(e => e.Event_Organisers)
            .HasForeignKey(evor => evor.IdOrganiser);



        }

        
    }
}
