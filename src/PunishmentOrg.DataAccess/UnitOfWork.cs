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
            PCaseRepository = new Repositories.PunishmentOrg.PCaseRepository(_context);
            GFESUser = new Repositories.BaseInfo.Anu.BaseInfo.FrontEndSecurity.GFESUserRepository(_context);
            GFESUserAccess = new Repositories.BaseInfo.Anu.BaseInfo.FrontEndSecurity.GFESUserAccessRepository(_context);
            PRegistaryTimeCase = new Repositories.PunishmentOrg.Anu.PunishmentOrg.PCase.PRegistaryTimeCaseRepository(_context);
            PJudgmentCase = new Repositories.PunishmentOrg.Anu.PunishmentOrg.Terminate.PJudgmentCaseRepository(_context);
        }
        public Domain.Interface.PunishmentOrg.DiscoveryMinutes.IPDiscoveryMinutesRepository PDiscoveryMinutes { get; private set; }

        public Domain.Interface.BaseInfo.SystemObject.IObjectStateRepository ObjectState { get; private set; }
        public Domain.Interface.BaseInfo.Anu.BaseInfo.FrontEndSecurity.IGFESUserRepository GFESUser { get; private set; }
        public Domain.Interface.BaseInfo.Anu.BaseInfo.FrontEndSecurity.IGFESUserAccessRepository GFESUserAccess { get; private set; }
        public Domain.Interface.PunishmentOrg.DataModelPunishmentOrgAnu.PunishmentOrg.Case.IPRegistaryTimeCaseRepository PRegistaryTimeCase { get; private set; }
        public Domain.Interface.PunishmentOrg.Case.IPCaseRepository PCaseRepository { get; private set; }
        public Domain.Interface.PunishmentOrg.Anu.PunishmentOrg.Terminate.IPJudgmentCaseRepository PJudgmentCase { get; private set; }

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
