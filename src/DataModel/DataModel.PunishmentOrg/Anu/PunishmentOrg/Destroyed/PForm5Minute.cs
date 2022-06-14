

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.PunishmentOrg.Destroyed
{
    public abstract class PForm5MinuteBase : PunishmentOrgEntity<string>
    {

		[Column("ARCHIVEADDRESS")]
		public virtual string? ArchiveAddress { get; set; }

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("FREEAREA")]
		public virtual long? FreeArea { get; set; }

		[Column("ISSUEDATE")]
		public virtual string? IssueDate { get; set; }

		[Column("LETTERDATE")]
		public virtual string? LetterDate { get; set; }

		[Column("LETTERNO")]
		public virtual string? LetterNo { get; set; }

		[Column("NO")]
		public virtual string? No { get; set; }

		[Column("PAGESUM")]
		public virtual long? PageSum { get; set; }

		[ForeignKey("PDESTROYEDLICENSEID")]
		public virtual Anu.PunishmentOrg.Destroyed.PDestroyedLicense? ThePDestroyedLicense { get; set; }

		[InverseProperty("ThePForm5Minute")]
		public virtual List<Anu.PunishmentOrg.Destroyed.PForm5MinuteConfirmer>? ThePForm5MinuteConfirmerList { get; set; }

		[InverseProperty("ThePForm5Minute")]
		public virtual List<Anu.PunishmentOrg.Destroyed.PForm5MinuteImages>? ThePForm5MinuteImagesList { get; set; }

		[InverseProperty("ThePForm5Minute")]
		public virtual List<Anu.PunishmentOrg.Destroyed.PForm5MinutePages>? ThePForm5MinutePagesList { get; set; }

		[ForeignKey("REGISTRARUSERID")]
		public virtual Anu.BaseInfo.SystemConfiguration.RegisterUserHistory? TheRegistrarUser { get; set; }

		[ForeignKey("UNITID")]
		public virtual Anu.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

    }
    [Table("PFORM5MINUTE")]
    public partial class PForm5Minute : PForm5MinuteBase { }

    }


