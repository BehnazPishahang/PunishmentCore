
namespace Anu.PunishmentOrg.ServiceModel.Destroyed
{
    [System.ComponentModel.DisplayName("فهرست اوراق داراي مجوز امحاء-فرم 4 در سرویس")]
    public class PDestroyedLicenseContract
    {
        public PDestroyedLicenseContract()
        {
        }
            
            [System.ComponentModel.DisplayName("نشاني بايگاني")]
        public string? ArchiveAddress { get; set; }

            
            
            [System.ComponentModel.DisplayName("مساحت بايگاني")]
        public long? ArchiveArea { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("زمان ثبت")]
        public string? CreateDateTime { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام خانوادگي مقام درخواست کننده")]
        public string? Family { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تاريخ تنظيم")]
        public string? IssueDate { get; set; }

            
            
            [System.ComponentModel.DisplayName("نام مقام درخواست کننده")]
        public string? Name { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره فرم")]
        public string? No { get; set; }

            
            
            [System.ComponentModel.DisplayName("جمع کل اوراق امحايي")]
        public long? PageSum { get; set; }

            
            
            [System.ComponentModel.DisplayName("تاريخ درخواست")]
        public string? ReqDate { get; set; }

            

    }
    }
