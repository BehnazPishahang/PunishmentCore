
namespace Anu.PunishmentOrg.ServiceModel.Gravamen
{
    [System.ComponentModel.DisplayName("اعتراض موضوع تبصره 1 ماده 21  قانون مبارزه با قاچاق کالا و ارز در سرویس")]
    public class PNote1Article21ProtestContract
    {
        public PNote1Article21ProtestContract()
        {
        }
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("زمان ثبت")]
        public string? CreateDateTime { get; set; }

            
            
            [System.ComponentModel.DisplayName("تاريخ صورتجلسه کشف مربوطه")]
        public string? DiscoveryMinutesDate { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره صورتجلسه کشف مربوطه")]
        public string? DiscoveryMinutesNo { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره")]
        public string? No { get; set; }

            
            
            [System.ComponentModel.DisplayName("تاريخ ارجاع اعتراض به شعبه")]
        public string? ReferDate { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("جهات اعتراض")]
        public string? RequestReason { get; set; }

            

    }
    }
