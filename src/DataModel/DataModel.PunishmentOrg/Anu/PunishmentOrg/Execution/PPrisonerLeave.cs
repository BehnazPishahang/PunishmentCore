

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Execution
{
    public abstract class PPrisonerLeaveBase : PunishmentOrgEntity<string>
    {

		[Column("ENDDATE")]
		public virtual string? EndDate { get; set; }

		[Column("STARTDATE")]
		public virtual string? StartDate { get; set; }

		[ForeignKey("PINCOMINGLETTERID")]
		public virtual Anu.PunishmentOrg.Letter.PIncomingLetter? ThePIncomingLetter { get; set; }

		[ForeignKey("PPRISONERID")]
		public virtual Anu.PunishmentOrg.Execution.PPrisoner? ThePPrisoner { get; set; }

    }
    [Table("PPRISONERLEAVE")]
    public partial class PPrisonerLeave : PPrisonerLeaveBase { }

    }


