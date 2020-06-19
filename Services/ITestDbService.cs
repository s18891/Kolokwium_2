using Kolokwium_2.DTOs.Requests;
using Kolokwium_2.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium_2.Services
{
    public interface ITestDbService
    {
        public Artist GetArtist(int id);

        public void UpdateEventTime(int ArtistId, int EventId, UpdateRequest request);

    }
}
