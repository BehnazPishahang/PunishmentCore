
namespace Anu.PunishmentOrg.ServiceModel.Destroyed
{
    [System.ComponentModel.DisplayName("پرونده امحاء در سرویس")]
    public class PDestroyedCaseContract
    {
        public PDestroyedCaseContract()
        {
        }
            
            [System.ComponentModel.DisplayName("شماره پرونده در سامانه سمپ و سامانه های قدیمی")]
        public string? CMSNo { get; set; }

            
            
            [System.ComponentModel.DisplayName("زمان تاييد و قرار گرفتن پرونده در گوني/کارتن")]
        public string? ConfirmDateTime { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("زمان ثبت")]
        public string? CreateDateTime { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره امحاي پرونده")]
        public string? DestroyedNo { get; set; }

            
            
            [System.ComponentModel.DisplayName("تاريخ مختومه شدن نهايي پرونده")]
        public string? EndDate { get; set; }

            
            
            [System.ComponentModel.DisplayName("سال مختومه شدن نهايي پرونده")]
        public string? EndYear { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تعداد اوراق پرونده")]
        public long? PageNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("عنوان گزارش دهنده")]
        public string? ReporterOrg { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره طبقه پرونده از نظر امحاء")]
        public Anu.PunishmentOrg.Enumerations.DestroyedCaseStep? StepNo { get; set; }

            

    }
    }
