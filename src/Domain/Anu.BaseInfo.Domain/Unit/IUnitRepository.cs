using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.BaseInfo.Domain.Unit;

public interface IUnitRepository : Anu.Domain.IGenericRepository<Anu.BaseInfo.DataModel.OrganizationChart.Unit>
{
    public Task<Anu.BaseInfo.DataModel.OrganizationChart.Unit> GetByUnitNo(string unitNo);
}
