using Anu.PunishmentOrg.DataModel;
using Anu.PunishmentOrg.DataModel.ArrestSaftyWrit;
using Anu.PunishmentOrg.DataModel.Case;
using Anu.PunishmentOrg.DataModel.Execution;
using Anu.PunishmentOrg.DataModel.Letter;
using Anu.PunishmentOrg.DataModel.Terminate;
using Anu.PunishmentOrg.Domain.Case;
using Anu.PunishmentOrg.Enumerations;
using Anu.Utility;
using Microsoft.EntityFrameworkCore;
using System.Text;
using Utility.Guard;

namespace Anu.PunishmentOrg.DataAccess.PCase
{
    public class PCaseRepository : Anu.DataAccess.Repositories.GenericRepository<Anu.PunishmentOrg.DataModel.Case.PCase>, Domain.Case.IPCaseRepository
    {
        string[] gUnitTypeCodes = new string[] { "005", "013", "008", "010", "011", "012" };
        string[] badviType = new string[] { "005", "013" };
        string[] ejraType = new string[] { "008", "010", "011", "012" };

        public PCaseRepository(Anu.DataAccess.ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Anu.PunishmentOrg.DataModel.Case.PCase>> GetPCaseByNo(string no)
        {
            return await _context.Set<Anu.PunishmentOrg.DataModel.Case.PCase>()
                .Include(x => x.TheHandlerUnit)
                .ThenInclude(x => x.TheGUnitType)
                .Where(a => a.No == no)
                .ToListAsync();
        }

        public async Task<Anu.PunishmentOrg.DataModel.Case.PCase> GetOnePCaseByNo(string no)
        {
            return await _context.Set<Anu.PunishmentOrg.DataModel.Case.PCase>().Where(x => x.No == no).FirstOrDefaultAsync();
        }

        public async Task<Statistic> GetStatistic(string nationalCode)
        {
            var pCase = await GetAllPCaseWithNationalCode(nationalCode);
            if (pCase == null || pCase.Count() == 0)
            {
                return new Statistic() { CountTotal = 0, CountSeen = 0, CountUnSeen = 0 };
            }

            return new Statistic() { CountTotal = pCase.Count(), CountSeen = 0, CountUnSeen = 0 };
        }

        public async Task<IEnumerable<DataModel.Case.PCase>> GetAllPCaseWithNationalCode(string nationalCode)
        {

            var query = from pcase in _context.Set<Anu.PunishmentOrg.DataModel.Case.PCase>()
                        where gUnitTypeCodes.Contains(pcase.TheHandlerUnit.TheGUnitType.Code) &&
                        pcase.CaseType == Enumerations.PUCaseType.MainCase &&
                        pcase.SubNo == 1 &&
                        (from person in _context.Set<PCasePerson>()
                         where person.ThePCase.Id == pcase.Id && person.NationalCode == nationalCode
                         select 1).Any()
                        select pcase;
            query = query.Include(a => a.TheHandlerUnit).ThenInclude(a => a.TheGUnitType);

            var pCase = await query.ToListAsync();

            if (pCase==null || pCase.Count()==0)
            {
                return null;
            }

            return pCase;
        }

        public async Task<string> ExportInqueryPCase(string nationalCode, string no)
        {
            var query = from pcase in _context.Set<Anu.PunishmentOrg.DataModel.Case.PCase>()
                        where gUnitTypeCodes.Contains(pcase.TheHandlerUnit.TheGUnitType.Code) &&
                        pcase.CaseType == Enumerations.PUCaseType.MainCase &&
                        pcase.No == no &&
                        (from person in _context.Set<PCasePerson>()
                         where person.ThePCase.Id == pcase.Id && person.NationalCode == nationalCode
                         select 1).Any()
                        orderby pcase.SubNo, pcase.CreateDateTime ascending
                        select pcase;
            var queryNew = query.Include(a => a.TheHandlerUnit).ThenInclude(a => a.TheGUnitType);

            var pCase = await queryNew.ToListAsync();
            if (pCase == null || pCase.Count() == 0)
            {
                return null;
            }

            string createPcase = "پرونده در شعبه {0} در تاریخ {1} ثبت گردید .";
            string handlingPcaseWithPRegiterTimeCase = "برای پرونده در تاریخ {0} ساعت {1} وقت رسیدگی تعیین شده است.";
            string handlingPcaseWithPSaftyWrit = "برای پرونده قرار {0} برای {1} صادر گردید.";
            string handlingPcaseWithPArrested = "برای {0} بازداشت صادر گردید .";

            string judgmentPJudgmentCase = "برای پرونده در تاریخ {0} رای صادر گردید.";
            string judgmentPRevisionRequestCase = "برای پرونده در تاریخ {0} {1} ثبت گردید.";

            string executionPcase = "پرونده در تاریخ {0} به {1} ارسال شد.";
            string executionPExecutionWrit = "پرونده در تاریخ {0} قرار {1} صادر گردید.";
            string executionPPrisoner = "برای {0} حبس صادر گردید.";
            string executionCaseArchiveState = "پرونده در اجرای احکام مختومه شد.";

            StringBuilder text = new StringBuilder();

            #region تشکیل پرونده
            foreach (var item in pCase)
            {
                if (badviType.Contains(item.TheHandlerUnit.TheGUnitType.Code))
                {
                    text.AppendFormat(createPcase, item.TheHandlerUnit.UnitName, item.CreateDateTime.Substring(0, 10)).AppendLine();
                }
                //}
                #endregion

                #region رسیدگی پرونده
                //foreach (var item in pCase)
                //{
                var query1 = from timeCase in _context.Set<PRegistaryTimeCase>()
                             where timeCase.ThePCase.Id == item.Id &&
                             timeCase.ThePRegistaryTime.TimeType == PURegisterTimeType.Disposition
                             orderby timeCase.ThePRegistaryTime.RegisterDate descending
                             select timeCase;
                var query11 = query1.Include(a => a.ThePRegistaryTime);
                var pRegistaryTimeCase = await query11.ToListAsync();

                if (!pRegistaryTimeCase.Null())
                {
                    foreach (var pr in pRegistaryTimeCase)
                    {
                        text.AppendFormat(handlingPcaseWithPRegiterTimeCase, pr.ThePRegistaryTime.RegisterDate.Substring(0, 10), pr.ThePRegistaryTime.RegisterDate.Substring(11)).AppendLine();
                    }

                }
                //}

                //foreach (var item in pCase)
                //{
                var query2 = from safty in _context.Set<PSaftyWrit>()
                             where safty.ThePCase.Id == item.Id
                             select safty;
                query2 = query2.Include(a => a.ThePCasePerson);
                var pSaftyWrit = await query2.ToListAsync();

                if (!pSaftyWrit.Null())
                {
                    foreach (var ps in pSaftyWrit)
                    {
                        text.AppendFormat(handlingPcaseWithPSaftyWrit, ps.SaftyWritType.GetDescription(), ps.ThePCasePerson.Name + " " + ps.ThePCasePerson.Family).AppendLine();
                    }
                }
                //}

                //foreach (var item in pCase)
                //{
                var query3 = from arrest in _context.Set<PArrested>()
                             where arrest.ThePCase.Id == item.Id
                             select arrest;
                query3 = query3.Include(a => a.TheArrestedPerson);
                var pArrested = await query3.ToListAsync();

                if (!pArrested.Null())
                {
                    foreach (var pa in pArrested)
                    {
                        text.AppendFormat(handlingPcaseWithPArrested, pa.TheArrestedPerson.Name + " " + pa.TheArrestedPerson.Family).AppendLine();
                    }
                }
                //}
                #endregion

                #region صدور دادنامه

                //foreach (var item in pCase)
                //{
                var queryJudg = from judg in _context.Set<PJudgmentCase>()
                                where judg.ThePCase.Id == item.Id
                                select judg;
                queryJudg = queryJudg.Include(a => a.ThePJudgment);
                var pJudgmentCase = await queryJudg.ToListAsync();

                if (!pJudgmentCase.Null())
                {
                    foreach (var pj in pJudgmentCase)
                    {
                        text.AppendFormat(judgmentPJudgmentCase, pj.ThePJudgment.JudgeDateTime.Substring(0, 10)).AppendLine();
                    }

                }
                //}


                //foreach (var item in pCase)
                //{
                var queryrevi = from revi in _context.Set<PRevisionRequestCase>()
                                where revi.ThePCase.Id == item.Id
                                select revi;
                queryrevi = queryrevi.Include(a => a.ThePRevisionRequest);
                var pRevisionRequest = await queryrevi.ToListAsync();

                if (!pRevisionRequest.Null())
                {
                    foreach (var pr in pRevisionRequest)
                    {
                        text.AppendFormat(judgmentPRevisionRequestCase, pr.ThePRevisionRequest.CreateDateTime.Substring(0, 10), pr.ThePRevisionRequest.RequestSubject).AppendLine();
                    }

                }
                //}

                #endregion


                #region اجرا احکام

                //foreach (var item in pCase)
                //{
                if (ejraType.Contains(item.TheHandlerUnit.TheGUnitType.Code))
                {
                    text.AppendFormat(executionPcase, item.CreateDateTime.Substring(0, 10), item.TheHandlerUnit.UnitName).AppendLine();
                }
                //}


                //foreach (var item in pCase)
                //{
                var querypexe = from pexe in _context.Set<DataModel.Execution.PExecutionWrit>()
                                where pexe.ThePCase.Id == item.Id
                                select pexe;
                var pExecutionWrit = await querypexe.ToListAsync();

                if (!pExecutionWrit.Null())
                {
                    foreach (var pe in pExecutionWrit)
                    {
                        text.AppendFormat(executionPExecutionWrit, pe.CreateDateTime, pe.WritType.GetDescription()).AppendLine();
                    }

                }
                //}


                //foreach (var item in pCase)
                //{
                var queryppri = from ppri in _context.Set<PPrisoner>()
                                where ppri.ThePCase.Id == item.Id
                                select ppri;
                queryppri = queryppri.Include(a => a.ThePrisonPerson);
                var pPrisoner = await queryppri.ToListAsync();

                if (!pPrisoner.Null())
                {
                    foreach (var pp in pPrisoner)
                    {
                        text.AppendFormat(executionPPrisoner, pp.ThePrisonPerson.Name + " " + pp.ThePrisonPerson.Family).AppendLine();
                    }

                }
                //}

                //foreach (var item in pCase)
                //{
                if (item.CaseArchiveState == PUCaseArchiveState.Closed)
                {
                    text.Append(executionCaseArchiveState).AppendLine();
                }

                text.Append("----------------------------------------").AppendLine();
            }

            #endregion

            return text.ToString();
        }
    }
}
