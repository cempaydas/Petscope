using System.Collections.Generic;
using prof_sofware.Models;

namespace prof_sofware.Services
{
    public interface IGenusService
    {
        public List<Genus> GetGenus();
        public Genus GetGenus(int id);
        public Genus AddGenus(Genus genus);

    }
}