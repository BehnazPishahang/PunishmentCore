

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PunishmentOrg.Domain.Interface.PunishmentOrg.Anu.PunishmentOrg.DiscoveryMinutes
{
    public interface IPDiscoveryMinutesRepository : IGenericRepository<Entities.PunishmentOrg.Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutes>
    {
        public Task<IEnumerable<Entities.PunishmentOrg.Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutesBase>> getObejectStateTitleWithUniqueNo(string UniqueNo);
        //Task<IEnumerable<Entities.PunishmentOrg.Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutes>> getObejectStateTitleWithUniqueNo(string UniqueNo);

    }
}
    


