using System.Collections.Generic;
using prof_sofware.Models;

namespace prof_sofware.Services
{
    public interface IHospitalService
    {
        public List<Hospital> GetHospitals();
        public Hospital GetHospital(int id);
        public Hospital AddHospital(Hospital hospital);

    }
}