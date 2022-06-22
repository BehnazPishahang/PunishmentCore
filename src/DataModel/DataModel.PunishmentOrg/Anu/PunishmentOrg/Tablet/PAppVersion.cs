

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Tablet
{
    public abstract class PAppVersionBase : PunishmentOrgEntity<string>
    {

		[Column("ALTERSCRIPT")]
		public virtual string? AlterScript { get; set; }

		[Column("CHANGELIST")]
		public virtual string? ChangeList { get; set; }

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("FORCEDUPDATE")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.YesNo? ForcedUpdate { get; set; }

		[Column("SERIALNO")]
		public virtual long? SerialNo { get; set; }

		[Column("VERSIONDATETIME")]
		public virtual string? VersionDateTime { get; set; }

		[Column("VERSIONNO")]
		public virtual string? VersionNo { get; set; }

    }
    [Table("PAPPVERSION")]
    public partial class PAppVersion : PAppVersionBase { }

    }


