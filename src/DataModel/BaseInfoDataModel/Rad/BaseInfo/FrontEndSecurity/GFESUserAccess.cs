

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.BaseInfo.FrontEndSecurity
{
    public abstract class GFESUserAccessBase : BaseInfoEntity<string>
    {

		[Column("FROMDATETIME")]
		public virtual string? FromDateTime { get; set; }

		[Column("INTRODUCTIONDATE")]
		public virtual string? IntroductionDate { get; set; }

		[Column("INTRODUCTIONNO")]
		public virtual string? IntroductionNo { get; set; }

		[Column("OFFICEPOSITION")]
		public virtual string? OfficePosition { get; set; }

		[Column("SIGNTEXT")]
		public virtual string? SignText { get; set; }

		[ForeignKey("GFESUSERID")]
		public virtual Rad.BaseInfo.FrontEndSecurity.GFESUser? TheGFESUser { get; set; }

		[ForeignKey("GFESUSERACCESSTYPEID")]
		public virtual Rad.BaseInfo.FrontEndSecurity.GFESUserAccessType? TheGFESUserAccessType { get; set; }

		[ForeignKey("NAJAUNITID")]
		public virtual Rad.BaseInfo.ExchangeData.NAJAUnit? TheNAJAUnit { get; set; }

		[Column("TODATETIME")]
		public virtual string? ToDateTime { get; set; }

    }
    [Table("GFESUSERACCESS")]
    public partial class GFESUserAccess : GFESUserAccessBase { }

    }


