using Kolokwium_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium_2.Configurations
{
    public class EventEfConfiguration : IEntityTypeConfiguration<Event>

    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasKey(e => e.IdEvent);



            builder.HasMany(e => e.Artist_Events)
                .WithOne(arev => arev.Event)
                .HasForeignKey(arev => arev.IdEvent);

            builder.HasMany(e => e.Event_Organisers)
                .WithOne(evor => evor.Event)
                .HasForeignKey(evor => evor.IdOrganiser);
        }
    }
}
