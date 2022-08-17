

using Anu.BaseInfo.DataModel.ExchangeData;
using Anu.BaseInfo.Domain.ExchangeData;
using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Anu.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using Utility.Guard;

namespace Anu.BaseInfo.DataAccess.ExchangeData
{
    public class GMechanizedLetterTypeRepository : GenericRepository<Anu.BaseInfo.DataModel.ExchangeData.GMechanizedLetterType>, IGMechanizedLetterTypeRepository
    {
        public GMechanizedLetterTypeRepository(Anu.DataAccess.ApplicationDbContext context) : base(context)
        {
        }


        public async Task<GMechanizedLetterType> GetByCode(string code)
        {
            return await _context.Set<Anu.BaseInfo.DataModel.ExchangeData.GMechanizedLetterType>().Where(x => x.Code == code).FirstOrDefaultAsync();


            // var GMechanizedLetterTypeID = await _context.Set<Anu.BaseInfo.DataModel.ExchangeData.GMechanizedLetterType>().Where(x => x.Code == code).Select(n => n.Id).FirstAsync();

            //GMechanizedLetterTypeID.Null(AnuResult.Error);

            //var GMechanizedLetterType = await _context.Set<GMechanizedLetterType>().Where(p => p.Id == GMechanizedLetterTypeID.ToString()).ToListAsync();

            //return GMechanizedLetterType;


        }
    }
}
