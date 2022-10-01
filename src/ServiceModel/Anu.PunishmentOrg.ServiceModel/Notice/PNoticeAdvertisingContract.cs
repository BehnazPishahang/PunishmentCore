
namespace Anu.PunishmentOrg.ServiceModel.Notice
{
    [System.ComponentModel.DisplayName("آگهي ابلاغ در سرویس")]
    public class PNoticeAdvertisingContract
    {
        public PNoticeAdvertisingContract()
        {
        }
            
            [System.ComponentModel.DisplayName("تاريخ انتشار")]
        public string? AdvertisingDate { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("تعداد دفعات انتشار")]
        public long? AdvertisingNumber { get; set; }

            
            
            [System.ComponentModel.DisplayName("متن آگهي")]
        public string? AdvertisingText { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("زمان ثبت")]
        public string? CreateDateTime { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("آيا آگهي چاپ شده")]
        public Anu.BaseInfo.Enumerations.YesNo? IsPrinted { get; set; }

            
            
            [System.ComponentModel.DisplayName("روزنامه انتشار دهنده")]
        public string? Newspaper { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره روزنامه")]
        public string? NewspaperNo { get; set; }

            
            
            [System.ComponentModel.DisplayName("شماره صفحه روزنامه")]
        public string? NewspaperPageNo { get; set; }

            
            
                [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره")]
        public string? No { get; set; }

            
            
            [System.ComponentModel.DisplayName("متن دستور انتشار آگهي")]
        public string? NoticeOrder { get; set; }

            
            
            [System.ComponentModel.DisplayName("تاريخ چاپ آگهي")]
        public string? PrintDate { get; set; }

            

    }
    }
