using Kolokwium_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium_2.Configurations
{
    public class Artist_EventEfConfiguration : IEntityTypeConfiguration<Artist_Event>
    {
        public void Configure(EntityTypeBuilder<Artist_Event> builder)
        {
            builder.HasKey(arev => new { arev.IdEvent, arev.IdArtist });

            builder.HasOne(arev => arev.Artist)
                .WithMany(a => a.Artist_Events)
                .HasForeignKey(arev => arev.IdArtist);
            
            builder.HasOne(arev => arev.Event)
            .WithMany(a => a.Artist_Events)
            .HasForeignKey(arev => arev.IdEvent);

        }
    }
}
