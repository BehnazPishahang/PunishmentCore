

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PunishmentOrg.Domain.Entities.PunishmentOrg.Anu.PunishmentOrg.DiscoveryMinutes;
using Microsoft.EntityFrameworkCore;
using PunishmentOrg.Domain.Interface.PunishmentOrg.Anu.PunishmentOrg.DiscoveryMinutes;

namespace PunishmentOrg.DataAccess.Repositories.PunishmentOrg.Anu.PunishmentOrg.DiscoveryMinutes
{
    public class PDiscoveryMinutesRepository : GenericRepository<Domain.Entities.PunishmentOrg.Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutes>,
        Domain.Interface.PunishmentOrg.Anu.PunishmentOrg.DiscoveryMinutes.IPDiscoveryMinutesRepository
    {
        public PDiscoveryMinutesRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<PDiscoveryMinutesBase>> getObejectStateTitleWithUniqueNo(string UniqueNo)
        {
            return await _context.Set<PDiscoveryMinutes>().Where(x => x.UniqueNo == UniqueNo).Include(a => a.TheObjectState).ToListAsync();
        }
    }
}


