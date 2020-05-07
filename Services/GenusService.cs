using System.Collections.Generic;
using System.Linq;
using prof_sofware.Models;

namespace prof_sofware.Services
{
    public class GenusService : IGenusService
    {
        private ApplicationDbContext _context;
        public GenusService(ApplicationDbContext context)
        {
            this._context=context;
            
        }
        public Genus AddGenus(Genus genus)
        {
            _context.Genus.Add(genus);
            _context.SaveChanges();
            return genus;
        }

        public List<Genus> GetGenus()
        {
            var re=_context.Genus.ToList();
            return re;
        }

        public Genus GetGenus(int id)
        {
            var re=_context.Genus.FirstOrDefault(x=>x.Id==id);
            return re;
        }
    }
}