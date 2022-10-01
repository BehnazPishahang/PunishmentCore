
namespace Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes
{
    [System.ComponentModel.DisplayName("اسناد،اوراق و وسايل کشف شده صورتجلسه/گزارش کشف قاچاق/اسنادي در سرویس")]
    public class PDiscoveryMinutesDocFoundContract
    {
        public PDiscoveryMinutesDocFoundContract()
        {
        }
            
            [System.ComponentModel.DisplayName("شماره رسيد/قبض سازمان تحويل گيرنده ارز")]
        public string? BillNoDocFound { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره يا مشخصه")]
        public string? Characteristic { get; set; }

            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن شماره يا مشخصه")]
        public Anu.PunishmentOrg.Enumerations.CharacteristicDoc? CharacteristicRN { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تعداد")]
        public long? Count { get; set; }

            
            
            [System.ComponentModel.DisplayName("توضيحات")]
        public string? Description { get; set; }

            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن توضيحات")]
        public Anu.PunishmentOrg.Enumerations.DescriptionDoc? DescriptionRN { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("صادر کننده")]
        public string? Exporter { get; set; }

            
            
            [System.ComponentModel.DisplayName("تاريخ صدور")]
        public string? IssuingDate { get; set; }

            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن تاريخ صدور")]
        public Anu.PunishmentOrg.Enumerations.IssuingDateDoc? IssuingDateRN { get; set; }

            
            
            [System.ComponentModel.DisplayName("مالک ")]
        public string? Owner { get; set; }

            
            
            [System.ComponentModel.DisplayName("علت وارد نکردن مالک ")]
        public Anu.PunishmentOrg.Enumerations.OwnerDoc? OwnerRN { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره ترتيب")]
        public long? RowNumber { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("عنوان")]
        public string? SubjectTitle { get; set; }

            

    }
    }
