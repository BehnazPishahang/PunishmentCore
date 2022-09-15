using Anu.PunishmentOrg.DataModel.Accounting;

namespace Anu.PunishmentOrg.DataAccess.Accounting
{
    public interface IPTreasuryRandomNumRepository : Anu.Domain.IGenericRepository<DataModel.Accounting.PTreasuryRandomNum>
    {
        abstract Task<PTreasuryRandomNum> Get_PTreasuryRandomNum_By_TreasuryNumber(string treasuryNumber);
    }
}