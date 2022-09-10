using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.BaseInfo.Domain.ExchangeData
{
    public interface IGExchangeUnitTitleRepository : Anu.Domain.IGenericRepository<Anu.BaseInfo.DataModel.ExchangeData.GExchangeUnitTitle>
    {
        public Task<Anu.BaseInfo.DataModel.ExchangeData.GExchangeUnitTitle> GetByCode(string code);
    }
}
