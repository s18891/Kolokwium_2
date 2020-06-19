using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium_2.Services
{
    public interface ITestDbService
    {
        public IEnumerable getTests();
    }
}
