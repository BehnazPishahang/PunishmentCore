using Anu.Commons.ServiceModel.ServicePaging;

namespace Anu.PunishmentOrg.Domain.Notice
{
    public interface IPNoticeRepository : Anu.Domain.IGenericRepository<DataModel.Notice.PNotice>
    {
        public Task<IEnumerable<DataModel.Notice.PNotice>> GetAllPNoticeByNationalCode(string NationalCode,Page Page);
    }
}
