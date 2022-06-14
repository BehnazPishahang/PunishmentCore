

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anu.BaseInfo.FrontEndSecurity
{
    public abstract class GFESCartableBase : BaseInfoEntity<string>
    {

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("DESC1")]
		public virtual string? Desc1 { get; set; }

		[Column("DESC2")]
		public virtual string? Desc2 { get; set; }

		[Column("DESC3")]
		public virtual string? Desc3 { get; set; }

		[Column("LASTACTIONDATETIME")]
		public virtual string? LastActionDateTime { get; set; }

		[Column("RELATEDCASEID")]
		public virtual string? RelatedCaseId { get; set; }

		[Column("RELATEDCASENO")]
		public virtual string? RelatedCaseNo { get; set; }

		[Column("RELATEDDOCID")]
		public virtual string? RelatedDocId { get; set; }

		[Column("RELATEDDOCNO")]
		public virtual string? RelatedDocNo { get; set; }

		[Column("STATE")]
		public virtual Anu.Enumerations.WorkFlowActivityInstanceState? State { get; set; }

		[ForeignKey("ACCESSUSERID")]
		public virtual Anu.BaseInfo.FrontEndSecurity.GFESUser? TheAccessUser { get; set; }

		[ForeignKey("ACTIVITYID")]
		public virtual Anu.BaseInfo.Security.Role.BaseRole? TheActivity { get; set; }

		[ForeignKey("CREATORUSERID")]
		public virtual Anu.BaseInfo.FrontEndSecurity.GFESUser? TheCreatorUser { get; set; }

		[ForeignKey("GFESUSERACCESSTYPEID")]
		public virtual Anu.BaseInfo.FrontEndSecurity.GFESUserAccessType? TheGFESUserAccessType { get; set; }

		[ForeignKey("NAJAUNITID")]
		public virtual Anu.BaseInfo.ExchangeData.NAJAUnit? TheNAJAUnit { get; set; }

		[ForeignKey("PERFORMERUSERID")]
		public virtual Anu.BaseInfo.FrontEndSecurity.GFESUser? ThePerformerUser { get; set; }

		[ForeignKey("RELATEDFORMID")]
		public virtual Anu.BaseInfo.SystemObject.SystemForm? TheRelatedForm { get; set; }

		[ForeignKey("RELATEDSYSOBJECTCASEID")]
		public virtual Anu.BaseInfo.SystemObject.SystemObject? TheRelatedSysObjectCase { get; set; }

		[ForeignKey("RELATEDSYSOBJECTDOCID")]
		public virtual Anu.BaseInfo.SystemObject.SystemObject? TheRelatedSysObjectDoc { get; set; }

    }
    [Table("GFESCARTABLE")]
    public partial class GFESCartable : GFESCartableBase { }

    }


