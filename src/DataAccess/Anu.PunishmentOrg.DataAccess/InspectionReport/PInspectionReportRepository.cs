using Anu.DataAccess;
using Anu.PunishmentOrg.DataModel.InspectionReport;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataAccess.InspectionReport
{
    public class PInspectionReportRepository : Anu.DataAccess.Repositories.GenericRepository<DataModel.InspectionReport.PInspectionReport>, Domain.InspectionReport.IPInspectionReportRepository
    {
        public PInspectionReportRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<PInspectionReport> GetPInspectionReportByUniqueNo(string UniqueNo)
        {
            var result = await _context.Set<PInspectionReport>()
                .Include(a=>a.TheObjectState)
                .Include(a=>a.ThePCase)
                .Where(a=>a.No == UniqueNo)
                .OrderByDescending(a=>a.SubNo)
                .ToListAsync();
            return result[0];
        }
    }
}
