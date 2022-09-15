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
                                .ThenInclude(a => a.ThePNoticePersonList)
                                .ThenInclude(a => a.ThePCase)
                                //.Include(a => a.ThePCase)
                                //.Include(a => a.ThePCasePerson)
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

        public async Task<DataModel.Notice.PNotice> GetPNoticeByNo(string no)
        {
            return await _context.Set<PNotice>()
                                 .Where(a => a.No == no)
                                 .Include(a => a.TheUnit)
                                 .Include(a => a.TheGNoticeType)
                                 .Include(a => a.ThePNoticePersonList)
                                 .ThenInclude(a => a.ThePCasePerson)
                                 .ThenInclude(a => a.ThePCase)
                                 .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Anu.PunishmentOrg.DataModel.Notice.PNotice>> GetAllPNoticeByNationalCode(string nationalityCode)
        {
            var theNoticeListOfUser = await _context.Set<Anu.PunishmentOrg.DataModel.Notice.PNoticePerson>()
                                .Include(a => a.ThePNotice)
                                .Include(a => a.ThePCasePerson)
                                .Where(a => a.ThePCasePerson.NationalCode == nationalityCode)
                                .Select(a => a.ThePNotice).ToListAsync();


            return theNoticeListOfUser;

        }
    }
}
