using Kolokwium_2.DTOs.Requests;
using Kolokwium_2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium_2.Services
{
    public class EfTestDbService : ITestDbService
    {
        private readonly TestDbContext _context;
        public EfTestDbService(TestDbContext context)
        {
            _context = context;
        }

        public IEnumerable getTests()
        {
            return _context.Test.ToList();
        }

        

        public Artist GetArtist(int id)
        {
            var artist = _context.Artists.Include(a => a.Artist_Events)
                           .FirstOrDefault(a => a.IdArtist == id);

            if (artist == null)
            {
                throw new Exception("not found");
            }

            artist.Artist_Events = artist.Artist_Events.OrderByDescending(arev => arev.PerformanceDate).ToList();

            return artist;
        }


        public void UpdateEventTime(int ArtistId, int EventId, UpdateRequest request)
        {
            var artist = _context.Artists.Include(a => a.Artist_Events)
                                        .SingleOrDefault(a => a.IdArtist == ArtistId);

            if (artist == null)
            {
                throw new Exception("artist not found");
            }

            var _event = _context.Event.SingleOrDefault(e => e.IdEvent == request.IdEvent);

                       _context.SaveChanges();
        }
    }
}
