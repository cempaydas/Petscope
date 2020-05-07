using System.Collections.Generic;
using prof_sofware.Models;

namespace prof_sofware.Services
{
    public interface IStatusService
    {
        public List<Status> GetStatuses();
        public Status GetStatus(int id);
        public Status AddStatus(Status status);
         
    }
}