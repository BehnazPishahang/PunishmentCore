
namespace Anu.PunishmentOrg.ServiceModel.Notice
{
    [System.ComponentModel.DisplayName("ابلاغنامه در سرویس")]
    public class PNoticeContract
    {
        public PNoticeContract()
        {
        }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("زمان ثبت")]
        public string? CreateDateTime { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("شماره")]
        public string? No { get; set; }



        [System.ComponentModel.DisplayName("تاريخ ابلاغ")]
        public string? NoticeDate { get; set; }



        [System.ComponentModel.DisplayName("نام خانوادگي ابلاغ شونده")]
        public string? NoticePersonFamily { get; set; }



        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DisplayName("نام ابلاغ شونده")]
        public string? NoticePersonName { get; set; }



    }
}
