

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.NewExchangeData
{
    public abstract class GBNWMechanizedLetterTypeBase : BaseInfoEntity<string>
    {

		[Column("CASENULLABLE")]
		public virtual Rad.CMS.Enumerations.YesNo? CaseNullable { get; set; }

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("NEEDRESULT")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? NeedResult { get; set; }

		[Column("POSTTYPEACCESS")]
		public virtual string? PostTypeAccess { get; set; }

		[Column("RECEIVERTYPE")]
		public virtual Rad.CMS.Enumerations.MechanizedLetterOrgTypeReceiver? ReceiverType { get; set; }

		[Column("SENDERTYPE")]
		public virtual Rad.CMS.Enumerations.MechanizedLetterOrgTypeReceiver? SenderType { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? State { get; set; }

		[InverseProperty("TheGBNWMechanizedLetterType")]
		public virtual List<Rad.BaseInfo.NewExchangeData.GBNWMechanizedLtrTpTemplate>? TheGBNWMechanizedLtrTpTemplateList { get; set; }

		[InverseProperty("TheGBNWMechanizedLetterType")]
		public virtual List<Rad.BaseInfo.NewExchangeData.GBNWMechanizedLtrTypeField>? TheGBNWMechanizedLtrTypeFieldList { get; set; }

		[InverseProperty("TheGBNWMechanizedLetterType")]
		public virtual List<Rad.BaseInfo.NewExchangeData.GBNWMechanizLetTypeInOrg>? TheGBNWMechanizLetTypeInOrgList { get; set; }

		[InverseProperty("TheGBNWMechanizedLetterType")]
		public virtual List<Rad.BaseInfo.NewExchangeData.GBNWMechanizLetTypeOutOrg>? TheGBNWMechanizLetTypeOutOrgList { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

		[Column("UNITLEVELACCESS")]
		public virtual string? UnitLevelAccess { get; set; }

		[Column("UNITTYPEACCESS")]
		public virtual string? UnitTypeAccess { get; set; }

    }
    [Table("GBNWMECHANIZEDLETTERTYPE")]
    public partial class GBNWMechanizedLetterType : GBNWMechanizedLetterTypeBase { }

    }


