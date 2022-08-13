using Anu.Commons.ServiceModel.ServicePaging;
using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Anu.DataAccess;
using Anu.PunishmentOrg.DataModel.Notice;
using Anu.Utility.Linq;
using Anu.Utility.Pagination;
using Microsoft.EntityFrameworkCore;
using Utility.Guard;

namespace Anu.PunishmentOrg.DataAccess.Notice
{
    public class PNoticeRepository : Anu.DataAccess.Repositories.GenericRepository<DataModel.Notice.PNotice>, Domain.Notice.IPNoticeRepository
    {
        public PNoticeRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<PNotice>> GetAllPNoticeByNationalCode(string NationalCode, Page page)
        {
            page.PageChecker("NoticeDate");

            var query = _context.Set<PNoticePerson>()
                .Include(a => a.ThePNotice)
                .Include(a => a.ThePCasePerson)
                .Where(a => a.ThePCasePerson.NationalCode == NationalCode)
                .Select(a => a.ThePNotice);

            var AllCount = await query
                .CountAsync();

            var notice = await query
                .AnuPagination(page)
                .ToListAsync();

            page.CalculateAllPage(AllCount);

            return notice;
        }
    }
}
