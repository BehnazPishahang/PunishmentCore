
using Anu.PunishmentOrg.ServiceModel.ServiceContract;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.ServiceModel.Gravamen
{
    [System.ComponentModel.DisplayName("دلایل رد / نقص شکوائیه در سرویس")]
    public class PGravamenRejectOrDefectRSContract
    {
        public PGravamenRejectOrDefectRSContract()
        {
            ThePBGravamenRejectDefectType = new PBGravamenRejectDefectTypeContract();
        }

        [System.ComponentModel.DisplayName("دلایل رد")]
        public PBGravamenRejectDefectTypeContract ThePBGravamenRejectDefectType { get; set; }
    }
}
