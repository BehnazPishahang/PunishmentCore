using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.BaseInfo.DataAccess.GMechanizedLetter
{
    public class GMechanizedLetterRepository : Anu.DataAccess.Repositories.GenericRepository<DataModel.MechanizedLetter.GMechanizedLetter>,
 Anu.BaseInfo.Domain.MechanizedLetter.IGMechanizedLetterRepository
    {
        public GMechanizedLetterRepository(Anu.DataAccess.ApplicationDbContext context) : base(context)
        {

        }

        public async Task<Anu.BaseInfo.DataModel.MechanizedLetter.GMechanizedLetter> GetByNo(string No)
        {
            return await _context.Set<Anu.BaseInfo.DataModel.MechanizedLetter.GMechanizedLetter>().Where(x => x.No == No).FirstOrDefaultAsync();
        }

        public async Task<string> GetMaxNo(string Year, string unitCode)
        {
            var MaxNo = "";
            var result =  _context.Set<Anu.BaseInfo.DataModel.MechanizedLetter.GMechanizedLetter>().Where(x => x.No.StartsWith($"{Year}986{unitCode}")).Select(x => x.No).Max();
            if (result == null)
            {
                MaxNo = $"{Year}986{unitCode}000001";

            }
            else
            {
                var strMaxNo = result.ToString().Substring(12);
                int maxNo = System.Convert.ToInt32(strMaxNo);
                maxNo++;
                MaxNo = $"{Year}986{unitCode}{maxNo.ToString().PadLeft(6, '0')}";
            }
            return MaxNo;
        }

    }
}
