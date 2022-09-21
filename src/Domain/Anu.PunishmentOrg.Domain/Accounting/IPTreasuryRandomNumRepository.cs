using Anu.PunishmentOrg.DataModel.Accounting;

namespace Anu.PunishmentOrg.DataAccess.Accounting
{
    public interface IPTreasuryRandomNumRepository : Anu.Domain.IGenericRepository<DataModel.Accounting.PTreasuryRandomNum>
    {
        abstract Task<List<PTreasuryRandomNum>> Get_PTreasuryRandomNum_EndsWith_TreasuryNumber(string treasuryNumber);
    }
}