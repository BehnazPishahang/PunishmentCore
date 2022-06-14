

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.DBLoging
{
    public abstract class DBLoggingBase : BaseInfoEntity<string>
    {

		[Column("CHANGEDATETIME")]
		public virtual string? ChangeDateTime { get; set; }

		[Column("COMMANDPRIORITY")]
		public virtual decimal? CommandPriority { get; set; }

		[Column("COMPUTERNAME")]
		public virtual string? ComputerName { get; set; }

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("SESSIONID")]
		public virtual string? SessionId { get; set; }

		[Column("SYNCPROCESSED")]
		public virtual Rad.CMS.Enumerations.SyncProcessed? SyncProcessed { get; set; }

		[ForeignKey("CMSORGANIZATIONID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSOrganization? TheCMSOrganization { get; set; }

		[ForeignKey("CMSUSERID")]
		public virtual Rad.BaseInfo.Security.CMSUser.CMSUser? TheCMSUser { get; set; }

		[InverseProperty("TheDBLogging")]
		public virtual List<Rad.DBLoging.ReceiverData>? TheReceiverDataList { get; set; }

		[ForeignKey("SYSTEMFORMID")]
		public virtual Rad.BaseInfo.SystemObject.SystemForm? TheSystemForm { get; set; }

		[Column("TRANSACTIONCOMMANDLOG")]
		public virtual byte[]? TransactionCommandLog { get; set; }

		[Column("TRANSACTIONORDERNO")]
		public virtual decimal? TransactionOrderNo { get; set; }

    }
    [Table("DBLOGGING")]
    public partial class DBLogging : DBLoggingBase { }

    }


