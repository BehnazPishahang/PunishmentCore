
namespace Anu.PunishmentOrg.ServiceModel.Gravamen
{
    [System.ComponentModel.DisplayName("تخلفات شکوائیه/گزارش مردمی در سرویس")]
    public class PGravamenViolationContract
    {
        public PGravamenViolationContract()
        {
        }


        [System.ComponentModel.DisplayName("شماره ترتیب")]
        public virtual long? RowNumber { get; set; }

        [System.ComponentModel.DisplayName("عنوان موضوع")]
        public virtual string? SubjectTitle { get; set; }

        [System.ComponentModel.DisplayName("نشانی جغرافیایی محل وقوع/کشف تخلف")]
        public virtual Anu.BaseInfo.DataModel.GeoInfo.GeoLocation? TheGeoLocation { get; set; }

        [System.ComponentModel.DisplayName("نوع تخلف/اتهام/خواسته")]
        public virtual Anu.PunishmentOrg.DataModel.BaseInfo.PBViolationType? ThePBViolationType { get; set; }

        [System.ComponentModel.DisplayName("شکوائیه/گزارش مردمی")]
        public virtual Anu.PunishmentOrg.DataModel.Gravamen.PGravamen? ThePGravamen { get; set; }

        [System.ComponentModel.DisplayName("نشانی محل وقوع/کشف تخلف")]
        public virtual string? ViolationAddress { get; set; }

        [System.ComponentModel.DisplayName("تاریخ وقوع تخلف")]
        public virtual string? ViolationDate { get; set; }

        [System.ComponentModel.DisplayName("توضیحات")]
        public virtual string? ViolationDesc { get; set; }

        [System.ComponentModel.DisplayName("ارزش مالی تخلف")]
        public virtual long? ViolationPrice { get; set; }

    }
}
