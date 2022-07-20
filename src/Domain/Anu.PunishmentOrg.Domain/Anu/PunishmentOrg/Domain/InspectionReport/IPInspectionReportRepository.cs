namespace Anu.PunishmentOrg.Domain.InspectionReport
{
    public interface IPInspectionReportRepository : Anu.Domain.IGenericRepository<DataModel.InspectionReport.PInspectionReport>
    {
        public Task<DataModel.InspectionReport.PInspectionReport> GetPInspectionReportByUniqueNo(string UniqueNo);

    }
}
