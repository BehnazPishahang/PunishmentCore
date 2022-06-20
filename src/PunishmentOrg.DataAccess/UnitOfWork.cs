using PunishmentOrg.DataAccess.Repositories.PunishmentOrg;
using PunishmentOrg.Domain.Interface.PunishmentOrg;
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
            ObjectState = new Repositories.ObjectStateRepository(_context);
            PCaseRepository = new PCaseRepository(_context);
            GFESUser = new Repositories.BaseInfo.Anu.BaseInfo.FrontEndSecurity.GFESUserRepository(_context);
            GFESUserAccess = new Repositories.BaseInfo.Anu.BaseInfo.FrontEndSecurity.GFESUserAccessRepository(_context);
        }
        public Domain.Interface.PunishmentOrg.IPDiscoveryMinutesRepository PDiscoveryMinutes { get; private set; }

        public Domain.Interface.IObjectStateRepository ObjectState { get; private set; }
        public Domain.Interface.BaseInfo.Anu.BaseInfo.FrontEndSecurity.IGFESUserRepository GFESUser { get; private set; }
        public Domain.Interface.BaseInfo.Anu.BaseInfo.FrontEndSecurity.IGFESUserAccessRepository GFESUserAccess { get; private set; }

        public IPCaseRepository PCaseRepository { get; private set; }

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
