
using Anu.PunishmentOrg.ServiceModel.ServiceContract;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.ServiceModel.Gravamen
{
    [System.ComponentModel.DisplayName("تاریخچه شکوائیه در سرویس")]
    public class PGravamenNoticeHstContract
    {
        public PGravamenNoticeHstContract()
        {

        }



        [System.ComponentModel.DisplayName("تاریخ ابلاغ")]
        public string IssueDateTime { get; set; }



        [System.ComponentModel.DisplayName("متن ابلاغ")]
        public string NoticeText { get; set; }



        [System.ComponentModel.DisplayName("نوع ابلاغ")]
        public Anu.PunishmentOrg.Enumerations.GravamenNoticeType? NoticeType { get; set; }
    }
}
