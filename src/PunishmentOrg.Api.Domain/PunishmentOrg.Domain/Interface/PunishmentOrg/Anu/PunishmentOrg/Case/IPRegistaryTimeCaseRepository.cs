namespace PunishmentOrg.Domain.Interface.PunishmentOrg.DataModelPunishmentOrgAnu.PunishmentOrg.Case
{
    public interface IPRegistaryTimeCaseRepository : IGenericRepository<DataModel.PunishemntOrg.Anu.PunishmentOrg.Case.PRegistaryTimeCase>
    {
        public Task<IEnumerable<DataModel.PunishemntOrg.Anu.PunishmentOrg.Case.PRegistaryTimeCase>> GetPCaseByNo(string pCaseNo, DataModel.Anu.Enumerations.PunishmentOrg.PURegisterTimeType timeType);
    }
}
