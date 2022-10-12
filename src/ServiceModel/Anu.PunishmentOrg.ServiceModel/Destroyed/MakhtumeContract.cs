
namespace Anu.PunishmentOrg.ServiceModel.Destroyed
{
    [System.ComponentModel.DisplayName("مختومه در سرویس")]
    public class MakhtumeContract
    {
        public MakhtumeContract()
        {
        }
            
            [System.ComponentModel.DisplayName("کد رای")]
        public string? CODERAY { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره دادنامه")]
        public string? DADNAME { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام خانوادگی")]
        public string? FAMILY { get; set; }

            
            
            [System.ComponentModel.DisplayName("آیا رکورد جاری، از نظر پرونده در سازمان ملاک است")]
        public Anu.BaseInfo.Enumerations.YesNo? IsOrgMainRecordCase { get; set; }

            
            
            [System.ComponentModel.DisplayName("آیا رکورد جاری، از نظر متهم-تخلف-شعبه ملاک است")]
        public Anu.BaseInfo.Enumerations.YesNo? IsStepMainRecordCase { get; set; }

            
            
            [System.ComponentModel.DisplayName("مرحله رسیدگی")]
        public string? MARHALE { get; set; }

            
            
            [System.ComponentModel.DisplayName("کد مرحله رسیدگی")]
        public string? MARHALECODE { get; set; }

            
            
            [System.ComponentModel.DisplayName("مرجع اعلام کننده")]
        public string? MARJA { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام")]
        public string? NAME { get; set; }

            
            
            [System.ComponentModel.DisplayName("نوبت رسیدگی")]
        public string? NOBAT { get; set; }

            
            
            [System.ComponentModel.DisplayName("کد نوبت رسیدگی")]
        public string? NOBATCODE { get; set; }

            
            
            [System.ComponentModel.DisplayName("نوع شعبه")]
        public string? NOSHOBE { get; set; }

            
            
            [System.ComponentModel.DisplayName("کد نوع شعبه")]
        public string? NOSHOBECODE { get; set; }

            
            
            [System.ComponentModel.DisplayName("استان")]
        public string? OSTAN { get; set; }

            
            
            [System.ComponentModel.DisplayName("کد استان")]
        public string? OSTANCODE { get; set; }

            
            
            [System.ComponentModel.DisplayName("ردیف متهم")]
        public string? RAIFMOT { get; set; }

            
            
            [System.ComponentModel.DisplayName("عنوان رای")]
        public string? RAY { get; set; }

            
            
            [System.ComponentModel.DisplayName("ردیف تخلف")]
        public string? RTAKH { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره گزارش بازرسی")]
        public string? SHGOZARESH { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره پرونده")]
        public string? SHM { get; set; }

            
            
            [System.ComponentModel.DisplayName("شعبه")]
        public string? SHOBE { get; set; }

            
            
            [System.ComponentModel.DisplayName("کد شعبه")]
        public string? SHOBECODE { get; set; }

            
            
            [System.ComponentModel.DisplayName("عنوان تخلف")]
        public string? TAKH { get; set; }

            
            
            [System.ComponentModel.DisplayName("کد تخلف")]
        public string? TAKHCODE { get; set; }

            
            
            [System.ComponentModel.DisplayName("واحد تعزیراتی")]
        public string? VAHED { get; set; }

            
            
            [System.ComponentModel.DisplayName("کد واحد تعزیراتی")]
        public string? VAHEDCODE { get; set; }

            

    }
    }
