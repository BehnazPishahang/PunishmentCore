
using Anu.PunishmentOrg.ServiceModel.ServiceContract;
using System.ComponentModel.DataAnnotations.Schema;
using Anu.PunishmentOrg.ServiceModel.BaseInfo;

namespace Anu.PunishmentOrg.ServiceModel.Gravamen
{
    [System.ComponentModel.DisplayName("علل رد/نقض شکوائيه در سرویس")]
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
