

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PunishmentOrg.Domain.Interface.PunishmentOrg
{ 
    public interface IPDiscoveryMinutesRepository : IGenericRepository<Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutes>
    {
        public Task<IEnumerable<Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutes>> getObejectStateTitleWithUniqueNo(string UniqueNo);
        //Task<IEnumerable<Entities.PunishmentOrg.Anu.PunishmentOrg.DiscoveryMinutes.PDiscoveryMinutes>> getObejectStateTitleWithUniqueNo(string UniqueNo);

    }
}
    


