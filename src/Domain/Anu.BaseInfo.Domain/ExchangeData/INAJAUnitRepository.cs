using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.BaseInfo.Domain.ExchangeData
{
    public interface INAJAUnitRepository:Anu.Domain.IGenericRepository<Anu.BaseInfo.DataModel.ExchangeData.NAJAUnit>
    {
        public Task<Anu.BaseInfo.DataModel.ExchangeData.NAJAUnit> GetByCode(string code);
    }
}
