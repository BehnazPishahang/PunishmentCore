

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.ExchangeData
{
    public abstract class GMechanizedLetterTypeBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("NEEDRESULT")]
		public virtual Anu.Enumerations.HaveNoHave? NeedResult { get; set; }

		[Column("POSTTYPEACCESS")]
		public virtual string? PostTypeAccess { get; set; }

		[Column("RECEIVERTYPE")]
		public virtual Anu.Enumerations.MechanizedLetterOrgTypeReceiver? ReceiverType { get; set; }

		[Column("SENDERTYPE")]
		public virtual Anu.Enumerations.MechanizedLetterOrgTypeReceiver? SenderType { get; set; }

		[Column("STATE")]
		public virtual Anu.Enumerations.State? State { get; set; }

		[InverseProperty("TheGMechanizedLetterType")]
		public virtual List<Anu.BaseInfo.ExchangeData.GMechanizedLetterTypeField>? TheGMechanizedLetterTypeFieldList { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

		[Column("UNITLEVELACCESS")]
		public virtual string? UnitLevelAccess { get; set; }

		[Column("UNITTYPEACCESS")]
		public virtual string? UnitTypeAccess { get; set; }

    }
    [Table("GMECHANIZEDLETTERTYPE")]
    public partial class GMechanizedLetterType : GMechanizedLetterTypeBase { }

    }


