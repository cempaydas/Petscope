using System.Collections.Generic;
using prof_sofware.Models;
namespace prof_sofware.Services
{
    public interface ISpeciesService
    {
        public List<Species> GetSpecies();
        public Species GetSpecies(int id);
        public Species AddSpecie(Species species);

    }
}