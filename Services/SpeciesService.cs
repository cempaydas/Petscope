using System.Collections.Generic;
using System.Linq;
using prof_sofware.Models;

namespace prof_sofware.Services
{
    public class SpeciesService : ISpeciesService
    {
        private ApplicationDbContext _context;
        public SpeciesService(ApplicationDbContext _context)
        {
            this._context = _context;

        }

        public Species AddSpecie(Species species)
        {
            _context.Species.Add(species);
            _context.SaveChanges();
            return species;
        }

       

        public List<Species> GetSpecies()
        {
            var species = _context.Species.ToList();
            return species;
        }

        public Species GetSpecies(int id)
        {
            var species = _context.Species.FirstOrDefault(x => x.Id == id);
            return species;
        }
    }
}