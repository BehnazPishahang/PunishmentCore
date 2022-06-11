using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunishmentOrg.DataAccess
{
    public partial class UnitOfWork : Domain.Interface.IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            PDiscoveryMinutes = new Repositories.PunishmentOrg.Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutesRepository(_context);
            ObjectState = new Repositories.BaseInfo.Anu.BaseInfo.SystemObject.ObjectStateRepository(_context);
        }
        public Domain.Interface.PunishmentOrg.Anu.PunishmentOrg.DiscoveryMinutes.IPDiscoveryMinutesRepository PDiscoveryMinutes { get; private set; }

        public Domain.Interface.BaseInfo.Anu.BaseInfo.SystemObject.IObjectStateRepository ObjectState { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
