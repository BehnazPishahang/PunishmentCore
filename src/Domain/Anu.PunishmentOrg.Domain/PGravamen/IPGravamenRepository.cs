

using Anu.Commons.ServiceModel.ServicePaging;

namespace Anu.PunishmentOrg.Domain.PGravamen;

//! کل من علیها fun
public interface IPGravamenRepository : Anu.Domain.IGenericRepository<DataModel.Gravamen.PGravamen>
{
    public Task<DataModel.Gravamen.PGravamen> GetPGravamenByFollowUpNo(string followUpNo);

    public Task<DataModel.Gravamen.PGravamen> GetPGravamenById(string id);
}