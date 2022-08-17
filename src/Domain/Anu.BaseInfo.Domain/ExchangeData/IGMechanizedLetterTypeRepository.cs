

namespace Anu.BaseInfo.Domain.ExchangeData
{
    public interface IGMechanizedLetterTypeRepository : Anu.Domain.IGenericRepository<Anu.BaseInfo.DataModel.ExchangeData.GMechanizedLetterType>
    {
        public Task<Anu.BaseInfo.DataModel.ExchangeData.GMechanizedLetterType> GetByCode(string code);
        //public Task<IEnumerable<Anu.BaseInfo.DataModel.ExchangeData.GMechanizedLetterType>> GetByCode(string code);
    }
}
