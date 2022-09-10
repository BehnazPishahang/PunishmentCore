using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.BaseInfo.Domain.Types
{
    public interface IMeasurementUnitTypeRepository : Anu.Domain.IGenericRepository<Anu.BaseInfo.DataModel.Types.MeasurementUnitType>
    {
        public Task<Anu.BaseInfo.DataModel.Types.MeasurementUnitType> GetByCode(string code);
    }
}
