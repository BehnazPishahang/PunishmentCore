

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.DBLoging
{
    public abstract class ChangeLogBase : BaseInfoEntity<string>
    {

		[Column("CHANGEDATETIME")]
		public virtual string? ChangeDateTime { get; set; }

		[Column("COMPUTERNAME")]
		public virtual string? ComputerName { get; set; }

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("MILISECOND")]
		public virtual string? MiliSecond { get; set; }

		[Column("NO")]
		public virtual string? No { get; set; }

		[Column("RELATEDOBJECTID")]
		public virtual string? RelatedObjectId { get; set; }

		[InverseProperty("TheChangeLog")]
		public virtual List<Rad.DBLoging.ChangeLogCase>? TheChangeLogCaseList { get; set; }

		[InverseProperty("TheChangeLog")]
		public virtual List<Rad.DBLoging.ChangeLogMainDoc>? TheChangeLogMainDocList { get; set; }

		[ForeignKey("CURRENTORGID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CMSOrganization? TheCurrentOrg { get; set; }

		[ForeignKey("REGISTERUSERHISTORYID")]
		public virtual Rad.BaseInfo.SystemConfiguration.RegisterUserHistory? TheRegisterUserHistory { get; set; }

		[ForeignKey("RELATEDSYSTEMFORMID")]
		public virtual Rad.BaseInfo.SystemObject.SystemForm? TheRelatedSystemForm { get; set; }

    }
    [Table("CHANGELOG")]
    public partial class ChangeLog : ChangeLogBase { }

    }


