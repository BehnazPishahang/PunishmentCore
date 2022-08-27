using Anu.BaseInfo.DataModel.OrganizationChart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.BaseInfo.Domain.OrganizationChart
{
    public interface IUnitRepository : Anu.Domain.IGenericRepository<Anu.BaseInfo.DataModel.OrganizationChart.Unit>
    {
        public Task<Anu.BaseInfo.DataModel.OrganizationChart.Unit> GetByCode(string code);

        public Task<Anu.BaseInfo.DataModel.OrganizationChart.Unit> FindRelatedUnitToGeoLocation(string locationCode , List<string> gUnitTypes);
    }
}
