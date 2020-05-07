using System.Collections.Generic;
using System.Linq;
using prof_sofware.Models;

namespace prof_sofware.Services
{
    public class HospitalService : IHospitalService
    {
        private ApplicationDbContext _context;
        public HospitalService(ApplicationDbContext context)
        {
            this._context = context;

        }
        public Hospital AddHospital(Hospital hospital)
        {
            _context.Hospitals.Add(hospital);
            _context.SaveChanges();
            return hospital;
        }

        public Hospital GetHospital(int id)
        {
            var re = _context.Hospitals.FirstOrDefault(x => x.Id == id);
            return re;

        }

        public List<Hospital> GetHospitals()
        {
            var re = _context.Hospitals.ToList();
            return re;
        }
    }
}