using System.Collections.Generic;
using System.Linq;
using prof_sofware.Models;

namespace prof_sofware.Services
{
    public class EmergencyService:IEmergencyService
    {

        private ApplicationDbContext _context;
        public EmergencyService(ApplicationDbContext context)
        {
            this._context = context;

        }
        public Emergency AddEmergency(Emergency emergency)
        {
            _context.Emergencies.Add(emergency);
            _context.SaveChanges();
            return emergency;
        }

        public Emergency GetEmergency(int id)
        {
            var re = _context.Emergencies.FirstOrDefault(x => x.Id == id);
            return re;

        }

        public List<Emergency> GetEmergencies()
        {
            var re = _context.Emergencies.ToList();
            return re;
        }
        
    }
}