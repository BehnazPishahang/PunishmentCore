using Anu.Commons.ServiceModel.ServicePaging;
using Anu.DataAccess;
using Anu.DataAccess.Repositories;
using Anu.PunishmentOrg.DataModel.Accounting;
using Anu.PunishmentOrg.DataModel.Notice;
using Anu.PunishmentOrg.Domain.Accounting;
using Anu.PunishmentOrg.Domain.PBillStore;
using Anu.Utility.Linq;
using Anu.Utility.Pagination;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.PunishmentOrg.DataAccess.Accounting
{
    public class PBill4PaidRepository : GenericRepository<DataModel.Accounting.PBill4Paid>, IPBill4PaidRepository
    {
        public PBill4PaidRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<List<PBill4Paid>> Get_PBill4PaidList_By_FishNo(string fishNo, Page page)
        {
            page.PageChecker("CreateDateTime");

            var query = _context.Set<PBill4Paid>()
                                .Where(a => a.FishNo == fishNo)
                                .Include(a => a.TheObjectState)
                                .Include(a => a.TheUnit)
                                .Include(a => a.ThePCasePerson);

            var AllCount = await query.CountAsync();

            var notice = await query.AnuPagination(page)
                                    .ToListAsync();

            page.CalculateAllPage(AllCount);

            return notice;
        }

        public async Task<List<PBill4Paid>> Get_PBill4PaidList_By_FishNo(string fishNo)
        {
            return await _context.Set<PBill4Paid>()
                                 .Where(a => a.FishNo == fishNo)
                                 .Include(a => a.TheObjectState)
                                 .Include(a => a.TheUnit)
                                 .Include(a => a.ThePCasePerson)
                                 .ToListAsync();
        }

        public async Task<List<PBill4Paid>> Get_PBill4PaidList_By_NationalCode(string nationalCode, Page page)
        {
            page.PageChecker("CreateDateTime");

            var query = _context.Set<PBill4Paid>()
                                .Where(a => a.ThePCasePerson.NationalCode == nationalCode)
                                .Include(a => a.TheObjectState)
                                .Include(a => a.TheUnit)
                                .Include(a => a.ThePCasePerson);

            var AllCount = await query.CountAsync();

            var notice = await query.AnuPagination(page)
                                    .ToListAsync();

            page.CalculateAllPage(AllCount);

            return notice;
        }

        public async Task<List<PBill4Paid>> Get_PBill4PaidList_By_NationalCode(string nationalCode)
        {
            return await _context.Set<PBill4Paid>()
                                 .Where(a => a.ThePCasePerson.NationalCode == nationalCode)
                                 .Include(a => a.TheObjectState)
                                 .Include(a => a.TheUnit)
                                 .Include(a => a.ThePCasePerson)
                                 .ToListAsync();
        }

        public async Task<PBill4Paid> Get_PBill4Paid_By_FishNo_With_ValidAccount(string fishNo)
        {
            return await _context.Set<PBill4Paid>()
                                 .Where(a => a.FishNo == fishNo &&
                                             a.TheAccounts.State == Anu.BaseInfo.Enumerations.State.Valid)
                                 .Include(a => a.TheAccounts)
                                 .FirstOrDefaultAsync();
        }
    }
}
