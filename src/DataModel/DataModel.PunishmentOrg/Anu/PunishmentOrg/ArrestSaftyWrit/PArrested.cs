

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.ArrestSaftyWrit
{
    public abstract class PArrestedBase : PunishmentOrgEntity<string>
    {

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("ENDDATE")]
		public virtual string? EndDate { get; set; }

		[Column("NO")]
		public virtual string? No { get; set; }

		[Column("SAFTYWRITTYPE")]
		public virtual Anu.Enumerations.PunishmentOrg.PUSaftyWritType? SaftyWritType { get; set; }

		[Column("STARTDATE")]
		public virtual string? StartDate { get; set; }

		[ForeignKey("ARRESTEDPERSONID")]
		public virtual Anu.PunishmentOrg.Case.PCasePerson? TheArrestedPerson { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual Anu.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[InverseProperty("ThePArrested")]
		public virtual List<Anu.PunishmentOrg.ArrestSaftyWrit.PArrestedUnit>? ThePArrestedUnitList { get; set; }

		[ForeignKey("PCASEID")]
		public virtual Anu.PunishmentOrg.Case.PCase? ThePCase { get; set; }

		[ForeignKey("PRISONID")]
		public virtual Anu.BaseInfo.ExchangeData.NAJAUnit? ThePrison { get; set; }

		[ForeignKey("PSAFTYWRITID")]
		public virtual Anu.PunishmentOrg.ArrestSaftyWrit.PSaftyWrit? ThePSaftyWrit { get; set; }

		[ForeignKey("UNITID")]
		public virtual Anu.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

		[Column("WRITAMOUNT")]
		public virtual long? WritAmount { get; set; }

		[Column("WRITDATE")]
		public virtual string? WritDate { get; set; }

		[Column("WRITNO")]
		public virtual string? WritNo { get; set; }

    }
    [Table("PARRESTED")]
    public partial class PArrested : PArrestedBase { }

    }


