namespace Anu.PunishmentOrg.Domain.BaseInfo
{
    public interface IPBProductCurrencyTypeRepository : Anu.Domain.IGenericRepository<DataModel.BaseInfo.PBProductCurrencyType>
    {
        public Task<DataModel.BaseInfo.PBProductCurrencyType> GetByCode(string code);
        public Task<string> GetMaxLevelCode(string levelcode);
    }
}
