
using System.Collections.Generic;
using prof_sofware.Models;

namespace prof_sofware.Services
{
    public interface IPetService
    {
         public List<Pet> GetPets();
        public Pet GetPet(int id);
        public Pet AddPet(Pet pet);       
    } 
    
}