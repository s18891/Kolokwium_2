using Kolokwium_2.Models;
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
    }
}
