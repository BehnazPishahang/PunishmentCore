
namespace Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes
{
    [System.ComponentModel.DisplayName("سند مورد بازرسي درخواست مجوز تعقيب بازرسي در سرویس")]
    public class PChaseLicenseReqDocContract
    {
        public PChaseLicenseReqDocContract()
        {
        }
            
            [System.ComponentModel.DisplayName("نتيجه درخواست")]
        public Anu.PunishmentOrg.Enumerations.PUConclusion? ConclusionRequest { get; set; }

            
            
            [System.ComponentModel.DisplayName("تاريخ سند")]
        public string? DocDate { get; set; }

            
            
            [System.ComponentModel.DisplayName("شناسه یکتای سند")]
        public long? DocId { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره سند")]
        public string? DocNo { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("عنوان سند")]
        public string? DocTitle { get; set; }

            
            
            [System.ComponentModel.DisplayName("مرجع صادر کننده سند")]
        public string? IssuerUnit { get; set; }

            
            
            [System.ComponentModel.DisplayName("عادي/رسمي بودن سند")]
        public Anu.PunishmentOrg.Enumerations.DocIssueType? IssueType { get; set; }

            
            
            [System.ComponentModel.DisplayName("نوع مالکيت سند")]
        public Anu.PunishmentOrg.Enumerations.OwnershipType? OwnershipType { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره ترتيب")]
        public long? RowNumber { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("درخواست 4گانه(مجوز بازرسی-تکمیل تحقیقات-اعلام تخلف-تایید مجوز شفاهی) و پاسخ آن در سرویس")]
        public Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes.PChaseLicenseReqContract? ThePChaseLicenseReqContract { get; set; }

            

    }
    }
