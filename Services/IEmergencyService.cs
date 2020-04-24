using System.Collections.Generic;
using prof_sofware.Models;

namespace prof_sofware.Services
{
    public interface IEmergencyService
    {
         public List<Emergency> GetEmergencies();
        public Emergency GetEmergency(int id);
        public Emergency AddEmergency(Emergency emergency);
    }
}