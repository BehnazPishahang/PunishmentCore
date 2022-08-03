using Anu.Commons.ServiceModel.ServicePaging;
using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Anu.DataAccess;
using Anu.PunishmentOrg.DataModel.Notice;
using Anu.Utility.Linq;
using Microsoft.EntityFrameworkCore;
using Utility.Guard;

namespace Anu.PunishmentOrg.DataAccess.Notice
{
    public class PNoticeRepository : Anu.DataAccess.Repositories.GenericRepository<DataModel.Notice.PNotice>, Domain.Notice.IPNoticeRepository
    {
        public PNoticeRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<PNotice>> GetAllPNoticeByNationalCode(string NationalCode, Page Page)
        {
            if (Page.OrderPage==null || Page.OrderPage.Property.NullOrWhiteSpace())
            {
                Page.OrderPage = new OrderPage() { Property = "NoticeDate", Ascending = true };
            }

            int AllCount = await _context.Set<PNoticePerson>()
                .Include(a => a.ThePNotice)
                .Include(a => a.ThePCasePerson)
                .Where(a => a.ThePCasePerson.NationalCode == NationalCode)
                .CountAsync();

            var notice = await _context.Set<PNoticePerson>()
                .Include(a => a.ThePNotice)
                .Include(a => a.ThePCasePerson)
                .Where(a => a.ThePCasePerson.NationalCode == NationalCode)
                .Select(a => a.ThePNotice)
                .Skip(Page.PageNumber)
                .Take(Page.RowCountPerPage)
                .PageOrderBy(Page.OrderPage, AnuResult.PropertyOrderNotFound)
                .ToListAsync();


            if (AllCount <= Page.RowCountPerPage)
            {
                Page.TotallPage = 1;
            }
            else
            {
                Page.TotallPage = (int)(AllCount / Page.RowCountPerPage);
            }

            return notice;
        }
    }
}
