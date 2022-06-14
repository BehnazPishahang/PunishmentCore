

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.SystemConfiguration
{
    public abstract class CaseServerBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("COMPUTERNAME")]
		public virtual string? ComputerName { get; set; }

		[Column("IP")]
		public virtual string? IP { get; set; }

		[Column("ISCURRENTSERVER")]
		public virtual Anu.Enumerations.YesNo? IsCurrentServer { get; set; }

		[Column("ISRELTOCENTRAL")]
		public virtual Anu.Enumerations.YesNo? IsRelToCentral { get; set; }

		[Column("MANAGERSERVERIP")]
		public virtual string? ManagerServerIP { get; set; }

		[Column("SERVERTYPE")]
		public virtual Anu.Enumerations.ServerType? ServerType { get; set; }

		[Column("SYNCURL")]
		public virtual string? SyncUrl { get; set; }

		[InverseProperty("TheCaseServer")]
		public virtual List<Anu.BaseInfo.SystemConfiguration.CMSOrganization>? TheCMSOrganizationList { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("CASESERVER")]
    public partial class CaseServer : CaseServerBase { }

    }


