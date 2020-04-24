using System.Collections.Generic;
using System.Linq;
using prof_sofware.Models;

namespace prof_sofware.Services
{
    public class StatusService : IStatusService
    {
        private ApplicationDbContext _context;
        public StatusService(ApplicationDbContext context)
        {
            this._context = context;

        }
        public Status AddStatus(Status status)
        {
            _context.Statuses.Add(status);
            _context.SaveChanges();
            return status;
        }

        public Status GetStatus(int id)
        {
            var s=_context.Statuses.FirstOrDefault(x=>x.Id==id);
            return s;
        }

        public List<Status> GetStatuses()
        {
            var s=_context.Statuses.ToList();
            return s;
        }
    }
}