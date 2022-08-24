using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Anu.BaseInfo.DataModel.ExchangeData
{
    public abstract class GMechanizedLetterTypeBase : BaseInfoEntity<string>
    {

        [Unicode(false)]
        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("NEEDRESULT")]
        public virtual Anu.BaseInfo.Enumerations.HaveNoHave? NeedResult { get; set; }

        [Unicode(false)]
        [Column("POSTTYPEACCESS")]
        public virtual string? PostTypeAccess { get; set; }

        [Column("RECEIVERTYPE")]
        public virtual Anu.BaseInfo.Enumerations.MechanizedLetterOrgTypeReceiver? ReceiverType { get; set; }

        [Column("SENDERTYPE")]
        public virtual Anu.BaseInfo.Enumerations.MechanizedLetterOrgTypeReceiver? SenderType { get; set; }

        [Column("STATE")]
        public virtual Anu.BaseInfo.Enumerations.State? State { get; set; }

        [InverseProperty("TheGMechanizedLetterType")]
        public virtual List<Anu.BaseInfo.DataModel.ExchangeData.GMechanizedLetterTypeField>? TheGMechanizedLetterTypeFieldList { get; set; }

        [Unicode(false)]
        [Column("TITLE")]
        public virtual string? Title { get; set; }

        [Unicode(false)]
        [Column("UNITLEVELACCESS")]
        public virtual string? UnitLevelAccess { get; set; }

        [Unicode(false)]
        [Column("UNITTYPEACCESS")]
        public virtual string? UnitTypeAccess { get; set; }

        }

    [Table("GMECHANIZEDLETTERTYPE")]
    public partial class GMechanizedLetterType : GMechanizedLetterTypeBase
    {
    }
    }