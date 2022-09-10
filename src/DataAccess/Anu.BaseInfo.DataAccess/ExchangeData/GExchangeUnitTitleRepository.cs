using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.BaseInfo.DataAccess.ExchangeData
{
    public class GExchangeUnitTitleRepository : Anu.DataAccess.Repositories.GenericRepository<DataModel.ExchangeData.GExchangeUnitTitle>, Domain.ExchangeData.IGExchangeUnitTitleRepository
    {
        public GExchangeUnitTitleRepository(Anu.DataAccess.ApplicationDbContext context) : base(context)
        {

        }

        public async Task<DataModel.ExchangeData.GExchangeUnitTitle> GetByCode(string code)
        {
            return await _context.Set<DataModel.ExchangeData.GExchangeUnitTitle>().Where(x => x.Code == code).FirstOrDefaultAsync();
        }


    }
}
