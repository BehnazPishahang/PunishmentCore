
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceContract
{
    [System.ComponentModel.DisplayName("سند مورد بازرسي درخواست مجوز تعقيب بازرسي")]
    public class PChaseLicenseReqDoc
    {
        public PChaseLicenseReqDoc()
        {
        }
            
            [System.ComponentModel.DisplayName("نتيجه درخواست")]
            public DataModel.Anu.Enumerations.PunishmentOrg.PUConclusion ConclusionRequest { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("تاريخ سند")]
            public string DocDate { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("شماره سند")]
            public string DocNo { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("عنوان سند")]
            public string DocTitle { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("مرجع صادر کننده سند")]
            public string IssuerUnit { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("عادي/رسمي بودن سند")]
            public DataModel.Anu.Enumerations.PunishmentOrg.DocIssueType IssueType { get; set ;} 
            
            
            [System.ComponentModel.DisplayName("نوع مالکيت سند")]
            public DataModel.Anu.Enumerations.PunishmentOrg.OwnershipType OwnershipType { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره ترتيب")]
            public long? RowNumber { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("ورودي سرويس درخواست مجوز تعقيب/بازرسي")]
            public Anu.PunishmentOrg.ServiceContract.PChaseLicenseReq ThePChaseLicenseReq { get; set ;} 
            

    }
    }
