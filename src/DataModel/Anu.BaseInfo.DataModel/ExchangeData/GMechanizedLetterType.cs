

using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.DataModel.ExchangeData
{
    public abstract class GMechanizedLetterTypeBase : BaseInfoEntity<string>
    {

        [Column("CODE")]
        public virtual string? Code { get; set; }

        [Column("NEEDRESULT")]
        public virtual Anu.BaseInfo.Enumerations.HaveNoHave? NeedResult { get; set; }

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

        [Column("TITLE")]
        public virtual string? Title { get; set; }

        [Column("UNITLEVELACCESS")]
        public virtual string? UnitLevelAccess { get; set; }

        [Column("UNITTYPEACCESS")]
        public virtual string? UnitTypeAccess { get; set; }

    }

    [Table("GMECHANIZEDLETTERTYPE")]
    public partial class GMechanizedLetterType : GMechanizedLetterTypeBase
    {
    }
}