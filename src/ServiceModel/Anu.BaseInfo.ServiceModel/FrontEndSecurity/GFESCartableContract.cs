
namespace Anu.BaseInfo.ServiceModel.FrontEndSecurity
{
    [System.ComponentModel.DisplayName("کارتابل کاربران خارج از سازمان در سرویس")]
    public class GFESCartableContract
    {
        public GFESCartableContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("زمان ايجاد")]
        public string? CreateDateTime { get; set; }

            
            
            [System.ComponentModel.DisplayName("شرح 1")]
        public string? Desc1 { get; set; }

            
            
            [System.ComponentModel.DisplayName("شرح 2")]
        public string? Desc2 { get; set; }

            
            
            [System.ComponentModel.DisplayName("شرح 3")]
        public string? Desc3 { get; set; }

            
            
            [System.ComponentModel.DisplayName("زمان آخرين اقدام")]
        public string? LastActionDateTime { get; set; }

            
            
            [System.ComponentModel.DisplayName("شناسه پرونده مرتبط")]
        public string? RelatedCaseId { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره پرونده مرتبط")]
        public string? RelatedCaseNo { get; set; }

            
            
            [System.ComponentModel.DisplayName("شناسه مدرک مرتبط")]
        public string? RelatedDocId { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره مدرک مرتبط")]
        public string? RelatedDocNo { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("وضعيت")]
        public Anu.BaseInfo.Enumerations.WorkFlowActivityInstanceState? State { get; set; }

            

    }
    }
