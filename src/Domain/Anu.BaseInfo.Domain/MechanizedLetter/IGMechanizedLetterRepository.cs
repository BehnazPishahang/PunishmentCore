using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.BaseInfo.Domain.MechanizedLetter
{
    public interface IGMechanizedLetterRepository : Anu.Domain.IGenericRepository<Anu.BaseInfo.DataModel.MechanizedLetter.GMechanizedLetter>
    {
        public Task<Anu.BaseInfo.DataModel.MechanizedLetter.GMechanizedLetter> GetByNo(string code);
        public Task<string> GetMaxNo(string Year, string unitCode);
    }
}
