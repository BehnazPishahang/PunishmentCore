

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.Types
{
    public abstract class GMechanizedLetterTypeBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("ENMGENERALORGANIZATIONTYPE")]
		public virtual Rad.CMS.Enumerations.GeneralOrganizationType? enmGeneralOrganizationType { get; set; }

		[Column("INFORMATIONFIELD")]
		public virtual string? InformationField { get; set; }

		[Column("INPUTOUTPUT")]
		public virtual Rad.CMS.Enumerations.LetterSubjectType? InputOutput { get; set; }

		[Column("MECHANIZESTATE")]
		public virtual Rad.CMS.Enumerations.CaseMechanizeState? MechanizeState { get; set; }

		[Column("NEEDRESULT")]
		public virtual Rad.CMS.Enumerations.HaveNoHave? NeedResult { get; set; }

		[Column("POSTTYPEACCESS")]
		public virtual string? PostTypeAccess { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.State? State { get; set; }

		[InverseProperty("TheGMechanizedLetterType")]
		public virtual List<Rad.BaseInfo.Types.GMechanizedLetterTypeField>? TheGMechanizedLetterTypeFieldList { get; set; }

		[ForeignKey("SYSTEMOBJECTID")]
		public virtual Rad.BaseInfo.SystemObject.SystemObject? TheSystemObject { get; set; }

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


