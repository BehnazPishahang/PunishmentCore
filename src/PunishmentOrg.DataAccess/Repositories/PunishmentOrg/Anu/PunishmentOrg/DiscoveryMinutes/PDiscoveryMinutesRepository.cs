

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Anu.PunishmentOrg.DiscoveryMinutes;
using PunishmentOrg.Domain.Interface.PunishmentOrg;

namespace PunishmentOrg.DataAccess.Repositories.PunishmentOrg.Anu.PunishmentOrg.DiscoveryMinutes
{
    public class PDiscoveryMinutesRepository : GenericRepository<PDiscoveryMinutes>,
        Domain.Interface.PunishmentOrg.IPDiscoveryMinutesRepository
    {
        public PDiscoveryMinutesRepository(ApplicationDbContext context) : base(context)
        {
        }

        

        Task<IEnumerable<PDiscoveryMinutes>> IPDiscoveryMinutesRepository.getObejectStateTitleWithUniqueNo(string UniqueNo)
        {
            throw new NotImplementedException();
        }
    }
}


