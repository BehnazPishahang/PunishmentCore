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
        string[] gUnitTypeCodes = new string[] { "005", "013", "008", "010", "011",
            "012", "006","014","007","015","016" };
        string[] badviType = new string[] { "005", "013", "006", "014", "007", "015", "016" };
        string[] ejraType = new string[] { "008", "010", "011", "012" };
        int[] objectStateType = new int[] { 2, 4};

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
            var totalPcase = pCase.Count();

            var countParvandeJari = await _context.Set<Anu.PunishmentOrg.DataModel.Case.PCasePerson>()
                .Include(a => a.ThePCase)
                .Where(a => a.NationalCode == nationalCode && a.ThePCase.CaseArchiveState == PUCaseArchiveState.Active)
                .GroupBy(a => a.ThePCase.No)
                .CountAsync();



            return new Statistic() { CountTotal = totalPcase, CountSeen = totalPcase - countParvandeJari, CountUnSeen = countParvandeJari };
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

            if (pCase == null || pCase.Count() == 0)
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

            string createPcase = "پرونده در {0} در تاریخ {1} ثبت گردید .";
            string handlingPcaseWithPRegiterTimeCase = "برای پرونده در تاریخ {0} ساعت {1} تا {2} وقت رسیدگی تعیین شده است.";
            string handlingPcaseWithPSaftyWrit = "برای پرونده قرار {0} برای {1} صادر گردید.";
            string handlingPcaseWithPArrested = "برای {0} بازداشت صادر گردید .";

            string judgmentPJudgmentCase = "برای پرونده در تاریخ {0} رای صادر گردید.";
            string judgmentPRevisionRequestCase = "برای پرونده در تاریخ {0} {1} ثبت گردید.";

            string executionPcase = "پرونده در تاریخ {0} به {1} ارسال شد.";
            string executionPcash = "بابت جزای نقدی این پرونده مبلغ {0} ریال واریز شده است.";
            string executionPExecutionWrit = "پرونده در تاریخ {0} قرار {1} صادر گردید.";
            string executionPPrisoner = "برای {0} حبس صادر گردید.";
            string executionCaseArchiveState = "پرونده در اجرای احکام مختومه شد.";

            StringBuilder text = new StringBuilder();
            text.AppendLine();

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
                        text.AppendFormat(handlingPcaseWithPRegiterTimeCase, pr.ThePRegistaryTime.RegisterDate.Substring(0, 10), pr.ThePRegistaryTime.StartTime, pr.ThePRegistaryTime.EndTime).AppendLine();
                    }

                }
                //}

                //foreach (var item in pCase)
                //{
                var query2 = from safty in _context.Set<PSaftyWrit>()
                             where safty.ThePCase.Id == item.Id 
                             //&& objectStateType.Contains(safty.TheObjectState.StateType.GetEnumCode())
                             select safty;
                query2 = query2.Include(a => a.ThePCasePerson);
                query2 = query2.Include(a => a.TheObjectState);
                var a=query2.ToQueryString();
                var pSaftyWrit = await query2.ToListAsync();

                if (!pSaftyWrit.Null())
                {
                    pSaftyWrit=pSaftyWrit.Where(a => objectStateType.Contains(a.TheObjectState.StateType.GetEnumCode())).ToList();
                    foreach (var ps in pSaftyWrit)
                    {
                        text.AppendFormat(handlingPcaseWithPSaftyWrit, ps.SaftyWritType.GetEnmDescription(), ps.ThePCasePerson.Name + " " + ps.ThePCasePerson.Family).AppendLine();
                    }
                }
                //}

                //foreach (var item in pCase)
                //{
                var query3 = from arrest in _context.Set<PArrested>()
                             where arrest.ThePCase.Id == item.Id
                             select arrest;
                query3 = query3.Include(a => a.TheArrestedPerson);
                query3 = query3.Include(a => a.TheObjectState);
                var pArrested = await query3.ToListAsync();

                if (!pArrested.Null())
                {
                    pArrested = pArrested.Where(a => objectStateType.Contains(a.TheObjectState.StateType.GetEnumCode())).ToList();
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
                queryJudg = queryJudg.Include(a => a.ThePJudgment.TheObjectState);
                var pJudgmentCase = await queryJudg.ToListAsync();

                if (!pJudgmentCase.Null())
                {
                    pJudgmentCase = pJudgmentCase.Where(a => objectStateType.Contains(a.ThePJudgment.TheObjectState.StateType.GetEnumCode())).ToList();
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
                queryrevi = queryrevi.Include(a => a.ThePRevisionRequest.TheObjectState);
                var pRevisionRequest = await queryrevi.ToListAsync();

                if (!pRevisionRequest.Null())
                {
                    pRevisionRequest = pRevisionRequest.Where(a => objectStateType.Contains(a.ThePRevisionRequest.TheObjectState.StateType.GetEnumCode())).ToList();
                    foreach (var pr in pRevisionRequest)
                    {
                        text.AppendFormat(judgmentPRevisionRequestCase, pr.ThePRevisionRequest.CreateDateTime.Substring(0, 10), pr.ThePRevisionRequest.RequestSubject.GetEnmDescription()).AppendLine();
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

                var querypcash = from pcash in _context.Set<DataModel.Accounting.PCashCase>()
                                 where pcash.ThePCase.Id == item.Id
                                 select pcash;
                querypcash = querypcash.Include(a=>a.ThePCase).Include(a=>a.ThePCash);
                querypcash = querypcash.Include(a=>a.ThePCash.TheObjectState);
                var pCashCase = await querypcash.ToListAsync();

                if (!pCashCase.Null())
                {
                    pCashCase = pCashCase.Where(a => objectStateType.Contains(a.ThePCash.TheObjectState.StateType.GetEnumCode())).ToList();
                    foreach (var c in pCashCase)
                    {
                        text.AppendFormat(executionPcash, c.ThePCash.TotalPaidCost.ToCommaString()).AppendLine();
                    }
                }


                //foreach (var item in pCase)
                //{
                var querypexe = from pexe in _context.Set<DataModel.Execution.PExecutionWrit>()
                                where pexe.ThePCase.Id == item.Id
                                select pexe;
                querypexe = querypexe.Include(a => a.TheObjectState);

                var pExecutionWrit = await querypexe.ToListAsync();

                if (!pExecutionWrit.Null())
                {
                    pExecutionWrit = pExecutionWrit.Where(a => objectStateType.Contains(a.TheObjectState.StateType.GetEnumCode())).ToList();
                    foreach (var pe in pExecutionWrit)
                    {
                        text.AppendFormat(executionPExecutionWrit, pe.CreateDateTime.Substring(0,10), pe.WritType.GetEnmDescription()).AppendLine();
                    }

                }
                //}


                //foreach (var item in pCase)
                //{
                var queryppri = from ppri in _context.Set<PPrisoner>()
                                where ppri.ThePCase.Id == item.Id
                                select ppri;
                queryppri = queryppri.Include(a => a.ThePrisonPerson);
                queryppri = queryppri.Include(a => a.TheObjectState);
                var pPrisoner = await queryppri.ToListAsync();

                if (!pPrisoner.Null())
                {
                    pPrisoner = pPrisoner.Where(a => objectStateType.Contains(a.TheObjectState.StateType.GetEnumCode())).ToList();
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
