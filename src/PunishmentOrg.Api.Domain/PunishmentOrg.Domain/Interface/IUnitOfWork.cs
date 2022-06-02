using PunishmentOrg.Domain.Interface.Anu.BaseInfo.OrganizationChart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunishmentOrg.Domain.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IUnitRepository Unit { get; }
        IGUnitTypeRepository GUnitType { get; }
        int Complete();
    }
}
