using System.Collections.Generic;
using System.Linq;
using prof_sofware.Models;

namespace prof_sofware.Services
{
    public class PetService : IPetService
    {
         private ApplicationDbContext _context;
        public PetService(ApplicationDbContext context)
        {
            this._context = context;

        }
        public Pet AddPet(Pet pet)
        {
            _context.Pets.Add(pet);
            _context.SaveChanges();
            return pet;
        }

        public Pet GetPet(int id)
        {
            var re = _context.Pets.FirstOrDefault(x => x.Id == id);
            return re;
        }

        public List<Pet> GetPets()
        {
            var re = _context.Pets.ToList();
            return re;
        }
    }
}