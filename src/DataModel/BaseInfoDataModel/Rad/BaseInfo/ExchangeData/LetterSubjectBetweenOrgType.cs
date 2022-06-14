

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.ExchangeData
{
    public abstract class LetterSubjectBetweenOrgTypeBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("ORG4EXCHANGEDATA")]
		public virtual Rad.CMS.Enumerations.Org4ExchangeData? Org4ExchangeData { get; set; }

		[Column("ORGSENDERTYPE")]
		public virtual Rad.CMS.Enumerations.OrgSenderType? OrgSenderType { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? State { get; set; }

		[InverseProperty("TheLetterSubjectBetweenOrgType")]
		public virtual List<Rad.BaseInfo.ExchangeData.LetterSubjectField>? TheLetterSubjectFieldList { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("LETTERSUBJECTBETWEENORGTYPE")]
    public partial class LetterSubjectBetweenOrgType : LetterSubjectBetweenOrgTypeBase { }

    }


