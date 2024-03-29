﻿using Anu.Commons.ServiceModel.ServicePaging;
using Anu.DataAccess.Repositories;
using Anu.PunishmentOrg.Domain.PGravamen;
using Anu.Utility.Linq;
using Anu.Utility.Pagination;
using Microsoft.EntityFrameworkCore;

namespace Anu.PunishmentOrg.DataAccess.PGravamen;

//! کل من علیها fun
public class PGravamenRepository : GenericRepository<DataModel.Gravamen.PGravamen>, IPGravamenRepository
{
    public PGravamenRepository(Anu.DataAccess.ApplicationDbContext context) : base(context)
    {

    }

    public async Task<DataModel.Gravamen.PGravamen> GetPGravamenByFollowUpNo(string followUpNo)
    {
        return await _context.Set<DataModel.Gravamen.PGravamen>()
                             .Where(a => a.FollowUpNo == followUpNo && a.GravamenOrReport == Enumerations.GravamenOrReport.Gravamen)
                             .Include(a => a.TheObjectState)
                             .Include(a => a.TheReceiveUnit)
                             .Include(a => a.TheReferUnit)
                             .Include(a => a.ThePCase)
                             .Include(a => a.ThePGravamenAttachmentList)
                             .ThenInclude(a => a.TheGAttachmentData)
                             .Include(a => a.ThePGravamenAttachmentList)
                             .ThenInclude(a => a.TheAttachmentType)
                             .Include(a => a.ThePGravamenPersonList)
                             .Include(a => a.ThePGravamenViolationList)
                             .Include(a => a.ThePGravamenNoticeHstList)
                             .Include(a => a.ThePGravamenRejectOrDefectRSList)
                             .ThenInclude(a => a.ThePBGravamenRejectDefectType)
                             .FirstOrDefaultAsync();
    }

    public async Task<DataModel.Gravamen.PGravamen> GetPGravamenById(string id)
    {
        return await _context.Set<DataModel.Gravamen.PGravamen>()
                             .Where(a => a.Id == id && a.GravamenOrReport == Enumerations.GravamenOrReport.Gravamen)
                             .Include(a => a.TheObjectState)
                             .Include(a => a.TheReceiveUnit)
                             .Include(a => a.TheReferUnit)
                             .Include(a => a.ThePCase)
                             .Include(a => a.ThePGravamenAttachmentList)
                             .ThenInclude(a => a.TheGAttachmentData)
                             .Include(a => a.ThePGravamenAttachmentList)
                             .ThenInclude(a => a.TheAttachmentType)
                             .Include(a => a.ThePGravamenPersonList)
                             .Include(a => a.ThePGravamenViolationList)
                             .Include(a => a.ThePGravamenNoticeHstList)
                             .Include(a => a.ThePGravamenRejectOrDefectRSList)
                             .ThenInclude(a => a.ThePBGravamenRejectDefectType)
                             .FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<DataModel.Gravamen.PGravamen>> GetPGravamenByPersonNationalCode(string nationalityCode , Page page)
    {
        page.PageChecker("CreateDateTime");

        var query = _context.Set<DataModel.Gravamen.PGravamenPerson>()
                            .Include(a => a.ThePGravamen)
                            .ThenInclude(a => a.TheObjectState)
                            .Include(a => a.ThePGravamen)
                            .ThenInclude(a => a.TheReceiveUnit)
                            .Include(a => a.ThePGravamen)
                            .ThenInclude(a => a.TheReferUnit)
                            .Include(a => a.ThePGravamen)
                            .ThenInclude(a => a.ThePCase)
                            .Include(a => a.ThePGravamen)
                            .ThenInclude(a => a.ThePGravamenRejectOrDefectRSList)
                            .ThenInclude(a => a.ThePBGravamenRejectDefectType)
                            .Include(a => a.ThePGravamen)
                            .Where(a => a.NationalCode == nationalityCode && a.PersonStartPost == Enumerations.PUPersonStartPost.PlaintiffPerson)
                            .Select(a => a.ThePGravamen);

        var AllCount = await query
            .CountAsync();

        var pGravamens = await query
            .AnuPagination(page).ToListAsync();

        page.CalculateAllPage(AllCount);

        return pGravamens;
    }

    public async Task<IEnumerable<DataModel.Gravamen.PGravamen>> GetPGravamenListByNationalCode(string nationalityCode)
    {
        var thePGravamenList = await _context.Set<Anu.PunishmentOrg.DataModel.Gravamen.PGravamenPerson>()
                                .Include(a => a.ThePGravamen)
                                .ThenInclude(a => a.TheObjectState)
                                .Where(a => a.NationalCode == nationalityCode)
                                .Select(a => a.ThePGravamen).ToListAsync();


        return thePGravamenList;
    }
}


