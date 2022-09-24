
using Anu.PunishmentOrg.ServiceModel.ServiceContract;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.ServiceModel.Gravamen
{
    [System.ComponentModel.DisplayName("شکوائیه/گزارش مردمی در سرویس")]
    public class PBGravamenRejectDefectTypeContract
    {
        public PBGravamenRejectDefectTypeContract()
        {
        }

        [System.ComponentModel.DisplayName("كد")]
        public string? Code { get; set; }



        [System.ComponentModel.DisplayName("علت رد")]
        public Anu.PunishmentOrg.Enumerations.RejectOrDefect? RejectOrDefect { get; set; }



        [System.ComponentModel.DisplayName("وضعيت")]
        public Anu.BaseInfo.Enumerations.State? State { get; set; }


        
        [System.ComponentModel.DisplayName("عنوان")]
        public string? Title { get; set; }
    }
}
