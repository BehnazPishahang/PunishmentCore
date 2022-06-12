using PunishmentOrg.Domain.Entities.Anu.BaseInfo.OrganizationChart;

namespace PunishmentOrg.Domain.Interface.Anu.BaseInfo.OrganizationChart
{
    public interface IGUnitTypeRepository : IGenericRepository<GUnitType>
    {
    }
}

namespace PunishmentOrg.Domain.Interface
{
    public partial interface IUnitOfWork : IDisposable
    {
        Anu.BaseInfo.OrganizationChart.IGUnitTypeRepository GUnitType { get; }
    }
}