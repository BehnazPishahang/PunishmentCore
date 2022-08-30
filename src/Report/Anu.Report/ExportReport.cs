using Anu.Utility;
using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;

namespace Anu.Report
{
    public static class ExportReport
    {
        private static StiReport GetReport<T>(string path, string businessObjectName, T businessObjectData)
        {
            var fileInfo = new System.IO.FileInfo(typeof(StiReport).Assembly.Location);
            var mrtPath = System.IO.Path.Combine(fileInfo.Directory.FullName, path);
            var report = new StiReport();
            report.Load(mrtPath);

            report.Dictionary.Databases.Clear();

            report.RegBusinessObject(businessObjectName, businessObjectData);

            return report;
        }

        public static string ExportPdf<T>(this string report,string businessObjectName, T businessObjectData)
        {
            var result = StiNetCoreReportResponse.ResponseAsPdf(GetReport(report, businessObjectName, businessObjectData)).Data;
            return result.ConvertToBase64();
        }



    }

}
