using Anu.DataAccess;
using Anu.PunishmentOrg.DataModel.Notice;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataAccess.Notice
{
    public class PNoticeRepository : Anu.DataAccess.Repositories.GenericRepository<DataModel.Notice.PNotice>, Domain.Notice.IPNoticeRepository
    {
        public PNoticeRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<PNotice>> GetAllPNoticeByNationalCode(string NationalCode)
        {
            var notice = await _context.Set<PNoticePerson>()
                .Include(a => a.ThePNotice)
                .Include(a => a.ThePCasePerson)
                .Where(a => a.ThePCasePerson.NationalCode == NationalCode)
                .Select(a => a.ThePNotice)
                .ToListAsync();

            return notice;
        }
    }
}
