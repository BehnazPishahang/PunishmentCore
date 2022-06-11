using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunishmentOrg.Domain.Interface
{
    public partial interface IUnitOfWork : IDisposable
    {
        PunishmentOrg.Anu.PunishmentOrg.DiscoveryMinutes.IPDiscoveryMinutesRepository PDiscoveryMinutes { get; }
        BaseInfo.Anu.BaseInfo.SystemObject.IObjectStateRepository ObjectState { get; }
        int Complete();
    }
}
